using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public sealed class GUISkin : ScriptableObject
	{
		// Token: 0x060002CB RID: 715 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
		// Note: this type is marked as 'beforefieldinit'.
		static GUISkin()
		{
			Il2CppClassPointerStore<GUISkin>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUISkin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUISkin>.NativeClassPtr);
			GUISkin.NativeFieldInfoPtr_m_Font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_Font");
			GUISkin.NativeFieldInfoPtr_m_box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_box");
			GUISkin.NativeFieldInfoPtr_m_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_button");
			GUISkin.NativeFieldInfoPtr_m_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_toggle");
			GUISkin.NativeFieldInfoPtr_m_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_label");
			GUISkin.NativeFieldInfoPtr_m_textField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_textField");
			GUISkin.NativeFieldInfoPtr_m_textArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_textArea");
			GUISkin.NativeFieldInfoPtr_m_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_window");
			GUISkin.NativeFieldInfoPtr_m_horizontalSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalSlider");
			GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalSliderThumb");
			GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumbExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalSliderThumbExtent");
			GUISkin.NativeFieldInfoPtr_m_verticalSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalSlider");
			GUISkin.NativeFieldInfoPtr_m_verticalSliderThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalSliderThumb");
			GUISkin.NativeFieldInfoPtr_m_verticalSliderThumbExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalSliderThumbExtent");
			GUISkin.NativeFieldInfoPtr_m_SliderMixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_SliderMixed");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbar");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbarThumb");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarLeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbarLeftButton");
			GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarRightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_horizontalScrollbarRightButton");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbar");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbarThumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbarThumb");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbarUpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbarUpButton");
			GUISkin.NativeFieldInfoPtr_m_verticalScrollbarDownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_verticalScrollbarDownButton");
			GUISkin.NativeFieldInfoPtr_m_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_ScrollView");
			GUISkin.NativeFieldInfoPtr_m_CustomStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_CustomStyles");
			GUISkin.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_Settings");
			GUISkin.NativeFieldInfoPtr_ms_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "ms_Error");
			GUISkin.NativeFieldInfoPtr_m_Styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_Styles");
			GUISkin.NativeFieldInfoPtr_m_SkinChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "m_SkinChanged");
			GUISkin.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "current");
			GUISkin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663502);
			GUISkin.NativeMethodInfoPtr_OnEnable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663503);
			GUISkin.NativeMethodInfoPtr_CleanupRoots_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663504);
			GUISkin.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663505);
			GUISkin.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663506);
			GUISkin.NativeMethodInfoPtr_get_box_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663507);
			GUISkin.NativeMethodInfoPtr_set_box_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663508);
			GUISkin.NativeMethodInfoPtr_get_label_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663509);
			GUISkin.NativeMethodInfoPtr_set_label_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663510);
			GUISkin.NativeMethodInfoPtr_get_textField_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663511);
			GUISkin.NativeMethodInfoPtr_set_textField_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663512);
			GUISkin.NativeMethodInfoPtr_get_textArea_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663513);
			GUISkin.NativeMethodInfoPtr_set_textArea_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663514);
			GUISkin.NativeMethodInfoPtr_get_button_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663515);
			GUISkin.NativeMethodInfoPtr_set_button_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663516);
			GUISkin.NativeMethodInfoPtr_get_toggle_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663517);
			GUISkin.NativeMethodInfoPtr_set_toggle_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663518);
			GUISkin.NativeMethodInfoPtr_get_window_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663519);
			GUISkin.NativeMethodInfoPtr_set_window_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663520);
			GUISkin.NativeMethodInfoPtr_get_horizontalSlider_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663521);
			GUISkin.NativeMethodInfoPtr_set_horizontalSlider_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663522);
			GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663523);
			GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663524);
			GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumbExtent_Internal_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663525);
			GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumbExtent_Internal_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663526);
			GUISkin.NativeMethodInfoPtr_get_sliderMixed_Internal_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663527);
			GUISkin.NativeMethodInfoPtr_set_sliderMixed_Internal_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663528);
			GUISkin.NativeMethodInfoPtr_get_verticalSlider_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663529);
			GUISkin.NativeMethodInfoPtr_set_verticalSlider_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663530);
			GUISkin.NativeMethodInfoPtr_get_verticalSliderThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663531);
			GUISkin.NativeMethodInfoPtr_set_verticalSliderThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663532);
			GUISkin.NativeMethodInfoPtr_get_verticalSliderThumbExtent_Internal_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663533);
			GUISkin.NativeMethodInfoPtr_set_verticalSliderThumbExtent_Internal_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663534);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663535);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663536);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663537);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663538);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarLeftButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663539);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarLeftButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663540);
			GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarRightButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663541);
			GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarRightButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663542);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663543);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663544);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbarThumb_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663545);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbarThumb_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663546);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbarUpButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663547);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbarUpButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663548);
			GUISkin.NativeMethodInfoPtr_get_verticalScrollbarDownButton_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663549);
			GUISkin.NativeMethodInfoPtr_set_verticalScrollbarDownButton_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663550);
			GUISkin.NativeMethodInfoPtr_get_scrollView_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663551);
			GUISkin.NativeMethodInfoPtr_set_scrollView_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663552);
			GUISkin.NativeMethodInfoPtr_get_customStyles_Public_get_Il2CppReferenceArray_1_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663553);
			GUISkin.NativeMethodInfoPtr_set_customStyles_Public_set_Void_Il2CppReferenceArray_1_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663554);
			GUISkin.NativeMethodInfoPtr_get_settings_Public_get_GUISettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663555);
			GUISkin.NativeMethodInfoPtr_get_error_Internal_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663556);
			GUISkin.NativeMethodInfoPtr_Apply_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663557);
			GUISkin.NativeMethodInfoPtr_BuildStyleCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663558);
			GUISkin.NativeMethodInfoPtr_GetStyle_Public_GUIStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663559);
			GUISkin.NativeMethodInfoPtr_FindStyle_Public_GUIStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663560);
			GUISkin.NativeMethodInfoPtr_MakeCurrent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663561);
			GUISkin.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, 100663562);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000CF24 File Offset: 0x0000B124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508255, XrefRangeEnd = 508262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUISkin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISkin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000CF60 File Offset: 0x0000B160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508262, XrefRangeEnd = 508263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_OnEnable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000CF94 File Offset: 0x0000B194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508263, XrefRangeEnd = 508266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupRoots()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_CleanupRoots_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		public unsafe Font font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508266, XrefRangeEnd = 508289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000D040 File Offset: 0x0000B240
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000D080 File Offset: 0x0000B280
		public unsafe GUIStyle box
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_box_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508289, XrefRangeEnd = 508290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_box_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000D104 File Offset: 0x0000B304
		public unsafe GUIStyle label
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_label_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508290, XrefRangeEnd = 508291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_label_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000D148 File Offset: 0x0000B348
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0000D188 File Offset: 0x0000B388
		public unsafe GUIStyle textField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_textField_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508291, XrefRangeEnd = 508292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_textField_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000D1CC File Offset: 0x0000B3CC
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000D20C File Offset: 0x0000B40C
		public unsafe GUIStyle textArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_textArea_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508292, XrefRangeEnd = 508293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_textArea_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000D250 File Offset: 0x0000B450
		// (set) Token: 0x060002DA RID: 730 RVA: 0x0000D290 File Offset: 0x0000B490
		public unsafe GUIStyle button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_button_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508293, XrefRangeEnd = 508294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_button_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0000D314 File Offset: 0x0000B514
		public unsafe GUIStyle toggle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_toggle_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508294, XrefRangeEnd = 508295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_toggle_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000D358 File Offset: 0x0000B558
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0000D398 File Offset: 0x0000B598
		public unsafe GUIStyle window
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_window_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508295, XrefRangeEnd = 508296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_window_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0000D41C File Offset: 0x0000B61C
		public unsafe GUIStyle horizontalSlider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalSlider_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508296, XrefRangeEnd = 508297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalSlider_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000D460 File Offset: 0x0000B660
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		public unsafe GUIStyle horizontalSliderThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508297, XrefRangeEnd = 508298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0000D524 File Offset: 0x0000B724
		public unsafe GUIStyle horizontalSliderThumbExtent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalSliderThumbExtent_Internal_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508298, XrefRangeEnd = 508299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalSliderThumbExtent_Internal_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000D568 File Offset: 0x0000B768
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		public unsafe GUIStyle sliderMixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_sliderMixed_Internal_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508299, XrefRangeEnd = 508300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_sliderMixed_Internal_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000D62C File Offset: 0x0000B82C
		public unsafe GUIStyle verticalSlider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalSlider_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508300, XrefRangeEnd = 508301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalSlider_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000D670 File Offset: 0x0000B870
		// (set) Token: 0x060002EA RID: 746 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		public unsafe GUIStyle verticalSliderThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalSliderThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508301, XrefRangeEnd = 508302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalSliderThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0000D734 File Offset: 0x0000B934
		public unsafe GUIStyle verticalSliderThumbExtent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalSliderThumbExtent_Internal_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508302, XrefRangeEnd = 508303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalSliderThumbExtent_Internal_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000D778 File Offset: 0x0000B978
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		public unsafe GUIStyle horizontalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508303, XrefRangeEnd = 508304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000D83C File Offset: 0x0000BA3C
		public unsafe GUIStyle horizontalScrollbarThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508304, XrefRangeEnd = 508305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000D880 File Offset: 0x0000BA80
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		public unsafe GUIStyle horizontalScrollbarLeftButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarLeftButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508305, XrefRangeEnd = 508306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarLeftButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000D904 File Offset: 0x0000BB04
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000D944 File Offset: 0x0000BB44
		public unsafe GUIStyle horizontalScrollbarRightButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_horizontalScrollbarRightButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508306, XrefRangeEnd = 508307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_horizontalScrollbarRightButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000D988 File Offset: 0x0000BB88
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		public unsafe GUIStyle verticalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508307, XrefRangeEnd = 508308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000DA0C File Offset: 0x0000BC0C
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0000DA4C File Offset: 0x0000BC4C
		public unsafe GUIStyle verticalScrollbarThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbarThumb_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508308, XrefRangeEnd = 508309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbarThumb_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000DA90 File Offset: 0x0000BC90
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		public unsafe GUIStyle verticalScrollbarUpButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbarUpButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508309, XrefRangeEnd = 508310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbarUpButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000DB14 File Offset: 0x0000BD14
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0000DB54 File Offset: 0x0000BD54
		public unsafe GUIStyle verticalScrollbarDownButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_verticalScrollbarDownButton_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508310, XrefRangeEnd = 508311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_verticalScrollbarDownButton_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0000DB98 File Offset: 0x0000BD98
		// (set) Token: 0x060002FE RID: 766 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		public unsafe GUIStyle scrollView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_scrollView_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508311, XrefRangeEnd = 508312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_scrollView_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000DC1C File Offset: 0x0000BE1C
		// (set) Token: 0x06000300 RID: 768 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		public unsafe Il2CppReferenceArray<GUIStyle> customStyles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_customStyles_Public_get_Il2CppReferenceArray_1_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIStyle>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508312, XrefRangeEnd = 508313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_set_customStyles_Public_set_Void_Il2CppReferenceArray_1_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000DCA0 File Offset: 0x0000BEA0
		public unsafe GUISettings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_settings_Public_get_GUISettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUISettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		public unsafe static GUIStyle error
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 508325, RefRangeEnd = 508330, XrefRangeStart = 508313, XrefRangeEnd = 508325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_get_error_Internal_Static_get_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000DD14 File Offset: 0x0000BF14
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 508337, RefRangeEnd = 508363, XrefRangeStart = 508330, XrefRangeEnd = 508337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_Apply_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000DD48 File Offset: 0x0000BF48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 508580, RefRangeEnd = 508584, XrefRangeStart = 508363, XrefRangeEnd = 508580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildStyleCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_BuildStyleCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000DD7C File Offset: 0x0000BF7C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 508630, RefRangeEnd = 508643, XrefRangeStart = 508584, XrefRangeEnd = 508630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle GetStyle(string styleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(styleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_GetStyle_Public_GUIStyle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000DDCC File Offset: 0x0000BFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508643, XrefRangeEnd = 508646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyle FindStyle(string styleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(styleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_FindStyle_Public_GUIStyle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000DE1C File Offset: 0x0000C01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508646, XrefRangeEnd = 508655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeCurrent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_MakeCurrent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000DE50 File Offset: 0x0000C050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508655, XrefRangeEnd = 508663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003129 File Offset: 0x00001329
		public GUISkin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000DE90 File Offset: 0x0000C090
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00003132 File Offset: 0x00001332
		public unsafe Font m_Font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003151 File Offset: 0x00001351
		public unsafe GUIStyle m_box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003170 File Offset: 0x00001370
		public unsafe GUIStyle m_button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000DF20 File Offset: 0x0000C120
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0000318F File Offset: 0x0000138F
		public unsafe GUIStyle m_toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000DF50 File Offset: 0x0000C150
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000031AE File Offset: 0x000013AE
		public unsafe GUIStyle m_label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000DF80 File Offset: 0x0000C180
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000031CD File Offset: 0x000013CD
		public unsafe GUIStyle m_textField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		// (set) Token: 0x06000317 RID: 791 RVA: 0x000031EC File Offset: 0x000013EC
		public unsafe GUIStyle m_textArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_textArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0000320B File Offset: 0x0000140B
		public unsafe GUIStyle m_window
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_window);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_window), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000E010 File Offset: 0x0000C210
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0000322A File Offset: 0x0000142A
		public unsafe GUIStyle m_horizontalSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000E040 File Offset: 0x0000C240
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00003249 File Offset: 0x00001449
		public unsafe GUIStyle m_horizontalSliderThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000E070 File Offset: 0x0000C270
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00003268 File Offset: 0x00001468
		public unsafe GUIStyle m_horizontalSliderThumbExtent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumbExtent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalSliderThumbExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00003287 File Offset: 0x00001487
		public unsafe GUIStyle m_verticalSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000032A6 File Offset: 0x000014A6
		public unsafe GUIStyle m_verticalSliderThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000E100 File Offset: 0x0000C300
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000032C5 File Offset: 0x000014C5
		public unsafe GUIStyle m_verticalSliderThumbExtent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumbExtent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalSliderThumbExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000E130 File Offset: 0x0000C330
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000032E4 File Offset: 0x000014E4
		public unsafe GUIStyle m_SliderMixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_SliderMixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_SliderMixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000E160 File Offset: 0x0000C360
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00003303 File Offset: 0x00001503
		public unsafe GUIStyle m_horizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000E190 File Offset: 0x0000C390
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00003322 File Offset: 0x00001522
		public unsafe GUIStyle m_horizontalScrollbarThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003341 File Offset: 0x00001541
		public unsafe GUIStyle m_horizontalScrollbarLeftButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarLeftButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarLeftButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00003360 File Offset: 0x00001560
		public unsafe GUIStyle m_horizontalScrollbarRightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarRightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_horizontalScrollbarRightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000E220 File Offset: 0x0000C420
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000337F File Offset: 0x0000157F
		public unsafe GUIStyle m_verticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000E250 File Offset: 0x0000C450
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000339E File Offset: 0x0000159E
		public unsafe GUIStyle m_verticalScrollbarThumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarThumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarThumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000E280 File Offset: 0x0000C480
		// (set) Token: 0x06000335 RID: 821 RVA: 0x000033BD File Offset: 0x000015BD
		public unsafe GUIStyle m_verticalScrollbarUpButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarUpButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarUpButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		// (set) Token: 0x06000337 RID: 823 RVA: 0x000033DC File Offset: 0x000015DC
		public unsafe GUIStyle m_verticalScrollbarDownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarDownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_verticalScrollbarDownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000033FB File Offset: 0x000015FB
		public unsafe GUIStyle m_ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000E310 File Offset: 0x0000C510
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000341A File Offset: 0x0000161A
		public unsafe Il2CppReferenceArray<GUIStyle> m_CustomStyles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_CustomStyles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIStyle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_CustomStyles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000E340 File Offset: 0x0000C540
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003439 File Offset: 0x00001639
		public unsafe GUISettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000E370 File Offset: 0x0000C570
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00003458 File Offset: 0x00001658
		public unsafe static GUIStyle ms_Error
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUISkin.NativeFieldInfoPtr_ms_Error, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUISkin.NativeFieldInfoPtr_ms_Error, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000E398 File Offset: 0x0000C598
		// (set) Token: 0x06000341 RID: 833 RVA: 0x0000346A File Offset: 0x0000166A
		public unsafe Dictionary<string, GUIStyle> m_Styles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Styles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GUIStyle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISkin.NativeFieldInfoPtr_m_Styles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000E3C8 File Offset: 0x0000C5C8
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00003489 File Offset: 0x00001689
		public unsafe static GUISkin.SkinChangedDelegate m_SkinChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUISkin.NativeFieldInfoPtr_m_SkinChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISkin.SkinChangedDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUISkin.NativeFieldInfoPtr_m_SkinChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
		// (set) Token: 0x06000345 RID: 837 RVA: 0x0000349B File Offset: 0x0000169B
		public unsafe static GUISkin current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUISkin.NativeFieldInfoPtr_current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUISkin.NativeFieldInfoPtr_current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_m_Font;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_m_box;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_m_button;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_m_toggle;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_m_label;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_m_textField;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_m_textArea;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_m_window;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalSlider;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalSliderThumb;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalSliderThumbExtent;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalSlider;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalSliderThumb;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalSliderThumbExtent;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_m_SliderMixed;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbar;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbarThumb;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbarLeftButton;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalScrollbarRightButton;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbar;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbarThumb;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbarUpButton;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalScrollbarDownButton;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollView;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomStyles;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_ms_Error;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_m_Styles;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_m_SkinChanged;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Void_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRoots_Internal_Static_Void_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_Font_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_get_box_Public_get_GUIStyle_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_set_box_Public_set_Void_GUIStyle_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_get_label_Public_get_GUIStyle_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_set_label_Public_set_Void_GUIStyle_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_get_textField_Public_get_GUIStyle_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_set_textField_Public_set_Void_GUIStyle_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_textArea_Public_get_GUIStyle_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_set_textArea_Public_set_Void_GUIStyle_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_GUIStyle_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_GUIStyle_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_get_toggle_Public_get_GUIStyle_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_set_toggle_Public_set_Void_GUIStyle_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_get_window_Public_get_GUIStyle_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_set_window_Public_set_Void_GUIStyle_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalSlider_Public_get_GUIStyle_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalSlider_Public_set_Void_GUIStyle_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalSliderThumb_Public_get_GUIStyle_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalSliderThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalSliderThumbExtent_Internal_get_GUIStyle_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalSliderThumbExtent_Internal_set_Void_GUIStyle_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_sliderMixed_Internal_get_GUIStyle_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_set_sliderMixed_Internal_set_Void_GUIStyle_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalSlider_Public_get_GUIStyle_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalSlider_Public_set_Void_GUIStyle_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalSliderThumb_Public_get_GUIStyle_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalSliderThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalSliderThumbExtent_Internal_get_GUIStyle_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalSliderThumbExtent_Internal_set_Void_GUIStyle_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_GUIStyle_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_GUIStyle_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarThumb_Public_get_GUIStyle_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarLeftButton_Public_get_GUIStyle_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarLeftButton_Public_set_Void_GUIStyle_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarRightButton_Public_get_GUIStyle_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarRightButton_Public_set_Void_GUIStyle_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbar_Public_get_GUIStyle_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_GUIStyle_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarThumb_Public_get_GUIStyle_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarThumb_Public_set_Void_GUIStyle_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarUpButton_Public_get_GUIStyle_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarUpButton_Public_set_Void_GUIStyle_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarDownButton_Public_get_GUIStyle_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarDownButton_Public_set_Void_GUIStyle_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollView_Public_get_GUIStyle_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollView_Public_set_Void_GUIStyle_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_get_customStyles_Public_get_Il2CppReferenceArray_1_GUIStyle_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_set_customStyles_Public_set_Void_Il2CppReferenceArray_1_GUIStyle_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_GUISettings_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_get_error_Internal_Static_get_GUIStyle_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Internal_Void_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_BuildStyleCache_Private_Void_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_GUIStyle_String_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_FindStyle_Public_GUIStyle_String_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_MakeCurrent_Internal_Void_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

		// Token: 0x02000071 RID: 113
		public sealed class SkinChangedDelegate : MulticastDelegate
		{
			// Token: 0x060006BC RID: 1724 RVA: 0x00018600 File Offset: 0x00016800
			// Note: this type is marked as 'beforefieldinit'.
			static SkinChangedDelegate()
			{
				Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUISkin>.NativeClassPtr, "SkinChangedDelegate");
				GUISkin.SkinChangedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr, 100663563);
				GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr, 100663564);
				GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr, 100663565);
				GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr, 100663566);
			}

			// Token: 0x060006BD RID: 1725 RVA: 0x00018674 File Offset: 0x00016874
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SkinChangedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISkin.SkinChangedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.SkinChangedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006BE RID: 1726 RVA: 0x000186D0 File Offset: 0x000168D0
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006BF RID: 1727 RVA: 0x00018704 File Offset: 0x00016904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x00018768 File Offset: 0x00016968
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISkin.SkinChangedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x00004948 File Offset: 0x00002B48
			public SkinChangedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x00004951 File Offset: 0x00002B51
			public static implicit operator GUISkin.SkinChangedDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<GUISkin.SkinChangedDelegate>(A_0);
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x00004959 File Offset: 0x00002B59
			public static GUISkin.SkinChangedDelegate operator +(GUISkin.SkinChangedDelegate A_0, GUISkin.SkinChangedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GUISkin.SkinChangedDelegate>();
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x00004967 File Offset: 0x00002B67
			public static GUISkin.SkinChangedDelegate operator -(GUISkin.SkinChangedDelegate A_0, GUISkin.SkinChangedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<GUISkin.SkinChangedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040003E1 RID: 993
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040003E2 RID: 994
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x040003E3 RID: 995
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x040003E4 RID: 996
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
