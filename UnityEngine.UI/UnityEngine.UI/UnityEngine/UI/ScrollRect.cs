using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000032 RID: 50
	public class ScrollRect : UIBehaviour
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x0001C384 File Offset: 0x0001A584
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollRect()
		{
			Il2CppClassPointerStore<ScrollRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ScrollRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr);
			ScrollRect.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Content");
			ScrollRect.NativeFieldInfoPtr_m_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Horizontal");
			ScrollRect.NativeFieldInfoPtr_m_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Vertical");
			ScrollRect.NativeFieldInfoPtr_m_MovementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_MovementType");
			ScrollRect.NativeFieldInfoPtr_m_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Elasticity");
			ScrollRect.NativeFieldInfoPtr_m_Inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Inertia");
			ScrollRect.NativeFieldInfoPtr_m_DecelerationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_DecelerationRate");
			ScrollRect.NativeFieldInfoPtr_m_ScrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ScrollSensitivity");
			ScrollRect.NativeFieldInfoPtr_m_Viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Viewport");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbar");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbar");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbarVisibility");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbarVisibility");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbarSpacing");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbarSpacing");
			ScrollRect.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_OnValueChanged");
			ScrollRect.NativeFieldInfoPtr_m_PointerStartLocalCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PointerStartLocalCursor");
			ScrollRect.NativeFieldInfoPtr_m_ContentStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ContentStartPosition");
			ScrollRect.NativeFieldInfoPtr_m_ViewRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ViewRect");
			ScrollRect.NativeFieldInfoPtr_m_ContentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ContentBounds");
			ScrollRect.NativeFieldInfoPtr_m_ViewBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ViewBounds");
			ScrollRect.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Velocity");
			ScrollRect.NativeFieldInfoPtr_m_Dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Dragging");
			ScrollRect.NativeFieldInfoPtr_m_Scrolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Scrolling");
			ScrollRect.NativeFieldInfoPtr_m_PrevPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PrevPosition");
			ScrollRect.NativeFieldInfoPtr_m_PrevContentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PrevContentBounds");
			ScrollRect.NativeFieldInfoPtr_m_PrevViewBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PrevViewBounds");
			ScrollRect.NativeFieldInfoPtr_m_HasRebuiltLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HasRebuiltLayout");
			ScrollRect.NativeFieldInfoPtr_m_HSliderExpand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HSliderExpand");
			ScrollRect.NativeFieldInfoPtr_m_VSliderExpand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VSliderExpand");
			ScrollRect.NativeFieldInfoPtr_m_HSliderHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HSliderHeight");
			ScrollRect.NativeFieldInfoPtr_m_VSliderWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VSliderWidth");
			ScrollRect.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Rect");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbarRect");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbarRect");
			ScrollRect.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Tracker");
			ScrollRect.NativeFieldInfoPtr_m_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Corners");
			ScrollRect.NativeMethodInfoPtr_get_content_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664196);
			ScrollRect.NativeMethodInfoPtr_set_content_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664197);
			ScrollRect.NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664198);
			ScrollRect.NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664199);
			ScrollRect.NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664200);
			ScrollRect.NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664201);
			ScrollRect.NativeMethodInfoPtr_get_movementType_Public_get_MovementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664202);
			ScrollRect.NativeMethodInfoPtr_set_movementType_Public_set_Void_MovementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664203);
			ScrollRect.NativeMethodInfoPtr_get_elasticity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664204);
			ScrollRect.NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664205);
			ScrollRect.NativeMethodInfoPtr_get_inertia_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664206);
			ScrollRect.NativeMethodInfoPtr_set_inertia_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664207);
			ScrollRect.NativeMethodInfoPtr_get_decelerationRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664208);
			ScrollRect.NativeMethodInfoPtr_set_decelerationRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664209);
			ScrollRect.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664210);
			ScrollRect.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664211);
			ScrollRect.NativeMethodInfoPtr_get_viewport_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664212);
			ScrollRect.NativeMethodInfoPtr_set_viewport_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664213);
			ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664214);
			ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664215);
			ScrollRect.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664216);
			ScrollRect.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664217);
			ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarVisibility_Public_get_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664218);
			ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664219);
			ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarVisibility_Public_get_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664220);
			ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664221);
			ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664222);
			ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664223);
			ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664224);
			ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664225);
			ScrollRect.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollRectEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664226);
			ScrollRect.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollRectEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664227);
			ScrollRect.NativeMethodInfoPtr_get_viewRect_Protected_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664228);
			ScrollRect.NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664229);
			ScrollRect.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664230);
			ScrollRect.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664231);
			ScrollRect.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664232);
			ScrollRect.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664233);
			ScrollRect.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664234);
			ScrollRect.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664235);
			ScrollRect.NativeMethodInfoPtr_UpdateCachedData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664236);
			ScrollRect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664237);
			ScrollRect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664238);
			ScrollRect.NativeMethodInfoPtr_IsActive_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664239);
			ScrollRect.NativeMethodInfoPtr_EnsureLayoutHasRebuilt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664240);
			ScrollRect.NativeMethodInfoPtr_StopMovement_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664241);
			ScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664242);
			ScrollRect.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664243);
			ScrollRect.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664244);
			ScrollRect.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664245);
			ScrollRect.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664246);
			ScrollRect.NativeMethodInfoPtr_SetContentAnchoredPosition_Protected_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664247);
			ScrollRect.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664248);
			ScrollRect.NativeMethodInfoPtr_UpdatePrevData_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664249);
			ScrollRect.NativeMethodInfoPtr_UpdateScrollbars_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664250);
			ScrollRect.NativeMethodInfoPtr_get_normalizedPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664251);
			ScrollRect.NativeMethodInfoPtr_set_normalizedPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664252);
			ScrollRect.NativeMethodInfoPtr_get_horizontalNormalizedPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664253);
			ScrollRect.NativeMethodInfoPtr_set_horizontalNormalizedPosition_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664254);
			ScrollRect.NativeMethodInfoPtr_get_verticalNormalizedPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664255);
			ScrollRect.NativeMethodInfoPtr_set_verticalNormalizedPosition_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664256);
			ScrollRect.NativeMethodInfoPtr_SetHorizontalNormalizedPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664257);
			ScrollRect.NativeMethodInfoPtr_SetVerticalNormalizedPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664258);
			ScrollRect.NativeMethodInfoPtr_SetNormalizedPosition_Protected_Virtual_New_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664259);
			ScrollRect.NativeMethodInfoPtr_RubberDelta_Private_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664260);
			ScrollRect.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664261);
			ScrollRect.NativeMethodInfoPtr_get_hScrollingNeeded_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664262);
			ScrollRect.NativeMethodInfoPtr_get_vScrollingNeeded_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664263);
			ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664264);
			ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664265);
			ScrollRect.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664266);
			ScrollRect.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664267);
			ScrollRect.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664268);
			ScrollRect.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664269);
			ScrollRect.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664270);
			ScrollRect.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664271);
			ScrollRect.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664272);
			ScrollRect.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664273);
			ScrollRect.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664274);
			ScrollRect.NativeMethodInfoPtr_UpdateScrollbarVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664275);
			ScrollRect.NativeMethodInfoPtr_UpdateOneScrollbarVisibility_Private_Static_Void_Boolean_Boolean_ScrollbarVisibility_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664276);
			ScrollRect.NativeMethodInfoPtr_UpdateScrollbarLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664277);
			ScrollRect.NativeMethodInfoPtr_UpdateBounds_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664278);
			ScrollRect.NativeMethodInfoPtr_AdjustBounds_Internal_Static_Void_byref_Bounds_byref_Vector2_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664279);
			ScrollRect.NativeMethodInfoPtr_GetBounds_Private_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664280);
			ScrollRect.NativeMethodInfoPtr_InternalGetBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664281);
			ScrollRect.NativeMethodInfoPtr_CalculateOffset_Private_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664282);
			ScrollRect.NativeMethodInfoPtr_InternalCalculateOffset_Internal_Static_Vector2_byref_Bounds_byref_Bounds_Boolean_Boolean_MovementType_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664283);
			ScrollRect.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664284);
			ScrollRect.NativeMethodInfoPtr_SetDirtyCaching_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664285);
			ScrollRect.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664286);
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001CDB4 File Offset: 0x0001AFB4
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x0001CDF4 File Offset: 0x0001AFF4
		public unsafe RectTransform content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_content_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_content_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0001CE38 File Offset: 0x0001B038
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x0001CE74 File Offset: 0x0001B074
		public unsafe bool horizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
		public unsafe bool vertical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001CF30 File Offset: 0x0001B130
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x0001CF6C File Offset: 0x0001B16C
		public unsafe ScrollRect.MovementType movementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_movementType_Public_get_MovementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_movementType_Public_set_Void_MovementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0001CFAC File Offset: 0x0001B1AC
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0001CFE8 File Offset: 0x0001B1E8
		public unsafe float elasticity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_elasticity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0001D028 File Offset: 0x0001B228
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x0001D064 File Offset: 0x0001B264
		public unsafe bool inertia
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_inertia_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_inertia_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001D0A4 File Offset: 0x0001B2A4
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0001D0E0 File Offset: 0x0001B2E0
		public unsafe float decelerationRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_decelerationRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_decelerationRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0001D120 File Offset: 0x0001B320
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0001D15C File Offset: 0x0001B35C
		public unsafe float scrollSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001D19C File Offset: 0x0001B39C
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0001D1DC File Offset: 0x0001B3DC
		public unsafe RectTransform viewport
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_viewport_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526185, XrefRangeEnd = 526186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_viewport_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001D220 File Offset: 0x0001B420
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0001D260 File Offset: 0x0001B460
		public unsafe Scrollbar horizontalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 526208, RefRangeEnd = 526209, XrefRangeStart = 526186, XrefRangeEnd = 526208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		public unsafe Scrollbar verticalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 526231, RefRangeEnd = 526234, XrefRangeStart = 526209, XrefRangeEnd = 526231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001D328 File Offset: 0x0001B528
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0001D364 File Offset: 0x0001B564
		public unsafe ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarVisibility_Public_get_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526234, XrefRangeEnd = 526235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001D3A4 File Offset: 0x0001B5A4
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0001D3E0 File Offset: 0x0001B5E0
		public unsafe ScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarVisibility_Public_get_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526235, XrefRangeEnd = 526236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001D420 File Offset: 0x0001B620
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0001D45C File Offset: 0x0001B65C
		public unsafe float horizontalScrollbarSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526236, XrefRangeEnd = 526237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001D49C File Offset: 0x0001B69C
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		public unsafe float verticalScrollbarSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526237, XrefRangeEnd = 526238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001D518 File Offset: 0x0001B718
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x0001D558 File Offset: 0x0001B758
		public unsafe ScrollRect.ScrollRectEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollRectEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScrollRect.ScrollRectEvent>(intPtr3) : null;
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 214194, RefRangeEnd = 214233, XrefRangeStart = 214194, XrefRangeEnd = 214233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollRectEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0001D59C File Offset: 0x0001B79C
		public unsafe RectTransform viewRect
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 526267, RefRangeEnd = 526294, XrefRangeStart = 526238, XrefRangeEnd = 526267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_viewRect_Protected_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0001D5DC File Offset: 0x0001B7DC
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0001D618 File Offset: 0x0001B818
		public unsafe Vector2 velocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0001D658 File Offset: 0x0001B858
		public unsafe RectTransform rectTransform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 526309, RefRangeEnd = 526312, XrefRangeStart = 526294, XrefRangeEnd = 526309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001D698 File Offset: 0x0001B898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526312, XrefRangeEnd = 526329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollRect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001D6D4 File Offset: 0x0001B8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526329, XrefRangeEnd = 526335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001D720 File Offset: 0x0001B920
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001D75C File Offset: 0x0001B95C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001D798 File Offset: 0x0001B998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 526470, RefRangeEnd = 526472, XrefRangeStart = 526335, XrefRangeEnd = 526470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCachedData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateCachedData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001D7CC File Offset: 0x0001B9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526472, XrefRangeEnd = 526498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001D808 File Offset: 0x0001BA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526498, XrefRangeEnd = 526530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0001D844 File Offset: 0x0001BA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526530, XrefRangeEnd = 526544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_IsActive_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0001D88C File Offset: 0x0001BA8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 526554, RefRangeEnd = 526557, XrefRangeStart = 526544, XrefRangeEnd = 526554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLayoutHasRebuilt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_EnsureLayoutHasRebuilt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0001D8C0 File Offset: 0x0001BAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526557, XrefRangeEnd = 526559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_StopMovement_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001D8FC File Offset: 0x0001BAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526559, XrefRangeEnd = 526566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnScroll(PointerEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0001D94C File Offset: 0x0001BB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526566, XrefRangeEnd = 526568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0001D99C File Offset: 0x0001BB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526568, XrefRangeEnd = 526578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001D9EC File Offset: 0x0001BBEC
		[CallerCount(0)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001DA3C File Offset: 0x0001BC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526578, XrefRangeEnd = 526589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0001DA8C File Offset: 0x0001BC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526589, XrefRangeEnd = 526598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetContentAnchoredPosition(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetContentAnchoredPosition_Protected_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526598, XrefRangeEnd = 526655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0001DB14 File Offset: 0x0001BD14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 526671, RefRangeEnd = 526673, XrefRangeStart = 526655, XrefRangeEnd = 526671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrevData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdatePrevData_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0001DB48 File Offset: 0x0001BD48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 526689, RefRangeEnd = 526691, XrefRangeStart = 526673, XrefRangeEnd = 526689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbars(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateScrollbars_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001DB88 File Offset: 0x0001BD88
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0001DBC4 File Offset: 0x0001BDC4
		public unsafe Vector2 normalizedPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526691, XrefRangeEnd = 526693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_normalizedPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_normalizedPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001DC04 File Offset: 0x0001BE04
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x0001DC40 File Offset: 0x0001BE40
		public unsafe float horizontalNormalizedPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 526695, RefRangeEnd = 526700, XrefRangeStart = 526693, XrefRangeEnd = 526695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalNormalizedPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalNormalizedPosition_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001DC80 File Offset: 0x0001BE80
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x0001DCBC File Offset: 0x0001BEBC
		public unsafe float verticalNormalizedPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 526702, RefRangeEnd = 526707, XrefRangeStart = 526700, XrefRangeEnd = 526702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalNormalizedPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalNormalizedPosition_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0001DCFC File Offset: 0x0001BEFC
		[CallerCount(0)]
		public unsafe void SetHorizontalNormalizedPosition(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetHorizontalNormalizedPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0001DD3C File Offset: 0x0001BF3C
		[CallerCount(0)]
		public unsafe void SetVerticalNormalizedPosition(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetVerticalNormalizedPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0001DD7C File Offset: 0x0001BF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526707, XrefRangeEnd = 526730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNormalizedPosition(float value, int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetNormalizedPosition_Protected_Virtual_New_Void_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001DDD4 File Offset: 0x0001BFD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 526731, RefRangeEnd = 526733, XrefRangeStart = 526730, XrefRangeEnd = 526731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RubberDelta(float overStretching, float viewSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overStretching;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_RubberDelta_Private_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001DE20 File Offset: 0x0001C020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526733, XrefRangeEnd = 526734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0001DE5C File Offset: 0x0001C05C
		public unsafe bool hScrollingNeeded
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 526736, RefRangeEnd = 526740, XrefRangeStart = 526734, XrefRangeEnd = 526736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_hScrollingNeeded_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001DE98 File Offset: 0x0001C098
		public unsafe bool vScrollingNeeded
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 526742, RefRangeEnd = 526747, XrefRangeStart = 526740, XrefRangeEnd = 526742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_vScrollingNeeded_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0001DED4 File Offset: 0x0001C0D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0001DF10 File Offset: 0x0001C110
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0001DF4C File Offset: 0x0001C14C
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0001DF94 File Offset: 0x0001C194
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0001DFDC File Offset: 0x0001C1DC
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0001E024 File Offset: 0x0001C224
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001E06C File Offset: 0x0001C26C
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001E0B4 File Offset: 0x0001C2B4
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0001E144 File Offset: 0x0001C344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526747, XrefRangeEnd = 526816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0001E180 File Offset: 0x0001C380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526816, XrefRangeEnd = 526824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0001E1BC File Offset: 0x0001C3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526824, XrefRangeEnd = 526828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbarVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateScrollbarVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0001E1F0 File Offset: 0x0001C3F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 526838, RefRangeEnd = 526842, XrefRangeStart = 526828, XrefRangeEnd = 526838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xScrollingNeeded;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xAxisEnabled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollbarVisibility;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scrollbar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateOneScrollbarVisibility_Private_Static_Void_Boolean_Boolean_ScrollbarVisibility_Scrollbar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0001E250 File Offset: 0x0001C450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 526869, RefRangeEnd = 526870, XrefRangeStart = 526842, XrefRangeEnd = 526869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbarLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateScrollbarLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0001E284 File Offset: 0x0001C484
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 526912, RefRangeEnd = 526923, XrefRangeStart = 526870, XrefRangeEnd = 526912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateBounds_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
		[CallerCount(0)]
		public unsafe static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &viewBounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentPivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_AdjustBounds_Internal_Static_Void_byref_Bounds_byref_Vector2_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0001E314 File Offset: 0x0001C514
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 526941, RefRangeEnd = 526946, XrefRangeStart = 526923, XrefRangeEnd = 526941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_GetBounds_Private_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0001E350 File Offset: 0x0001C550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 526949, RefRangeEnd = 526950, XrefRangeStart = 526946, XrefRangeEnd = 526949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds InternalGetBounds(Il2CppStructArray<Vector3> corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(corners);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewWorldToLocalMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_InternalGetBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001E3A0 File Offset: 0x0001C5A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 526954, RefRangeEnd = 526958, XrefRangeStart = 526950, XrefRangeEnd = 526954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculateOffset(Vector2 delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_CalculateOffset_Private_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0001E3EC File Offset: 0x0001C5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526958, XrefRangeEnd = 526962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &viewBounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentBounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horizontal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertical;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref movementType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_InternalCalculateOffset_Internal_Static_Vector2_byref_Bounds_byref_Bounds_Boolean_Boolean_MovementType_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001E470 File Offset: 0x0001C670
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 526967, RefRangeEnd = 526975, XrefRangeStart = 526962, XrefRangeEnd = 526967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001E4A4 File Offset: 0x0001C6A4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 526984, RefRangeEnd = 526997, XrefRangeStart = 526975, XrefRangeEnd = 526984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirtyCaching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetDirtyCaching_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0001E4D8 File Offset: 0x0001C6D8
		public unsafe virtual Transform UnityEngine.UI.ICanvasElement.transform
		{
			[CallerCount(333)]
			[CachedScanResults(RefRangeStart = 456526, RefRangeEnd = 456859, XrefRangeStart = 456526, XrefRangeEnd = 456859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00003EEC File Offset: 0x000020EC
		public ScrollRect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0001E518 File Offset: 0x0001C718
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00003EF5 File Offset: 0x000020F5
		public unsafe RectTransform m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0001E548 File Offset: 0x0001C748
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00003F14 File Offset: 0x00002114
		public unsafe bool m_Horizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Horizontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Horizontal)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0001E570 File Offset: 0x0001C770
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00003F2F File Offset: 0x0000212F
		public unsafe bool m_Vertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Vertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Vertical)) = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001E598 File Offset: 0x0001C798
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00003F4A File Offset: 0x0000214A
		public unsafe ScrollRect.MovementType m_MovementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_MovementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_MovementType)) = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0001E5C0 File Offset: 0x0001C7C0
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00003F65 File Offset: 0x00002165
		public unsafe float m_Elasticity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Elasticity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Elasticity)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00003F80 File Offset: 0x00002180
		public unsafe bool m_Inertia
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Inertia);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Inertia)) = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001E610 File Offset: 0x0001C810
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x00003F9B File Offset: 0x0000219B
		public unsafe float m_DecelerationRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_DecelerationRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_DecelerationRate)) = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001E638 File Offset: 0x0001C838
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x00003FB6 File Offset: 0x000021B6
		public unsafe float m_ScrollSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ScrollSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ScrollSensitivity)) = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001E660 File Offset: 0x0001C860
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00003FD1 File Offset: 0x000021D1
		public unsafe RectTransform m_Viewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Viewport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Viewport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001E690 File Offset: 0x0001C890
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00003FF0 File Offset: 0x000021F0
		public unsafe Scrollbar m_HorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x0000400F File Offset: 0x0000220F
		public unsafe Scrollbar m_VerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x0000402E File Offset: 0x0000222E
		public unsafe ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarVisibility)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001E718 File Offset: 0x0001C918
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00004049 File Offset: 0x00002249
		public unsafe ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarVisibility)) = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0001E740 File Offset: 0x0001C940
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00004064 File Offset: 0x00002264
		public unsafe float m_HorizontalScrollbarSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarSpacing)) = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0001E768 File Offset: 0x0001C968
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x0000407F File Offset: 0x0000227F
		public unsafe float m_VerticalScrollbarSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarSpacing)) = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001E790 File Offset: 0x0001C990
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x0000409A File Offset: 0x0000229A
		public unsafe ScrollRect.ScrollRectEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect.ScrollRectEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001E7C0 File Offset: 0x0001C9C0
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x000040B9 File Offset: 0x000022B9
		public unsafe Vector2 m_PointerStartLocalCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PointerStartLocalCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PointerStartLocalCursor)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001E7E8 File Offset: 0x0001C9E8
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x000040D4 File Offset: 0x000022D4
		public unsafe Vector2 m_ContentStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentStartPosition)) = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001E810 File Offset: 0x0001CA10
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x000040EF File Offset: 0x000022EF
		public unsafe RectTransform m_ViewRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001E840 File Offset: 0x0001CA40
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x0000410E File Offset: 0x0000230E
		public unsafe Bounds m_ContentBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentBounds)) = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0001E868 File Offset: 0x0001CA68
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00004129 File Offset: 0x00002329
		public unsafe Bounds m_ViewBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewBounds)) = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0001E890 File Offset: 0x0001CA90
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00004144 File Offset: 0x00002344
		public unsafe Vector2 m_Velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Velocity)) = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0001E8B8 File Offset: 0x0001CAB8
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x0000415F File Offset: 0x0000235F
		public unsafe bool m_Dragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Dragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Dragging)) = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0001E8E0 File Offset: 0x0001CAE0
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x0000417A File Offset: 0x0000237A
		public unsafe bool m_Scrolling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Scrolling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Scrolling)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0001E908 File Offset: 0x0001CB08
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00004195 File Offset: 0x00002395
		public unsafe Vector2 m_PrevPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevPosition)) = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0001E930 File Offset: 0x0001CB30
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x000041B0 File Offset: 0x000023B0
		public unsafe Bounds m_PrevContentBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevContentBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevContentBounds)) = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0001E958 File Offset: 0x0001CB58
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x000041CB File Offset: 0x000023CB
		public unsafe Bounds m_PrevViewBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevViewBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevViewBounds)) = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0001E980 File Offset: 0x0001CB80
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x000041E6 File Offset: 0x000023E6
		public unsafe bool m_HasRebuiltLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HasRebuiltLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HasRebuiltLayout)) = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00004201 File Offset: 0x00002401
		public unsafe bool m_HSliderExpand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderExpand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderExpand)) = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0001E9D0 File Offset: 0x0001CBD0
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x0000421C File Offset: 0x0000241C
		public unsafe bool m_VSliderExpand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderExpand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderExpand)) = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001E9F8 File Offset: 0x0001CBF8
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00004237 File Offset: 0x00002437
		public unsafe float m_HSliderHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderHeight)) = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0001EA20 File Offset: 0x0001CC20
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00004252 File Offset: 0x00002452
		public unsafe float m_VSliderWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderWidth)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001EA48 File Offset: 0x0001CC48
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x0000426D File Offset: 0x0000246D
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0001EA78 File Offset: 0x0001CC78
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x0000428C File Offset: 0x0000248C
		public unsafe RectTransform m_HorizontalScrollbarRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0001EAA8 File Offset: 0x0001CCA8
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x000042AB File Offset: 0x000024AB
		public unsafe RectTransform m_VerticalScrollbarRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x0001EAD8 File Offset: 0x0001CCD8
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x000042CA File Offset: 0x000024CA
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0001EB00 File Offset: 0x0001CD00
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x000042E5 File Offset: 0x000024E5
		public unsafe Il2CppStructArray<Vector3> m_Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_m_Horizontal;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_m_Vertical;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr_m_MovementType;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_m_Elasticity;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_m_Inertia;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_m_DecelerationRate;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollSensitivity;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_m_Viewport;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbar;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbar;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbarVisibility;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarVisibility;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbarSpacing;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarSpacing;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerStartLocalCursor;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentStartPosition;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewRect;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentBounds;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewBounds;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_m_Velocity;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_m_Dragging;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr_m_Scrolling;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevPosition;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevContentBounds;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevViewBounds;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_m_HasRebuiltLayout;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_m_HSliderExpand;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_m_VSliderExpand;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_m_HSliderHeight;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr_m_VSliderWidth;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbarRect;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarRect;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_m_Corners;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_get_content_Public_get_RectTransform_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_set_content_Public_set_Void_RectTransform_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_get_movementType_Public_get_MovementType_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_set_movementType_Public_set_Void_MovementType_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_get_elasticity_Public_get_Single_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_get_inertia_Public_get_Boolean_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_set_inertia_Public_set_Void_Boolean_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_get_decelerationRate_Public_get_Single_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_set_decelerationRate_Public_set_Void_Single_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_get_viewport_Public_get_RectTransform_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_set_viewport_Public_set_Void_RectTransform_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_Scrollbar_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_Scrollbar_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarVisibility_Public_get_ScrollbarVisibility_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarVisibility_Public_get_ScrollbarVisibility_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarSpacing_Public_get_Single_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarSpacing_Public_set_Void_Single_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarSpacing_Public_get_Single_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarSpacing_Public_set_Void_Single_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollRectEvent_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollRectEvent_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_get_viewRect_Protected_get_RectTransform_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCachedData_Private_Void_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Boolean_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLayoutHasRebuilt_Private_Void_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_StopMovement_Public_Virtual_New_Void_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_SetContentAnchoredPosition_Protected_Virtual_New_Void_Vector2_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrevData_Protected_Void_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbars_Private_Void_Vector2_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedPosition_Public_get_Vector2_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_set_normalizedPosition_Public_set_Void_Vector2_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalNormalizedPosition_Public_get_Single_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalNormalizedPosition_Public_set_Void_Single_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalNormalizedPosition_Public_get_Single_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalNormalizedPosition_Public_set_Void_Single_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontalNormalizedPosition_Private_Void_Single_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticalNormalizedPosition_Private_Void_Single_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalizedPosition_Protected_Virtual_New_Void_Single_Int32_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_RubberDelta_Private_Static_Single_Single_Single_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_get_hScrollingNeeded_Private_get_Boolean_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_get_vScrollingNeeded_Private_get_Boolean_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbarVisibility_Private_Void_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOneScrollbarVisibility_Private_Static_Void_Boolean_Boolean_ScrollbarVisibility_Scrollbar_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbarLayout_Private_Void_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBounds_Protected_Void_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_AdjustBounds_Internal_Static_Void_byref_Bounds_byref_Vector2_byref_Vector3_byref_Vector3_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_GetBounds_Private_Bounds_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_CalculateOffset_Private_Vector2_Vector2_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_InternalCalculateOffset_Internal_Static_Vector2_byref_Bounds_byref_Bounds_Boolean_Boolean_MovementType_byref_Vector2_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_SetDirtyCaching_Protected_Void_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_get_Transform_0;

		// Token: 0x020000A1 RID: 161
		[OriginalName("UnityEngine.UI.dll", "", "MovementType")]
		public enum MovementType
		{
			// Token: 0x04000962 RID: 2402
			Unrestricted,
			// Token: 0x04000963 RID: 2403
			Elastic,
			// Token: 0x04000964 RID: 2404
			Clamped
		}

		// Token: 0x020000A2 RID: 162
		[OriginalName("UnityEngine.UI.dll", "", "ScrollbarVisibility")]
		public enum ScrollbarVisibility
		{
			// Token: 0x04000966 RID: 2406
			Permanent,
			// Token: 0x04000967 RID: 2407
			AutoHide,
			// Token: 0x04000968 RID: 2408
			AutoHideAndExpandViewport
		}

		// Token: 0x020000A3 RID: 163
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			// Token: 0x06000C16 RID: 3094 RVA: 0x000067EA File Offset: 0x000049EA
			// Note: this type is marked as 'beforefieldinit'.
			static ScrollRectEvent()
			{
				Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "ScrollRectEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr);
				ScrollRect.ScrollRectEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr, 100664287);
			}

			// Token: 0x06000C17 RID: 3095 RVA: 0x000348E8 File Offset: 0x00032AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526183, XrefRangeEnd = 526185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScrollRectEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.ScrollRectEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C18 RID: 3096 RVA: 0x0000681E File Offset: 0x00004A1E
			public ScrollRectEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000969 RID: 2409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
