using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public class GUI : Object
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000059D8 File Offset: 0x00003BD8
		// Note: this type is marked as 'beforefieldinit'.
		static GUI()
		{
			Il2CppClassPointerStore<GUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUI");
			GUI.NativeFieldInfoPtr_s_ScrollControlId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ScrollControlId");
			GUI.NativeFieldInfoPtr_s_HotTextField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_HotTextField");
			GUI.NativeFieldInfoPtr_s_BoxHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_BoxHash");
			GUI.NativeFieldInfoPtr_s_ButonHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ButonHash");
			GUI.NativeFieldInfoPtr_s_RepeatButtonHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_RepeatButtonHash");
			GUI.NativeFieldInfoPtr_s_ToggleHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ToggleHash");
			GUI.NativeFieldInfoPtr_s_ButtonGridHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ButtonGridHash");
			GUI.NativeFieldInfoPtr_s_SliderHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_SliderHash");
			GUI.NativeFieldInfoPtr_s_BeginGroupHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_BeginGroupHash");
			GUI.NativeFieldInfoPtr_s_ScrollviewHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ScrollviewHash");
			GUI.NativeFieldInfoPtr__scrollTroughSide_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "<scrollTroughSide>k__BackingField");
			GUI.NativeFieldInfoPtr__nextScrollStepTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "<nextScrollStepTime>k__BackingField");
			GUI.NativeFieldInfoPtr_s_Skin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_Skin");
			GUI.NativeFieldInfoPtr_s_ToolTipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "s_ToolTipRect");
			GUI.NativeFieldInfoPtr__scrollViewStates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUI>.NativeClassPtr, "<scrollViewStates>k__BackingField");
			GUI.NativeMethodInfoPtr_get_color_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663337);
			GUI.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663338);
			GUI.NativeMethodInfoPtr_set_changed_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663339);
			GUI.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663340);
			GUI.NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663341);
			GUI.NativeMethodInfoPtr_get_usePageScrollbars_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663342);
			GUI.NativeMethodInfoPtr_get_blendMaterial_Internal_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663343);
			GUI.NativeMethodInfoPtr_get_blitMaterial_Internal_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663344);
			GUI.NativeMethodInfoPtr_get_roundedRectMaterial_Internal_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663345);
			GUI.NativeMethodInfoPtr_get_roundedRectWithColorPerBorderMaterial_Internal_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663346);
			GUI.NativeMethodInfoPtr_GrabMouseControl_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663347);
			GUI.NativeMethodInfoPtr_HasMouseControl_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663348);
			GUI.NativeMethodInfoPtr_ReleaseMouseControl_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663349);
			GUI.NativeMethodInfoPtr_InternalRepaintEditorWindow_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663350);
			GUI.NativeMethodInfoPtr_Internal_DoWindow_Private_Static_Rect_Int32_Int32_Rect_WindowFunction_GUIContent_GUIStyle_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663351);
			GUI.NativeMethodInfoPtr_FocusWindow_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663352);
			GUI.NativeMethodInfoPtr_get_scrollTroughSide_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663354);
			GUI.NativeMethodInfoPtr_set_scrollTroughSide_Internal_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663355);
			GUI.NativeMethodInfoPtr_get_nextScrollStepTime_Internal_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663356);
			GUI.NativeMethodInfoPtr_set_nextScrollStepTime_Internal_Static_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663357);
			GUI.NativeMethodInfoPtr_set_skin_Public_Static_set_Void_GUISkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663358);
			GUI.NativeMethodInfoPtr_get_skin_Public_Static_get_GUISkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663359);
			GUI.NativeMethodInfoPtr_DoSetSkin_Internal_Static_Void_GUISkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663360);
			GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_String_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663361);
			GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663362);
			GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663363);
			GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663364);
			GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663365);
			GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663366);
			GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663367);
			GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663368);
			GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663369);
			GUI.NativeMethodInfoPtr_DrawTexture_Internal_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Vector4_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663370);
			GUI.NativeMethodInfoPtr_DrawTexture_Internal_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Color_Color_Color_Vector4_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663371);
			GUI.NativeMethodInfoPtr_CalculateScaledTextureRects_Internal_Static_Boolean_Rect_ScaleMode_Single_byref_Rect_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663372);
			GUI.NativeMethodInfoPtr_Box_Public_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663373);
			GUI.NativeMethodInfoPtr_Button_Public_Static_Boolean_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663374);
			GUI.NativeMethodInfoPtr_Button_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663375);
			GUI.NativeMethodInfoPtr_DoRepeatButton_Private_Static_Boolean_Rect_GUIContent_GUIStyle_FocusType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663376);
			GUI.NativeMethodInfoPtr_PasswordFieldGetStrToShow_Internal_Static_String_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663377);
			GUI.NativeMethodInfoPtr_DoTextField_Internal_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663378);
			GUI.NativeMethodInfoPtr_DoTextField_Internal_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663379);
			GUI.NativeMethodInfoPtr_DoTextField_Internal_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663380);
			GUI.NativeMethodInfoPtr_HandleTextFieldEventForTouchscreen_Private_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_Char_TextEditor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663381);
			GUI.NativeMethodInfoPtr_HandleTextFieldEventForDesktop_Private_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_TextEditor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663382);
			GUI.NativeMethodInfoPtr_HandleTextFieldEventForDesktopWithForcedKeyboard_Private_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_TextEditor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663383);
			GUI.NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Rect_Boolean_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663384);
			GUI.NativeMethodInfoPtr_DoControl_Internal_Static_Boolean_Rect_Int32_Boolean_Boolean_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663385);
			GUI.NativeMethodInfoPtr_DoLabel_Private_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663386);
			GUI.NativeMethodInfoPtr_DoToggle_Internal_Static_Boolean_Rect_Int32_Boolean_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663387);
			GUI.NativeMethodInfoPtr_DoButton_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663388);
			GUI.NativeMethodInfoPtr_Slider_Public_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_Boolean_Int32_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663389);
			GUI.NativeMethodInfoPtr_HorizontalScrollbar_Public_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663390);
			GUI.NativeMethodInfoPtr_ScrollerRepeatButton_Internal_Static_Boolean_Int32_Rect_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663391);
			GUI.NativeMethodInfoPtr_VerticalScrollbar_Public_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663392);
			GUI.NativeMethodInfoPtr_Scroller_Internal_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_GUIStyle_GUIStyle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663393);
			GUI.NativeMethodInfoPtr_BeginGroup_Public_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663394);
			GUI.NativeMethodInfoPtr_BeginGroup_Internal_Static_Void_Rect_GUIContent_GUIStyle_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663395);
			GUI.NativeMethodInfoPtr_EndGroup_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663396);
			GUI.NativeMethodInfoPtr_get_scrollViewStates_Internal_Static_get_GenericStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663397);
			GUI.NativeMethodInfoPtr_BeginScrollView_Internal_Static_Vector2_Rect_Vector2_Rect_Boolean_Boolean_GUIStyle_GUIStyle_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663398);
			GUI.NativeMethodInfoPtr_EndScrollView_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663399);
			GUI.NativeMethodInfoPtr_Window_Public_Static_Rect_Int32_Rect_WindowFunction_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663400);
			GUI.NativeMethodInfoPtr_DoWindow_Private_Static_Rect_Int32_Rect_WindowFunction_GUIContent_GUIStyle_GUISkin_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663401);
			GUI.NativeMethodInfoPtr_CallWindowDelegate_Internal_Static_Void_WindowFunction_Int32_Int32_GUISkin_Int32_Single_Single_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663402);
			GUI.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663403);
			GUI.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663404);
			GUI.NativeMethodInfoPtr_Internal_DoWindow_Injected_Private_Static_Void_Int32_Int32_byref_Rect_WindowFunction_GUIContent_GUIStyle_Object_Boolean_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI>.NativeClassPtr, 100663405);
			GUI.get_changedDelegateField = IL2CPP.ResolveICall<GUI.get_changedDelegate>("UnityEngine.GUI::get_changed");
			GUI.get_depthDelegateField = IL2CPP.ResolveICall<GUI.get_depthDelegate>("UnityEngine.GUI::get_depth");
			GUI.set_depthDelegateField = IL2CPP.ResolveICall<GUI.set_depthDelegate>("UnityEngine.GUI::set_depth");
			GUI.get_isInsideListDelegateField = IL2CPP.ResolveICall<GUI.get_isInsideListDelegate>("UnityEngine.GUI::get_isInsideList");
			GUI.set_isInsideListDelegateField = IL2CPP.ResolveICall<GUI.set_isInsideListDelegate>("UnityEngine.GUI::set_isInsideList");
			GUI.SetNextControlNameDelegateField = IL2CPP.ResolveICall<GUI.SetNextControlNameDelegate>("UnityEngine.GUI::SetNextControlName");
			GUI.GetNameOfFocusedControlDelegateField = IL2CPP.ResolveICall<GUI.GetNameOfFocusedControlDelegate>("UnityEngine.GUI::GetNameOfFocusedControl");
			GUI.FocusControlDelegateField = IL2CPP.ResolveICall<GUI.FocusControlDelegate>("UnityEngine.GUI::FocusControl");
			GUI.Internal_GetTooltipDelegateField = IL2CPP.ResolveICall<GUI.Internal_GetTooltipDelegate>("UnityEngine.GUI::Internal_GetTooltip");
			GUI.Internal_SetTooltipDelegateField = IL2CPP.ResolveICall<GUI.Internal_SetTooltipDelegate>("UnityEngine.GUI::Internal_SetTooltip");
			GUI.Internal_GetMouseTooltipDelegateField = IL2CPP.ResolveICall<GUI.Internal_GetMouseTooltipDelegate>("UnityEngine.GUI::Internal_GetMouseTooltip");
			GUI.BringWindowToFrontDelegateField = IL2CPP.ResolveICall<GUI.BringWindowToFrontDelegate>("UnityEngine.GUI::BringWindowToFront");
			GUI.BringWindowToBackDelegateField = IL2CPP.ResolveICall<GUI.BringWindowToBackDelegate>("UnityEngine.GUI::BringWindowToBack");
			GUI.UnfocusWindowDelegateField = IL2CPP.ResolveICall<GUI.UnfocusWindowDelegate>("UnityEngine.GUI::UnfocusWindow");
			GUI.Internal_BeginWindowsDelegateField = IL2CPP.ResolveICall<GUI.Internal_BeginWindowsDelegate>("UnityEngine.GUI::Internal_BeginWindows");
			GUI.Internal_EndWindowsDelegateField = IL2CPP.ResolveICall<GUI.Internal_EndWindowsDelegate>("UnityEngine.GUI::Internal_EndWindows");
			GUI.Internal_ConcatenateDelegateField = IL2CPP.ResolveICall<GUI.Internal_ConcatenateDelegate>("UnityEngine.GUI::Internal_Concatenate");
			GUI.get_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<GUI.get_backgroundColor_InjectedDelegate>("UnityEngine.GUI::get_backgroundColor_Injected");
			GUI.set_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<GUI.set_backgroundColor_InjectedDelegate>("UnityEngine.GUI::set_backgroundColor_Injected");
			GUI.get_contentColor_InjectedDelegateField = IL2CPP.ResolveICall<GUI.get_contentColor_InjectedDelegate>("UnityEngine.GUI::get_contentColor_Injected");
			GUI.set_contentColor_InjectedDelegateField = IL2CPP.ResolveICall<GUI.set_contentColor_InjectedDelegate>("UnityEngine.GUI::set_contentColor_Injected");
			GUI.Internal_DoModalWindow_InjectedDelegateField = IL2CPP.ResolveICall<GUI.Internal_DoModalWindow_InjectedDelegate>("UnityEngine.GUI::Internal_DoModalWindow_Injected");
			GUI.DragWindow_InjectedDelegateField = IL2CPP.ResolveICall<GUI.DragWindow_InjectedDelegate>("UnityEngine.GUI::DragWindow_Injected");
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000061D4 File Offset: 0x000043D4
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00006204 File Offset: 0x00004404
		public unsafe static Color color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505519, XrefRangeEnd = 505524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_color_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505524, XrefRangeEnd = 505529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000022DB File Offset: 0x000004DB
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00006238 File Offset: 0x00004438
		public unsafe static bool changed
		{
			get
			{
				return GUI.get_changedDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 505533, RefRangeEnd = 505534, XrefRangeStart = 505529, XrefRangeEnd = 505533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_changed_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000626C File Offset: 0x0000446C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000629C File Offset: 0x0000449C
		public unsafe static bool enabled
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 505538, RefRangeEnd = 505547, XrefRangeStart = 505534, XrefRangeEnd = 505538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 505551, RefRangeEnd = 505567, XrefRangeStart = 505547, XrefRangeEnd = 505551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000062D0 File Offset: 0x000044D0
		public unsafe static bool usePageScrollbars
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505567, XrefRangeEnd = 505571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_usePageScrollbars_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00006300 File Offset: 0x00004500
		public unsafe static Material blendMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505571, XrefRangeEnd = 505575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_blendMaterial_Internal_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00006334 File Offset: 0x00004534
		public unsafe static Material blitMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505575, XrefRangeEnd = 505579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_blitMaterial_Internal_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00006368 File Offset: 0x00004568
		public unsafe static Material roundedRectMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 505583, RefRangeEnd = 505585, XrefRangeStart = 505579, XrefRangeEnd = 505583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_roundedRectMaterial_Internal_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000639C File Offset: 0x0000459C
		public unsafe static Material roundedRectWithColorPerBorderMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505585, XrefRangeEnd = 505589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_roundedRectWithColorPerBorderMaterial_Internal_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000063D0 File Offset: 0x000045D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505589, XrefRangeEnd = 505593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GrabMouseControl(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_GrabMouseControl_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006404 File Offset: 0x00004604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505597, RefRangeEnd = 505599, XrefRangeStart = 505593, XrefRangeEnd = 505597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasMouseControl(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_HasMouseControl_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006444 File Offset: 0x00004644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505599, XrefRangeEnd = 505603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseMouseControl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_ReleaseMouseControl_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000646C File Offset: 0x0000466C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505603, XrefRangeEnd = 505607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalRepaintEditorWindow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_InternalRepaintEditorWindow_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006494 File Offset: 0x00004694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505607, XrefRangeEnd = 505612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, Object skin, bool forceRectOnLayout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(title);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skin);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRectOnLayout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Internal_DoWindow_Private_Static_Rect_Int32_Int32_Rect_WindowFunction_GUIContent_GUIStyle_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006548 File Offset: 0x00004748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 505653, RefRangeEnd = 505654, XrefRangeStart = 505612, XrefRangeEnd = 505653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FocusWindow(int windowID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_FocusWindow_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000657C File Offset: 0x0000477C
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000065AC File Offset: 0x000047AC
		public unsafe static int scrollTroughSide
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505654, XrefRangeEnd = 505658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_scrollTroughSide_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505658, XrefRangeEnd = 505662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_scrollTroughSide_Internal_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000065E0 File Offset: 0x000047E0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00006610 File Offset: 0x00004810
		public unsafe static DateTime nextScrollStepTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505662, XrefRangeEnd = 505666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_nextScrollStepTime_Internal_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505666, XrefRangeEnd = 505670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_nextScrollStepTime_Internal_Static_set_Void_DateTime_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000667C File Offset: 0x0000487C
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00006644 File Offset: 0x00004844
		public unsafe static GUISkin skin
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 505690, RefRangeEnd = 505729, XrefRangeStart = 505682, XrefRangeEnd = 505690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_skin_Public_Static_get_GUISkin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 505678, RefRangeEnd = 505682, XrefRangeStart = 505670, XrefRangeEnd = 505678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_skin_Public_Static_set_Void_GUISkin_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000066B0 File Offset: 0x000048B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 505758, RefRangeEnd = 505759, XrefRangeStart = 505729, XrefRangeEnd = 505758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoSetSkin(GUISkin newSkin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSkin);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoSetSkin_Internal_Static_Void_GUISkin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000066E8 File Offset: 0x000048E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505759, XrefRangeEnd = 505767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Label(Rect position, string text, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_String_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00006740 File Offset: 0x00004940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 505775, RefRangeEnd = 505778, XrefRangeStart = 505767, XrefRangeEnd = 505775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Label(Rect position, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Label_Public_Static_Void_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006798 File Offset: 0x00004998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505800, RefRangeEnd = 505802, XrefRangeStart = 505778, XrefRangeEnd = 505800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect position, Texture image)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000067DC File Offset: 0x000049DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505802, XrefRangeEnd = 505820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006830 File Offset: 0x00004A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505820, XrefRangeEnd = 505834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaBlend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00006890 File Offset: 0x00004A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505834, XrefRangeEnd = 505844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaBlend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imageAspect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00006900 File Offset: 0x00004B00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 505865, RefRangeEnd = 505869, XrefRangeStart = 505844, XrefRangeEnd = 505865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaBlend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imageAspect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderWidth;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderRadius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006998 File Offset: 0x00004B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505869, XrefRangeEnd = 505883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaBlend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imageAspect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderWidths;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderRadius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00006A30 File Offset: 0x00004C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505883, XrefRangeEnd = 505891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaBlend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imageAspect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderWidths;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderRadiuses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505891, XrefRangeEnd = 505895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaBlend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imageAspect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderWidths;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderRadiuses;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSmoothCorners;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DrawTexture_Internal_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Vector4_Vector4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00006B70 File Offset: 0x00004D70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 505950, RefRangeEnd = 505954, XrefRangeStart = 505895, XrefRangeEnd = 505950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaBlend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imageAspect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftColor;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topColor;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightColor;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottomColor;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderWidths;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderRadiuses;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSmoothCorners;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DrawTexture_Internal_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Color_Color_Color_Vector4_Vector4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00006C44 File Offset: 0x00004E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 505955, RefRangeEnd = 505956, XrefRangeStart = 505954, XrefRangeEnd = 505955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imageAspect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outScreenRect;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outSourceRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_CalculateScaledTextureRects_Internal_Static_Boolean_Rect_ScaleMode_Single_byref_Rect_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00006CBC File Offset: 0x00004EBC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 505974, RefRangeEnd = 505983, XrefRangeStart = 505956, XrefRangeEnd = 505974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Box(Rect position, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Box_Public_Static_Void_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00006D14 File Offset: 0x00004F14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 505992, RefRangeEnd = 505995, XrefRangeStart = 505983, XrefRangeEnd = 505992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Button_Public_Static_Boolean_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00006D78 File Offset: 0x00004F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506011, RefRangeEnd = 506012, XrefRangeStart = 505995, XrefRangeEnd = 506011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Button(Rect position, int id, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Button_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00006DE8 File Offset: 0x00004FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506034, RefRangeEnd = 506035, XrefRangeStart = 506012, XrefRangeEnd = 506034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focusType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoRepeatButton_Private_Static_Boolean_Rect_GUIContent_GUIStyle_FocusType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006E58 File Offset: 0x00005058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506035, XrefRangeEnd = 506046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PasswordFieldGetStrToShow(string password, char maskChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_PasswordFieldGetStrToShow_Internal_Static_String_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006EA4 File Offset: 0x000050A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506046, XrefRangeEnd = 506054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoTextField_Internal_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006F28 File Offset: 0x00005128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506054, XrefRangeEnd = 506058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secureText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoTextField_Internal_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00006FBC File Offset: 0x000051BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 506108, RefRangeEnd = 506111, XrefRangeStart = 506058, XrefRangeEnd = 506108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secureText);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoTextField_Internal_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007060 File Offset: 0x00005260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506154, RefRangeEnd = 506155, XrefRangeStart = 506111, XrefRangeEnd = 506154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secureText);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskChar;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_HandleTextFieldEventForTouchscreen_Private_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_Char_TextEditor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007118 File Offset: 0x00005318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 506263, RefRangeEnd = 506265, XrefRangeStart = 506155, XrefRangeEnd = 506263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_HandleTextFieldEventForDesktop_Private_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_TextEditor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000071AC File Offset: 0x000053AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506309, RefRangeEnd = 506310, XrefRangeStart = 506265, XrefRangeEnd = 506309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secureText);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_HandleTextFieldEventForDesktopWithForcedKeyboard_Private_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_TextEditor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007254 File Offset: 0x00005454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506328, RefRangeEnd = 506329, XrefRangeStart = 506310, XrefRangeEnd = 506328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Rect_Boolean_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000072C4 File Offset: 0x000054C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 506380, RefRangeEnd = 506384, XrefRangeStart = 506329, XrefRangeEnd = 506380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hover;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoControl_Internal_Static_Boolean_Rect_Int32_Boolean_Boolean_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00007354 File Offset: 0x00005554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506416, RefRangeEnd = 506417, XrefRangeStart = 506384, XrefRangeEnd = 506416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoLabel(Rect position, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoLabel_Private_Static_Void_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000073AC File Offset: 0x000055AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506417, XrefRangeEnd = 506426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoToggle_Internal_Static_Boolean_Rect_Int32_Boolean_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000742C File Offset: 0x0000562C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506426, XrefRangeEnd = 506435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoButton_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000749C File Offset: 0x0000569C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506460, RefRangeEnd = 506461, XrefRangeStart = 506435, XrefRangeEnd = 506460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(slider);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thumb);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horiz;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thumbExtent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Slider_Public_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_Boolean_Int32_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007568 File Offset: 0x00005768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506461, XrefRangeEnd = 506483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_HorizontalScrollbar_Public_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000075F0 File Offset: 0x000057F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 506519, RefRangeEnd = 506521, XrefRangeStart = 506483, XrefRangeEnd = 506519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_ScrollerRepeatButton_Internal_Static_Boolean_Int32_Rect_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007650 File Offset: 0x00005850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506521, XrefRangeEnd = 506543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottomValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_VerticalScrollbar_Public_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000076D8 File Offset: 0x000058D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 506596, RefRangeEnd = 506600, XrefRangeStart = 506543, XrefRangeEnd = 506596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(slider);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thumb);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leftButton);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightButton);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horiz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Scroller_Internal_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_GUIStyle_GUIStyle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000077AC File Offset: 0x000059AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506600, XrefRangeEnd = 506606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_BeginGroup_Public_Static_Void_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007804 File Offset: 0x00005A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 506640, RefRangeEnd = 506642, XrefRangeStart = 506606, XrefRangeEnd = 506640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_BeginGroup_Internal_Static_Void_Rect_GUIContent_GUIStyle_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007868 File Offset: 0x00005A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506642, XrefRangeEnd = 506650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndGroup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_EndGroup_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00007890 File Offset: 0x00005A90
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002584 File Offset: 0x00000784
		public unsafe static GenericStack scrollViewStates
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506650, XrefRangeEnd = 506654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_scrollViewStates_Internal_Static_get_GenericStack_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericStack>(intPtr3) : null;
			}
			set
			{
				GUI._scrollViewStates_k__BackingField = value;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000078C4 File Offset: 0x00005AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506834, RefRangeEnd = 506835, XrefRangeStart = 506654, XrefRangeEnd = 506834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alwaysShowHorizontal;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alwaysShowVertical;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(horizontalScrollbar);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(verticalScrollbar);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(background);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_BeginScrollView_Internal_Static_Vector2_Rect_Vector2_Rect_Boolean_Boolean_GUIStyle_GUIStyle_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00007974 File Offset: 0x00005B74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 506945, RefRangeEnd = 506947, XrefRangeStart = 506835, XrefRangeEnd = 506945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndScrollView(bool handleScrollWheel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleScrollWheel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_EndScrollView_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000079A8 File Offset: 0x00005BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506968, RefRangeEnd = 506969, XrefRangeStart = 506947, XrefRangeEnd = 506968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientRect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Window_Public_Static_Rect_Int32_Rect_WindowFunction_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00007A2C File Offset: 0x00005C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506969, XrefRangeEnd = 506982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect DoWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientRect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skin);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRectOnLayout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_DoWindow_Private_Static_Rect_Int32_Rect_WindowFunction_GUIContent_GUIStyle_GUISkin_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506982, XrefRangeEnd = 507039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_skin);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_CallWindowDelegate_Internal_Static_Void_WindowFunction_Int32_Int32_GUISkin_Int32_Single_Single_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00007B74 File Offset: 0x00005D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507039, XrefRangeEnd = 507043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_color_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507043, XrefRangeEnd = 507047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_color_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00007BDC File Offset: 0x00005DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507047, XrefRangeEnd = 507051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, Object skin, bool forceRectOnLayout, out Rect ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &clientRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(title);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skin);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRectOnLayout;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.NativeMethodInfoPtr_Internal_DoWindow_Injected_Private_Static_Void_Int32_Int32_byref_Rect_WindowFunction_GUIContent_GUIStyle_Object_Boolean_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000021E6 File Offset: 0x000003E6
		public GUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00007C94 File Offset: 0x00005E94
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000021EF File Offset: 0x000003EF
		public unsafe static int s_ScrollControlId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ScrollControlId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ScrollControlId, (void*)(&value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00007CB0 File Offset: 0x00005EB0
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000021FD File Offset: 0x000003FD
		public unsafe static int s_HotTextField
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_HotTextField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_HotTextField, (void*)(&value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00007CCC File Offset: 0x00005ECC
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000220B File Offset: 0x0000040B
		public unsafe static int s_BoxHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_BoxHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_BoxHash, (void*)(&value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00007CE8 File Offset: 0x00005EE8
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002219 File Offset: 0x00000419
		public unsafe static int s_ButonHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ButonHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ButonHash, (void*)(&value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00007D04 File Offset: 0x00005F04
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002227 File Offset: 0x00000427
		public unsafe static int s_RepeatButtonHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_RepeatButtonHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_RepeatButtonHash, (void*)(&value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00007D20 File Offset: 0x00005F20
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002235 File Offset: 0x00000435
		public unsafe static int s_ToggleHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ToggleHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ToggleHash, (void*)(&value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00007D3C File Offset: 0x00005F3C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002243 File Offset: 0x00000443
		public unsafe static int s_ButtonGridHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ButtonGridHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ButtonGridHash, (void*)(&value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00007D58 File Offset: 0x00005F58
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002251 File Offset: 0x00000451
		public unsafe static int s_SliderHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_SliderHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_SliderHash, (void*)(&value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00007D74 File Offset: 0x00005F74
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000225F File Offset: 0x0000045F
		public unsafe static int s_BeginGroupHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_BeginGroupHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_BeginGroupHash, (void*)(&value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00007D90 File Offset: 0x00005F90
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000226D File Offset: 0x0000046D
		public unsafe static int s_ScrollviewHash
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ScrollviewHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ScrollviewHash, (void*)(&value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00007DAC File Offset: 0x00005FAC
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000227B File Offset: 0x0000047B
		public unsafe static int _scrollTroughSide_k__BackingField
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr__scrollTroughSide_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr__scrollTroughSide_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00007DC8 File Offset: 0x00005FC8
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002289 File Offset: 0x00000489
		public unsafe static DateTime _nextScrollStepTime_k__BackingField
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr__nextScrollStepTime_k__BackingField, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr__nextScrollStepTime_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00007DE4 File Offset: 0x00005FE4
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002297 File Offset: 0x00000497
		public unsafe static GUISkin s_Skin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_Skin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_Skin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00007E0C File Offset: 0x0000600C
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000022A9 File Offset: 0x000004A9
		public unsafe static Rect s_ToolTipRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr_s_ToolTipRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr_s_ToolTipRect, (void*)(&value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00007E28 File Offset: 0x00006028
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000022B7 File Offset: 0x000004B7
		public unsafe static GenericStack _scrollViewStates_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUI.NativeFieldInfoPtr__scrollViewStates_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericStack>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUI.NativeFieldInfoPtr__scrollViewStates_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00007E50 File Offset: 0x00006050
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000022C9 File Offset: 0x000004C9
		public static Color backgroundColor
		{
			get
			{
				Color color;
				GUI.get_backgroundColor_Injected(out color);
				return color;
			}
			set
			{
				GUI.set_backgroundColor_Injected(ref value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00007E68 File Offset: 0x00006068
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000022D2 File Offset: 0x000004D2
		public static Color contentColor
		{
			get
			{
				Color color;
				GUI.get_contentColor_Injected(out color);
				return color;
			}
			set
			{
				GUI.set_contentColor_Injected(ref value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000022E7 File Offset: 0x000004E7
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000022F3 File Offset: 0x000004F3
		public static int depth
		{
			get
			{
				return GUI.get_depthDelegateField();
			}
			set
			{
				GUI.set_depthDelegateField(value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002300 File Offset: 0x00000500
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000230C File Offset: 0x0000050C
		public static bool isInsideList
		{
			get
			{
				return GUI.get_isInsideListDelegateField();
			}
			set
			{
				GUI.set_isInsideListDelegateField(value);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002319 File Offset: 0x00000519
		public static void SetNextControlName(string name)
		{
			GUI.SetNextControlNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00007E80 File Offset: 0x00006080
		public static string GetNameOfFocusedControl()
		{
			IntPtr intPtr = GUI.GetNameOfFocusedControlDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000232B File Offset: 0x0000052B
		public static void FocusControl(string name)
		{
			GUI.FocusControlDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00007EA0 File Offset: 0x000060A0
		public static string Internal_GetTooltip()
		{
			IntPtr intPtr = GUI.Internal_GetTooltipDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000233D File Offset: 0x0000053D
		public static void Internal_SetTooltip(string value)
		{
			GUI.Internal_SetTooltipDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00007EC0 File Offset: 0x000060C0
		public static string Internal_GetMouseTooltip()
		{
			IntPtr intPtr = GUI.Internal_GetMouseTooltipDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00007EE0 File Offset: 0x000060E0
		public static Rect Internal_DoModalWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Object skin)
		{
			Rect rect;
			GUI.Internal_DoModalWindow_Injected(id, instanceID, ref clientRect, func, content, style, skin, out rect);
			return rect;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000234F File Offset: 0x0000054F
		public static void DragWindow(Rect position)
		{
			GUI.DragWindow_Injected(ref position);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002358 File Offset: 0x00000558
		public static void BringWindowToFront(int windowID)
		{
			GUI.BringWindowToFrontDelegateField(windowID);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002365 File Offset: 0x00000565
		public static void BringWindowToBack(int windowID)
		{
			GUI.BringWindowToBackDelegateField(windowID);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002372 File Offset: 0x00000572
		public static void UnfocusWindow()
		{
			GUI.UnfocusWindowDelegateField();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000237E File Offset: 0x0000057E
		public static void Internal_BeginWindows()
		{
			GUI.Internal_BeginWindowsDelegateField();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000238A File Offset: 0x0000058A
		public static void Internal_EndWindows()
		{
			GUI.Internal_EndWindowsDelegateField();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00007F00 File Offset: 0x00006100
		public static string Internal_Concatenate(GUIContent first, GUIContent second)
		{
			IntPtr intPtr = GUI.Internal_ConcatenateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(first), IL2CPP.Il2CppObjectBaseToPtr(second));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002396 File Offset: 0x00000596
		public static void CleanupRoots()
		{
			GUI.s_Skin = null;
			GUIUtility.CleanupRoots();
			GUILayoutUtility.CleanupRoots();
			GUISkin.CleanupRoots();
			GUIStyle.CleanupRoots();
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00007F2C File Offset: 0x0000612C
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000023B7 File Offset: 0x000005B7
		public static Matrix4x4 matrix
		{
			get
			{
				return GUIClip.GetMatrix();
			}
			set
			{
				GUIClip.SetMatrix(value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00007F44 File Offset: 0x00006144
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000023C1 File Offset: 0x000005C1
		public static string tooltip
		{
			get
			{
				string text = GUI.Internal_GetTooltip();
				bool flag = text != null;
				string text2;
				if (flag)
				{
					text2 = text;
				}
				else
				{
					text2 = "";
				}
				return text2;
			}
			set
			{
				GUI.Internal_SetTooltip(value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000023CB File Offset: 0x000005CB
		public static string mouseTooltip
		{
			get
			{
				return GUI.Internal_GetMouseTooltip();
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00007F70 File Offset: 0x00006170
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000023D2 File Offset: 0x000005D2
		public static Rect tooltipRect
		{
			get
			{
				return GUI.s_ToolTipRect;
			}
			set
			{
				GUI.s_ToolTipRect = value;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000023DB File Offset: 0x000005DB
		public static void Label(Rect position, string text)
		{
			GUI.Label(position, GUIContent.Temp(text), GUI.s_Skin.label);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000023F5 File Offset: 0x000005F5
		public static void Label(Rect position, Texture image)
		{
			GUI.Label(position, GUIContent.Temp(image), GUI.s_Skin.label);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000240F File Offset: 0x0000060F
		public static void Label(Rect position, GUIContent content)
		{
			GUI.Label(position, content, GUI.s_Skin.label);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002424 File Offset: 0x00000624
		public static void Label(Rect position, Texture image, GUIStyle style)
		{
			GUI.Label(position, GUIContent.Temp(image), style);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007F88 File Offset: 0x00006188
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses)
		{
			GUI.DrawTexture(position, image, scaleMode, alphaBlend, imageAspect, leftColor, topColor, rightColor, bottomColor, borderWidths, borderRadiuses, true);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002435 File Offset: 0x00000635
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords)
		{
			GUI.DrawTextureWithTexCoords(position, image, texCoords, true);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007FB0 File Offset: 0x000061B0
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend)
		{
			GUIUtility.CheckOnGUI();
			bool flag = Event.current.type == EventType.Repaint;
			if (flag)
			{
				Material material = (alphaBlend ? GUI.blendMaterial : GUI.blitMaterial);
				Internal_DrawTextureArguments internal_DrawTextureArguments = null;
				internal_DrawTextureArguments.texture = image;
				internal_DrawTextureArguments.mat = material;
				internal_DrawTextureArguments.leftBorder = 0;
				internal_DrawTextureArguments.rightBorder = 0;
				internal_DrawTextureArguments.topBorder = 0;
				internal_DrawTextureArguments.bottomBorder = 0;
				internal_DrawTextureArguments.color = GUI.color;
				internal_DrawTextureArguments.leftBorderColor = GUI.color;
				internal_DrawTextureArguments.topBorderColor = GUI.color;
				internal_DrawTextureArguments.rightBorderColor = GUI.color;
				internal_DrawTextureArguments.bottomBorderColor = GUI.color;
				internal_DrawTextureArguments.screenRect = position;
				internal_DrawTextureArguments.sourceRect = texCoords;
				Graphics.Internal_DrawTexture(ref internal_DrawTextureArguments);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002442 File Offset: 0x00000642
		public static void Box(Rect position, string text)
		{
			GUI.Box(position, GUIContent.Temp(text), GUI.s_Skin.box);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000245C File Offset: 0x0000065C
		public static void Box(Rect position, Texture image)
		{
			GUI.Box(position, GUIContent.Temp(image), GUI.s_Skin.box);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002476 File Offset: 0x00000676
		public static void Box(Rect position, GUIContent content)
		{
			GUI.Box(position, content, GUI.s_Skin.box);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000248B File Offset: 0x0000068B
		public static void Box(Rect position, string text, GUIStyle style)
		{
			GUI.Box(position, GUIContent.Temp(text), style);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000249C File Offset: 0x0000069C
		public static void Box(Rect position, Texture image, GUIStyle style)
		{
			GUI.Box(position, GUIContent.Temp(image), style);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00008078 File Offset: 0x00006278
		public static bool Button(Rect position, string text)
		{
			return GUI.Button(position, GUIContent.Temp(text), GUI.s_Skin.button);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000080A0 File Offset: 0x000062A0
		public static bool Button(Rect position, Texture image)
		{
			return GUI.Button(position, GUIContent.Temp(image), GUI.s_Skin.button);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000080C8 File Offset: 0x000062C8
		public static bool Button(Rect position, GUIContent content)
		{
			return GUI.Button(position, content, GUI.s_Skin.button);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000080EC File Offset: 0x000062EC
		public static bool Button(Rect position, string text, GUIStyle style)
		{
			return GUI.Button(position, GUIContent.Temp(text), style);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000810C File Offset: 0x0000630C
		public static bool Button(Rect position, Texture image, GUIStyle style)
		{
			return GUI.Button(position, GUIContent.Temp(image), style);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000812C File Offset: 0x0000632C
		public static bool RepeatButton(Rect position, string text)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(text), GUI.s_Skin.button, FocusType.Passive);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008158 File Offset: 0x00006358
		public static bool RepeatButton(Rect position, Texture image)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(image), GUI.s_Skin.button, FocusType.Passive);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008184 File Offset: 0x00006384
		public static bool RepeatButton(Rect position, GUIContent content)
		{
			return GUI.DoRepeatButton(position, content, GUI.s_Skin.button, FocusType.Passive);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000081A8 File Offset: 0x000063A8
		public static bool RepeatButton(Rect position, string text, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(text), style, FocusType.Passive);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000081C8 File Offset: 0x000063C8
		public static bool RepeatButton(Rect position, Texture image, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, GUIContent.Temp(image), style, FocusType.Passive);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000081E8 File Offset: 0x000063E8
		public static bool RepeatButton(Rect position, GUIContent content, GUIStyle style)
		{
			return GUI.DoRepeatButton(position, content, style, FocusType.Passive);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00008204 File Offset: 0x00006404
		public static string TextField(Rect position, string text)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, -1, GUI.skin.textField);
			return guicontent.text;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00008240 File Offset: 0x00006440
		public static string TextField(Rect position, string text, int maxLength)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, GUI.skin.textField);
			return guicontent.text;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000827C File Offset: 0x0000647C
		public static string TextField(Rect position, string text, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, -1, style);
			return guicontent.text;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000082B0 File Offset: 0x000064B0
		public static string TextField(Rect position, string text, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000082E4 File Offset: 0x000064E4
		public static string PasswordField(Rect position, string password, char maskChar)
		{
			return GUI.PasswordField(position, password, maskChar, -1, GUI.skin.textField);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000830C File Offset: 0x0000650C
		public static string PasswordField(Rect position, string password, char maskChar, int maxLength)
		{
			return GUI.PasswordField(position, password, maskChar, maxLength, GUI.skin.textField);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00008334 File Offset: 0x00006534
		public static string PasswordField(Rect position, string password, char maskChar, GUIStyle style)
		{
			return GUI.PasswordField(position, password, maskChar, -1, style);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00008350 File Offset: 0x00006550
		public static string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			string text = GUI.PasswordFieldGetStrToShow(password, maskChar);
			GUIContent guicontent = GUIContent.Temp(text);
			bool changed = GUI.changed;
			GUI.changed = false;
			bool flag = TouchScreenKeyboard.isSupported && !TouchScreenKeyboard.isInPlaceEditingAllowed;
			if (flag)
			{
				GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard), guicontent, false, maxLength, style, password, maskChar);
			}
			else
			{
				GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, false, maxLength, style);
			}
			text = (GUI.changed ? guicontent.text : password);
			GUI.changed = GUI.changed || changed;
			return text;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000083E4 File Offset: 0x000065E4
		public static string TextArea(Rect position, string text)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, -1, GUI.skin.textArea);
			return guicontent.text;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00008420 File Offset: 0x00006620
		public static string TextArea(Rect position, string text, int maxLength)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, maxLength, GUI.skin.textArea);
			return guicontent.text;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000845C File Offset: 0x0000665C
		public static string TextArea(Rect position, string text, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, -1, style);
			return guicontent.text;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00008490 File Offset: 0x00006690
		public static string TextArea(Rect position, string text, int maxLength, GUIStyle style)
		{
			GUIContent guicontent = GUIContent.Temp(text);
			GUI.DoTextField(position, GUIUtility.GetControlID(FocusType.Keyboard, position), guicontent, true, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000084C4 File Offset: 0x000066C4
		public static bool Toggle(Rect position, bool value, string text)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(text), GUI.s_Skin.toggle);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000084F0 File Offset: 0x000066F0
		public static bool Toggle(Rect position, bool value, Texture image)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(image), GUI.s_Skin.toggle);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000851C File Offset: 0x0000671C
		public static bool Toggle(Rect position, bool value, GUIContent content)
		{
			return GUI.Toggle(position, value, content, GUI.s_Skin.toggle);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00008540 File Offset: 0x00006740
		public static bool Toggle(Rect position, bool value, string text, GUIStyle style)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(text), style);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00008560 File Offset: 0x00006760
		public static bool Toggle(Rect position, bool value, Texture image, GUIStyle style)
		{
			return GUI.Toggle(position, value, GUIContent.Temp(image), style);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00008580 File Offset: 0x00006780
		public static bool Toggle(Rect position, int id, bool value, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoToggle(position, id, value, content, style);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000085A4 File Offset: 0x000067A4
		public static int Toolbar(Rect position, int selected, Il2CppStringArray texts)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(texts), GUI.s_Skin.button);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000085D0 File Offset: 0x000067D0
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<Texture> images)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(images), GUI.s_Skin.button);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000085FC File Offset: 0x000067FC
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents)
		{
			return GUI.Toolbar(position, selected, contents, GUI.s_Skin.button);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00008620 File Offset: 0x00006820
		public static int Toolbar(Rect position, int selected, Il2CppStringArray texts, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(texts), style);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00008640 File Offset: 0x00006840
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<Texture> images, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, GUIContent.Temp(images), style);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00008660 File Offset: 0x00006860
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style)
		{
			return GUI.Toolbar(position, selected, contents, null, style, GUI.ToolbarButtonSize.Fixed, null);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00008680 File Offset: 0x00006880
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize)
		{
			return GUI.Toolbar(position, selected, contents, null, style, buttonSize, null);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000086A0 File Offset: 0x000068A0
		public static int Toolbar(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStringArray controlNames, GUIStyle style, GUI.ToolbarButtonSize buttonSize, [Optional] Il2CppStructArray<bool> contentsEnabled)
		{
			GUIUtility.CheckOnGUI();
			GUIStyle guistyle;
			GUIStyle guistyle2;
			GUIStyle guistyle3;
			GUI.FindStyles(ref style, out guistyle, out guistyle2, out guistyle3, "left", "mid", "right");
			return GUI.DoButtonGrid(position, selected, contents, controlNames, contents.Length, style, guistyle, guistyle2, guistyle3, buttonSize, contentsEnabled);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000086F0 File Offset: 0x000068F0
		public static int SelectionGrid(Rect position, int selected, Il2CppStringArray texts, int xCount)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(texts), xCount, null);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00008714 File Offset: 0x00006914
		public static int SelectionGrid(Rect position, int selected, Il2CppReferenceArray<Texture> images, int xCount)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(images), xCount, null);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00008738 File Offset: 0x00006938
		public static int SelectionGrid(Rect position, int selected, Il2CppReferenceArray<GUIContent> content, int xCount)
		{
			return GUI.SelectionGrid(position, selected, content, xCount, null);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00008754 File Offset: 0x00006954
		public static int SelectionGrid(Rect position, int selected, Il2CppStringArray texts, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(texts), xCount, style);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00008778 File Offset: 0x00006978
		public static int SelectionGrid(Rect position, int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style)
		{
			return GUI.SelectionGrid(position, selected, GUIContent.Temp(images), xCount, style);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000879C File Offset: 0x0000699C
		public static int SelectionGrid(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style)
		{
			bool flag = style == null;
			if (flag)
			{
				style = GUI.s_Skin.button;
			}
			return GUI.DoButtonGrid(position, selected, contents, null, xCount, style, style, style, style, GUI.ToolbarButtonSize.Fixed, null);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000087D8 File Offset: 0x000069D8
		public static void FindStyles(ref GUIStyle style, out GUIStyle firstStyle, out GUIStyle midStyle, out GUIStyle lastStyle, string first, string mid, string last)
		{
			bool flag = style == null;
			if (flag)
			{
				style = GUI.skin.button;
			}
			string name = style.name;
			midStyle = GUI.skin.FindStyle(String.Concat(name, mid)) ?? style;
			firstStyle = GUI.skin.FindStyle(String.Concat(name, first)) ?? midStyle;
			lastStyle = GUI.skin.FindStyle(String.Concat(name, last)) ?? midStyle;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00008854 File Offset: 0x00006A54
		public static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			bool flag = xCount < 2;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				bool flag2 = xCount == 2;
				if (flag2)
				{
					num = Mathf.Max(firstStyle.margin.right, lastStyle.margin.left);
				}
				else
				{
					int num2 = Mathf.Max(midStyle.margin.left, midStyle.margin.right);
					num = Mathf.Max(firstStyle.margin.right, midStyle.margin.left) + Mathf.Max(midStyle.margin.right, lastStyle.margin.left) + num2 * (xCount - 3);
				}
			}
			return num;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000024AD File Offset: 0x000006AD
		public static int DoButtonGrid(Rect position, int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStringArray controlNames, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, [Optional] Il2CppStructArray<bool> contentsEnabled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000024BA File Offset: 0x000006BA
		public static Il2CppStructArray<Rect> CalcMouseRects(Rect position, Il2CppReferenceArray<GUIContent> contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders, GUI.ToolbarButtonSize buttonSize)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000088F8 File Offset: 0x00006AF8
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, true, 0, GUI.skin.horizontalSliderThumbExtent);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008938 File Offset: 0x00006B38
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, slider, thumb, true, 0, null);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008960 File Offset: 0x00006B60
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle thumbExtent)
		{
			return GUI.Slider(position, value, 0f, leftValue, rightValue, slider, thumb, true, 0, (thumbExtent == null && thumb == GUI.skin.horizontalSliderThumb) ? GUI.skin.horizontalSliderThumbExtent : thumbExtent);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000089A8 File Offset: 0x00006BA8
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, false, 0, GUI.skin.verticalSliderThumbExtent);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000089E8 File Offset: 0x00006BE8
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, slider, thumb, false, 0, null);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00008A10 File Offset: 0x00006C10
		public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb, GUIStyle thumbExtent)
		{
			return GUI.Slider(position, value, 0f, topValue, bottomValue, slider, thumb, false, 0, (thumbExtent == null && thumb == GUI.skin.verticalSliderThumb) ? GUI.skin.verticalSliderThumbExtent : thumbExtent);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00008A58 File Offset: 0x00006C58
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue)
		{
			return GUI.Scroller(position, value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, GUI.skin.horizontalScrollbarThumb, GUI.skin.horizontalScrollbarLeftButton, GUI.skin.horizontalScrollbarRightButton, true);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008AA0 File Offset: 0x00006CA0
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue)
		{
			return GUI.Scroller(position, value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, GUI.skin.verticalScrollbarThumb, GUI.skin.verticalScrollbarUpButton, GUI.skin.verticalScrollbarDownButton, false);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000024C7 File Offset: 0x000006C7
		public static void BeginClip(Rect position, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Push(position, scrollOffset, renderOffset, resetOffset);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000024DA File Offset: 0x000006DA
		public static void BeginGroup(Rect position)
		{
			GUI.BeginGroup(position, GUIContent.none, GUIStyle.none);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000024EE File Offset: 0x000006EE
		public static void BeginGroup(Rect position, string text)
		{
			GUI.BeginGroup(position, GUIContent.Temp(text), GUIStyle.none);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002503 File Offset: 0x00000703
		public static void BeginGroup(Rect position, Texture image)
		{
			GUI.BeginGroup(position, GUIContent.Temp(image), GUIStyle.none);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002518 File Offset: 0x00000718
		public static void BeginGroup(Rect position, GUIContent content)
		{
			GUI.BeginGroup(position, content, GUIStyle.none);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002528 File Offset: 0x00000728
		public static void BeginGroup(Rect position, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.none, style);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002538 File Offset: 0x00000738
		public static void BeginGroup(Rect position, string text, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.Temp(text), style);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002549 File Offset: 0x00000749
		public static void BeginGroup(Rect position, Texture image, GUIStyle style)
		{
			GUI.BeginGroup(position, GUIContent.Temp(image), style);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000255A File Offset: 0x0000075A
		public static void BeginClip(Rect position)
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Push(position, Vector2.zero, Vector2.zero, false);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002575 File Offset: 0x00000775
		public static void EndClip()
		{
			GUIUtility.CheckOnGUI();
			GUIClip.Pop();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008AE8 File Offset: 0x00006CE8
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008B24 File Offset: 0x00006D24
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00008B60 File Offset: 0x00006D60
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00008B8C File Offset: 0x00006D8C
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00008BB8 File Offset: 0x00006DB8
		public static Vector2 DoBeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			return GUI.BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000258C File Offset: 0x0000078C
		public static void EndScrollView()
		{
			GUI.EndScrollView(true);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00008BDC File Offset: 0x00006DDC
		public static ScrollViewState GetTopScrollView()
		{
			bool flag = GUI.scrollViewStates.Count != 0;
			ScrollViewState scrollViewState;
			if (flag)
			{
				scrollViewState = GUI.scrollViewStates.Peek().Cast<ScrollViewState>();
			}
			else
			{
				scrollViewState = null;
			}
			return scrollViewState;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00008C14 File Offset: 0x00006E14
		public static void ScrollTo(Rect position)
		{
			ScrollViewState topScrollView = GUI.GetTopScrollView();
			if (topScrollView != null)
			{
				topScrollView.ScrollTo(position);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00008C38 File Offset: 0x00006E38
		public static bool ScrollTowards(Rect position, float maxDelta)
		{
			ScrollViewState topScrollView = GUI.GetTopScrollView();
			bool flag = topScrollView == null;
			return !flag && topScrollView.ScrollTowards(position, maxDelta);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00008C64 File Offset: 0x00006E64
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(text), GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008C9C File Offset: 0x00006E9C
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(image), GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00008CD4 File Offset: 0x00006ED4
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, content, GUI.skin.window, GUI.skin, true);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00008D08 File Offset: 0x00006F08
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(text), style, GUI.skin, true);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00008D38 File Offset: 0x00006F38
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoWindow(id, clientRect, func, GUIContent.Temp(image), style, GUI.skin, true);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008D68 File Offset: 0x00006F68
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(text), GUI.skin.window, GUI.skin);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00008DA0 File Offset: 0x00006FA0
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(image), GUI.skin.window, GUI.skin);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00008DD8 File Offset: 0x00006FD8
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, content, GUI.skin.window, GUI.skin);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00008E08 File Offset: 0x00007008
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(text), style, GUI.skin);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00008E38 File Offset: 0x00007038
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, GUIContent.Temp(image), style, GUI.skin);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00008E68 File Offset: 0x00007068
		public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style)
		{
			GUIUtility.CheckOnGUI();
			return GUI.DoModalWindow(id, clientRect, func, content, style, GUI.skin);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00008E90 File Offset: 0x00007090
		public static Rect DoModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin)
		{
			return GUI.Internal_DoModalWindow(id, GUIUtility.s_OriginalID, clientRect, func, content, style, skin);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002596 File Offset: 0x00000796
		public static void DragWindow()
		{
			GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00008EB4 File Offset: 0x000070B4
		public static void BeginWindows(int skinMode, int editorWindowInstanceID)
		{
			GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
			GenericStack layoutGroups = GUILayoutUtility.current.layoutGroups;
			GUILayoutGroup windows = GUILayoutUtility.current.windows;
			Matrix4x4 matrix = GUI.matrix;
			GUI.Internal_BeginWindows();
			GUI.matrix = matrix;
			GUILayoutUtility.current.topLevel = topLevel;
			GUILayoutUtility.current.layoutGroups = layoutGroups;
			GUILayoutUtility.current.windows = windows;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00008F18 File Offset: 0x00007118
		public static void EndWindows()
		{
			GUILayoutGroup topLevel = GUILayoutUtility.current.topLevel;
			GenericStack layoutGroups = GUILayoutUtility.current.layoutGroups;
			GUILayoutGroup windows = GUILayoutUtility.current.windows;
			GUI.Internal_EndWindows();
			GUILayoutUtility.current.topLevel = topLevel;
			GUILayoutUtility.current.layoutGroups = layoutGroups;
			GUILayoutUtility.current.windows = windows;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000025B8 File Offset: 0x000007B8
		public static void get_backgroundColor_Injected(out Color ret)
		{
			GUI.get_backgroundColor_InjectedDelegateField(out ret);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000025C5 File Offset: 0x000007C5
		public static void set_backgroundColor_Injected(ref Color value)
		{
			GUI.set_backgroundColor_InjectedDelegateField(ref value);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000025D2 File Offset: 0x000007D2
		public static void get_contentColor_Injected(out Color ret)
		{
			GUI.get_contentColor_InjectedDelegateField(out ret);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000025DF File Offset: 0x000007DF
		public static void set_contentColor_Injected(ref Color value)
		{
			GUI.set_contentColor_InjectedDelegateField(ref value);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008F70 File Offset: 0x00007170
		public static void Internal_DoModalWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Object skin, out Rect ret)
		{
			GUI.Internal_DoModalWindow_InjectedDelegateField(id, instanceID, ref clientRect, IL2CPP.Il2CppObjectBaseToPtr(func), IL2CPP.Il2CppObjectBaseToPtr(content), IL2CPP.Il2CppObjectBaseToPtr(style), IL2CPP.Il2CppObjectBaseToPtr(skin), out ret);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000025EC File Offset: 0x000007EC
		public static void DragWindow_Injected(ref Rect position)
		{
			GUI.DragWindow_InjectedDelegateField(ref position);
		}

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_s_ScrollControlId;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_s_HotTextField;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_s_BoxHash;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_s_ButonHash;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_s_RepeatButtonHash;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_s_ToggleHash;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_s_ButtonGridHash;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_s_SliderHash;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_s_BeginGroupHash;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_s_ScrollviewHash;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr__scrollTroughSide_k__BackingField;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr__nextScrollStepTime_k__BackingField;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_s_Skin;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_s_ToolTipRect;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr__scrollViewStates_k__BackingField;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Static_get_Color_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_set_changed_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_usePageScrollbars_Internal_Static_get_Boolean_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_blendMaterial_Internal_Static_get_Material_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_blitMaterial_Internal_Static_get_Material_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_roundedRectMaterial_Internal_Static_get_Material_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_get_roundedRectWithColorPerBorderMaterial_Internal_Static_get_Material_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_GrabMouseControl_Internal_Static_Void_Int32_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_HasMouseControl_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseMouseControl_Internal_Static_Void_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_InternalRepaintEditorWindow_Internal_Static_Void_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DoWindow_Private_Static_Rect_Int32_Int32_Rect_WindowFunction_GUIContent_GUIStyle_Object_Boolean_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_FocusWindow_Public_Static_Void_Int32_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollTroughSide_Internal_Static_get_Int32_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollTroughSide_Internal_Static_set_Void_Int32_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_nextScrollStepTime_Internal_Static_get_DateTime_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_set_nextScrollStepTime_Internal_Static_set_Void_DateTime_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_set_skin_Public_Static_set_Void_GUISkin_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_skin_Public_Static_get_GUISkin_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_DoSetSkin_Internal_Static_Void_GUISkin_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_Label_Public_Static_Void_Rect_String_GUIStyle_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_Label_Public_Static_Void_Rect_GUIContent_GUIStyle_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Single_Single_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Vector4_Single_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Public_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Vector4_Vector4_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Internal_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Vector4_Vector4_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_DrawTexture_Internal_Static_Void_Rect_Texture_ScaleMode_Boolean_Single_Color_Color_Color_Color_Vector4_Vector4_Boolean_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_CalculateScaledTextureRects_Internal_Static_Boolean_Rect_ScaleMode_Single_byref_Rect_byref_Rect_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_Void_Rect_GUIContent_GUIStyle_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_Button_Public_Static_Boolean_Rect_GUIContent_GUIStyle_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_Button_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_DoRepeatButton_Private_Static_Boolean_Rect_GUIContent_GUIStyle_FocusType_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_PasswordFieldGetStrToShow_Internal_Static_String_String_Char_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_DoTextField_Internal_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_DoTextField_Internal_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_DoTextField_Internal_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_Char_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_HandleTextFieldEventForTouchscreen_Private_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_Char_TextEditor_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_HandleTextFieldEventForDesktop_Private_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_TextEditor_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_HandleTextFieldEventForDesktopWithForcedKeyboard_Private_Static_Void_Rect_Int32_GUIContent_Boolean_Int32_GUIStyle_String_TextEditor_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Static_Boolean_Rect_Boolean_GUIContent_GUIStyle_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_DoControl_Internal_Static_Boolean_Rect_Int32_Boolean_Boolean_GUIContent_GUIStyle_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_DoLabel_Private_Static_Void_Rect_GUIContent_GUIStyle_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_DoToggle_Internal_Static_Boolean_Rect_Int32_Boolean_GUIContent_GUIStyle_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_DoButton_Internal_Static_Boolean_Rect_Int32_GUIContent_GUIStyle_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_Slider_Public_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_Boolean_Int32_GUIStyle_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_HorizontalScrollbar_Public_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_ScrollerRepeatButton_Internal_Static_Boolean_Int32_Rect_GUIStyle_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_VerticalScrollbar_Public_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_Scroller_Internal_Static_Single_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_GUIStyle_GUIStyle_Boolean_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_BeginGroup_Public_Static_Void_Rect_GUIContent_GUIStyle_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_BeginGroup_Internal_Static_Void_Rect_GUIContent_GUIStyle_Vector2_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_EndGroup_Public_Static_Void_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollViewStates_Internal_Static_get_GenericStack_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_BeginScrollView_Internal_Static_Vector2_Rect_Vector2_Rect_Boolean_Boolean_GUIStyle_GUIStyle_GUIStyle_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_EndScrollView_Public_Static_Void_Boolean_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_Window_Public_Static_Rect_Int32_Rect_WindowFunction_GUIContent_GUIStyle_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_DoWindow_Private_Static_Rect_Int32_Rect_WindowFunction_GUIContent_GUIStyle_GUISkin_Boolean_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_CallWindowDelegate_Internal_Static_Void_WindowFunction_Int32_Int32_GUISkin_Int32_Single_Single_GUIStyle_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DoWindow_Injected_Private_Static_Void_Int32_Int32_byref_Rect_WindowFunction_GUIContent_GUIStyle_Object_Boolean_byref_Rect_0;

		// Token: 0x040000C1 RID: 193
		public const float s_ScrollStepSize = 10f;

		// Token: 0x040000C2 RID: 194
		private static readonly GUI.get_changedDelegate get_changedDelegateField;

		// Token: 0x040000C3 RID: 195
		private static readonly GUI.get_depthDelegate get_depthDelegateField;

		// Token: 0x040000C4 RID: 196
		private static readonly GUI.set_depthDelegate set_depthDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly GUI.get_isInsideListDelegate get_isInsideListDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly GUI.set_isInsideListDelegate set_isInsideListDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly GUI.SetNextControlNameDelegate SetNextControlNameDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly GUI.GetNameOfFocusedControlDelegate GetNameOfFocusedControlDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly GUI.FocusControlDelegate FocusControlDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly GUI.Internal_GetTooltipDelegate Internal_GetTooltipDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly GUI.Internal_SetTooltipDelegate Internal_SetTooltipDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly GUI.Internal_GetMouseTooltipDelegate Internal_GetMouseTooltipDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly GUI.BringWindowToFrontDelegate BringWindowToFrontDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly GUI.BringWindowToBackDelegate BringWindowToBackDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly GUI.UnfocusWindowDelegate UnfocusWindowDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly GUI.Internal_BeginWindowsDelegate Internal_BeginWindowsDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly GUI.Internal_EndWindowsDelegate Internal_EndWindowsDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly GUI.Internal_ConcatenateDelegate Internal_ConcatenateDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly GUI.get_backgroundColor_InjectedDelegate get_backgroundColor_InjectedDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly GUI.set_backgroundColor_InjectedDelegate set_backgroundColor_InjectedDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly GUI.get_contentColor_InjectedDelegate get_contentColor_InjectedDelegateField;

		// Token: 0x040000D6 RID: 214
		private static readonly GUI.set_contentColor_InjectedDelegate set_contentColor_InjectedDelegateField;

		// Token: 0x040000D7 RID: 215
		private static readonly GUI.Internal_DoModalWindow_InjectedDelegate Internal_DoModalWindow_InjectedDelegateField;

		// Token: 0x040000D8 RID: 216
		private static readonly GUI.DragWindow_InjectedDelegate DragWindow_InjectedDelegateField;

		// Token: 0x0200003A RID: 58
		public sealed class WindowFunction : MulticastDelegate
		{
			// Token: 0x06000647 RID: 1607 RVA: 0x00018028 File Offset: 0x00016228
			// Note: this type is marked as 'beforefieldinit'.
			static WindowFunction()
			{
				Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUI>.NativeClassPtr, "WindowFunction");
				GUI.WindowFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr, 100663406);
				GUI.WindowFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr, 100663407);
				GUI.WindowFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr, 100663408);
				GUI.WindowFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr, 100663409);
			}

			// Token: 0x06000648 RID: 1608 RVA: 0x0001809C File Offset: 0x0001629C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WindowFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUI.WindowFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.WindowFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x000180F8 File Offset: 0x000162F8
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 12882, RefRangeEnd = 12902, XrefRangeStart = 12882, XrefRangeEnd = 12902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.WindowFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x00018138 File Offset: 0x00016338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505515, XrefRangeEnd = 505519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int id, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.WindowFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x000181A8 File Offset: 0x000163A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUI.WindowFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600064C RID: 1612 RVA: 0x00004816 File Offset: 0x00002A16
			public WindowFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600064D RID: 1613 RVA: 0x0000481F File Offset: 0x00002A1F
			public static implicit operator GUI.WindowFunction(Action<int> A_0)
			{
				return DelegateSupport.ConvertDelegate<GUI.WindowFunction>(A_0);
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x00004827 File Offset: 0x00002A27
			public static GUI.WindowFunction operator +(GUI.WindowFunction A_0, GUI.WindowFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GUI.WindowFunction>();
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x00004835 File Offset: 0x00002A35
			public static GUI.WindowFunction operator -(GUI.WindowFunction A_0, GUI.WindowFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<GUI.WindowFunction>();
				}
				return delegate2;
			}

			// Token: 0x040003BF RID: 959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040003C0 RID: 960
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

			// Token: 0x040003C1 RID: 961
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

			// Token: 0x040003C2 RID: 962
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200003B RID: 59
		public enum ToolbarButtonSize
		{
			// Token: 0x040003C4 RID: 964
			Fixed,
			// Token: 0x040003C5 RID: 965
			FitToContents
		}

		// Token: 0x0200003C RID: 60
		public abstract class Scope
		{
		}

		// Token: 0x0200003D RID: 61
		public class GroupScope : GUI.Scope
		{
		}

		// Token: 0x0200003E RID: 62
		public class ScrollViewScope : GUI.Scope
		{
		}

		// Token: 0x0200003F RID: 63
		public class ClipScope : GUI.Scope
		{
		}

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000651 RID: 1617
		private delegate bool get_changedDelegate();

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x06000653 RID: 1619
		private delegate int get_depthDelegate();

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000655 RID: 1621
		private delegate void set_depthDelegate(int value);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000657 RID: 1623
		private delegate bool get_isInsideListDelegate();

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000659 RID: 1625
		private delegate void set_isInsideListDelegate(bool value);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x0600065B RID: 1627
		private delegate void SetNextControlNameDelegate(IntPtr name);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x0600065D RID: 1629
		private delegate IntPtr GetNameOfFocusedControlDelegate();

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600065F RID: 1631
		private delegate void FocusControlDelegate(IntPtr name);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000661 RID: 1633
		private delegate IntPtr Internal_GetTooltipDelegate();

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000663 RID: 1635
		private delegate void Internal_SetTooltipDelegate(IntPtr value);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000665 RID: 1637
		private delegate IntPtr Internal_GetMouseTooltipDelegate();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000667 RID: 1639
		private delegate void BringWindowToFrontDelegate(int windowID);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000669 RID: 1641
		private delegate void BringWindowToBackDelegate(int windowID);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x0600066B RID: 1643
		private delegate void UnfocusWindowDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x0600066D RID: 1645
		private delegate void Internal_BeginWindowsDelegate();

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x0600066F RID: 1647
		private delegate void Internal_EndWindowsDelegate();

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000671 RID: 1649
		private delegate IntPtr Internal_ConcatenateDelegate(IntPtr first, IntPtr second);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x06000673 RID: 1651
		private delegate void get_backgroundColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000675 RID: 1653
		private delegate void set_backgroundColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000677 RID: 1655
		private delegate void get_contentColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000679 RID: 1657
		private delegate void set_contentColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x0600067B RID: 1659
		private delegate void Internal_DoModalWindow_InjectedDelegate(int id, int instanceID, IntPtr clientRect, IntPtr func, IntPtr content, IntPtr style, IntPtr skin, [Out] IntPtr ret);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x0600067D RID: 1661
		private delegate void DragWindow_InjectedDelegate(IntPtr position);
	}
}
