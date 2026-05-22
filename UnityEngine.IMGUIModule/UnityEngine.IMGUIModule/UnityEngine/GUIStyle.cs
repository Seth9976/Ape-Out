using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public sealed class GUIStyle : Object
	{
		// Token: 0x06000360 RID: 864 RVA: 0x0000E97C File Offset: 0x0000CB7C
		// Note: this type is marked as 'beforefieldinit'.
		static GUIStyle()
		{
			Il2CppClassPointerStore<GUIStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIStyle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr);
			GUIStyle.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Ptr");
			GUIStyle.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Normal");
			GUIStyle.NativeFieldInfoPtr_m_Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Hover");
			GUIStyle.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Active");
			GUIStyle.NativeFieldInfoPtr_m_Focused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Focused");
			GUIStyle.NativeFieldInfoPtr_m_OnNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnNormal");
			GUIStyle.NativeFieldInfoPtr_m_OnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnHover");
			GUIStyle.NativeFieldInfoPtr_m_OnActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnActive");
			GUIStyle.NativeFieldInfoPtr_m_OnFocused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnFocused");
			GUIStyle.NativeFieldInfoPtr_m_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Border");
			GUIStyle.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Padding");
			GUIStyle.NativeFieldInfoPtr_m_Margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Margin");
			GUIStyle.NativeFieldInfoPtr_m_Overflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Overflow");
			GUIStyle.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Name");
			GUIStyle.NativeFieldInfoPtr_showKeyboardFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "showKeyboardFocus");
			GUIStyle.NativeFieldInfoPtr_s_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "s_None");
			GUIStyle.NativeMethodInfoPtr_get_rawName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663579);
			GUIStyle.NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663580);
			GUIStyle.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663581);
			GUIStyle.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663582);
			GUIStyle.NativeMethodInfoPtr_get_imagePosition_Public_get_ImagePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663583);
			GUIStyle.NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663584);
			GUIStyle.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663585);
			GUIStyle.NativeMethodInfoPtr_get_wordWrap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663586);
			GUIStyle.NativeMethodInfoPtr_set_wordWrap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663587);
			GUIStyle.NativeMethodInfoPtr_get_contentOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663588);
			GUIStyle.NativeMethodInfoPtr_set_contentOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663589);
			GUIStyle.NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663590);
			GUIStyle.NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663591);
			GUIStyle.NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663592);
			GUIStyle.NativeMethodInfoPtr_set_stretchWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663593);
			GUIStyle.NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663594);
			GUIStyle.NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663595);
			GUIStyle.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663596);
			GUIStyle.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663597);
			GUIStyle.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663598);
			GUIStyle.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663599);
			GUIStyle.NativeMethodInfoPtr_set_Internal_clipOffset_Internal_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663600);
			GUIStyle.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663601);
			GUIStyle.NativeMethodInfoPtr_Internal_Copy_Private_Static_IntPtr_GUIStyle_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663602);
			GUIStyle.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663603);
			GUIStyle.NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663604);
			GUIStyle.NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663605);
			GUIStyle.NativeMethodInfoPtr_Internal_GetLineHeight_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663606);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663607);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663608);
			GUIStyle.NativeMethodInfoPtr_Internal_DrawCursor_Private_Void_Rect_GUIContent_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663609);
			GUIStyle.NativeMethodInfoPtr_Internal_DrawWithTextSelection_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663610);
			GUIStyle.NativeMethodInfoPtr_Internal_GetCursorPixelPosition_Internal_Vector2_Rect_GUIContent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663611);
			GUIStyle.NativeMethodInfoPtr_Internal_GetCursorStringIndex_Internal_Int32_Rect_GUIContent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663612);
			GUIStyle.NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Internal_String_Rect_GUIContent_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663613);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcSize_Internal_Vector2_GUIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663614);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663615);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcHeight_Private_Single_GUIContent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663616);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Private_Vector2_GUIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663617);
			GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663618);
			GUIStyle.NativeMethodInfoPtr_IsTooltipActive_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663619);
			GUIStyle.NativeMethodInfoPtr_Internal_GetCursorFlashOffset_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663620);
			GUIStyle.NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663621);
			GUIStyle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663622);
			GUIStyle.NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663623);
			GUIStyle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663624);
			GUIStyle.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663625);
			GUIStyle.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663626);
			GUIStyle.NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663627);
			GUIStyle.NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663628);
			GUIStyle.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663629);
			GUIStyle.NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663630);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663631);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663632);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663633);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663634);
			GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663635);
			GUIStyle.NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663636);
			GUIStyle.NativeMethodInfoPtr_DrawCursor_Public_Void_Rect_GUIContent_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663637);
			GUIStyle.NativeMethodInfoPtr_DrawWithTextSelection_Internal_Void_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663638);
			GUIStyle.NativeMethodInfoPtr_DrawWithTextSelection_Internal_Void_Rect_GUIContent_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663639);
			GUIStyle.NativeMethodInfoPtr_DrawWithTextSelection_Public_Void_Rect_GUIContent_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663640);
			GUIStyle.NativeMethodInfoPtr_op_Implicit_Public_Static_GUIStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663641);
			GUIStyle.NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663642);
			GUIStyle.NativeMethodInfoPtr_GetCursorPixelPosition_Public_Vector2_Rect_GUIContent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663643);
			GUIStyle.NativeMethodInfoPtr_GetCursorStringIndex_Public_Int32_Rect_GUIContent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663644);
			GUIStyle.NativeMethodInfoPtr_CalcSize_Public_Vector2_GUIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663645);
			GUIStyle.NativeMethodInfoPtr_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663646);
			GUIStyle.NativeMethodInfoPtr_CalcHeight_Public_Single_GUIContent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663647);
			GUIStyle.NativeMethodInfoPtr_get_isHeightDependantOnWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663648);
			GUIStyle.NativeMethodInfoPtr_CalcMinMaxWidth_Public_Void_GUIContent_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663649);
			GUIStyle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663650);
			GUIStyle.NativeMethodInfoPtr_get_contentOffset_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663652);
			GUIStyle.NativeMethodInfoPtr_set_contentOffset_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663653);
			GUIStyle.NativeMethodInfoPtr_set_Internal_clipOffset_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663654);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663655);
			GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Void_byref_Rect_GUIContent_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663656);
			GUIStyle.NativeMethodInfoPtr_Internal_DrawCursor_Injected_Private_Void_byref_Rect_GUIContent_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663657);
			GUIStyle.NativeMethodInfoPtr_Internal_DrawWithTextSelection_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_byref_Color_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663658);
			GUIStyle.NativeMethodInfoPtr_Internal_GetCursorPixelPosition_Injected_Private_Void_byref_Rect_GUIContent_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663659);
			GUIStyle.NativeMethodInfoPtr_Internal_GetCursorStringIndex_Injected_Private_Int32_byref_Rect_GUIContent_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663660);
			GUIStyle.NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Injected_Private_String_byref_Rect_GUIContent_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663661);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcSize_Injected_Private_Void_GUIContent_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663662);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Injected_Private_Void_GUIContent_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663663);
			GUIStyle.NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Injected_Private_Void_GUIContent_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663664);
			GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_String_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663665);
			GUIStyle.set_imagePositionDelegateField = IL2CPP.ResolveICall<GUIStyle.set_imagePositionDelegate>("UnityEngine.GUIStyle::set_imagePosition");
			GUIStyle.get_clippingDelegateField = IL2CPP.ResolveICall<GUIStyle.get_clippingDelegate>("UnityEngine.GUIStyle::get_clipping");
			GUIStyle.set_clippingDelegateField = IL2CPP.ResolveICall<GUIStyle.set_clippingDelegate>("UnityEngine.GUIStyle::set_clipping");
			GUIStyle.set_fixedWidthDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fixedWidthDelegate>("UnityEngine.GUIStyle::set_fixedWidth");
			GUIStyle.set_fixedHeightDelegateField = IL2CPP.ResolveICall<GUIStyle.set_fixedHeightDelegate>("UnityEngine.GUIStyle::set_fixedHeight");
			GUIStyle.get_richTextDelegateField = IL2CPP.ResolveICall<GUIStyle.get_richTextDelegate>("UnityEngine.GUIStyle::get_richText");
			GUIStyle.set_richTextDelegateField = IL2CPP.ResolveICall<GUIStyle.set_richTextDelegate>("UnityEngine.GUIStyle::set_richText");
			GUIStyle.AssignStyleStateDelegateField = IL2CPP.ResolveICall<GUIStyle.AssignStyleStateDelegate>("UnityEngine.GUIStyle::AssignStyleState");
			GUIStyle.AssignRectOffsetDelegateField = IL2CPP.ResolveICall<GUIStyle.AssignRectOffsetDelegate>("UnityEngine.GUIStyle::AssignRectOffset");
			GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegate>("UnityEngine.GUIStyle::Internal_GetNumCharactersThatFitWithinWidth");
			GUIStyle.get_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.get_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_clipOffset_Injected");
			GUIStyle.set_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.set_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_clipOffset_Injected");
			GUIStyle.get_Internal_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.get_Internal_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_Internal_clipOffset_Injected");
			GUIStyle.Internal_GetHyperlinksRect_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyle.Internal_GetHyperlinksRect_InjectedDelegate>("UnityEngine.GUIStyle::Internal_GetHyperlinksRect_Injected");
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0000F278 File Offset: 0x0000D478
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0000F2B0 File Offset: 0x0000D4B0
		public unsafe string rawName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508710, XrefRangeEnd = 508714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_rawName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508714, XrefRangeEnd = 508718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		// (set) Token: 0x06000364 RID: 868 RVA: 0x0000F334 File Offset: 0x0000D534
		public unsafe Font font
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 508722, RefRangeEnd = 508723, XrefRangeStart = 508718, XrefRangeEnd = 508722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508723, XrefRangeEnd = 508727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000F378 File Offset: 0x0000D578
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003708 File Offset: 0x00001908
		public unsafe ImagePosition imagePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508727, XrefRangeEnd = 508731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_imagePosition_Public_get_ImagePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_imagePositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		public unsafe TextAnchor alignment
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508731, XrefRangeEnd = 508735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 508739, RefRangeEnd = 508740, XrefRangeStart = 508735, XrefRangeEnd = 508739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000F430 File Offset: 0x0000D630
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0000F46C File Offset: 0x0000D66C
		public unsafe bool wordWrap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508740, XrefRangeEnd = 508744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_wordWrap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 508748, RefRangeEnd = 508750, XrefRangeStart = 508744, XrefRangeEnd = 508748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_wordWrap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
		public unsafe Vector2 contentOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508750, XrefRangeEnd = 508752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_contentOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508752, XrefRangeEnd = 508754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_contentOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000F528 File Offset: 0x0000D728
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00003740 File Offset: 0x00001940
		public unsafe float fixedWidth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 508758, RefRangeEnd = 508761, XrefRangeStart = 508754, XrefRangeEnd = 508758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_fixedWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000F564 File Offset: 0x0000D764
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00003753 File Offset: 0x00001953
		public unsafe float fixedHeight
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 508765, RefRangeEnd = 508771, XrefRangeStart = 508761, XrefRangeEnd = 508765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GUIStyle.set_fixedHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		// (set) Token: 0x0600036F RID: 879 RVA: 0x0000F5DC File Offset: 0x0000D7DC
		public unsafe bool stretchWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508771, XrefRangeEnd = 508775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508775, XrefRangeEnd = 508779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_stretchWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000F61C File Offset: 0x0000D81C
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0000F658 File Offset: 0x0000D858
		public unsafe bool stretchHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508779, XrefRangeEnd = 508783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508783, XrefRangeEnd = 508787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000F698 File Offset: 0x0000D898
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		public unsafe int fontSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508787, XrefRangeEnd = 508791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 508795, RefRangeEnd = 508796, XrefRangeStart = 508791, XrefRangeEnd = 508795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000F714 File Offset: 0x0000D914
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000F750 File Offset: 0x0000D950
		public unsafe FontStyle fontStyle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508796, XrefRangeEnd = 508800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508800, XrefRangeEnd = 508804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00011208 File Offset: 0x0000F408
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0000F790 File Offset: 0x0000D990
		public unsafe Vector2 Internal_clipOffset
		{
			get
			{
				Vector2 vector;
				this.get_Internal_clipOffset_Injected(out vector);
				return vector;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508804, XrefRangeEnd = 508806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_Internal_clipOffset_Internal_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508806, XrefRangeEnd = 508810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(GUIStyle self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000F814 File Offset: 0x0000DA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508810, XrefRangeEnd = 508814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Copy(GUIStyle self, GUIStyle other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Copy_Private_Static_IntPtr_GUIStyle_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000F868 File Offset: 0x0000DA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508814, XrefRangeEnd = 508818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000F89C File Offset: 0x0000DA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508818, XrefRangeEnd = 508822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetStyleStatePtr(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508822, XrefRangeEnd = 508826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetRectOffsetPtr(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000F934 File Offset: 0x0000DB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508826, XrefRangeEnd = 508830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Internal_GetLineHeight(IntPtr target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetLineHeight_Private_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000F974 File Offset: 0x0000DB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508830, XrefRangeEnd = 508832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000F9FC File Offset: 0x0000DBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508832, XrefRangeEnd = 508834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000FA68 File Offset: 0x0000DC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508834, XrefRangeEnd = 508836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_DrawCursor_Private_Void_Rect_GUIContent_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508836, XrefRangeEnd = 508838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSelectionAsComposition;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorFirst;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorLast;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorColor;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_DrawWithTextSelection_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508838, XrefRangeEnd = 508840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorStringIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetCursorPixelPosition_Internal_Vector2_Rect_GUIContent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000FC14 File Offset: 0x0000DE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508840, XrefRangeEnd = 508842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorPixelPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetCursorStringIndex_Internal_Int32_Rect_GUIContent_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000FC80 File Offset: 0x0000DE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508842, XrefRangeEnd = 508844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Internal_String_Rect_GUIContent_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000FCF4 File Offset: 0x0000DEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508844, XrefRangeEnd = 508846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 Internal_CalcSize(GUIContent content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcSize_Internal_Vector2_GUIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000FD44 File Offset: 0x0000DF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508846, XrefRangeEnd = 508848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000FDA0 File Offset: 0x0000DFA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 508852, RefRangeEnd = 508856, XrefRangeStart = 508848, XrefRangeEnd = 508852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Internal_CalcHeight(GUIContent content, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcHeight_Private_Single_GUIContent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000FDFC File Offset: 0x0000DFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508856, XrefRangeEnd = 508858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 Internal_CalcMinMaxWidth(GUIContent content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Private_Vector2_GUIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000FE4C File Offset: 0x0000E04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508858, XrefRangeEnd = 508863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMouseTooltip(string tooltip, Rect screenRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000FE90 File Offset: 0x0000E090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508863, XrefRangeEnd = 508867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTooltipActive(string tooltip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_IsTooltipActive_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000FED4 File Offset: 0x0000E0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508867, XrefRangeEnd = 508871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Internal_GetCursorFlashOffset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetCursorFlashOffset_Private_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000FF04 File Offset: 0x0000E104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508871, XrefRangeEnd = 508875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultFont(Font font)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000FF3C File Offset: 0x0000E13C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 508880, RefRangeEnd = 508906, XrefRangeStart = 508875, XrefRangeEnd = 508880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000FF78 File Offset: 0x0000E178
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 508918, RefRangeEnd = 508927, XrefRangeStart = 508906, XrefRangeEnd = 508918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle(GUIStyle other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000FFC4 File Offset: 0x0000E1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508927, XrefRangeEnd = 508934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00010030 File Offset: 0x0000E230
		public unsafe string name
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 508936, RefRangeEnd = 508951, XrefRangeStart = 508934, XrefRangeEnd = 508936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 508955, RefRangeEnd = 508979, XrefRangeStart = 508951, XrefRangeEnd = 508955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00010074 File Offset: 0x0000E274
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x000037EA File Offset: 0x000019EA
		public unsafe GUIStyleState normal
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 508984, RefRangeEnd = 508988, XrefRangeStart = 508979, XrefRangeEnd = 508984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr3) : null;
			}
			set
			{
				this.AssignStyleState(0, value.m_Ptr);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000392 RID: 914 RVA: 0x000100B4 File Offset: 0x0000E2B4
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00003883 File Offset: 0x00001A83
		public unsafe RectOffset margin
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 508993, RefRangeEnd = 509015, XrefRangeStart = 508988, XrefRangeEnd = 508993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
			set
			{
				this.AssignRectOffset(1, value.m_Ptr);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000100F4 File Offset: 0x0000E2F4
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00003894 File Offset: 0x00001A94
		public unsafe RectOffset padding
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 509020, RefRangeEnd = 509037, XrefRangeStart = 509015, XrefRangeEnd = 509020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
			set
			{
				this.AssignRectOffset(2, value.m_Ptr);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00010134 File Offset: 0x0000E334
		public unsafe float lineHeight
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 509045, RefRangeEnd = 509051, XrefRangeStart = 509037, XrefRangeEnd = 509045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00010170 File Offset: 0x0000E370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509051, XrefRangeEnd = 509057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000101E8 File Offset: 0x0000E3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509057, XrefRangeEnd = 509059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00010270 File Offset: 0x0000E470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509059, XrefRangeEnd = 509060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, int controlID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000102D0 File Offset: 0x0000E4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509060, XrefRangeEnd = 509061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, int controlID, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001033C File Offset: 0x0000E53C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 509080, RefRangeEnd = 509085, XrefRangeStart = 509061, XrefRangeEnd = 509080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hover;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000103B8 File Offset: 0x0000E5B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 509087, RefRangeEnd = 509092, XrefRangeStart = 509085, XrefRangeEnd = 509087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00010450 File Offset: 0x0000E650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509116, RefRangeEnd = 509117, XrefRangeStart = 509092, XrefRangeEnd = 509116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawCursor(Rect position, GUIContent content, int controlID, int character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref character;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_DrawCursor_Public_Void_Rect_GUIContent_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000104BC File Offset: 0x0000E6BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509141, RefRangeEnd = 509142, XrefRangeStart = 509117, XrefRangeEnd = 509141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstSelectedCharacter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastSelectedCharacter;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSelectionAsComposition;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_DrawWithTextSelection_Internal_Void_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00010560 File Offset: 0x0000E760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 509157, RefRangeEnd = 509160, XrefRangeStart = 509142, XrefRangeEnd = 509157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstSelectedCharacter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastSelectedCharacter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSelectionAsComposition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_DrawWithTextSelection_Internal_Void_Rect_GUIContent_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000105E8 File Offset: 0x0000E7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509160, XrefRangeEnd = 509161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstSelectedCharacter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastSelectedCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_DrawWithTextSelection_Public_Void_Rect_GUIContent_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00010664 File Offset: 0x0000E864
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 509184, RefRangeEnd = 509196, XrefRangeStart = 509161, XrefRangeEnd = 509184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator GUIStyle(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_op_Implicit_Public_Static_GUIStyle_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000106A8 File Offset: 0x0000E8A8
		public unsafe static GUIStyle none
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 509205, RefRangeEnd = 509229, XrefRangeStart = 509196, XrefRangeEnd = 509205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000106DC File Offset: 0x0000E8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509229, XrefRangeEnd = 509231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorStringIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_GetCursorPixelPosition_Public_Vector2_Rect_GUIContent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00010748 File Offset: 0x0000E948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509231, XrefRangeEnd = 509233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorPixelPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_GetCursorStringIndex_Public_Int32_Rect_GUIContent_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000107B4 File Offset: 0x0000E9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalcSize(GUIContent content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_CalcSize_Public_Vector2_GUIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00010804 File Offset: 0x0000EA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref constraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00010860 File Offset: 0x0000EA60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 508852, RefRangeEnd = 508856, XrefRangeStart = 508852, XrefRangeEnd = 508856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalcHeight(GUIContent content, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_CalcHeight_Public_Single_GUIContent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000108BC File Offset: 0x0000EABC
		public unsafe bool isHeightDependantOnWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509233, XrefRangeEnd = 509239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_isHeightDependantOnWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000108F8 File Offset: 0x0000EAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509239, XrefRangeEnd = 509241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_CalcMinMaxWidth_Public_Void_GUIContent_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00010958 File Offset: 0x0000EB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509241, XrefRangeEnd = 509255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00010990 File Offset: 0x0000EB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509255, XrefRangeEnd = 509259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_contentOffset_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_get_contentOffset_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000109D0 File Offset: 0x0000EBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509259, XrefRangeEnd = 509263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_contentOffset_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_contentOffset_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00010A10 File Offset: 0x0000EC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509263, XrefRangeEnd = 509267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_Internal_clipOffset_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_set_Internal_clipOffset_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00010A50 File Offset: 0x0000EC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509267, XrefRangeEnd = 509271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509271, XrefRangeEnd = 509275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Void_byref_Rect_GUIContent_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00010B44 File Offset: 0x0000ED44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509275, XrefRangeEnd = 509279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cursorColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_DrawCursor_Injected_Private_Void_byref_Rect_GUIContent_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00010BB4 File Offset: 0x0000EDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509279, XrefRangeEnd = 509283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHover;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasKeyboardFocus;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSelectionAsComposition;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorFirst;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorLast;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cursorColor;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &selectionColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_DrawWithTextSelection_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_byref_Color_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00010C88 File Offset: 0x0000EE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509283, XrefRangeEnd = 509287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorStringIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetCursorPixelPosition_Injected_Private_Void_byref_Rect_GUIContent_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509287, XrefRangeEnd = 509291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cursorPixelPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetCursorStringIndex_Injected_Private_Int32_byref_Rect_GUIContent_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00010D64 File Offset: 0x0000EF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509291, XrefRangeEnd = 509295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &localPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Injected_Private_String_byref_Rect_GUIContent_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00010DD8 File Offset: 0x0000EFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509295, XrefRangeEnd = 509299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcSize_Injected_Private_Void_GUIContent_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00010E28 File Offset: 0x0000F028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509299, XrefRangeEnd = 509303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Injected_Private_Void_GUIContent_byref_Vector2_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00010E88 File Offset: 0x0000F088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509303, XrefRangeEnd = 509307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Injected_Private_Void_GUIContent_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509307, XrefRangeEnd = 509311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &screenRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyle.NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_String_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00003531 File Offset: 0x00001731
		public GUIStyle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00010F1C File Offset: 0x0000F11C
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x0000353A File Offset: 0x0000173A
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00010F44 File Offset: 0x0000F144
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00003555 File Offset: 0x00001755
		public unsafe GUIStyleState m_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00010F74 File Offset: 0x0000F174
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00003574 File Offset: 0x00001774
		public unsafe GUIStyleState m_Hover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Hover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Hover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00010FA4 File Offset: 0x0000F1A4
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00003593 File Offset: 0x00001793
		public unsafe GUIStyleState m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Active);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Active), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00010FD4 File Offset: 0x0000F1D4
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x000035B2 File Offset: 0x000017B2
		public unsafe GUIStyleState m_Focused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Focused);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Focused), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00011004 File Offset: 0x0000F204
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x000035D1 File Offset: 0x000017D1
		public unsafe GUIStyleState m_OnNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00011034 File Offset: 0x0000F234
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000035F0 File Offset: 0x000017F0
		public unsafe GUIStyleState m_OnHover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnHover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnHover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00011064 File Offset: 0x0000F264
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x0000360F File Offset: 0x0000180F
		public unsafe GUIStyleState m_OnActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnActive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnActive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00011094 File Offset: 0x0000F294
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0000362E File Offset: 0x0000182E
		public unsafe GUIStyleState m_OnFocused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnFocused);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_OnFocused), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003CA RID: 970 RVA: 0x000110C4 File Offset: 0x0000F2C4
		// (set) Token: 0x060003CB RID: 971 RVA: 0x0000364D File Offset: 0x0000184D
		public unsafe RectOffset m_Border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003CC RID: 972 RVA: 0x000110F4 File Offset: 0x0000F2F4
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0000366C File Offset: 0x0000186C
		public unsafe RectOffset m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Padding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Padding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00011124 File Offset: 0x0000F324
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0000368B File Offset: 0x0000188B
		public unsafe RectOffset m_Margin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Margin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Margin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00011154 File Offset: 0x0000F354
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x000036AA File Offset: 0x000018AA
		public unsafe RectOffset m_Overflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Overflow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Overflow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00011184 File Offset: 0x0000F384
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x000036C9 File Offset: 0x000018C9
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyle.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000111AC File Offset: 0x0000F3AC
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000036E8 File Offset: 0x000018E8
		public unsafe static bool showKeyboardFocus
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(GUIStyle.NativeFieldInfoPtr_showKeyboardFocus, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIStyle.NativeFieldInfoPtr_showKeyboardFocus, (void*)(&value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000111C8 File Offset: 0x0000F3C8
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000036F6 File Offset: 0x000018F6
		public unsafe static GUIStyle s_None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIStyle.NativeFieldInfoPtr_s_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIStyle.NativeFieldInfoPtr_s_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0000371B File Offset: 0x0000191B
		// (set) Token: 0x060003DA RID: 986 RVA: 0x0000372D File Offset: 0x0000192D
		public TextClipping clipping
		{
			get
			{
				return GUIStyle.get_clippingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_clippingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00003766 File Offset: 0x00001966
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00003778 File Offset: 0x00001978
		public bool richText
		{
			get
			{
				return GUIStyle.get_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GUIStyle.set_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000111F0 File Offset: 0x0000F3F0
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0000378B File Offset: 0x0000198B
		public Vector2 clipOffset
		{
			get
			{
				Vector2 vector;
				this.get_clipOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_clipOffset_Injected(ref value);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00003795 File Offset: 0x00001995
		public void AssignStyleState(int idx, IntPtr srcStyleState)
		{
			GUIStyle.AssignStyleStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), idx, srcStyleState);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000037A9 File Offset: 0x000019A9
		public void AssignRectOffset(int idx, IntPtr srcRectOffset)
		{
			GUIStyle.AssignRectOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), idx, srcRectOffset);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000037BD File Offset: 0x000019BD
		public Il2CppStructArray<Rect> Internal_GetHyperlinksRect(Rect localPosition, GUIContent mContent)
		{
			return this.Internal_GetHyperlinksRect_Injected(ref localPosition, mContent);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000037C8 File Offset: 0x000019C8
		public int Internal_GetNumCharactersThatFitWithinWidth(string text, float width)
		{
			return GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(text), width);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000037E1 File Offset: 0x000019E1
		public static void CleanupRoots()
		{
			GUIStyle.s_None = null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00011220 File Offset: 0x0000F420
		public void InternalOnAfterDeserialize()
		{
			this.m_Normal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(0));
			this.m_Hover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(1));
			this.m_Active = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(2));
			this.m_Focused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(3));
			this.m_OnNormal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(4));
			this.m_OnHover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(5));
			this.m_OnActive = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(6));
			this.m_OnFocused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(7));
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000112C8 File Offset: 0x0000F4C8
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x000037FB File Offset: 0x000019FB
		public GUIStyleState hover
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_Hover) == null)
				{
					guistyleState = (this.m_Hover = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(1)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(1, value.m_Ptr);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x000112FC File Offset: 0x0000F4FC
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x0000380C File Offset: 0x00001A0C
		public GUIStyleState active
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_Active) == null)
				{
					guistyleState = (this.m_Active = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(2)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(2, value.m_Ptr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00011330 File Offset: 0x0000F530
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x0000381D File Offset: 0x00001A1D
		public GUIStyleState onNormal
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnNormal) == null)
				{
					guistyleState = (this.m_OnNormal = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(4)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(4, value.m_Ptr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00011364 File Offset: 0x0000F564
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0000382E File Offset: 0x00001A2E
		public GUIStyleState onHover
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnHover) == null)
				{
					guistyleState = (this.m_OnHover = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(5)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(5, value.m_Ptr);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00011398 File Offset: 0x0000F598
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x0000383F File Offset: 0x00001A3F
		public GUIStyleState onActive
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnActive) == null)
				{
					guistyleState = (this.m_OnActive = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(6)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(6, value.m_Ptr);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000113CC File Offset: 0x0000F5CC
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00003850 File Offset: 0x00001A50
		public GUIStyleState focused
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_Focused) == null)
				{
					guistyleState = (this.m_Focused = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(3)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(3, value.m_Ptr);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00011400 File Offset: 0x0000F600
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00003861 File Offset: 0x00001A61
		public GUIStyleState onFocused
		{
			get
			{
				GUIStyleState guistyleState;
				if ((guistyleState = this.m_OnFocused) == null)
				{
					guistyleState = (this.m_OnFocused = GUIStyleState.GetGUIStyleState(this, this.GetStyleStatePtr(7)));
				}
				return guistyleState;
			}
			set
			{
				this.AssignStyleState(7, value.m_Ptr);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00011434 File Offset: 0x0000F634
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00003872 File Offset: 0x00001A72
		public RectOffset border
		{
			get
			{
				RectOffset rectOffset;
				if ((rectOffset = this.m_Border) == null)
				{
					rectOffset = (this.m_Border = new RectOffset(this, this.GetRectOffsetPtr(0)));
				}
				return rectOffset;
			}
			set
			{
				this.AssignRectOffset(0, value.m_Ptr);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00011468 File Offset: 0x0000F668
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x000038A5 File Offset: 0x00001AA5
		public RectOffset overflow
		{
			get
			{
				RectOffset rectOffset;
				if ((rectOffset = this.m_Overflow) == null)
				{
					rectOffset = (this.m_Overflow = new RectOffset(this, this.GetRectOffsetPtr(3)));
				}
				return rectOffset;
			}
			set
			{
				this.AssignRectOffset(3, value.m_Ptr);
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000038B6 File Offset: 0x00001AB6
		public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			this.Draw(position, GUIContent.Temp(text), -1, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000038CF File Offset: 0x00001ACF
		public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			this.Draw(position, GUIContent.Temp(image), -1, isHover, isActive, on, hasKeyboardFocus);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001149C File Offset: 0x0000F69C
		public int GetNumCharactersThatFitWithinWidth(string text, float width)
		{
			return this.Internal_GetNumCharactersThatFitWithinWidth(text, width);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000114B8 File Offset: 0x0000F6B8
		public Vector2 CalcScreenSize(Vector2 contentSize)
		{
			return new Vector2((this.fixedWidth != 0f) ? this.fixedWidth : Mathf.Ceil(contentSize.x + (float)this.padding.left + (float)this.padding.right), (this.fixedHeight != 0f) ? this.fixedHeight : Mathf.Ceil(contentSize.y + (float)this.padding.top + (float)this.padding.bottom));
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000038E8 File Offset: 0x00001AE8
		public void get_clipOffset_Injected(out Vector2 ret)
		{
			GUIStyle.get_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000038FB File Offset: 0x00001AFB
		public void set_clipOffset_Injected(ref Vector2 value)
		{
			GUIStyle.set_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000390E File Offset: 0x00001B0E
		public void get_Internal_clipOffset_Injected(out Vector2 ret)
		{
			GUIStyle.get_Internal_clipOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00011544 File Offset: 0x0000F744
		public Il2CppStructArray<Rect> Internal_GetHyperlinksRect_Injected(ref Rect localPosition, GUIContent mContent)
		{
			IntPtr intPtr = GUIStyle.Internal_GetHyperlinksRect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref localPosition, IL2CPP.Il2CppObjectBaseToPtr(mContent));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
		}

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_m_Hover;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_m_Focused;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_m_OnNormal;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_m_OnHover;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_m_OnActive;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_m_OnFocused;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_m_Border;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_m_Margin;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_m_Overflow;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_showKeyboardFocus;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_s_None;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_rawName_Internal_get_String_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_Font_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_get_imagePosition_Public_get_ImagePosition_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_get_wordWrap_Public_get_Boolean_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_set_wordWrap_Public_set_Void_Boolean_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_contentOffset_Public_get_Vector2_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_set_contentOffset_Public_set_Void_Vector2_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_set_stretchWidth_Public_set_Void_Boolean_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_set_Internal_clipOffset_Internal_set_Void_Vector2_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Copy_Private_Static_IntPtr_GUIStyle_GUIStyle_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetLineHeight_Private_Static_Single_IntPtr_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawCursor_Private_Void_Rect_GUIContent_Int32_Color_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawWithTextSelection_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetCursorPixelPosition_Internal_Vector2_Rect_GUIContent_Int32_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetCursorStringIndex_Internal_Int32_Rect_GUIContent_Vector2_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Internal_String_Rect_GUIContent_Int32_Int32_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcSize_Internal_Vector2_GUIContent_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcHeight_Private_Single_GUIContent_Single_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Private_Vector2_GUIContent_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_IsTooltipActive_Internal_Static_Boolean_String_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetCursorFlashOffset_Private_Static_Single_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_DrawCursor_Public_Void_Rect_GUIContent_Int32_Int32_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_DrawWithTextSelection_Internal_Void_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_DrawWithTextSelection_Internal_Void_Rect_GUIContent_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_DrawWithTextSelection_Public_Void_Rect_GUIContent_Int32_Int32_Int32_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_GUIStyle_String_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorPixelPosition_Public_Vector2_Rect_GUIContent_Int32_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorStringIndex_Public_Int32_Rect_GUIContent_Vector2_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_CalcSize_Public_Vector2_GUIContent_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Single_GUIContent_Single_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_get_isHeightDependantOnWidth_Public_get_Boolean_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_CalcMinMaxWidth_Public_Void_GUIContent_byref_Single_byref_Single_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_get_contentOffset_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_set_contentOffset_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_set_Internal_clipOffset_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Void_byref_Rect_GUIContent_Int32_Boolean_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawCursor_Injected_Private_Void_byref_Rect_GUIContent_Int32_byref_Color_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawWithTextSelection_Injected_Private_Void_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_byref_Color_byref_Color_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetCursorPixelPosition_Injected_Private_Void_byref_Rect_GUIContent_Int32_byref_Vector2_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetCursorStringIndex_Injected_Private_Int32_byref_Rect_GUIContent_byref_Vector2_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetSelectedRenderedText_Injected_Private_String_byref_Rect_GUIContent_Int32_Int32_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcSize_Injected_Private_Void_GUIContent_byref_Vector2_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Injected_Private_Void_GUIContent_byref_Vector2_byref_Vector2_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Injected_Private_Void_GUIContent_byref_Vector2_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_String_byref_Rect_0;

		// Token: 0x0400022E RID: 558
		private static readonly GUIStyle.set_imagePositionDelegate set_imagePositionDelegateField;

		// Token: 0x0400022F RID: 559
		private static readonly GUIStyle.get_clippingDelegate get_clippingDelegateField;

		// Token: 0x04000230 RID: 560
		private static readonly GUIStyle.set_clippingDelegate set_clippingDelegateField;

		// Token: 0x04000231 RID: 561
		private static readonly GUIStyle.set_fixedWidthDelegate set_fixedWidthDelegateField;

		// Token: 0x04000232 RID: 562
		private static readonly GUIStyle.set_fixedHeightDelegate set_fixedHeightDelegateField;

		// Token: 0x04000233 RID: 563
		private static readonly GUIStyle.get_richTextDelegate get_richTextDelegateField;

		// Token: 0x04000234 RID: 564
		private static readonly GUIStyle.set_richTextDelegate set_richTextDelegateField;

		// Token: 0x04000235 RID: 565
		private static readonly GUIStyle.AssignStyleStateDelegate AssignStyleStateDelegateField;

		// Token: 0x04000236 RID: 566
		private static readonly GUIStyle.AssignRectOffsetDelegate AssignRectOffsetDelegateField;

		// Token: 0x04000237 RID: 567
		private static readonly GUIStyle.Internal_GetNumCharactersThatFitWithinWidthDelegate Internal_GetNumCharactersThatFitWithinWidthDelegateField;

		// Token: 0x04000238 RID: 568
		private static readonly GUIStyle.get_clipOffset_InjectedDelegate get_clipOffset_InjectedDelegateField;

		// Token: 0x04000239 RID: 569
		private static readonly GUIStyle.set_clipOffset_InjectedDelegate set_clipOffset_InjectedDelegateField;

		// Token: 0x0400023A RID: 570
		private static readonly GUIStyle.get_Internal_clipOffset_InjectedDelegate get_Internal_clipOffset_InjectedDelegateField;

		// Token: 0x0400023B RID: 571
		private static readonly GUIStyle.Internal_GetHyperlinksRect_InjectedDelegate Internal_GetHyperlinksRect_InjectedDelegateField;

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060006CA RID: 1738
		private delegate void set_imagePositionDelegate(IntPtr @this, ImagePosition value);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060006CC RID: 1740
		private delegate TextClipping get_clippingDelegate(IntPtr @this);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060006CE RID: 1742
		private delegate void set_clippingDelegate(IntPtr @this, TextClipping value);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060006D0 RID: 1744
		private delegate void set_fixedWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060006D2 RID: 1746
		private delegate void set_fixedHeightDelegate(IntPtr @this, float value);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060006D4 RID: 1748
		private delegate bool get_richTextDelegate(IntPtr @this);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060006D6 RID: 1750
		private delegate void set_richTextDelegate(IntPtr @this, bool value);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060006D8 RID: 1752
		private delegate void AssignStyleStateDelegate(IntPtr @this, int idx, IntPtr srcStyleState);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060006DA RID: 1754
		private delegate void AssignRectOffsetDelegate(IntPtr @this, int idx, IntPtr srcRectOffset);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060006DC RID: 1756
		private delegate int Internal_GetNumCharactersThatFitWithinWidthDelegate(IntPtr @this, IntPtr text, float width);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060006DE RID: 1758
		private delegate void get_clipOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060006E0 RID: 1760
		private delegate void set_clipOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060006E2 RID: 1762
		private delegate void get_Internal_clipOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060006E4 RID: 1764
		private delegate IntPtr Internal_GetHyperlinksRect_InjectedDelegate(IntPtr @this, IntPtr localPosition, IntPtr mContent);
	}
}
