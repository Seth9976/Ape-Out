using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Core.PathCore;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x02000015 RID: 21
	public static class ShortcutExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00009D68 File Offset: 0x00007F68
		// Note: this type is marked as 'beforefieldinit'.
		static ShortcutExtensions()
		{
			Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "ShortcutExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr);
			ShortcutExtensions.NativeMethodInfoPtr_DOAspect_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663462);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Camera_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663463);
			ShortcutExtensions.NativeMethodInfoPtr_DOFarClipPlane_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663464);
			ShortcutExtensions.NativeMethodInfoPtr_DOFieldOfView_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663465);
			ShortcutExtensions.NativeMethodInfoPtr_DONearClipPlane_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663466);
			ShortcutExtensions.NativeMethodInfoPtr_DOOrthoSize_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663467);
			ShortcutExtensions.NativeMethodInfoPtr_DOPixelRect_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_Camera_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663468);
			ShortcutExtensions.NativeMethodInfoPtr_DORect_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_Camera_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663469);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663470);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663471);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663472);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663473);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Light_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663474);
			ShortcutExtensions.NativeMethodInfoPtr_DOIntensity_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Light_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663475);
			ShortcutExtensions.NativeMethodInfoPtr_DOShadowStrength_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Light_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663476);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_LineRenderer_Color2_Color2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663477);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663478);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Color_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663479);
			ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Color_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663480);
			ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663481);
			ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663482);
			ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663483);
			ShortcutExtensions.NativeMethodInfoPtr_DOFloat_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Material_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663484);
			ShortcutExtensions.NativeMethodInfoPtr_DOFloat_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Material_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663485);
			ShortcutExtensions.NativeMethodInfoPtr_DOOffset_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663486);
			ShortcutExtensions.NativeMethodInfoPtr_DOOffset_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663487);
			ShortcutExtensions.NativeMethodInfoPtr_DOTiling_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663488);
			ShortcutExtensions.NativeMethodInfoPtr_DOTiling_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663489);
			ShortcutExtensions.NativeMethodInfoPtr_DOVector_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_Material_Vector4_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663490);
			ShortcutExtensions.NativeMethodInfoPtr_DOVector_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_Material_Vector4_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663491);
			ShortcutExtensions.NativeMethodInfoPtr_DOResize_Public_Static_Tweener_TrailRenderer_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663492);
			ShortcutExtensions.NativeMethodInfoPtr_DOTime_Public_Static_TweenerCore_3_Single_Single_FloatOptions_TrailRenderer_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663493);
			ShortcutExtensions.NativeMethodInfoPtr_DOMove_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663494);
			ShortcutExtensions.NativeMethodInfoPtr_DOMoveX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663495);
			ShortcutExtensions.NativeMethodInfoPtr_DOMoveY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663496);
			ShortcutExtensions.NativeMethodInfoPtr_DOMoveZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663497);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalMove_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663498);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663499);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663500);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663501);
			ShortcutExtensions.NativeMethodInfoPtr_DORotate_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Transform_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663502);
			ShortcutExtensions.NativeMethodInfoPtr_DORotateQuaternion_Public_Static_TweenerCore_3_Quaternion_Quaternion_NoOptions_Transform_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663503);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalRotate_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Transform_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663504);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalRotateQuaternion_Public_Static_TweenerCore_3_Quaternion_Quaternion_NoOptions_Transform_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663505);
			ShortcutExtensions.NativeMethodInfoPtr_DOScale_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663506);
			ShortcutExtensions.NativeMethodInfoPtr_DOScale_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663507);
			ShortcutExtensions.NativeMethodInfoPtr_DOScaleX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663508);
			ShortcutExtensions.NativeMethodInfoPtr_DOScaleY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663509);
			ShortcutExtensions.NativeMethodInfoPtr_DOScaleZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663510);
			ShortcutExtensions.NativeMethodInfoPtr_DOLookAt_Public_Static_Tweener_Transform_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663511);
			ShortcutExtensions.NativeMethodInfoPtr_DOPunchPosition_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663512);
			ShortcutExtensions.NativeMethodInfoPtr_DOPunchScale_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663513);
			ShortcutExtensions.NativeMethodInfoPtr_DOPunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663514);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663515);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663516);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663517);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663518);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663519);
			ShortcutExtensions.NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663520);
			ShortcutExtensions.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663521);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663522);
			ShortcutExtensions.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663523);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663524);
			ShortcutExtensions.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663525);
			ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663526);
			ShortcutExtensions.NativeMethodInfoPtr_DOTimeScale_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Tween_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663527);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Light_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663528);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663529);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663530);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663531);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663532);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableLocalMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663533);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663534);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableLocalRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663535);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendablePunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663536);
			ShortcutExtensions.NativeMethodInfoPtr_DOBlendableScaleBy_Public_Static_Tweener_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663537);
			ShortcutExtensions.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Component_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663538);
			ShortcutExtensions.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663539);
			ShortcutExtensions.NativeMethodInfoPtr_DOKill_Public_Static_Int32_Component_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663540);
			ShortcutExtensions.NativeMethodInfoPtr_DOKill_Public_Static_Int32_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663541);
			ShortcutExtensions.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663542);
			ShortcutExtensions.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663543);
			ShortcutExtensions.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Component_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663544);
			ShortcutExtensions.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Material_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663545);
			ShortcutExtensions.NativeMethodInfoPtr_DOPause_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663546);
			ShortcutExtensions.NativeMethodInfoPtr_DOPause_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663547);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663548);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663549);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663550);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663551);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663552);
			ShortcutExtensions.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663553);
			ShortcutExtensions.NativeMethodInfoPtr_DORestart_Public_Static_Int32_Component_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663554);
			ShortcutExtensions.NativeMethodInfoPtr_DORestart_Public_Static_Int32_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663555);
			ShortcutExtensions.NativeMethodInfoPtr_DORewind_Public_Static_Int32_Component_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663556);
			ShortcutExtensions.NativeMethodInfoPtr_DORewind_Public_Static_Int32_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663557);
			ShortcutExtensions.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663558);
			ShortcutExtensions.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663559);
			ShortcutExtensions.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663560);
			ShortcutExtensions.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, 100663561);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000A568 File Offset: 0x00008768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119783, XrefRangeEnd = 119804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOAspect(this Camera target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOAspect_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000A5C8 File Offset: 0x000087C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119804, XrefRangeEnd = 119830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this Camera target, Color endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Camera_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000A628 File Offset: 0x00008828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119830, XrefRangeEnd = 119851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOFarClipPlane(this Camera target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFarClipPlane_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000A688 File Offset: 0x00008888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119851, XrefRangeEnd = 119872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOFieldOfView(this Camera target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFieldOfView_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000A6E8 File Offset: 0x000088E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119872, XrefRangeEnd = 119893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DONearClipPlane(this Camera target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DONearClipPlane_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000A748 File Offset: 0x00008948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119893, XrefRangeEnd = 119914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOOrthoSize(this Camera target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOOrthoSize_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000A7A8 File Offset: 0x000089A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119914, XrefRangeEnd = 119935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Rect, Rect, RectOptions> DOPixelRect(this Camera target, Rect endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPixelRect_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_Camera_Rect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Rect, Rect, RectOptions>>(intPtr3) : null;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000A808 File Offset: 0x00008A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119935, XrefRangeEnd = 119956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Rect, Rect, RectOptions> DORect(this Camera target, Rect endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORect_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_Camera_Rect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Rect, Rect, RectOptions>>(intPtr3) : null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000A868 File Offset: 0x00008A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119956, XrefRangeEnd = 119981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakePosition(this Camera target, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119981, XrefRangeEnd = 120006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakePosition(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000A980 File Offset: 0x00008B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120006, XrefRangeEnd = 120031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeRotation(this Camera target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000AA0C File Offset: 0x00008C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120031, XrefRangeEnd = 120056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeRotation(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000AA98 File Offset: 0x00008C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120056, XrefRangeEnd = 120082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this Light target, Color endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Light_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000AAF8 File Offset: 0x00008CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120082, XrefRangeEnd = 120103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOIntensity(this Light target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOIntensity_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Light_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000AB58 File Offset: 0x00008D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120103, XrefRangeEnd = 120124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOShadowStrength(this Light target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShadowStrength_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Light_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120124, XrefRangeEnd = 120162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOColor(this LineRenderer target, Color2 startValue, Color2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_Tweener_LineRenderer_Color2_Color2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000AC28 File Offset: 0x00008E28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120188, RefRangeEnd = 120191, XrefRangeStart = 120162, XrefRangeEnd = 120188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this Material target, Color endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000AC88 File Offset: 0x00008E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120219, RefRangeEnd = 120220, XrefRangeStart = 120191, XrefRangeEnd = 120219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this Material target, Color endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Color_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000ACFC File Offset: 0x00008EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120220, XrefRangeEnd = 120249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this Material target, Color endValue, int propertyID, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Color_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000AD6C File Offset: 0x00008F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120249, XrefRangeEnd = 120270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOFade(this Material target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000ADCC File Offset: 0x00008FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120270, XrefRangeEnd = 120293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOFade(this Material target, float endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000AE40 File Offset: 0x00009040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120293, XrefRangeEnd = 120317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOFade(this Material target, float endValue, int propertyID, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000AEB0 File Offset: 0x000090B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120317, XrefRangeEnd = 120340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOFloat(this Material target, float endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFloat_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Material_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000AF24 File Offset: 0x00009124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120340, XrefRangeEnd = 120364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOFloat(this Material target, float endValue, int propertyID, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFloat_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Material_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000AF94 File Offset: 0x00009194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120364, XrefRangeEnd = 120385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOOffset_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000AFF4 File Offset: 0x000091F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120385, XrefRangeEnd = 120408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOOffset_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000B068 File Offset: 0x00009268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120408, XrefRangeEnd = 120429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTiling_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000B0C8 File Offset: 0x000092C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120429, XrefRangeEnd = 120452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTiling_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000B13C File Offset: 0x0000933C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120452, XrefRangeEnd = 120475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(this Material target, Vector4 endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOVector_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_Material_Vector4_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector4, Vector4, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000B1B0 File Offset: 0x000093B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120475, XrefRangeEnd = 120499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(this Material target, Vector4 endValue, int propertyID, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOVector_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_Material_Vector4_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector4, Vector4, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000B220 File Offset: 0x00009420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120499, XrefRangeEnd = 120520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOResize(this TrailRenderer target, float toStartWidth, float toEndWidth, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toStartWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toEndWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOResize_Public_Static_Tweener_TrailRenderer_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000B290 File Offset: 0x00009490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120520, XrefRangeEnd = 120541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOTime(this TrailRenderer target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTime_Public_Static_TweenerCore_3_Single_Single_FloatOptions_TrailRenderer_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000B2F0 File Offset: 0x000094F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 120567, RefRangeEnd = 120573, XrefRangeStart = 120541, XrefRangeEnd = 120567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMove_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000B360 File Offset: 0x00009560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120573, XrefRangeEnd = 120599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Transform target, float endValue, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMoveX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120625, RefRangeEnd = 120627, XrefRangeStart = 120599, XrefRangeEnd = 120625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Transform target, float endValue, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMoveY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000B440 File Offset: 0x00009640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120653, RefRangeEnd = 120654, XrefRangeStart = 120627, XrefRangeEnd = 120653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOMoveZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000B4B0 File Offset: 0x000096B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120654, XrefRangeEnd = 120680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalMove_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000B520 File Offset: 0x00009720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120680, XrefRangeEnd = 120706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveX(this Transform target, float endValue, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000B590 File Offset: 0x00009790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120706, XrefRangeEnd = 120732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveY(this Transform target, float endValue, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000B600 File Offset: 0x00009800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120732, XrefRangeEnd = 120758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalMoveZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000B670 File Offset: 0x00009870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120779, RefRangeEnd = 120780, XrefRangeStart = 120758, XrefRangeEnd = 120779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORotate_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Transform_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Quaternion, Vector3, QuaternionOptions>>(intPtr3) : null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000B6E0 File Offset: 0x000098E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120780, XrefRangeEnd = 120803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Quaternion, Quaternion, NoOptions> DORotateQuaternion(this Transform target, Quaternion endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORotateQuaternion_Public_Static_TweenerCore_3_Quaternion_Quaternion_NoOptions_Transform_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Quaternion, Quaternion, NoOptions>>(intPtr3) : null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000B740 File Offset: 0x00009940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120803, XrefRangeEnd = 120824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalRotate_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Transform_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Quaternion, Vector3, QuaternionOptions>>(intPtr3) : null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000B7B0 File Offset: 0x000099B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120824, XrefRangeEnd = 120847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Quaternion, Quaternion, NoOptions> DOLocalRotateQuaternion(this Transform target, Quaternion endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalRotateQuaternion_Public_Static_TweenerCore_3_Quaternion_Quaternion_NoOptions_Transform_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Quaternion, Quaternion, NoOptions>>(intPtr3) : null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000B810 File Offset: 0x00009A10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120873, RefRangeEnd = 120874, XrefRangeStart = 120847, XrefRangeEnd = 120873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, Vector3 endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScale_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000B870 File Offset: 0x00009A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120874, XrefRangeEnd = 120900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScale_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120900, XrefRangeEnd = 120926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleX(this Transform target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScaleX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000B930 File Offset: 0x00009B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120926, XrefRangeEnd = 120952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleY(this Transform target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScaleY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000B990 File Offset: 0x00009B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120952, XrefRangeEnd = 120978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleZ(this Transform target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOScaleZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120978, XrefRangeEnd = 121005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref towards;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLookAt_Public_Static_Tweener_Transform_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000BA78 File Offset: 0x00009C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121005, XrefRangeEnd = 121029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPunchPosition_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000BB04 File Offset: 0x00009D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121029, XrefRangeEnd = 121053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPunchScale_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000BB80 File Offset: 0x00009D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121053, XrefRangeEnd = 121077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000BBFC File Offset: 0x00009DFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 121102, RefRangeEnd = 121107, XrefRangeStart = 121077, XrefRangeEnd = 121102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakePosition(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000BC94 File Offset: 0x00009E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121107, XrefRangeEnd = 121132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000BD2C File Offset: 0x00009F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121132, XrefRangeEnd = 121157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeRotation(this Transform target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121157, XrefRangeEnd = 121182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000BE44 File Offset: 0x0000A044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121182, XrefRangeEnd = 121208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeScale(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000BED0 File Offset: 0x0000A0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121208, XrefRangeEnd = 121233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000BF5C File Offset: 0x0000A15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121233, XrefRangeEnd = 121315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121315, XrefRangeEnd = 121393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOLocalJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000C074 File Offset: 0x0000A274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121393, XrefRangeEnd = 121422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Il2CppStructArray<Vector3> path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Nullable<Color> gizmoColor = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000C11C File Offset: 0x0000A31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121422, XrefRangeEnd = 121451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Il2CppStructArray<Vector3> path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Nullable<Color> gizmoColor = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121451, XrefRangeEnd = 121476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000C238 File Offset: 0x0000A438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121476, XrefRangeEnd = 121501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000C2AC File Offset: 0x0000A4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121501, XrefRangeEnd = 121522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOTimeScale(this Tween target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTimeScale_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Tween_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000C30C File Offset: 0x0000A50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121522, XrefRangeEnd = 121551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Light target, Color endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Light_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000C36C File Offset: 0x0000A56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121551, XrefRangeEnd = 121579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Material target, Color endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121579, XrefRangeEnd = 121609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Material target, Color endValue, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000C440 File Offset: 0x0000A640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121609, XrefRangeEnd = 121641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Material target, Color endValue, int propertyID, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121641, XrefRangeEnd = 121670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000C520 File Offset: 0x0000A720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121670, XrefRangeEnd = 121699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableLocalMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableLocalMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000C590 File Offset: 0x0000A790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121699, XrefRangeEnd = 121723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000C600 File Offset: 0x0000A800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121723, XrefRangeEnd = 121747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableLocalRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableLocalRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000C670 File Offset: 0x0000A870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121747, XrefRangeEnd = 121774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendablePunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendablePunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121774, XrefRangeEnd = 121803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableScaleBy(this Transform target, Vector3 byValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOBlendableScaleBy_Public_Static_Tweener_Transform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000C74C File Offset: 0x0000A94C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121810, RefRangeEnd = 121812, XrefRangeStart = 121803, XrefRangeEnd = 121810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOComplete(this Component target, bool withCallbacks = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Component_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000C79C File Offset: 0x0000A99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121812, XrefRangeEnd = 121819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOComplete(this Material target, bool withCallbacks = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121819, XrefRangeEnd = 121823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOKill(this Component target, bool complete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOKill_Public_Static_Int32_Component_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000C83C File Offset: 0x0000AA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121823, XrefRangeEnd = 121827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOKill(this Material target, bool complete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOKill_Public_Static_Int32_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000C88C File Offset: 0x0000AA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121827, XrefRangeEnd = 121834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOFlip(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121834, XrefRangeEnd = 121841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOFlip(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000C914 File Offset: 0x0000AB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121841, XrefRangeEnd = 121848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOGoto(this Component target, float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Component_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000C974 File Offset: 0x0000AB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121848, XrefRangeEnd = 121855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOGoto(this Material target, float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Material_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121862, RefRangeEnd = 121864, XrefRangeStart = 121855, XrefRangeEnd = 121862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPause(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPause_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000CA18 File Offset: 0x0000AC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121864, XrefRangeEnd = 121871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPause(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPause_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121871, XrefRangeEnd = 121878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlay(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121878, XrefRangeEnd = 121885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlay(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121885, XrefRangeEnd = 121892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayBackwards(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121892, XrefRangeEnd = 121899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayBackwards(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121899, XrefRangeEnd = 121906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayForward(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000CBB0 File Offset: 0x0000ADB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121906, XrefRangeEnd = 121913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOPlayForward(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121913, XrefRangeEnd = 121920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORestart(this Component target, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORestart_Public_Static_Int32_Component_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000CC44 File Offset: 0x0000AE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121920, XrefRangeEnd = 121927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORestart(this Material target, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORestart_Public_Static_Int32_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000CC94 File Offset: 0x0000AE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121927, XrefRangeEnd = 121934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORewind(this Component target, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORewind_Public_Static_Int32_Component_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000CCE4 File Offset: 0x0000AEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121934, XrefRangeEnd = 121941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DORewind(this Material target, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DORewind_Public_Static_Int32_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000CD34 File Offset: 0x0000AF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121941, XrefRangeEnd = 121948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOSmoothRewind(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000CD78 File Offset: 0x0000AF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121948, XrefRangeEnd = 121955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOSmoothRewind(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121955, XrefRangeEnd = 121962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOTogglePause(this Component target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000CE00 File Offset: 0x0000B000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121962, XrefRangeEnd = 121969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DOTogglePause(this Material target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002335 File Offset: 0x00000535
		public ShortcutExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_DOAspect_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Camera_Color_Single_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_DOFarClipPlane_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_DOFieldOfView_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_DONearClipPlane_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_DOOrthoSize_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Camera_Single_Single_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_DOPixelRect_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_Camera_Rect_Single_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_DORect_Public_Static_TweenerCore_3_Rect_Rect_RectOptions_Camera_Rect_Single_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Single_Int32_Single_Boolean_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Camera_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Light_Color_Single_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_DOIntensity_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Light_Single_Single_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_DOShadowStrength_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Light_Single_Single_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_Tweener_LineRenderer_Color2_Color2_Single_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Color_Single_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Color_String_Single_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Color_Int32_Single_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Single_Single_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Single_String_Single_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Material_Single_Int32_Single_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_DOFloat_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Material_Single_String_Single_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_DOFloat_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Material_Single_Int32_Single_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_DOOffset_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Single_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_DOOffset_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_String_Single_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_DOTiling_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Single_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_DOTiling_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_String_Single_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_DOVector_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_Material_Vector4_String_Single_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_DOVector_Public_Static_TweenerCore_3_Vector4_Vector4_VectorOptions_Material_Vector4_Int32_Single_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_DOResize_Public_Static_Tweener_TrailRenderer_Single_Single_Single_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_DOTime_Public_Static_TweenerCore_3_Single_Single_FloatOptions_TrailRenderer_Single_Single_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_DOMove_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Vector3_Single_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalMove_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Vector3_Single_Boolean_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalMoveX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalMoveY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalMoveZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_Boolean_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_DORotate_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Transform_Vector3_Single_RotateMode_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_DORotateQuaternion_Public_Static_TweenerCore_3_Quaternion_Quaternion_NoOptions_Transform_Quaternion_Single_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalRotate_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Transform_Vector3_Single_RotateMode_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalRotateQuaternion_Public_Static_TweenerCore_3_Quaternion_Quaternion_NoOptions_Transform_Quaternion_Single_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_DOScale_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Vector3_Single_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_DOScale_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_DOScaleX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_DOScaleY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_DOScaleZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Transform_Single_Single_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_DOLookAt_Public_Static_Tweener_Transform_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_DOPunchPosition_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_Boolean_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_DOPunchScale_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_DOPunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_Boolean_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_DOShakePosition_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_Boolean_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeRotation_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Single_Int32_Single_Boolean_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeScale_Public_Static_Tweener_Transform_Single_Vector3_Int32_Single_Boolean_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalJump_Public_Static_Sequence_Transform_Vector3_Single_Int32_Single_Boolean_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Transform_Path_Single_PathMode_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_DOTimeScale_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Tween_Single_Single_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Light_Color_Single_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_Single_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_String_Single_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Material_Color_Int32_Single_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableLocalMoveBy_Public_Static_Tweener_Transform_Vector3_Single_Boolean_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableLocalRotateBy_Public_Static_Tweener_Transform_Vector3_Single_RotateMode_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendablePunchRotation_Public_Static_Tweener_Transform_Vector3_Single_Int32_Single_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableScaleBy_Public_Static_Tweener_Transform_Vector3_Single_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Component_Boolean_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_DOComplete_Public_Static_Int32_Material_Boolean_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_DOKill_Public_Static_Int32_Component_Boolean_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_DOKill_Public_Static_Int32_Material_Boolean_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Component_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_DOFlip_Public_Static_Int32_Material_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Component_Single_Boolean_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_DOGoto_Public_Static_Int32_Material_Single_Boolean_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_DOPause_Public_Static_Int32_Component_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_DOPause_Public_Static_Int32_Material_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Component_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_DOPlay_Public_Static_Int32_Material_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Component_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayBackwards_Public_Static_Int32_Material_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Component_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_DOPlayForward_Public_Static_Int32_Material_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_DORestart_Public_Static_Int32_Component_Boolean_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_DORestart_Public_Static_Int32_Material_Boolean_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_DORewind_Public_Static_Int32_Component_Boolean_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_DORewind_Public_Static_Int32_Material_Boolean_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Component_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_DOSmoothRewind_Public_Static_Int32_Material_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Component_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_DOTogglePause_Public_Static_Int32_Material_0;

		// Token: 0x02000068 RID: 104
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005DD RID: 1501 RVA: 0x0001FFAC File Offset: 0x0001E1AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663562);
				ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__DOAspect_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663563);
				ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__DOAspect_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663564);
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x00020028 File Offset: 0x0001E228
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005DF RID: 1503 RVA: 0x00020064 File Offset: 0x0001E264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119477, XrefRangeEnd = 119482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOAspect_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__DOAspect_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x000200A0 File Offset: 0x0001E2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119482, XrefRangeEnd = 119487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAspect_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__DOAspect_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x00003EEB File Offset: 0x000020EB
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x060005E2 RID: 1506 RVA: 0x000200E0 File Offset: 0x0001E2E0
			// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00003EF4 File Offset: 0x000020F4
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004B8 RID: 1208
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004B9 RID: 1209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004BA RID: 1210
			private static readonly IntPtr NativeMethodInfoPtr__DOAspect_b__0_Internal_Single_0;

			// Token: 0x040004BB RID: 1211
			private static readonly IntPtr NativeMethodInfoPtr__DOAspect_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000069 RID: 105
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005E4 RID: 1508 RVA: 0x00020110 File Offset: 0x0001E310
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100663565);
				ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100663566);
				ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100663567);
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x0002018C File Offset: 0x0001E38C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x000201C8 File Offset: 0x0001E3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119487, XrefRangeEnd = 119489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x00020204 File Offset: 0x0001E404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119489, XrefRangeEnd = 119491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x00003F13 File Offset: 0x00002113
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00020244 File Offset: 0x0001E444
			// (set) Token: 0x060005EA RID: 1514 RVA: 0x00003F1C File Offset: 0x0000211C
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004BC RID: 1212
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004BD RID: 1213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004BE RID: 1214
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x040004BF RID: 1215
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200006A RID: 106
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005EB RID: 1515 RVA: 0x00020274 File Offset: 0x0001E474
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100663568);
				ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__DOFarClipPlane_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100663569);
				ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__DOFarClipPlane_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100663570);
			}

			// Token: 0x060005EC RID: 1516 RVA: 0x000202F0 File Offset: 0x0001E4F0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005ED RID: 1517 RVA: 0x0002032C File Offset: 0x0001E52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119491, XrefRangeEnd = 119496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFarClipPlane_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__DOFarClipPlane_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005EE RID: 1518 RVA: 0x00020368 File Offset: 0x0001E568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119496, XrefRangeEnd = 119501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFarClipPlane_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__DOFarClipPlane_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x00003F3B File Offset: 0x0000213B
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x060005F0 RID: 1520 RVA: 0x000203A8 File Offset: 0x0001E5A8
			// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00003F44 File Offset: 0x00002144
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004C0 RID: 1216
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004C1 RID: 1217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004C2 RID: 1218
			private static readonly IntPtr NativeMethodInfoPtr__DOFarClipPlane_b__0_Internal_Single_0;

			// Token: 0x040004C3 RID: 1219
			private static readonly IntPtr NativeMethodInfoPtr__DOFarClipPlane_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200006B RID: 107
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005F2 RID: 1522 RVA: 0x000203D8 File Offset: 0x0001E5D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663571);
				ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__DOFieldOfView_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663572);
				ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__DOFieldOfView_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663573);
			}

			// Token: 0x060005F3 RID: 1523 RVA: 0x00020454 File Offset: 0x0001E654
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005F4 RID: 1524 RVA: 0x00020490 File Offset: 0x0001E690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119501, XrefRangeEnd = 119506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFieldOfView_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__DOFieldOfView_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005F5 RID: 1525 RVA: 0x000204CC File Offset: 0x0001E6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119506, XrefRangeEnd = 119511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFieldOfView_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__DOFieldOfView_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005F6 RID: 1526 RVA: 0x00003F63 File Offset: 0x00002163
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0002050C File Offset: 0x0001E70C
			// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00003F6C File Offset: 0x0000216C
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004C4 RID: 1220
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004C5 RID: 1221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004C6 RID: 1222
			private static readonly IntPtr NativeMethodInfoPtr__DOFieldOfView_b__0_Internal_Single_0;

			// Token: 0x040004C7 RID: 1223
			private static readonly IntPtr NativeMethodInfoPtr__DOFieldOfView_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200006C RID: 108
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005F9 RID: 1529 RVA: 0x0002053C File Offset: 0x0001E73C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr, 100663574);
				ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__DONearClipPlane_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr, 100663575);
				ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__DONearClipPlane_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr, 100663576);
			}

			// Token: 0x060005FA RID: 1530 RVA: 0x000205B8 File Offset: 0x0001E7B8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005FB RID: 1531 RVA: 0x000205F4 File Offset: 0x0001E7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119511, XrefRangeEnd = 119516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DONearClipPlane_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__DONearClipPlane_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005FC RID: 1532 RVA: 0x00020630 File Offset: 0x0001E830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119516, XrefRangeEnd = 119521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DONearClipPlane_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__DONearClipPlane_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005FD RID: 1533 RVA: 0x00003F8B File Offset: 0x0000218B
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x060005FE RID: 1534 RVA: 0x00020670 File Offset: 0x0001E870
			// (set) Token: 0x060005FF RID: 1535 RVA: 0x00003F94 File Offset: 0x00002194
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004C8 RID: 1224
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004C9 RID: 1225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004CA RID: 1226
			private static readonly IntPtr NativeMethodInfoPtr__DONearClipPlane_b__0_Internal_Single_0;

			// Token: 0x040004CB RID: 1227
			private static readonly IntPtr NativeMethodInfoPtr__DONearClipPlane_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200006D RID: 109
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000600 RID: 1536 RVA: 0x000206A0 File Offset: 0x0001E8A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass5_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr, 100663577);
				ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__DOOrthoSize_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr, 100663578);
				ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__DOOrthoSize_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr, 100663579);
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x0002071C File Offset: 0x0001E91C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000602 RID: 1538 RVA: 0x00020758 File Offset: 0x0001E958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119521, XrefRangeEnd = 119526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOOrthoSize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__DOOrthoSize_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000603 RID: 1539 RVA: 0x00020794 File Offset: 0x0001E994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119526, XrefRangeEnd = 119531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOOrthoSize_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass5_0.NativeMethodInfoPtr__DOOrthoSize_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x00003FB3 File Offset: 0x000021B3
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000605 RID: 1541 RVA: 0x000207D4 File Offset: 0x0001E9D4
			// (set) Token: 0x06000606 RID: 1542 RVA: 0x00003FBC File Offset: 0x000021BC
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass5_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass5_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004CC RID: 1228
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004CD RID: 1229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004CE RID: 1230
			private static readonly IntPtr NativeMethodInfoPtr__DOOrthoSize_b__0_Internal_Single_0;

			// Token: 0x040004CF RID: 1231
			private static readonly IntPtr NativeMethodInfoPtr__DOOrthoSize_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200006E RID: 110
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000607 RID: 1543 RVA: 0x00020804 File Offset: 0x0001EA04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass6_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr, 100663580);
				ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__DOPixelRect_b__0_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr, 100663581);
				ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__DOPixelRect_b__1_Internal_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr, 100663582);
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x00020880 File Offset: 0x0001EA80
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000609 RID: 1545 RVA: 0x000208BC File Offset: 0x0001EABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119531, XrefRangeEnd = 119533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rect _DOPixelRect_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__DOPixelRect_b__0_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600060A RID: 1546 RVA: 0x000208F8 File Offset: 0x0001EAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119533, XrefRangeEnd = 119535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPixelRect_b__1(Rect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass6_0.NativeMethodInfoPtr__DOPixelRect_b__1_Internal_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600060B RID: 1547 RVA: 0x00003FDB File Offset: 0x000021DB
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x0600060C RID: 1548 RVA: 0x00020938 File Offset: 0x0001EB38
			// (set) Token: 0x0600060D RID: 1549 RVA: 0x00003FE4 File Offset: 0x000021E4
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass6_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass6_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004D0 RID: 1232
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004D1 RID: 1233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004D2 RID: 1234
			private static readonly IntPtr NativeMethodInfoPtr__DOPixelRect_b__0_Internal_Rect_0;

			// Token: 0x040004D3 RID: 1235
			private static readonly IntPtr NativeMethodInfoPtr__DOPixelRect_b__1_Internal_Void_Rect_0;
		}

		// Token: 0x0200006F RID: 111
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600060E RID: 1550 RVA: 0x00020968 File Offset: 0x0001EB68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass7_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr, 100663583);
				ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__DORect_b__0_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr, 100663584);
				ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__DORect_b__1_Internal_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr, 100663585);
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x000209E4 File Offset: 0x0001EBE4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000610 RID: 1552 RVA: 0x00020A20 File Offset: 0x0001EC20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119535, XrefRangeEnd = 119537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rect _DORect_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__DORect_b__0_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000611 RID: 1553 RVA: 0x00020A5C File Offset: 0x0001EC5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119537, XrefRangeEnd = 119539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DORect_b__1(Rect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass7_0.NativeMethodInfoPtr__DORect_b__1_Internal_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000612 RID: 1554 RVA: 0x00004003 File Offset: 0x00002203
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000613 RID: 1555 RVA: 0x00020A9C File Offset: 0x0001EC9C
			// (set) Token: 0x06000614 RID: 1556 RVA: 0x0000400C File Offset: 0x0000220C
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass7_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass7_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004D4 RID: 1236
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004D5 RID: 1237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004D6 RID: 1238
			private static readonly IntPtr NativeMethodInfoPtr__DORect_b__0_Internal_Rect_0;

			// Token: 0x040004D7 RID: 1239
			private static readonly IntPtr NativeMethodInfoPtr__DORect_b__1_Internal_Void_Rect_0;
		}

		// Token: 0x02000070 RID: 112
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000615 RID: 1557 RVA: 0x00020ACC File Offset: 0x0001ECCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr, 100663586);
				ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr, 100663587);
				ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr, 100663588);
			}

			// Token: 0x06000616 RID: 1558 RVA: 0x00020B48 File Offset: 0x0001ED48
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x00020B84 File Offset: 0x0001ED84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119539, XrefRangeEnd = 119543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakePosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x00020BC0 File Offset: 0x0001EDC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119543, XrefRangeEnd = 119547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakePosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000619 RID: 1561 RVA: 0x0000402B File Offset: 0x0000222B
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600061A RID: 1562 RVA: 0x00020C00 File Offset: 0x0001EE00
			// (set) Token: 0x0600061B RID: 1563 RVA: 0x00004034 File Offset: 0x00002234
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004D8 RID: 1240
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004D9 RID: 1241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004DA RID: 1242
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0;

			// Token: 0x040004DB RID: 1243
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000071 RID: 113
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600061C RID: 1564 RVA: 0x00020C30 File Offset: 0x0001EE30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass9_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr, 100663589);
				ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr, 100663590);
				ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr, 100663591);
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x00020CAC File Offset: 0x0001EEAC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x00020CE8 File Offset: 0x0001EEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakePosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x00020D24 File Offset: 0x0001EF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakePosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass9_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000620 RID: 1568 RVA: 0x00004053 File Offset: 0x00002253
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000621 RID: 1569 RVA: 0x00020D64 File Offset: 0x0001EF64
			// (set) Token: 0x06000622 RID: 1570 RVA: 0x0000405C File Offset: 0x0000225C
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass9_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass9_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004DC RID: 1244
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004DD RID: 1245
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004DE RID: 1246
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0;

			// Token: 0x040004DF RID: 1247
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000072 RID: 114
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000623 RID: 1571 RVA: 0x00020D94 File Offset: 0x0001EF94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100663592);
				ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100663593);
				ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100663594);
			}

			// Token: 0x06000624 RID: 1572 RVA: 0x00020E10 File Offset: 0x0001F010
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000625 RID: 1573 RVA: 0x00020E4C File Offset: 0x0001F04C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119547, XrefRangeEnd = 119552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000626 RID: 1574 RVA: 0x00020E88 File Offset: 0x0001F088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119552, XrefRangeEnd = 119558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000627 RID: 1575 RVA: 0x0000407B File Offset: 0x0000227B
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000628 RID: 1576 RVA: 0x00020EC8 File Offset: 0x0001F0C8
			// (set) Token: 0x06000629 RID: 1577 RVA: 0x00004084 File Offset: 0x00002284
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E0 RID: 1248
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004E1 RID: 1249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E2 RID: 1250
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0;

			// Token: 0x040004E3 RID: 1251
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000073 RID: 115
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600062A RID: 1578 RVA: 0x00020EF8 File Offset: 0x0001F0F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100663595);
				ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100663596);
				ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100663597);
			}

			// Token: 0x0600062B RID: 1579 RVA: 0x00020F74 File Offset: 0x0001F174
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600062C RID: 1580 RVA: 0x00020FB0 File Offset: 0x0001F1B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x00020FEC File Offset: 0x0001F1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600062E RID: 1582 RVA: 0x000040A3 File Offset: 0x000022A3
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x0600062F RID: 1583 RVA: 0x0002102C File Offset: 0x0001F22C
			// (set) Token: 0x06000630 RID: 1584 RVA: 0x000040AC File Offset: 0x000022AC
			public unsafe Camera target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E4 RID: 1252
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004E5 RID: 1253
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E6 RID: 1254
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0;

			// Token: 0x040004E7 RID: 1255
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000074 RID: 116
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000631 RID: 1585 RVA: 0x0002105C File Offset: 0x0001F25C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass12_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr, 100663598);
				ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr, 100663599);
				ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr, 100663600);
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x000210D8 File Offset: 0x0001F2D8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x00021114 File Offset: 0x0001F314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119558, XrefRangeEnd = 119560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000634 RID: 1588 RVA: 0x00021150 File Offset: 0x0001F350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119560, XrefRangeEnd = 119562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000635 RID: 1589 RVA: 0x000040CB File Offset: 0x000022CB
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000636 RID: 1590 RVA: 0x00021190 File Offset: 0x0001F390
			// (set) Token: 0x06000637 RID: 1591 RVA: 0x000040D4 File Offset: 0x000022D4
			public unsafe Light target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass12_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass12_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E8 RID: 1256
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004E9 RID: 1257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004EA RID: 1258
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x040004EB RID: 1259
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000075 RID: 117
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000638 RID: 1592 RVA: 0x000211C0 File Offset: 0x0001F3C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100663601);
				ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__DOIntensity_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100663602);
				ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__DOIntensity_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100663603);
			}

			// Token: 0x06000639 RID: 1593 RVA: 0x0002123C File Offset: 0x0001F43C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600063A RID: 1594 RVA: 0x00021278 File Offset: 0x0001F478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119562, XrefRangeEnd = 119567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOIntensity_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__DOIntensity_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600063B RID: 1595 RVA: 0x000212B4 File Offset: 0x0001F4B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119567, XrefRangeEnd = 119572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOIntensity_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__DOIntensity_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600063C RID: 1596 RVA: 0x000040F3 File Offset: 0x000022F3
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x0600063D RID: 1597 RVA: 0x000212F4 File Offset: 0x0001F4F4
			// (set) Token: 0x0600063E RID: 1598 RVA: 0x000040FC File Offset: 0x000022FC
			public unsafe Light target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004EC RID: 1260
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004ED RID: 1261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004EE RID: 1262
			private static readonly IntPtr NativeMethodInfoPtr__DOIntensity_b__0_Internal_Single_0;

			// Token: 0x040004EF RID: 1263
			private static readonly IntPtr NativeMethodInfoPtr__DOIntensity_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000076 RID: 118
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600063F RID: 1599 RVA: 0x00021324 File Offset: 0x0001F524
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100663604);
				ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__DOShadowStrength_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100663605);
				ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__DOShadowStrength_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100663606);
			}

			// Token: 0x06000640 RID: 1600 RVA: 0x000213A0 File Offset: 0x0001F5A0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000641 RID: 1601 RVA: 0x000213DC File Offset: 0x0001F5DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119572, XrefRangeEnd = 119577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOShadowStrength_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__DOShadowStrength_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000642 RID: 1602 RVA: 0x00021418 File Offset: 0x0001F618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119577, XrefRangeEnd = 119582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShadowStrength_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__DOShadowStrength_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000643 RID: 1603 RVA: 0x0000411B File Offset: 0x0000231B
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000644 RID: 1604 RVA: 0x00021458 File Offset: 0x0001F658
			// (set) Token: 0x06000645 RID: 1605 RVA: 0x00004124 File Offset: 0x00002324
			public unsafe Light target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004F0 RID: 1264
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004F1 RID: 1265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004F2 RID: 1266
			private static readonly IntPtr NativeMethodInfoPtr__DOShadowStrength_b__0_Internal_Single_0;

			// Token: 0x040004F3 RID: 1267
			private static readonly IntPtr NativeMethodInfoPtr__DOShadowStrength_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000077 RID: 119
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000646 RID: 1606 RVA: 0x00021488 File Offset: 0x0001F688
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_startValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr, "startValue");
				ShortcutExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr, 100663607);
				ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr, 100663608);
				ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr, 100663609);
			}

			// Token: 0x06000647 RID: 1607 RVA: 0x00021518 File Offset: 0x0001F718
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000648 RID: 1608 RVA: 0x00021554 File Offset: 0x0001F754
			[CallerCount(0)]
			public unsafe Color2 _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x00021590 File Offset: 0x0001F790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119582, XrefRangeEnd = 119586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x00004143 File Offset: 0x00002343
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x0600064B RID: 1611 RVA: 0x000215D0 File Offset: 0x0001F7D0
			// (set) Token: 0x0600064C RID: 1612 RVA: 0x0000414C File Offset: 0x0000234C
			public unsafe Color2 startValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_startValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_startValue)) = value;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x0600064D RID: 1613 RVA: 0x000215F8 File Offset: 0x0001F7F8
			// (set) Token: 0x0600064E RID: 1614 RVA: 0x00004167 File Offset: 0x00002367
			public unsafe LineRenderer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004F4 RID: 1268
			private static readonly IntPtr NativeFieldInfoPtr_startValue;

			// Token: 0x040004F5 RID: 1269
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004F6 RID: 1270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004F7 RID: 1271
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color2_0;

			// Token: 0x040004F8 RID: 1272
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color2_0;
		}

		// Token: 0x02000078 RID: 120
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600064F RID: 1615 RVA: 0x00021628 File Offset: 0x0001F828
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr, 100663610);
				ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr, 100663611);
				ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr, 100663612);
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x000216A4 File Offset: 0x0001F8A4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x000216E0 File Offset: 0x0001F8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119586, XrefRangeEnd = 119587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x0002171C File Offset: 0x0001F91C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119587, XrefRangeEnd = 119588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x00004186 File Offset: 0x00002386
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000654 RID: 1620 RVA: 0x0002175C File Offset: 0x0001F95C
			// (set) Token: 0x06000655 RID: 1621 RVA: 0x0000418F File Offset: 0x0000238F
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004F9 RID: 1273
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004FA RID: 1274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004FB RID: 1275
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x040004FC RID: 1276
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000079 RID: 121
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000656 RID: 1622 RVA: 0x0002178C File Offset: 0x0001F98C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, 100663613);
				ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, 100663614);
				ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr, 100663615);
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x0002181C File Offset: 0x0001FA1C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x00021858 File Offset: 0x0001FA58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119588, XrefRangeEnd = 119589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000659 RID: 1625 RVA: 0x00021894 File Offset: 0x0001FA94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119589, XrefRangeEnd = 119590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass17_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x000041AE File Offset: 0x000023AE
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x0600065B RID: 1627 RVA: 0x000218D4 File Offset: 0x0001FAD4
			// (set) Token: 0x0600065C RID: 1628 RVA: 0x000041B7 File Offset: 0x000023B7
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x0600065D RID: 1629 RVA: 0x00021904 File Offset: 0x0001FB04
			// (set) Token: 0x0600065E RID: 1630 RVA: 0x000041D6 File Offset: 0x000023D6
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass17_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004FD RID: 1277
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040004FE RID: 1278
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040004FF RID: 1279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000500 RID: 1280
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x04000501 RID: 1281
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200007A RID: 122
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600065F RID: 1631 RVA: 0x0002192C File Offset: 0x0001FB2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass18_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass18_0.NativeFieldInfoPtr_propertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr, "propertyID");
				ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr, 100663616);
				ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr, 100663617);
				ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr, 100663618);
			}

			// Token: 0x06000660 RID: 1632 RVA: 0x000219BC File Offset: 0x0001FBBC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000661 RID: 1633 RVA: 0x000219F8 File Offset: 0x0001FBF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119590, XrefRangeEnd = 119592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x00021A34 File Offset: 0x0001FC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119592, XrefRangeEnd = 119594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass18_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x000041F5 File Offset: 0x000023F5
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000664 RID: 1636 RVA: 0x00021A74 File Offset: 0x0001FC74
			// (set) Token: 0x06000665 RID: 1637 RVA: 0x000041FE File Offset: 0x000023FE
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass18_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass18_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000666 RID: 1638 RVA: 0x00021AA4 File Offset: 0x0001FCA4
			// (set) Token: 0x06000667 RID: 1639 RVA: 0x0000421D File Offset: 0x0000241D
			public unsafe int propertyID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass18_0.NativeFieldInfoPtr_propertyID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass18_0.NativeFieldInfoPtr_propertyID)) = value;
				}
			}

			// Token: 0x04000502 RID: 1282
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000503 RID: 1283
			private static readonly IntPtr NativeFieldInfoPtr_propertyID;

			// Token: 0x04000504 RID: 1284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000505 RID: 1285
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x04000506 RID: 1286
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200007B RID: 123
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000668 RID: 1640 RVA: 0x00021ACC File Offset: 0x0001FCCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass19_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr, 100663619);
				ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr, 100663620);
				ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr, 100663621);
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x00021B48 File Offset: 0x0001FD48
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x00021B84 File Offset: 0x0001FD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600066B RID: 1643 RVA: 0x00021BC0 File Offset: 0x0001FDC0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass19_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x00004238 File Offset: 0x00002438
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x0600066D RID: 1645 RVA: 0x00021C00 File Offset: 0x0001FE00
			// (set) Token: 0x0600066E RID: 1646 RVA: 0x00004241 File Offset: 0x00002441
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass19_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass19_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000507 RID: 1287
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000508 RID: 1288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000509 RID: 1289
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x0400050A RID: 1290
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200007C RID: 124
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600066F RID: 1647 RVA: 0x00021C30 File Offset: 0x0001FE30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass20_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass20_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr, 100663622);
				ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr, 100663623);
				ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr, 100663624);
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x00021CC0 File Offset: 0x0001FEC0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x00021CFC File Offset: 0x0001FEFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x00021D38 File Offset: 0x0001FF38
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass20_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000673 RID: 1651 RVA: 0x00004260 File Offset: 0x00002460
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000674 RID: 1652 RVA: 0x00021D78 File Offset: 0x0001FF78
			// (set) Token: 0x06000675 RID: 1653 RVA: 0x00004269 File Offset: 0x00002469
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass20_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass20_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000676 RID: 1654 RVA: 0x00021DA8 File Offset: 0x0001FFA8
			// (set) Token: 0x06000677 RID: 1655 RVA: 0x00004288 File Offset: 0x00002488
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass20_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass20_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400050B RID: 1291
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400050C RID: 1292
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x0400050D RID: 1293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400050E RID: 1294
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x0400050F RID: 1295
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200007D RID: 125
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000678 RID: 1656 RVA: 0x00021DD0 File Offset: 0x0001FFD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_propertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, "propertyID");
				ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, 100663625);
				ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, 100663626);
				ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr, 100663627);
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x00021E60 File Offset: 0x00020060
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x00021E9C File Offset: 0x0002009C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x00021ED8 File Offset: 0x000200D8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass21_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600067C RID: 1660 RVA: 0x000042A7 File Offset: 0x000024A7
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600067D RID: 1661 RVA: 0x00021F18 File Offset: 0x00020118
			// (set) Token: 0x0600067E RID: 1662 RVA: 0x000042B0 File Offset: 0x000024B0
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x0600067F RID: 1663 RVA: 0x00021F48 File Offset: 0x00020148
			// (set) Token: 0x06000680 RID: 1664 RVA: 0x000042CF File Offset: 0x000024CF
			public unsafe int propertyID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_propertyID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass21_0.NativeFieldInfoPtr_propertyID)) = value;
				}
			}

			// Token: 0x04000510 RID: 1296
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000511 RID: 1297
			private static readonly IntPtr NativeFieldInfoPtr_propertyID;

			// Token: 0x04000512 RID: 1298
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000513 RID: 1299
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x04000514 RID: 1300
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200007E RID: 126
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000681 RID: 1665 RVA: 0x00021F70 File Offset: 0x00020170
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, 100663628);
				ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__DOFloat_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, 100663629);
				ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__DOFloat_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr, 100663630);
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x00022000 File Offset: 0x00020200
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000683 RID: 1667 RVA: 0x0002203C File Offset: 0x0002023C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119594, XrefRangeEnd = 119596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFloat_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__DOFloat_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000684 RID: 1668 RVA: 0x00022078 File Offset: 0x00020278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119596, XrefRangeEnd = 119598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFloat_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass22_0.NativeMethodInfoPtr__DOFloat_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000685 RID: 1669 RVA: 0x000042EA File Offset: 0x000024EA
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000686 RID: 1670 RVA: 0x000220B8 File Offset: 0x000202B8
			// (set) Token: 0x06000687 RID: 1671 RVA: 0x000042F3 File Offset: 0x000024F3
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x06000688 RID: 1672 RVA: 0x000220E8 File Offset: 0x000202E8
			// (set) Token: 0x06000689 RID: 1673 RVA: 0x00004312 File Offset: 0x00002512
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass22_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000515 RID: 1301
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000516 RID: 1302
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04000517 RID: 1303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000518 RID: 1304
			private static readonly IntPtr NativeMethodInfoPtr__DOFloat_b__0_Internal_Single_0;

			// Token: 0x04000519 RID: 1305
			private static readonly IntPtr NativeMethodInfoPtr__DOFloat_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200007F RID: 127
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600068A RID: 1674 RVA: 0x00022110 File Offset: 0x00020310
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass23_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass23_0.NativeFieldInfoPtr_propertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr, "propertyID");
				ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr, 100663631);
				ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__DOFloat_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr, 100663632);
				ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__DOFloat_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr, 100663633);
			}

			// Token: 0x0600068B RID: 1675 RVA: 0x000221A0 File Offset: 0x000203A0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x000221DC File Offset: 0x000203DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119598, XrefRangeEnd = 119603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFloat_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__DOFloat_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x00022218 File Offset: 0x00020418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119603, XrefRangeEnd = 119608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFloat_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass23_0.NativeMethodInfoPtr__DOFloat_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x00004331 File Offset: 0x00002531
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x0600068F RID: 1679 RVA: 0x00022258 File Offset: 0x00020458
			// (set) Token: 0x06000690 RID: 1680 RVA: 0x0000433A File Offset: 0x0000253A
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass23_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass23_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000691 RID: 1681 RVA: 0x00022288 File Offset: 0x00020488
			// (set) Token: 0x06000692 RID: 1682 RVA: 0x00004359 File Offset: 0x00002559
			public unsafe int propertyID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass23_0.NativeFieldInfoPtr_propertyID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass23_0.NativeFieldInfoPtr_propertyID)) = value;
				}
			}

			// Token: 0x0400051A RID: 1306
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400051B RID: 1307
			private static readonly IntPtr NativeFieldInfoPtr_propertyID;

			// Token: 0x0400051C RID: 1308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400051D RID: 1309
			private static readonly IntPtr NativeMethodInfoPtr__DOFloat_b__0_Internal_Single_0;

			// Token: 0x0400051E RID: 1310
			private static readonly IntPtr NativeMethodInfoPtr__DOFloat_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000080 RID: 128
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000693 RID: 1683 RVA: 0x000222B0 File Offset: 0x000204B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass24_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr, 100663634);
				ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr, 100663635);
				ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr, 100663636);
			}

			// Token: 0x06000694 RID: 1684 RVA: 0x0002232C File Offset: 0x0002052C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000695 RID: 1685 RVA: 0x00022368 File Offset: 0x00020568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119608, XrefRangeEnd = 119613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOOffset_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000696 RID: 1686 RVA: 0x000223A4 File Offset: 0x000205A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119613, XrefRangeEnd = 119618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOOffset_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass24_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000697 RID: 1687 RVA: 0x00004374 File Offset: 0x00002574
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000698 RID: 1688 RVA: 0x000223E4 File Offset: 0x000205E4
			// (set) Token: 0x06000699 RID: 1689 RVA: 0x0000437D File Offset: 0x0000257D
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass24_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass24_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400051F RID: 1311
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000520 RID: 1312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000521 RID: 1313
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0;

			// Token: 0x04000522 RID: 1314
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000081 RID: 129
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600069A RID: 1690 RVA: 0x00022414 File Offset: 0x00020614
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass25_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass25_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr, 100663637);
				ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr, 100663638);
				ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr, 100663639);
			}

			// Token: 0x0600069B RID: 1691 RVA: 0x000224A4 File Offset: 0x000206A4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600069C RID: 1692 RVA: 0x000224E0 File Offset: 0x000206E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119618, XrefRangeEnd = 119620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOOffset_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600069D RID: 1693 RVA: 0x0002251C File Offset: 0x0002071C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119620, XrefRangeEnd = 119622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOOffset_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass25_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600069E RID: 1694 RVA: 0x0000439C File Offset: 0x0000259C
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x0600069F RID: 1695 RVA: 0x0002255C File Offset: 0x0002075C
			// (set) Token: 0x060006A0 RID: 1696 RVA: 0x000043A5 File Offset: 0x000025A5
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass25_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass25_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0002258C File Offset: 0x0002078C
			// (set) Token: 0x060006A2 RID: 1698 RVA: 0x000043C4 File Offset: 0x000025C4
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass25_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass25_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000523 RID: 1315
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000524 RID: 1316
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04000525 RID: 1317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000526 RID: 1318
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0;

			// Token: 0x04000527 RID: 1319
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000082 RID: 130
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006A3 RID: 1699 RVA: 0x000225B4 File Offset: 0x000207B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass26_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr, 100663640);
				ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr, 100663641);
				ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr, 100663642);
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x00022630 File Offset: 0x00020830
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x0002266C File Offset: 0x0002086C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119622, XrefRangeEnd = 119627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOTiling_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006A6 RID: 1702 RVA: 0x000226A8 File Offset: 0x000208A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119627, XrefRangeEnd = 119632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOTiling_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass26_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006A7 RID: 1703 RVA: 0x000043E3 File Offset: 0x000025E3
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060006A8 RID: 1704 RVA: 0x000226E8 File Offset: 0x000208E8
			// (set) Token: 0x060006A9 RID: 1705 RVA: 0x000043EC File Offset: 0x000025EC
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass26_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass26_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000528 RID: 1320
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000529 RID: 1321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400052A RID: 1322
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0;

			// Token: 0x0400052B RID: 1323
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000083 RID: 131
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006AA RID: 1706 RVA: 0x00022718 File Offset: 0x00020918
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, 100663643);
				ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, 100663644);
				ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr, 100663645);
			}

			// Token: 0x060006AB RID: 1707 RVA: 0x000227A8 File Offset: 0x000209A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006AC RID: 1708 RVA: 0x000227E4 File Offset: 0x000209E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119632, XrefRangeEnd = 119634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOTiling_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006AD RID: 1709 RVA: 0x00022820 File Offset: 0x00020A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119634, XrefRangeEnd = 119636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOTiling_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass27_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006AE RID: 1710 RVA: 0x0000440B File Offset: 0x0000260B
			public __c__DisplayClass27_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060006AF RID: 1711 RVA: 0x00022860 File Offset: 0x00020A60
			// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00004414 File Offset: 0x00002614
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00022890 File Offset: 0x00020A90
			// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00004433 File Offset: 0x00002633
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass27_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400052C RID: 1324
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400052D RID: 1325
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x0400052E RID: 1326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400052F RID: 1327
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0;

			// Token: 0x04000530 RID: 1328
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000084 RID: 132
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006B3 RID: 1715 RVA: 0x000228B8 File Offset: 0x00020AB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass28_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass28_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr, 100663646);
				ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__DOVector_b__0_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr, 100663647);
				ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__DOVector_b__1_Internal_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr, 100663648);
			}

			// Token: 0x060006B4 RID: 1716 RVA: 0x00022948 File Offset: 0x00020B48
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006B5 RID: 1717 RVA: 0x00022984 File Offset: 0x00020B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119636, XrefRangeEnd = 119640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector4 _DOVector_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__DOVector_b__0_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006B6 RID: 1718 RVA: 0x000229C0 File Offset: 0x00020BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119640, XrefRangeEnd = 119641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOVector_b__1(Vector4 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass28_0.NativeMethodInfoPtr__DOVector_b__1_Internal_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006B7 RID: 1719 RVA: 0x00004452 File Offset: 0x00002652
			public __c__DisplayClass28_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00022A00 File Offset: 0x00020C00
			// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0000445B File Offset: 0x0000265B
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass28_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass28_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060006BA RID: 1722 RVA: 0x00022A30 File Offset: 0x00020C30
			// (set) Token: 0x060006BB RID: 1723 RVA: 0x0000447A File Offset: 0x0000267A
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass28_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass28_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000531 RID: 1329
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000532 RID: 1330
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04000533 RID: 1331
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000534 RID: 1332
			private static readonly IntPtr NativeMethodInfoPtr__DOVector_b__0_Internal_Vector4_0;

			// Token: 0x04000535 RID: 1333
			private static readonly IntPtr NativeMethodInfoPtr__DOVector_b__1_Internal_Void_Vector4_0;
		}

		// Token: 0x02000085 RID: 133
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006BC RID: 1724 RVA: 0x00022A58 File Offset: 0x00020C58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass29_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass29_0.NativeFieldInfoPtr_propertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr, "propertyID");
				ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr, 100663649);
				ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__DOVector_b__0_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr, 100663650);
				ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__DOVector_b__1_Internal_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr, 100663651);
			}

			// Token: 0x060006BD RID: 1725 RVA: 0x00022AE8 File Offset: 0x00020CE8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006BE RID: 1726 RVA: 0x00022B24 File Offset: 0x00020D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119641, XrefRangeEnd = 119643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector4 _DOVector_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__DOVector_b__0_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006BF RID: 1727 RVA: 0x00022B60 File Offset: 0x00020D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119643, XrefRangeEnd = 119645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOVector_b__1(Vector4 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass29_0.NativeMethodInfoPtr__DOVector_b__1_Internal_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x00004499 File Offset: 0x00002699
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00022BA0 File Offset: 0x00020DA0
			// (set) Token: 0x060006C2 RID: 1730 RVA: 0x000044A2 File Offset: 0x000026A2
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass29_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass29_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00022BD0 File Offset: 0x00020DD0
			// (set) Token: 0x060006C4 RID: 1732 RVA: 0x000044C1 File Offset: 0x000026C1
			public unsafe int propertyID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass29_0.NativeFieldInfoPtr_propertyID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass29_0.NativeFieldInfoPtr_propertyID)) = value;
				}
			}

			// Token: 0x04000536 RID: 1334
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000537 RID: 1335
			private static readonly IntPtr NativeFieldInfoPtr_propertyID;

			// Token: 0x04000538 RID: 1336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000539 RID: 1337
			private static readonly IntPtr NativeMethodInfoPtr__DOVector_b__0_Internal_Vector4_0;

			// Token: 0x0400053A RID: 1338
			private static readonly IntPtr NativeMethodInfoPtr__DOVector_b__1_Internal_Void_Vector4_0;
		}

		// Token: 0x02000086 RID: 134
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006C5 RID: 1733 RVA: 0x00022BF8 File Offset: 0x00020DF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass30_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr, 100663652);
				ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__DOResize_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr, 100663653);
				ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__DOResize_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr, 100663654);
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x00022C74 File Offset: 0x00020E74
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x00022CB0 File Offset: 0x00020EB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119645, XrefRangeEnd = 119649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOResize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__DOResize_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006C8 RID: 1736 RVA: 0x00022CEC File Offset: 0x00020EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119649, XrefRangeEnd = 119658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOResize_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass30_0.NativeMethodInfoPtr__DOResize_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x000044DC File Offset: 0x000026DC
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x060006CA RID: 1738 RVA: 0x00022D2C File Offset: 0x00020F2C
			// (set) Token: 0x060006CB RID: 1739 RVA: 0x000044E5 File Offset: 0x000026E5
			public unsafe TrailRenderer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass30_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass30_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400053B RID: 1339
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400053C RID: 1340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400053D RID: 1341
			private static readonly IntPtr NativeMethodInfoPtr__DOResize_b__0_Internal_Vector2_0;

			// Token: 0x0400053E RID: 1342
			private static readonly IntPtr NativeMethodInfoPtr__DOResize_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000087 RID: 135
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006CC RID: 1740 RVA: 0x00022D5C File Offset: 0x00020F5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass31_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr, 100663655);
				ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__DOTime_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr, 100663656);
				ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__DOTime_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr, 100663657);
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x00022DD8 File Offset: 0x00020FD8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x00022E14 File Offset: 0x00021014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119658, XrefRangeEnd = 119663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOTime_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__DOTime_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006CF RID: 1743 RVA: 0x00022E50 File Offset: 0x00021050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119663, XrefRangeEnd = 119668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOTime_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass31_0.NativeMethodInfoPtr__DOTime_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x00004504 File Offset: 0x00002704
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00022E90 File Offset: 0x00021090
			// (set) Token: 0x060006D2 RID: 1746 RVA: 0x0000450D File Offset: 0x0000270D
			public unsafe TrailRenderer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass31_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass31_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400053F RID: 1343
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000540 RID: 1344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000541 RID: 1345
			private static readonly IntPtr NativeMethodInfoPtr__DOTime_b__0_Internal_Single_0;

			// Token: 0x04000542 RID: 1346
			private static readonly IntPtr NativeMethodInfoPtr__DOTime_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000088 RID: 136
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006D3 RID: 1747 RVA: 0x00022EC0 File Offset: 0x000210C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass32_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr, 100663658);
				ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr, 100663659);
				ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__DOMove_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr, 100663660);
			}

			// Token: 0x060006D4 RID: 1748 RVA: 0x00022F3C File Offset: 0x0002113C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006D5 RID: 1749 RVA: 0x00022F78 File Offset: 0x00021178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119668, XrefRangeEnd = 119670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMove_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x00022FB4 File Offset: 0x000211B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119670, XrefRangeEnd = 119672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOMove_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass32_0.NativeMethodInfoPtr__DOMove_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x0000452C File Offset: 0x0000272C
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00022FF4 File Offset: 0x000211F4
			// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00004535 File Offset: 0x00002735
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass32_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass32_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000543 RID: 1347
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000544 RID: 1348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000545 RID: 1349
			private static readonly IntPtr NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0;

			// Token: 0x04000546 RID: 1350
			private static readonly IntPtr NativeMethodInfoPtr__DOMove_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000089 RID: 137
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006DA RID: 1754 RVA: 0x00023024 File Offset: 0x00021224
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass33_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr, 100663661);
				ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr, 100663662);
				ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__DOMoveX_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr, 100663663);
			}

			// Token: 0x060006DB RID: 1755 RVA: 0x000230A0 File Offset: 0x000212A0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x000230DC File Offset: 0x000212DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x00023118 File Offset: 0x00021318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOMoveX_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass33_0.NativeMethodInfoPtr__DOMoveX_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x00004554 File Offset: 0x00002754
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060006DF RID: 1759 RVA: 0x00023158 File Offset: 0x00021358
			// (set) Token: 0x060006E0 RID: 1760 RVA: 0x0000455D File Offset: 0x0000275D
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass33_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass33_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000547 RID: 1351
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000548 RID: 1352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000549 RID: 1353
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0;

			// Token: 0x0400054A RID: 1354
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveX_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008A RID: 138
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006E1 RID: 1761 RVA: 0x00023188 File Offset: 0x00021388
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, 100663664);
				ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, 100663665);
				ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOMoveY_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr, 100663666);
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x00023204 File Offset: 0x00021404
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006E3 RID: 1763 RVA: 0x00023240 File Offset: 0x00021440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x0002327C File Offset: 0x0002147C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOMoveY_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass34_0.NativeMethodInfoPtr__DOMoveY_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x0000457C File Offset: 0x0000277C
			public __c__DisplayClass34_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000232BC File Offset: 0x000214BC
			// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00004585 File Offset: 0x00002785
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass34_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400054B RID: 1355
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400054C RID: 1356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400054D RID: 1357
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0;

			// Token: 0x0400054E RID: 1358
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveY_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008B RID: 139
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006E8 RID: 1768 RVA: 0x000232EC File Offset: 0x000214EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass35_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr, 100663667);
				ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr, 100663668);
				ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__DOMoveZ_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr, 100663669);
			}

			// Token: 0x060006E9 RID: 1769 RVA: 0x00023368 File Offset: 0x00021568
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006EA RID: 1770 RVA: 0x000233A4 File Offset: 0x000215A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006EB RID: 1771 RVA: 0x000233E0 File Offset: 0x000215E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOMoveZ_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass35_0.NativeMethodInfoPtr__DOMoveZ_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006EC RID: 1772 RVA: 0x000045A4 File Offset: 0x000027A4
			public __c__DisplayClass35_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060006ED RID: 1773 RVA: 0x00023420 File Offset: 0x00021620
			// (set) Token: 0x060006EE RID: 1774 RVA: 0x000045AD File Offset: 0x000027AD
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass35_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass35_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400054F RID: 1359
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000550 RID: 1360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000551 RID: 1361
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0;

			// Token: 0x04000552 RID: 1362
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveZ_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008C RID: 140
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006EF RID: 1775 RVA: 0x00023450 File Offset: 0x00021650
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass36_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr, 100663670);
				ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__DOLocalMove_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr, 100663671);
				ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__DOLocalMove_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr, 100663672);
			}

			// Token: 0x060006F0 RID: 1776 RVA: 0x000234CC File Offset: 0x000216CC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x00023508 File Offset: 0x00021708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalMove_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__DOLocalMove_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x00023544 File Offset: 0x00021744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119672, XrefRangeEnd = 119674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalMove_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass36_0.NativeMethodInfoPtr__DOLocalMove_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006F3 RID: 1779 RVA: 0x000045CC File Offset: 0x000027CC
			public __c__DisplayClass36_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00023584 File Offset: 0x00021784
			// (set) Token: 0x060006F5 RID: 1781 RVA: 0x000045D5 File Offset: 0x000027D5
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass36_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass36_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000553 RID: 1363
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000554 RID: 1364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000555 RID: 1365
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMove_b__0_Internal_Vector3_0;

			// Token: 0x04000556 RID: 1366
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMove_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008D RID: 141
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006F6 RID: 1782 RVA: 0x000235B4 File Offset: 0x000217B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass37_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr, 100663673);
				ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__DOLocalMoveX_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr, 100663674);
				ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__DOLocalMoveX_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr, 100663675);
			}

			// Token: 0x060006F7 RID: 1783 RVA: 0x00023630 File Offset: 0x00021830
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006F8 RID: 1784 RVA: 0x0002366C File Offset: 0x0002186C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalMoveX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__DOLocalMoveX_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006F9 RID: 1785 RVA: 0x000236A8 File Offset: 0x000218A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalMoveX_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass37_0.NativeMethodInfoPtr__DOLocalMoveX_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006FA RID: 1786 RVA: 0x000045F4 File Offset: 0x000027F4
			public __c__DisplayClass37_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x060006FB RID: 1787 RVA: 0x000236E8 File Offset: 0x000218E8
			// (set) Token: 0x060006FC RID: 1788 RVA: 0x000045FD File Offset: 0x000027FD
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass37_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass37_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000557 RID: 1367
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000558 RID: 1368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000559 RID: 1369
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveX_b__0_Internal_Vector3_0;

			// Token: 0x0400055A RID: 1370
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveX_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008E RID: 142
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060006FD RID: 1789 RVA: 0x00023718 File Offset: 0x00021918
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass38_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr, 100663676);
				ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__DOLocalMoveY_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr, 100663677);
				ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__DOLocalMoveY_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr, 100663678);
			}

			// Token: 0x060006FE RID: 1790 RVA: 0x00023794 File Offset: 0x00021994
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006FF RID: 1791 RVA: 0x000237D0 File Offset: 0x000219D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalMoveY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__DOLocalMoveY_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000700 RID: 1792 RVA: 0x0002380C File Offset: 0x00021A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalMoveY_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass38_0.NativeMethodInfoPtr__DOLocalMoveY_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000701 RID: 1793 RVA: 0x0000461C File Offset: 0x0000281C
			public __c__DisplayClass38_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000702 RID: 1794 RVA: 0x0002384C File Offset: 0x00021A4C
			// (set) Token: 0x06000703 RID: 1795 RVA: 0x00004625 File Offset: 0x00002825
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass38_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass38_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400055B RID: 1371
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400055C RID: 1372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400055D RID: 1373
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveY_b__0_Internal_Vector3_0;

			// Token: 0x0400055E RID: 1374
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveY_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200008F RID: 143
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000704 RID: 1796 RVA: 0x0002387C File Offset: 0x00021A7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass39_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr, 100663679);
				ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__DOLocalMoveZ_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr, 100663680);
				ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__DOLocalMoveZ_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr, 100663681);
			}

			// Token: 0x06000705 RID: 1797 RVA: 0x000238F8 File Offset: 0x00021AF8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000706 RID: 1798 RVA: 0x00023934 File Offset: 0x00021B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalMoveZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__DOLocalMoveZ_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000707 RID: 1799 RVA: 0x00023970 File Offset: 0x00021B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalMoveZ_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass39_0.NativeMethodInfoPtr__DOLocalMoveZ_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000708 RID: 1800 RVA: 0x00004644 File Offset: 0x00002844
			public __c__DisplayClass39_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x06000709 RID: 1801 RVA: 0x000239B0 File Offset: 0x00021BB0
			// (set) Token: 0x0600070A RID: 1802 RVA: 0x0000464D File Offset: 0x0000284D
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass39_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass39_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400055F RID: 1375
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000560 RID: 1376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000561 RID: 1377
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveZ_b__0_Internal_Vector3_0;

			// Token: 0x04000562 RID: 1378
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalMoveZ_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000090 RID: 144
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600070B RID: 1803 RVA: 0x000239E0 File Offset: 0x00021BE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass40_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr, 100663682);
				ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr, 100663683);
				ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__DORotate_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr, 100663684);
			}

			// Token: 0x0600070C RID: 1804 RVA: 0x00023A5C File Offset: 0x00021C5C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600070D RID: 1805 RVA: 0x00023A98 File Offset: 0x00021C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119674, XrefRangeEnd = 119676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DORotate_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600070E RID: 1806 RVA: 0x00023AD4 File Offset: 0x00021CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119676, XrefRangeEnd = 119678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DORotate_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass40_0.NativeMethodInfoPtr__DORotate_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600070F RID: 1807 RVA: 0x0000466C File Offset: 0x0000286C
			public __c__DisplayClass40_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x06000710 RID: 1808 RVA: 0x00023B14 File Offset: 0x00021D14
			// (set) Token: 0x06000711 RID: 1809 RVA: 0x00004675 File Offset: 0x00002875
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass40_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass40_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000563 RID: 1379
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000564 RID: 1380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000565 RID: 1381
			private static readonly IntPtr NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0;

			// Token: 0x04000566 RID: 1382
			private static readonly IntPtr NativeMethodInfoPtr__DORotate_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x02000091 RID: 145
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000712 RID: 1810 RVA: 0x00023B44 File Offset: 0x00021D44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass41_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr, 100663685);
				ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__DORotateQuaternion_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr, 100663686);
				ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__DORotateQuaternion_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr, 100663687);
			}

			// Token: 0x06000713 RID: 1811 RVA: 0x00023BC0 File Offset: 0x00021DC0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000714 RID: 1812 RVA: 0x00023BFC File Offset: 0x00021DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DORotateQuaternion_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__DORotateQuaternion_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000715 RID: 1813 RVA: 0x00023C38 File Offset: 0x00021E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DORotateQuaternion_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass41_0.NativeMethodInfoPtr__DORotateQuaternion_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000716 RID: 1814 RVA: 0x00004694 File Offset: 0x00002894
			public __c__DisplayClass41_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000717 RID: 1815 RVA: 0x00023C78 File Offset: 0x00021E78
			// (set) Token: 0x06000718 RID: 1816 RVA: 0x0000469D File Offset: 0x0000289D
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass41_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass41_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000567 RID: 1383
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000568 RID: 1384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000569 RID: 1385
			private static readonly IntPtr NativeMethodInfoPtr__DORotateQuaternion_b__0_Internal_Quaternion_0;

			// Token: 0x0400056A RID: 1386
			private static readonly IntPtr NativeMethodInfoPtr__DORotateQuaternion_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x02000092 RID: 146
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000719 RID: 1817 RVA: 0x00023CA8 File Offset: 0x00021EA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass42_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr, 100663688);
				ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__DOLocalRotate_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr, 100663689);
				ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__DOLocalRotate_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr, 100663690);
			}

			// Token: 0x0600071A RID: 1818 RVA: 0x00023D24 File Offset: 0x00021F24
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600071B RID: 1819 RVA: 0x00023D60 File Offset: 0x00021F60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119678, XrefRangeEnd = 119680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DOLocalRotate_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__DOLocalRotate_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600071C RID: 1820 RVA: 0x00023D9C File Offset: 0x00021F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119680, XrefRangeEnd = 119682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalRotate_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass42_0.NativeMethodInfoPtr__DOLocalRotate_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600071D RID: 1821 RVA: 0x000046BC File Offset: 0x000028BC
			public __c__DisplayClass42_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x0600071E RID: 1822 RVA: 0x00023DDC File Offset: 0x00021FDC
			// (set) Token: 0x0600071F RID: 1823 RVA: 0x000046C5 File Offset: 0x000028C5
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass42_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass42_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400056B RID: 1387
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400056C RID: 1388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400056D RID: 1389
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalRotate_b__0_Internal_Quaternion_0;

			// Token: 0x0400056E RID: 1390
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalRotate_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x02000093 RID: 147
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000720 RID: 1824 RVA: 0x00023E0C File Offset: 0x0002200C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass43_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr, 100663691);
				ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__DOLocalRotateQuaternion_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr, 100663692);
				ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__DOLocalRotateQuaternion_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr, 100663693);
			}

			// Token: 0x06000721 RID: 1825 RVA: 0x00023E88 File Offset: 0x00022088
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000722 RID: 1826 RVA: 0x00023EC4 File Offset: 0x000220C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DOLocalRotateQuaternion_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__DOLocalRotateQuaternion_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000723 RID: 1827 RVA: 0x00023F00 File Offset: 0x00022100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalRotateQuaternion_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass43_0.NativeMethodInfoPtr__DOLocalRotateQuaternion_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000724 RID: 1828 RVA: 0x000046E4 File Offset: 0x000028E4
			public __c__DisplayClass43_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000725 RID: 1829 RVA: 0x00023F40 File Offset: 0x00022140
			// (set) Token: 0x06000726 RID: 1830 RVA: 0x000046ED File Offset: 0x000028ED
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass43_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass43_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400056F RID: 1391
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000570 RID: 1392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000571 RID: 1393
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalRotateQuaternion_b__0_Internal_Quaternion_0;

			// Token: 0x04000572 RID: 1394
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalRotateQuaternion_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x02000094 RID: 148
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000727 RID: 1831 RVA: 0x00023F70 File Offset: 0x00022170
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass44_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr, 100663694);
				ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr, 100663695);
				ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr, 100663696);
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x00023FEC File Offset: 0x000221EC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000729 RID: 1833 RVA: 0x00024028 File Offset: 0x00022228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119682, XrefRangeEnd = 119684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x00024064 File Offset: 0x00022264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119684, XrefRangeEnd = 119686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass44_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600072B RID: 1835 RVA: 0x0000470C File Offset: 0x0000290C
			public __c__DisplayClass44_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x0600072C RID: 1836 RVA: 0x000240A4 File Offset: 0x000222A4
			// (set) Token: 0x0600072D RID: 1837 RVA: 0x00004715 File Offset: 0x00002915
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass44_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass44_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000573 RID: 1395
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000574 RID: 1396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000575 RID: 1397
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0;

			// Token: 0x04000576 RID: 1398
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000095 RID: 149
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600072E RID: 1838 RVA: 0x000240D4 File Offset: 0x000222D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass45_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr, 100663697);
				ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr, 100663698);
				ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr, 100663699);
			}

			// Token: 0x0600072F RID: 1839 RVA: 0x00024150 File Offset: 0x00022350
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000730 RID: 1840 RVA: 0x0002418C File Offset: 0x0002238C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000731 RID: 1841 RVA: 0x000241C8 File Offset: 0x000223C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass45_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000732 RID: 1842 RVA: 0x00004734 File Offset: 0x00002934
			public __c__DisplayClass45_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000733 RID: 1843 RVA: 0x00024208 File Offset: 0x00022408
			// (set) Token: 0x06000734 RID: 1844 RVA: 0x0000473D File Offset: 0x0000293D
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass45_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass45_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000577 RID: 1399
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000578 RID: 1400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000579 RID: 1401
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__0_Internal_Vector3_0;

			// Token: 0x0400057A RID: 1402
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000096 RID: 150
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000735 RID: 1845 RVA: 0x00024238 File Offset: 0x00022438
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass46_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr, 100663700);
				ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__DOScaleX_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr, 100663701);
				ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__DOScaleX_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr, 100663702);
			}

			// Token: 0x06000736 RID: 1846 RVA: 0x000242B4 File Offset: 0x000224B4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000737 RID: 1847 RVA: 0x000242F0 File Offset: 0x000224F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScaleX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__DOScaleX_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000738 RID: 1848 RVA: 0x0002432C File Offset: 0x0002252C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScaleX_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass46_0.NativeMethodInfoPtr__DOScaleX_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000739 RID: 1849 RVA: 0x0000475C File Offset: 0x0000295C
			public __c__DisplayClass46_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x0600073A RID: 1850 RVA: 0x0002436C File Offset: 0x0002256C
			// (set) Token: 0x0600073B RID: 1851 RVA: 0x00004765 File Offset: 0x00002965
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass46_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass46_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400057B RID: 1403
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400057C RID: 1404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400057D RID: 1405
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleX_b__0_Internal_Vector3_0;

			// Token: 0x0400057E RID: 1406
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleX_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000097 RID: 151
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600073C RID: 1852 RVA: 0x0002439C File Offset: 0x0002259C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass47_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr, 100663703);
				ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__DOScaleY_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr, 100663704);
				ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__DOScaleY_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr, 100663705);
			}

			// Token: 0x0600073D RID: 1853 RVA: 0x00024418 File Offset: 0x00022618
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600073E RID: 1854 RVA: 0x00024454 File Offset: 0x00022654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScaleY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__DOScaleY_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600073F RID: 1855 RVA: 0x00024490 File Offset: 0x00022690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScaleY_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass47_0.NativeMethodInfoPtr__DOScaleY_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000740 RID: 1856 RVA: 0x00004784 File Offset: 0x00002984
			public __c__DisplayClass47_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x06000741 RID: 1857 RVA: 0x000244D0 File Offset: 0x000226D0
			// (set) Token: 0x06000742 RID: 1858 RVA: 0x0000478D File Offset: 0x0000298D
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass47_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass47_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400057F RID: 1407
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000580 RID: 1408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000581 RID: 1409
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleY_b__0_Internal_Vector3_0;

			// Token: 0x04000582 RID: 1410
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleY_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000098 RID: 152
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000743 RID: 1859 RVA: 0x00024500 File Offset: 0x00022700
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass48_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr, 100663706);
				ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__DOScaleZ_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr, 100663707);
				ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__DOScaleZ_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr, 100663708);
			}

			// Token: 0x06000744 RID: 1860 RVA: 0x0002457C File Offset: 0x0002277C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000745 RID: 1861 RVA: 0x000245B8 File Offset: 0x000227B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOScaleZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__DOScaleZ_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000746 RID: 1862 RVA: 0x000245F4 File Offset: 0x000227F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScaleZ_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass48_0.NativeMethodInfoPtr__DOScaleZ_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000747 RID: 1863 RVA: 0x000047AC File Offset: 0x000029AC
			public __c__DisplayClass48_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x06000748 RID: 1864 RVA: 0x00024634 File Offset: 0x00022834
			// (set) Token: 0x06000749 RID: 1865 RVA: 0x000047B5 File Offset: 0x000029B5
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass48_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass48_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000583 RID: 1411
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000584 RID: 1412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000585 RID: 1413
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleZ_b__0_Internal_Vector3_0;

			// Token: 0x04000586 RID: 1414
			private static readonly IntPtr NativeMethodInfoPtr__DOScaleZ_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000099 RID: 153
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600074A RID: 1866 RVA: 0x00024664 File Offset: 0x00022864
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass49_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr, 100663709);
				ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr, 100663710);
				ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__DOLookAt_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr, 100663711);
			}

			// Token: 0x0600074B RID: 1867 RVA: 0x000246E0 File Offset: 0x000228E0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x0002471C File Offset: 0x0002291C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DOLookAt_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x00024758 File Offset: 0x00022958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLookAt_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass49_0.NativeMethodInfoPtr__DOLookAt_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x000047D4 File Offset: 0x000029D4
			public __c__DisplayClass49_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x0600074F RID: 1871 RVA: 0x00024798 File Offset: 0x00022998
			// (set) Token: 0x06000750 RID: 1872 RVA: 0x000047DD File Offset: 0x000029DD
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass49_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass49_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000587 RID: 1415
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000588 RID: 1416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000589 RID: 1417
			private static readonly IntPtr NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0;

			// Token: 0x0400058A RID: 1418
			private static readonly IntPtr NativeMethodInfoPtr__DOLookAt_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x0200009A RID: 154
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000751 RID: 1873 RVA: 0x000247C8 File Offset: 0x000229C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass50_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr, 100663712);
				ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__DOPunchPosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr, 100663713);
				ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__DOPunchPosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr, 100663714);
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x00024844 File Offset: 0x00022A44
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x00024880 File Offset: 0x00022A80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPunchPosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__DOPunchPosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000754 RID: 1876 RVA: 0x000248BC File Offset: 0x00022ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPunchPosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass50_0.NativeMethodInfoPtr__DOPunchPosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000755 RID: 1877 RVA: 0x000047FC File Offset: 0x000029FC
			public __c__DisplayClass50_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x06000756 RID: 1878 RVA: 0x000248FC File Offset: 0x00022AFC
			// (set) Token: 0x06000757 RID: 1879 RVA: 0x00004805 File Offset: 0x00002A05
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass50_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass50_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400058B RID: 1419
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400058C RID: 1420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400058D RID: 1421
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchPosition_b__0_Internal_Vector3_0;

			// Token: 0x0400058E RID: 1422
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchPosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009B RID: 155
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000758 RID: 1880 RVA: 0x0002492C File Offset: 0x00022B2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass51_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr, 100663715);
				ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__DOPunchScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr, 100663716);
				ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__DOPunchScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr, 100663717);
			}

			// Token: 0x06000759 RID: 1881 RVA: 0x000249A8 File Offset: 0x00022BA8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600075A RID: 1882 RVA: 0x000249E4 File Offset: 0x00022BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPunchScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__DOPunchScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600075B RID: 1883 RVA: 0x00024A20 File Offset: 0x00022C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPunchScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass51_0.NativeMethodInfoPtr__DOPunchScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600075C RID: 1884 RVA: 0x00004824 File Offset: 0x00002A24
			public __c__DisplayClass51_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x0600075D RID: 1885 RVA: 0x00024A60 File Offset: 0x00022C60
			// (set) Token: 0x0600075E RID: 1886 RVA: 0x0000482D File Offset: 0x00002A2D
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass51_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass51_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400058F RID: 1423
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000590 RID: 1424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000591 RID: 1425
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchScale_b__0_Internal_Vector3_0;

			// Token: 0x04000592 RID: 1426
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009C RID: 156
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600075F RID: 1887 RVA: 0x00024A90 File Offset: 0x00022C90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass52_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr, 100663718);
				ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__DOPunchRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr, 100663719);
				ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__DOPunchRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr, 100663720);
			}

			// Token: 0x06000760 RID: 1888 RVA: 0x00024B0C File Offset: 0x00022D0C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000761 RID: 1889 RVA: 0x00024B48 File Offset: 0x00022D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119686, XrefRangeEnd = 119689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPunchRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__DOPunchRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000762 RID: 1890 RVA: 0x00024B84 File Offset: 0x00022D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119689, XrefRangeEnd = 119693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPunchRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass52_0.NativeMethodInfoPtr__DOPunchRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x0000484C File Offset: 0x00002A4C
			public __c__DisplayClass52_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x06000764 RID: 1892 RVA: 0x00024BC4 File Offset: 0x00022DC4
			// (set) Token: 0x06000765 RID: 1893 RVA: 0x00004855 File Offset: 0x00002A55
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass52_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass52_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000593 RID: 1427
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000594 RID: 1428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000595 RID: 1429
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchRotation_b__0_Internal_Vector3_0;

			// Token: 0x04000596 RID: 1430
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009D RID: 157
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000766 RID: 1894 RVA: 0x00024BF4 File Offset: 0x00022DF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass53_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr, 100663721);
				ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr, 100663722);
				ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr, 100663723);
			}

			// Token: 0x06000767 RID: 1895 RVA: 0x00024C70 File Offset: 0x00022E70
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000768 RID: 1896 RVA: 0x00024CAC File Offset: 0x00022EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakePosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000769 RID: 1897 RVA: 0x00024CE8 File Offset: 0x00022EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakePosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass53_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600076A RID: 1898 RVA: 0x00004874 File Offset: 0x00002A74
			public __c__DisplayClass53_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x0600076B RID: 1899 RVA: 0x00024D28 File Offset: 0x00022F28
			// (set) Token: 0x0600076C RID: 1900 RVA: 0x0000487D File Offset: 0x00002A7D
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass53_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass53_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000597 RID: 1431
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000598 RID: 1432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000599 RID: 1433
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0;

			// Token: 0x0400059A RID: 1434
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009E RID: 158
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600076D RID: 1901 RVA: 0x00024D58 File Offset: 0x00022F58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass54_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr, 100663724);
				ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr, 100663725);
				ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr, 100663726);
			}

			// Token: 0x0600076E RID: 1902 RVA: 0x00024DD4 File Offset: 0x00022FD4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600076F RID: 1903 RVA: 0x00024E10 File Offset: 0x00023010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakePosition_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000770 RID: 1904 RVA: 0x00024E4C File Offset: 0x0002304C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakePosition_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass54_0.NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000771 RID: 1905 RVA: 0x0000489C File Offset: 0x00002A9C
			public __c__DisplayClass54_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000772 RID: 1906 RVA: 0x00024E8C File Offset: 0x0002308C
			// (set) Token: 0x06000773 RID: 1907 RVA: 0x000048A5 File Offset: 0x00002AA5
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass54_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass54_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400059B RID: 1435
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400059C RID: 1436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400059D RID: 1437
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__0_Internal_Vector3_0;

			// Token: 0x0400059E RID: 1438
			private static readonly IntPtr NativeMethodInfoPtr__DOShakePosition_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200009F RID: 159
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000774 RID: 1908 RVA: 0x00024EBC File Offset: 0x000230BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass55_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr, 100663727);
				ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr, 100663728);
				ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr, 100663729);
			}

			// Token: 0x06000775 RID: 1909 RVA: 0x00024F38 File Offset: 0x00023138
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000776 RID: 1910 RVA: 0x00024F74 File Offset: 0x00023174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000777 RID: 1911 RVA: 0x00024FB0 File Offset: 0x000231B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass55_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000778 RID: 1912 RVA: 0x000048C4 File Offset: 0x00002AC4
			public __c__DisplayClass55_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06000779 RID: 1913 RVA: 0x00024FF0 File Offset: 0x000231F0
			// (set) Token: 0x0600077A RID: 1914 RVA: 0x000048CD File Offset: 0x00002ACD
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass55_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass55_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400059F RID: 1439
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005A0 RID: 1440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005A1 RID: 1441
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0;

			// Token: 0x040005A2 RID: 1442
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A0 RID: 160
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600077B RID: 1915 RVA: 0x00025020 File Offset: 0x00023220
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass56_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr, 100663730);
				ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr, 100663731);
				ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr, 100663732);
			}

			// Token: 0x0600077C RID: 1916 RVA: 0x0002509C File Offset: 0x0002329C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600077D RID: 1917 RVA: 0x000250D8 File Offset: 0x000232D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600077E RID: 1918 RVA: 0x00025114 File Offset: 0x00023314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeRotation_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass56_0.NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600077F RID: 1919 RVA: 0x000048EC File Offset: 0x00002AEC
			public __c__DisplayClass56_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x06000780 RID: 1920 RVA: 0x00025154 File Offset: 0x00023354
			// (set) Token: 0x06000781 RID: 1921 RVA: 0x000048F5 File Offset: 0x00002AF5
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass56_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass56_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005A3 RID: 1443
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005A4 RID: 1444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005A5 RID: 1445
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__0_Internal_Vector3_0;

			// Token: 0x040005A6 RID: 1446
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A1 RID: 161
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000782 RID: 1922 RVA: 0x00025184 File Offset: 0x00023384
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass57_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr, 100663733);
				ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr, 100663734);
				ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr, 100663735);
			}

			// Token: 0x06000783 RID: 1923 RVA: 0x00025200 File Offset: 0x00023400
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x0002523C File Offset: 0x0002343C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000785 RID: 1925 RVA: 0x00025278 File Offset: 0x00023478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass57_0.NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x00004914 File Offset: 0x00002B14
			public __c__DisplayClass57_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x06000787 RID: 1927 RVA: 0x000252B8 File Offset: 0x000234B8
			// (set) Token: 0x06000788 RID: 1928 RVA: 0x0000491D File Offset: 0x00002B1D
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass57_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass57_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005A7 RID: 1447
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005A8 RID: 1448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005A9 RID: 1449
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0;

			// Token: 0x040005AA RID: 1450
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A2 RID: 162
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000789 RID: 1929 RVA: 0x000252E8 File Offset: 0x000234E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass58_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr, 100663736);
				ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr, 100663737);
				ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr, 100663738);
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x00025364 File Offset: 0x00023564
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600078B RID: 1931 RVA: 0x000253A0 File Offset: 0x000235A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600078C RID: 1932 RVA: 0x000253DC File Offset: 0x000235DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeScale_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass58_0.NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600078D RID: 1933 RVA: 0x0000493C File Offset: 0x00002B3C
			public __c__DisplayClass58_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x0600078E RID: 1934 RVA: 0x0002541C File Offset: 0x0002361C
			// (set) Token: 0x0600078F RID: 1935 RVA: 0x00004945 File Offset: 0x00002B45
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass58_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass58_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005AB RID: 1451
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005AC RID: 1452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005AD RID: 1453
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeScale_b__0_Internal_Vector3_0;

			// Token: 0x040005AE RID: 1454
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeScale_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A3 RID: 163
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000790 RID: 1936 RVA: 0x0002544C File Offset: 0x0002364C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_startPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, "startPosY");
				ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_offsetYSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, "offsetYSet");
				ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, "offsetY");
				ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, "s");
				ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, "endValue");
				ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_yTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, "yTween");
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663739);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663740);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663741);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663742);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663743);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__4_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663744);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663745);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__6_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663746);
				ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr, 100663747);
			}

			// Token: 0x06000791 RID: 1937 RVA: 0x000255B8 File Offset: 0x000237B8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000792 RID: 1938 RVA: 0x000255F4 File Offset: 0x000237F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000793 RID: 1939 RVA: 0x00025630 File Offset: 0x00023830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000794 RID: 1940 RVA: 0x00025670 File Offset: 0x00023870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119693, XrefRangeEnd = 119695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000795 RID: 1941 RVA: 0x000256A4 File Offset: 0x000238A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000796 RID: 1942 RVA: 0x000256E0 File Offset: 0x000238E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__4(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__4_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000797 RID: 1943 RVA: 0x00025720 File Offset: 0x00023920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000798 RID: 1944 RVA: 0x0002575C File Offset: 0x0002395C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__6(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__6_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000799 RID: 1945 RVA: 0x0002579C File Offset: 0x0002399C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119695, XrefRangeEnd = 119701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass59_0.NativeMethodInfoPtr__DOJump_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600079A RID: 1946 RVA: 0x00004964 File Offset: 0x00002B64
			public __c__DisplayClass59_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x0600079B RID: 1947 RVA: 0x000257D0 File Offset: 0x000239D0
			// (set) Token: 0x0600079C RID: 1948 RVA: 0x0000496D File Offset: 0x00002B6D
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x0600079D RID: 1949 RVA: 0x00025800 File Offset: 0x00023A00
			// (set) Token: 0x0600079E RID: 1950 RVA: 0x0000498C File Offset: 0x00002B8C
			public unsafe float startPosY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_startPosY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_startPosY)) = value;
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x0600079F RID: 1951 RVA: 0x00025828 File Offset: 0x00023A28
			// (set) Token: 0x060007A0 RID: 1952 RVA: 0x000049A7 File Offset: 0x00002BA7
			public unsafe bool offsetYSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_offsetYSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_offsetYSet)) = value;
				}
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00025850 File Offset: 0x00023A50
			// (set) Token: 0x060007A2 RID: 1954 RVA: 0x000049C2 File Offset: 0x00002BC2
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00025878 File Offset: 0x00023A78
			// (set) Token: 0x060007A4 RID: 1956 RVA: 0x000049DD File Offset: 0x00002BDD
			public unsafe Sequence s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_s);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_s), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000258A8 File Offset: 0x00023AA8
			// (set) Token: 0x060007A6 RID: 1958 RVA: 0x000049FC File Offset: 0x00002BFC
			public unsafe Vector3 endValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_endValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_endValue)) = value;
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060007A7 RID: 1959 RVA: 0x000258D0 File Offset: 0x00023AD0
			// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00004A17 File Offset: 0x00002C17
			public unsafe Tween yTween
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_yTween);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass59_0.NativeFieldInfoPtr_yTween), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005AF RID: 1455
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005B0 RID: 1456
			private static readonly IntPtr NativeFieldInfoPtr_startPosY;

			// Token: 0x040005B1 RID: 1457
			private static readonly IntPtr NativeFieldInfoPtr_offsetYSet;

			// Token: 0x040005B2 RID: 1458
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x040005B3 RID: 1459
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x040005B4 RID: 1460
			private static readonly IntPtr NativeFieldInfoPtr_endValue;

			// Token: 0x040005B5 RID: 1461
			private static readonly IntPtr NativeFieldInfoPtr_yTween;

			// Token: 0x040005B6 RID: 1462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005B7 RID: 1463
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0;

			// Token: 0x040005B8 RID: 1464
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__1_Internal_Void_Vector3_0;

			// Token: 0x040005B9 RID: 1465
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__2_Internal_Void_0;

			// Token: 0x040005BA RID: 1466
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__3_Internal_Vector3_0;

			// Token: 0x040005BB RID: 1467
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__4_Internal_Void_Vector3_0;

			// Token: 0x040005BC RID: 1468
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__5_Internal_Vector3_0;

			// Token: 0x040005BD RID: 1469
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__6_Internal_Void_Vector3_0;

			// Token: 0x040005BE RID: 1470
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__7_Internal_Void_0;
		}

		// Token: 0x020000A4 RID: 164
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007A9 RID: 1961 RVA: 0x00025900 File Offset: 0x00023B00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_offsetYSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, "offsetYSet");
				ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, "offsetY");
				ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, "s");
				ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, "endValue");
				ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_startPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, "startPosY");
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663748);
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663749);
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663750);
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__2_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663751);
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__3_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663752);
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__4_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663753);
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__5_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663754);
				ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr, 100663755);
			}

			// Token: 0x060007AA RID: 1962 RVA: 0x00025A44 File Offset: 0x00023C44
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007AB RID: 1963 RVA: 0x00025A80 File Offset: 0x00023C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalJump_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007AC RID: 1964 RVA: 0x00025ABC File Offset: 0x00023CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalJump_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007AD RID: 1965 RVA: 0x00025AFC File Offset: 0x00023CFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalJump_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__2_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007AE RID: 1966 RVA: 0x00025B38 File Offset: 0x00023D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalJump_b__3(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__3_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007AF RID: 1967 RVA: 0x00025B78 File Offset: 0x00023D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalJump_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__4_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007B0 RID: 1968 RVA: 0x00025BB4 File Offset: 0x00023DB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalJump_b__5(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__5_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007B1 RID: 1969 RVA: 0x00025BF4 File Offset: 0x00023DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119701, XrefRangeEnd = 119707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalJump_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass60_0.NativeMethodInfoPtr__DOLocalJump_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007B2 RID: 1970 RVA: 0x00004A36 File Offset: 0x00002C36
			public __c__DisplayClass60_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00025C28 File Offset: 0x00023E28
			// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00004A3F File Offset: 0x00002C3F
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00025C58 File Offset: 0x00023E58
			// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00004A5E File Offset: 0x00002C5E
			public unsafe bool offsetYSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_offsetYSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_offsetYSet)) = value;
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00025C80 File Offset: 0x00023E80
			// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00004A79 File Offset: 0x00002C79
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00025CA8 File Offset: 0x00023EA8
			// (set) Token: 0x060007BA RID: 1978 RVA: 0x00004A94 File Offset: 0x00002C94
			public unsafe Sequence s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_s);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_s), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x060007BB RID: 1979 RVA: 0x00025CD8 File Offset: 0x00023ED8
			// (set) Token: 0x060007BC RID: 1980 RVA: 0x00004AB3 File Offset: 0x00002CB3
			public unsafe Vector3 endValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_endValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_endValue)) = value;
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x060007BD RID: 1981 RVA: 0x00025D00 File Offset: 0x00023F00
			// (set) Token: 0x060007BE RID: 1982 RVA: 0x00004ACE File Offset: 0x00002CCE
			public unsafe float startPosY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_startPosY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass60_0.NativeFieldInfoPtr_startPosY)) = value;
				}
			}

			// Token: 0x040005BF RID: 1471
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005C0 RID: 1472
			private static readonly IntPtr NativeFieldInfoPtr_offsetYSet;

			// Token: 0x040005C1 RID: 1473
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x040005C2 RID: 1474
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x040005C3 RID: 1475
			private static readonly IntPtr NativeFieldInfoPtr_endValue;

			// Token: 0x040005C4 RID: 1476
			private static readonly IntPtr NativeFieldInfoPtr_startPosY;

			// Token: 0x040005C5 RID: 1477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005C6 RID: 1478
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__0_Internal_Vector3_0;

			// Token: 0x040005C7 RID: 1479
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__1_Internal_Void_Vector3_0;

			// Token: 0x040005C8 RID: 1480
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__2_Internal_Vector3_0;

			// Token: 0x040005C9 RID: 1481
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__3_Internal_Void_Vector3_0;

			// Token: 0x040005CA RID: 1482
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__4_Internal_Vector3_0;

			// Token: 0x040005CB RID: 1483
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__5_Internal_Void_Vector3_0;

			// Token: 0x040005CC RID: 1484
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalJump_b__6_Internal_Void_0;
		}

		// Token: 0x020000A5 RID: 165
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007BF RID: 1983 RVA: 0x00025D28 File Offset: 0x00023F28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass61_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr, 100663756);
				ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr, 100663757);
				ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr, 100663758);
			}

			// Token: 0x060007C0 RID: 1984 RVA: 0x00025DA4 File Offset: 0x00023FA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x00025DE0 File Offset: 0x00023FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x00025E1C File Offset: 0x0002401C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass61_0.NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x00004AE9 File Offset: 0x00002CE9
			public __c__DisplayClass61_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00025E5C File Offset: 0x0002405C
			// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00004AF2 File Offset: 0x00002CF2
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass61_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass61_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005CD RID: 1485
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005CE RID: 1486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005CF RID: 1487
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0;

			// Token: 0x040005D0 RID: 1488
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A6 RID: 166
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007C6 RID: 1990 RVA: 0x00025E8C File Offset: 0x0002408C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass62_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr, 100663759);
				ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr, 100663760);
				ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr, 100663761);
			}

			// Token: 0x060007C7 RID: 1991 RVA: 0x00025F08 File Offset: 0x00024108
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007C8 RID: 1992 RVA: 0x00025F44 File Offset: 0x00024144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x00025F80 File Offset: 0x00024180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass62_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x00004B11 File Offset: 0x00002D11
			public __c__DisplayClass62_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x060007CB RID: 1995 RVA: 0x00025FC0 File Offset: 0x000241C0
			// (set) Token: 0x060007CC RID: 1996 RVA: 0x00004B1A File Offset: 0x00002D1A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass62_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass62_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005D1 RID: 1489
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005D2 RID: 1490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005D3 RID: 1491
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0;

			// Token: 0x040005D4 RID: 1492
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A7 RID: 167
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007CD RID: 1997 RVA: 0x00025FF0 File Offset: 0x000241F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass63_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr, 100663762);
				ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr, 100663763);
				ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr, 100663764);
			}

			// Token: 0x060007CE RID: 1998 RVA: 0x0002606C File Offset: 0x0002426C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007CF RID: 1999 RVA: 0x000260A8 File Offset: 0x000242A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007D0 RID: 2000 RVA: 0x000260E4 File Offset: 0x000242E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass63_0.NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007D1 RID: 2001 RVA: 0x00004B39 File Offset: 0x00002D39
			public __c__DisplayClass63_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00026124 File Offset: 0x00024324
			// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00004B42 File Offset: 0x00002D42
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass63_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass63_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005D5 RID: 1493
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005D6 RID: 1494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005D7 RID: 1495
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0;

			// Token: 0x040005D8 RID: 1496
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A8 RID: 168
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007D4 RID: 2004 RVA: 0x00026154 File Offset: 0x00024354
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass64_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr, 100663765);
				ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr, 100663766);
				ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr, 100663767);
			}

			// Token: 0x060007D5 RID: 2005 RVA: 0x000261D0 File Offset: 0x000243D0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007D6 RID: 2006 RVA: 0x0002620C File Offset: 0x0002440C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007D7 RID: 2007 RVA: 0x00026248 File Offset: 0x00024448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass64_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007D8 RID: 2008 RVA: 0x00004B61 File Offset: 0x00002D61
			public __c__DisplayClass64_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00026288 File Offset: 0x00024488
			// (set) Token: 0x060007DA RID: 2010 RVA: 0x00004B6A File Offset: 0x00002D6A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass64_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass64_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005D9 RID: 1497
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005DA RID: 1498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005DB RID: 1499
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0;

			// Token: 0x040005DC RID: 1500
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000A9 RID: 169
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007DB RID: 2011 RVA: 0x000262B8 File Offset: 0x000244B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass65_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr, 100663768);
				ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__DOTimeScale_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr, 100663769);
				ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__DOTimeScale_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr, 100663770);
			}

			// Token: 0x060007DC RID: 2012 RVA: 0x00026334 File Offset: 0x00024534
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007DD RID: 2013 RVA: 0x00026370 File Offset: 0x00024570
			[CallerCount(0)]
			public unsafe float _DOTimeScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__DOTimeScale_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007DE RID: 2014 RVA: 0x000263AC File Offset: 0x000245AC
			[CallerCount(0)]
			public unsafe void _DOTimeScale_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass65_0.NativeMethodInfoPtr__DOTimeScale_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007DF RID: 2015 RVA: 0x00004B89 File Offset: 0x00002D89
			public __c__DisplayClass65_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x060007E0 RID: 2016 RVA: 0x000263EC File Offset: 0x000245EC
			// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00004B92 File Offset: 0x00002D92
			public unsafe Tween target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass65_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass65_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005DD RID: 1501
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005DE RID: 1502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005DF RID: 1503
			private static readonly IntPtr NativeMethodInfoPtr__DOTimeScale_b__0_Internal_Single_0;

			// Token: 0x040005E0 RID: 1504
			private static readonly IntPtr NativeMethodInfoPtr__DOTimeScale_b__1_Internal_Void_Single_0;
		}

		// Token: 0x020000AA RID: 170
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007E2 RID: 2018 RVA: 0x0002641C File Offset: 0x0002461C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass66_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass66_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr, 100663771);
				ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr, 100663772);
				ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr, 100663773);
			}

			// Token: 0x060007E3 RID: 2019 RVA: 0x000264AC File Offset: 0x000246AC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007E4 RID: 2020 RVA: 0x000264E8 File Offset: 0x000246E8
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007E5 RID: 2021 RVA: 0x00026524 File Offset: 0x00024724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119707, XrefRangeEnd = 119711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass66_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007E6 RID: 2022 RVA: 0x00004BB1 File Offset: 0x00002DB1
			public __c__DisplayClass66_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00026564 File Offset: 0x00024764
			// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00004BBA File Offset: 0x00002DBA
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass66_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass66_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0002658C File Offset: 0x0002478C
			// (set) Token: 0x060007EA RID: 2026 RVA: 0x00004BD5 File Offset: 0x00002DD5
			public unsafe Light target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass66_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass66_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005E1 RID: 1505
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005E2 RID: 1506
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005E3 RID: 1507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005E4 RID: 1508
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x040005E5 RID: 1509
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020000AB RID: 171
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007EB RID: 2027 RVA: 0x000265BC File Offset: 0x000247BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass67_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass67_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr, 100663774);
				ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr, 100663775);
				ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr, 100663776);
			}

			// Token: 0x060007EC RID: 2028 RVA: 0x0002664C File Offset: 0x0002484C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007ED RID: 2029 RVA: 0x00026688 File Offset: 0x00024888
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007EE RID: 2030 RVA: 0x000266C4 File Offset: 0x000248C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119711, XrefRangeEnd = 119713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass67_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007EF RID: 2031 RVA: 0x00004BF4 File Offset: 0x00002DF4
			public __c__DisplayClass67_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00026704 File Offset: 0x00024904
			// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00004BFD File Offset: 0x00002DFD
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass67_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass67_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0002672C File Offset: 0x0002492C
			// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00004C18 File Offset: 0x00002E18
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass67_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass67_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005E6 RID: 1510
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005E7 RID: 1511
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005E8 RID: 1512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005E9 RID: 1513
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x040005EA RID: 1514
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020000AC RID: 172
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007F4 RID: 2036 RVA: 0x0002675C File Offset: 0x0002495C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, "property");
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663777);
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663778);
				ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr, 100663779);
			}

			// Token: 0x060007F5 RID: 2037 RVA: 0x00026800 File Offset: 0x00024A00
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass68_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007F6 RID: 2038 RVA: 0x0002683C File Offset: 0x00024A3C
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007F7 RID: 2039 RVA: 0x00026878 File Offset: 0x00024A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119713, XrefRangeEnd = 119715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass68_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007F8 RID: 2040 RVA: 0x00004C37 File Offset: 0x00002E37
			public __c__DisplayClass68_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x060007F9 RID: 2041 RVA: 0x000268B8 File Offset: 0x00024AB8
			// (set) Token: 0x060007FA RID: 2042 RVA: 0x00004C40 File Offset: 0x00002E40
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x060007FB RID: 2043 RVA: 0x000268E0 File Offset: 0x00024AE0
			// (set) Token: 0x060007FC RID: 2044 RVA: 0x00004C5B File Offset: 0x00002E5B
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x060007FD RID: 2045 RVA: 0x00026910 File Offset: 0x00024B10
			// (set) Token: 0x060007FE RID: 2046 RVA: 0x00004C7A File Offset: 0x00002E7A
			public unsafe string property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_property);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass68_0.NativeFieldInfoPtr_property), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040005EB RID: 1515
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005EC RID: 1516
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005ED RID: 1517
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040005EE RID: 1518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005EF RID: 1519
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x040005F0 RID: 1520
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020000AD RID: 173
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass69_0")]
		public sealed class __c__DisplayClass69_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060007FF RID: 2047 RVA: 0x00026938 File Offset: 0x00024B38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass69_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass69_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_propertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, "propertyID");
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663780);
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663781);
				ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr, 100663782);
			}

			// Token: 0x06000800 RID: 2048 RVA: 0x000269DC File Offset: 0x00024BDC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass69_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass69_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000801 RID: 2049 RVA: 0x00026A18 File Offset: 0x00024C18
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000802 RID: 2050 RVA: 0x00026A54 File Offset: 0x00024C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119715, XrefRangeEnd = 119719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass69_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000803 RID: 2051 RVA: 0x00004C99 File Offset: 0x00002E99
			public __c__DisplayClass69_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06000804 RID: 2052 RVA: 0x00026A94 File Offset: 0x00024C94
			// (set) Token: 0x06000805 RID: 2053 RVA: 0x00004CA2 File Offset: 0x00002EA2
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000806 RID: 2054 RVA: 0x00026ABC File Offset: 0x00024CBC
			// (set) Token: 0x06000807 RID: 2055 RVA: 0x00004CBD File Offset: 0x00002EBD
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06000808 RID: 2056 RVA: 0x00026AEC File Offset: 0x00024CEC
			// (set) Token: 0x06000809 RID: 2057 RVA: 0x00004CDC File Offset: 0x00002EDC
			public unsafe int propertyID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_propertyID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass69_0.NativeFieldInfoPtr_propertyID)) = value;
				}
			}

			// Token: 0x040005F1 RID: 1521
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005F2 RID: 1522
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005F3 RID: 1523
			private static readonly IntPtr NativeFieldInfoPtr_propertyID;

			// Token: 0x040005F4 RID: 1524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005F5 RID: 1525
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x040005F6 RID: 1526
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020000AE RID: 174
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600080A RID: 2058 RVA: 0x00026B14 File Offset: 0x00024D14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass70_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass70_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr, 100663783);
				ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__DOBlendableMoveBy_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr, 100663784);
				ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__DOBlendableMoveBy_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr, 100663785);
			}

			// Token: 0x0600080B RID: 2059 RVA: 0x00026BA4 File Offset: 0x00024DA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600080C RID: 2060 RVA: 0x00026BE0 File Offset: 0x00024DE0
			[CallerCount(0)]
			public unsafe Vector3 _DOBlendableMoveBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__DOBlendableMoveBy_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600080D RID: 2061 RVA: 0x00026C1C File Offset: 0x00024E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119719, XrefRangeEnd = 119723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableMoveBy_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass70_0.NativeMethodInfoPtr__DOBlendableMoveBy_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600080E RID: 2062 RVA: 0x00004CF7 File Offset: 0x00002EF7
			public __c__DisplayClass70_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x0600080F RID: 2063 RVA: 0x00026C5C File Offset: 0x00024E5C
			// (set) Token: 0x06000810 RID: 2064 RVA: 0x00004D00 File Offset: 0x00002F00
			public unsafe Vector3 to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass70_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass70_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000811 RID: 2065 RVA: 0x00026C84 File Offset: 0x00024E84
			// (set) Token: 0x06000812 RID: 2066 RVA: 0x00004D1B File Offset: 0x00002F1B
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass70_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass70_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005F7 RID: 1527
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005F8 RID: 1528
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005F9 RID: 1529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005FA RID: 1530
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableMoveBy_b__0_Internal_Vector3_0;

			// Token: 0x040005FB RID: 1531
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableMoveBy_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000AF RID: 175
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass71_0")]
		public sealed class __c__DisplayClass71_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000813 RID: 2067 RVA: 0x00026CB4 File Offset: 0x00024EB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass71_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass71_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass71_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass71_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr, 100663786);
				ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr, 100663787);
				ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr, 100663788);
			}

			// Token: 0x06000814 RID: 2068 RVA: 0x00026D44 File Offset: 0x00024F44
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass71_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass71_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000815 RID: 2069 RVA: 0x00026D80 File Offset: 0x00024F80
			[CallerCount(0)]
			public unsafe Vector3 _DOBlendableLocalMoveBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000816 RID: 2070 RVA: 0x00026DBC File Offset: 0x00024FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119723, XrefRangeEnd = 119727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableLocalMoveBy_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass71_0.NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000817 RID: 2071 RVA: 0x00004D3A File Offset: 0x00002F3A
			public __c__DisplayClass71_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x06000818 RID: 2072 RVA: 0x00026DFC File Offset: 0x00024FFC
			// (set) Token: 0x06000819 RID: 2073 RVA: 0x00004D43 File Offset: 0x00002F43
			public unsafe Vector3 to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass71_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass71_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x0600081A RID: 2074 RVA: 0x00026E24 File Offset: 0x00025024
			// (set) Token: 0x0600081B RID: 2075 RVA: 0x00004D5E File Offset: 0x00002F5E
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass71_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass71_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005FC RID: 1532
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040005FD RID: 1533
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040005FE RID: 1534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005FF RID: 1535
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__0_Internal_Vector3_0;

			// Token: 0x04000600 RID: 1536
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableLocalMoveBy_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000B0 RID: 176
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass72_0")]
		public sealed class __c__DisplayClass72_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600081C RID: 2076 RVA: 0x00026E54 File Offset: 0x00025054
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass72_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass72_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass72_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr, 100663789);
				ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__DOBlendableRotateBy_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr, 100663790);
				ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__DOBlendableRotateBy_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr, 100663791);
			}

			// Token: 0x0600081D RID: 2077 RVA: 0x00026EE4 File Offset: 0x000250E4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass72_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600081E RID: 2078 RVA: 0x00026F20 File Offset: 0x00025120
			[CallerCount(0)]
			public unsafe Quaternion _DOBlendableRotateBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__DOBlendableRotateBy_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600081F RID: 2079 RVA: 0x00026F5C File Offset: 0x0002515C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119727, XrefRangeEnd = 119743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableRotateBy_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass72_0.NativeMethodInfoPtr__DOBlendableRotateBy_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000820 RID: 2080 RVA: 0x00004D7D File Offset: 0x00002F7D
			public __c__DisplayClass72_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x06000821 RID: 2081 RVA: 0x00026F9C File Offset: 0x0002519C
			// (set) Token: 0x06000822 RID: 2082 RVA: 0x00004D86 File Offset: 0x00002F86
			public unsafe Quaternion to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass72_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass72_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000823 RID: 2083 RVA: 0x00026FC4 File Offset: 0x000251C4
			// (set) Token: 0x06000824 RID: 2084 RVA: 0x00004DA1 File Offset: 0x00002FA1
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass72_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass72_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000601 RID: 1537
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x04000602 RID: 1538
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000603 RID: 1539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000604 RID: 1540
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableRotateBy_b__0_Internal_Quaternion_0;

			// Token: 0x04000605 RID: 1541
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableRotateBy_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x020000B1 RID: 177
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass73_0")]
		public sealed class __c__DisplayClass73_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000825 RID: 2085 RVA: 0x00026FF4 File Offset: 0x000251F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass73_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass73_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass73_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass73_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr, 100663792);
				ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr, 100663793);
				ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__1_Internal_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr, 100663794);
			}

			// Token: 0x06000826 RID: 2086 RVA: 0x00027084 File Offset: 0x00025284
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass73_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass73_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000827 RID: 2087 RVA: 0x000270C0 File Offset: 0x000252C0
			[CallerCount(0)]
			public unsafe Quaternion _DOBlendableLocalRotateBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000828 RID: 2088 RVA: 0x000270FC File Offset: 0x000252FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119743, XrefRangeEnd = 119759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableLocalRotateBy_b__1(Quaternion x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass73_0.NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__1_Internal_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000829 RID: 2089 RVA: 0x00004DC0 File Offset: 0x00002FC0
			public __c__DisplayClass73_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x0600082A RID: 2090 RVA: 0x0002713C File Offset: 0x0002533C
			// (set) Token: 0x0600082B RID: 2091 RVA: 0x00004DC9 File Offset: 0x00002FC9
			public unsafe Quaternion to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass73_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass73_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x0600082C RID: 2092 RVA: 0x00027164 File Offset: 0x00025364
			// (set) Token: 0x0600082D RID: 2093 RVA: 0x00004DE4 File Offset: 0x00002FE4
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass73_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass73_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000606 RID: 1542
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x04000607 RID: 1543
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000608 RID: 1544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000609 RID: 1545
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__0_Internal_Quaternion_0;

			// Token: 0x0400060A RID: 1546
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableLocalRotateBy_b__1_Internal_Void_Quaternion_0;
		}

		// Token: 0x020000B2 RID: 178
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass74_0")]
		public sealed class __c__DisplayClass74_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600082E RID: 2094 RVA: 0x00027194 File Offset: 0x00025394
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass74_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass74_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass74_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr, 100663795);
				ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__DOBlendablePunchRotation_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr, 100663796);
				ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__DOBlendablePunchRotation_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr, 100663797);
			}

			// Token: 0x0600082F RID: 2095 RVA: 0x00027224 File Offset: 0x00025424
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass74_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000830 RID: 2096 RVA: 0x00027260 File Offset: 0x00025460
			[CallerCount(0)]
			public unsafe Vector3 _DOBlendablePunchRotation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__DOBlendablePunchRotation_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000831 RID: 2097 RVA: 0x0002729C File Offset: 0x0002549C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119759, XrefRangeEnd = 119779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendablePunchRotation_b__1(Vector3 v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass74_0.NativeMethodInfoPtr__DOBlendablePunchRotation_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000832 RID: 2098 RVA: 0x00004E03 File Offset: 0x00003003
			public __c__DisplayClass74_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x06000833 RID: 2099 RVA: 0x000272DC File Offset: 0x000254DC
			// (set) Token: 0x06000834 RID: 2100 RVA: 0x00004E0C File Offset: 0x0000300C
			public unsafe Vector3 to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass74_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass74_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x06000835 RID: 2101 RVA: 0x00027304 File Offset: 0x00025504
			// (set) Token: 0x06000836 RID: 2102 RVA: 0x00004E27 File Offset: 0x00003027
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass74_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass74_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400060B RID: 1547
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x0400060C RID: 1548
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400060D RID: 1549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400060E RID: 1550
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendablePunchRotation_b__0_Internal_Vector3_0;

			// Token: 0x0400060F RID: 1551
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendablePunchRotation_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020000B3 RID: 179
		[ObfuscatedName("DG.Tweening.ShortcutExtensions+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000837 RID: 2103 RVA: 0x00027334 File Offset: 0x00025534
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutExtensions>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr);
				ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, "to");
				ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, "target");
				ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, 100663798);
				ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__DOBlendableScaleBy_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, 100663799);
				ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__DOBlendableScaleBy_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr, 100663800);
			}

			// Token: 0x06000838 RID: 2104 RVA: 0x000273C4 File Offset: 0x000255C4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutExtensions.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000839 RID: 2105 RVA: 0x00027400 File Offset: 0x00025600
			[CallerCount(0)]
			public unsafe Vector3 _DOBlendableScaleBy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__DOBlendableScaleBy_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600083A RID: 2106 RVA: 0x0002743C File Offset: 0x0002563C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119779, XrefRangeEnd = 119783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableScaleBy_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortcutExtensions.__c__DisplayClass75_0.NativeMethodInfoPtr__DOBlendableScaleBy_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600083B RID: 2107 RVA: 0x00004E46 File Offset: 0x00003046
			public __c__DisplayClass75_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x0600083C RID: 2108 RVA: 0x0002747C File Offset: 0x0002567C
			// (set) Token: 0x0600083D RID: 2109 RVA: 0x00004E4F File Offset: 0x0000304F
			public unsafe Vector3 to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x0600083E RID: 2110 RVA: 0x000274A4 File Offset: 0x000256A4
			// (set) Token: 0x0600083F RID: 2111 RVA: 0x00004E6A File Offset: 0x0000306A
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortcutExtensions.__c__DisplayClass75_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000610 RID: 1552
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x04000611 RID: 1553
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000612 RID: 1554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000613 RID: 1555
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableScaleBy_b__0_Internal_Vector3_0;

			// Token: 0x04000614 RID: 1556
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableScaleBy_b__1_Internal_Void_Vector3_0;
		}
	}
}
