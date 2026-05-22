using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200001E RID: 30
	public class TextEditor : Object
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x00015784 File Offset: 0x00013984
		// Note: this type is marked as 'beforefieldinit'.
		static TextEditor()
		{
			Il2CppClassPointerStore<TextEditor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "TextEditor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEditor>.NativeClassPtr);
			TextEditor.NativeFieldInfoPtr_keyboardOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "keyboardOnScreen");
			TextEditor.NativeFieldInfoPtr_controlID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "controlID");
			TextEditor.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "style");
			TextEditor.NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "multiline");
			TextEditor.NativeFieldInfoPtr_hasHorizontalCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "hasHorizontalCursorPos");
			TextEditor.NativeFieldInfoPtr_isPasswordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "isPasswordField");
			TextEditor.NativeFieldInfoPtr_m_HasFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_HasFocus");
			TextEditor.NativeFieldInfoPtr_scrollOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "scrollOffset");
			TextEditor.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_Content");
			TextEditor.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_Position");
			TextEditor.NativeFieldInfoPtr_m_CursorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_CursorIndex");
			TextEditor.NativeFieldInfoPtr_m_SelectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_SelectIndex");
			TextEditor.NativeFieldInfoPtr_m_RevealCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_RevealCursor");
			TextEditor.NativeFieldInfoPtr_graphicalCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "graphicalCursorPos");
			TextEditor.NativeFieldInfoPtr_graphicalSelectCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "graphicalSelectCursorPos");
			TextEditor.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_MouseDragSelectsWholeWords");
			TextEditor.NativeFieldInfoPtr_m_DblClickInitPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_DblClickInitPos");
			TextEditor.NativeFieldInfoPtr_m_DblClickSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_DblClickSnap");
			TextEditor.NativeFieldInfoPtr_m_bJustSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_bJustSelected");
			TextEditor.NativeFieldInfoPtr_m_iAltCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_iAltCursorPos");
			TextEditor.NativeFieldInfoPtr_oldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "oldText");
			TextEditor.NativeFieldInfoPtr_oldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "oldPos");
			TextEditor.NativeFieldInfoPtr_oldSelectPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "oldSelectPos");
			TextEditor.NativeFieldInfoPtr_s_Keyactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "s_Keyactions");
			TextEditor.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663785);
			TextEditor.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663786);
			TextEditor.NativeMethodInfoPtr_get_position_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663787);
			TextEditor.NativeMethodInfoPtr_set_position_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663788);
			TextEditor.NativeMethodInfoPtr_get_localPosition_Internal_Virtual_New_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663789);
			TextEditor.NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663790);
			TextEditor.NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663791);
			TextEditor.NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663792);
			TextEditor.NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663793);
			TextEditor.NativeMethodInfoPtr_ClearCursorPos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663794);
			TextEditor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663795);
			TextEditor.NativeMethodInfoPtr_OnFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663796);
			TextEditor.NativeMethodInfoPtr_OnLostFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663797);
			TextEditor.NativeMethodInfoPtr_GrabGraphicalCursorPos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663798);
			TextEditor.NativeMethodInfoPtr_HandleKeyEvent_Public_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663799);
			TextEditor.NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663800);
			TextEditor.NativeMethodInfoPtr_DeleteLineBack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663801);
			TextEditor.NativeMethodInfoPtr_DeleteWordBack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663802);
			TextEditor.NativeMethodInfoPtr_DeleteWordForward_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663803);
			TextEditor.NativeMethodInfoPtr_Delete_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663804);
			TextEditor.NativeMethodInfoPtr_Backspace_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663805);
			TextEditor.NativeMethodInfoPtr_SelectAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663806);
			TextEditor.NativeMethodInfoPtr_SelectNone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663807);
			TextEditor.NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663808);
			TextEditor.NativeMethodInfoPtr_DeleteSelection_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663809);
			TextEditor.NativeMethodInfoPtr_ReplaceSelection_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663810);
			TextEditor.NativeMethodInfoPtr_Insert_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663811);
			TextEditor.NativeMethodInfoPtr_MoveRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663812);
			TextEditor.NativeMethodInfoPtr_MoveLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663813);
			TextEditor.NativeMethodInfoPtr_MoveUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663814);
			TextEditor.NativeMethodInfoPtr_MoveDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663815);
			TextEditor.NativeMethodInfoPtr_MoveLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663816);
			TextEditor.NativeMethodInfoPtr_MoveLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663817);
			TextEditor.NativeMethodInfoPtr_MoveGraphicalLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663818);
			TextEditor.NativeMethodInfoPtr_MoveGraphicalLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663819);
			TextEditor.NativeMethodInfoPtr_MoveTextStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663820);
			TextEditor.NativeMethodInfoPtr_MoveTextEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663821);
			TextEditor.NativeMethodInfoPtr_IndexOfEndOfLine_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663822);
			TextEditor.NativeMethodInfoPtr_MoveParagraphForward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663823);
			TextEditor.NativeMethodInfoPtr_MoveParagraphBackward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663824);
			TextEditor.NativeMethodInfoPtr_MoveCursorToPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663825);
			TextEditor.NativeMethodInfoPtr_MoveCursorToPosition_Internal_FamOrAssem_Void_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663826);
			TextEditor.NativeMethodInfoPtr_SelectToPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663827);
			TextEditor.NativeMethodInfoPtr_SelectLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663828);
			TextEditor.NativeMethodInfoPtr_SelectRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663829);
			TextEditor.NativeMethodInfoPtr_SelectUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663830);
			TextEditor.NativeMethodInfoPtr_SelectDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663831);
			TextEditor.NativeMethodInfoPtr_SelectTextEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663832);
			TextEditor.NativeMethodInfoPtr_SelectTextStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663833);
			TextEditor.NativeMethodInfoPtr_MouseDragSelectsWholeWords_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663834);
			TextEditor.NativeMethodInfoPtr_DblClickSnap_Public_Void_DblClickSnapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663835);
			TextEditor.NativeMethodInfoPtr_GetGraphicalLineStart_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663836);
			TextEditor.NativeMethodInfoPtr_GetGraphicalLineEnd_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663837);
			TextEditor.NativeMethodInfoPtr_FindNextSeperator_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663838);
			TextEditor.NativeMethodInfoPtr_FindPrevSeperator_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663839);
			TextEditor.NativeMethodInfoPtr_MoveWordRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663840);
			TextEditor.NativeMethodInfoPtr_MoveToStartOfNextWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663841);
			TextEditor.NativeMethodInfoPtr_MoveToEndOfPreviousWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663842);
			TextEditor.NativeMethodInfoPtr_SelectToStartOfNextWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663843);
			TextEditor.NativeMethodInfoPtr_SelectToEndOfPreviousWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663844);
			TextEditor.NativeMethodInfoPtr_ClassifyChar_Private_CharacterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663845);
			TextEditor.NativeMethodInfoPtr_FindStartOfNextWord_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663846);
			TextEditor.NativeMethodInfoPtr_FindEndOfPreviousWord_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663847);
			TextEditor.NativeMethodInfoPtr_MoveWordLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663848);
			TextEditor.NativeMethodInfoPtr_SelectWordRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663849);
			TextEditor.NativeMethodInfoPtr_SelectWordLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663850);
			TextEditor.NativeMethodInfoPtr_ExpandSelectGraphicalLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663851);
			TextEditor.NativeMethodInfoPtr_ExpandSelectGraphicalLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663852);
			TextEditor.NativeMethodInfoPtr_SelectGraphicalLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663853);
			TextEditor.NativeMethodInfoPtr_SelectGraphicalLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663854);
			TextEditor.NativeMethodInfoPtr_SelectParagraphForward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663855);
			TextEditor.NativeMethodInfoPtr_SelectParagraphBackward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663856);
			TextEditor.NativeMethodInfoPtr_SelectCurrentWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663857);
			TextEditor.NativeMethodInfoPtr_FindEndOfClassification_Private_Int32_Int32_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663858);
			TextEditor.NativeMethodInfoPtr_SelectCurrentParagraph_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663859);
			TextEditor.NativeMethodInfoPtr_UpdateScrollOffsetIfNeeded_Public_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663860);
			TextEditor.NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663861);
			TextEditor.NativeMethodInfoPtr_DrawCursor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663862);
			TextEditor.NativeMethodInfoPtr_PerformOperation_Private_Boolean_TextEditOp_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663863);
			TextEditor.NativeMethodInfoPtr_SaveBackup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663864);
			TextEditor.NativeMethodInfoPtr_Cut_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663865);
			TextEditor.NativeMethodInfoPtr_Copy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663866);
			TextEditor.NativeMethodInfoPtr_ReplaceNewlinesWithSpaces_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663867);
			TextEditor.NativeMethodInfoPtr_Paste_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663868);
			TextEditor.NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextEditOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663869);
			TextEditor.NativeMethodInfoPtr_InitKeyActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663870);
			TextEditor.NativeMethodInfoPtr_DetectFocusChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663871);
			TextEditor.NativeMethodInfoPtr_OnDetectFocusChange_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663872);
			TextEditor.NativeMethodInfoPtr_OnCursorIndexChange_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663873);
			TextEditor.NativeMethodInfoPtr_OnSelectIndexChange_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663874);
			TextEditor.NativeMethodInfoPtr_ClampTextIndex_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663875);
			TextEditor.NativeMethodInfoPtr_EnsureValidCodePointIndex_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663876);
			TextEditor.NativeMethodInfoPtr_IsValidCodePointIndex_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663877);
			TextEditor.NativeMethodInfoPtr_PreviousCodePointIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663878);
			TextEditor.NativeMethodInfoPtr_NextCodePointIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663879);
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00016100 File Offset: 0x00014300
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00016138 File Offset: 0x00014338
		public unsafe string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510606, XrefRangeEnd = 510611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001617C File Offset: 0x0001437C
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x000161B8 File Offset: 0x000143B8
		public unsafe Rect position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_get_position_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510611, XrefRangeEnd = 510614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_set_position_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000161F8 File Offset: 0x000143F8
		public unsafe virtual Rect localPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextEditor.NativeMethodInfoPtr_get_localPosition_Internal_Virtual_New_get_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00016240 File Offset: 0x00014440
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0001627C File Offset: 0x0001447C
		public unsafe int cursorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 510615, RefRangeEnd = 510627, XrefRangeStart = 510614, XrefRangeEnd = 510615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x000162BC File Offset: 0x000144BC
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x000162F8 File Offset: 0x000144F8
		public unsafe int selectIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 510628, RefRangeEnd = 510631, XrefRangeStart = 510627, XrefRangeEnd = 510628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00016338 File Offset: 0x00014538
		[CallerCount(0)]
		public unsafe void ClearCursorPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_ClearCursorPos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0001636C File Offset: 0x0001456C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510631, XrefRangeEnd = 510641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextEditor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextEditor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000163A8 File Offset: 0x000145A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510641, XrefRangeEnd = 510642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_OnFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000163DC File Offset: 0x000145DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510642, XrefRangeEnd = 510644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLostFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_OnLostFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00016410 File Offset: 0x00014610
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 510648, RefRangeEnd = 510654, XrefRangeStart = 510644, XrefRangeEnd = 510648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabGraphicalCursorPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_GrabGraphicalCursorPos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00016444 File Offset: 0x00014644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510654, XrefRangeEnd = 510655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleKeyEvent(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_HandleKeyEvent_Public_Boolean_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00016494 File Offset: 0x00014694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510669, RefRangeEnd = 510671, XrefRangeStart = 510655, XrefRangeEnd = 510669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleKeyEvent(Event e, bool textIsReadOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textIsReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000164F0 File Offset: 0x000146F0
		[CallerCount(0)]
		public unsafe bool DeleteLineBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_DeleteLineBack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001652C File Offset: 0x0001472C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510671, XrefRangeEnd = 510679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteWordBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_DeleteWordBack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00016568 File Offset: 0x00014768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510679, XrefRangeEnd = 510680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteWordForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_DeleteWordForward_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000165A4 File Offset: 0x000147A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510680, XrefRangeEnd = 510686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_Delete_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000165E0 File Offset: 0x000147E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510686, XrefRangeEnd = 510694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Backspace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_Backspace_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0001661C File Offset: 0x0001481C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510696, RefRangeEnd = 510698, XrefRangeStart = 510694, XrefRangeEnd = 510696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00016650 File Offset: 0x00014850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510698, XrefRangeEnd = 510699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectNone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectNone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00016684 File Offset: 0x00014884
		public unsafe bool hasSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000166C0 File Offset: 0x000148C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 510711, RefRangeEnd = 510716, XrefRangeStart = 510699, XrefRangeEnd = 510711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_DeleteSelection_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000166FC File Offset: 0x000148FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 510720, RefRangeEnd = 510724, XrefRangeStart = 510716, XrefRangeEnd = 510720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceSelection(string replace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(replace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_ReplaceSelection_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00016740 File Offset: 0x00014940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510724, XrefRangeEnd = 510729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_Insert_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00016780 File Offset: 0x00014980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 510736, RefRangeEnd = 510739, XrefRangeStart = 510729, XrefRangeEnd = 510736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000167B4 File Offset: 0x000149B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 510746, RefRangeEnd = 510749, XrefRangeStart = 510739, XrefRangeEnd = 510746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000167E8 File Offset: 0x000149E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510757, RefRangeEnd = 510758, XrefRangeStart = 510749, XrefRangeEnd = 510757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0001681C File Offset: 0x00014A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510767, RefRangeEnd = 510768, XrefRangeStart = 510758, XrefRangeEnd = 510767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00016850 File Offset: 0x00014A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510768, XrefRangeEnd = 510773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00016884 File Offset: 0x00014A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510773, XrefRangeEnd = 510775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLineEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000168B8 File Offset: 0x00014AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510775, XrefRangeEnd = 510778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveGraphicalLineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveGraphicalLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000168EC File Offset: 0x00014AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510778, XrefRangeEnd = 510781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveGraphicalLineEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveGraphicalLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00016920 File Offset: 0x00014B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510781, XrefRangeEnd = 510783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveTextStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00016954 File Offset: 0x00014B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510783, XrefRangeEnd = 510785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveTextEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00016988 File Offset: 0x00014B88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510786, RefRangeEnd = 510787, XrefRangeStart = 510785, XrefRangeEnd = 510786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfEndOfLine(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_IndexOfEndOfLine_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000169D4 File Offset: 0x00014BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510787, XrefRangeEnd = 510791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveParagraphForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveParagraphForward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00016A08 File Offset: 0x00014C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510794, RefRangeEnd = 510795, XrefRangeStart = 510791, XrefRangeEnd = 510794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveParagraphBackward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveParagraphBackward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00016A3C File Offset: 0x00014C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510808, RefRangeEnd = 510810, XrefRangeStart = 510795, XrefRangeEnd = 510808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveCursorToPosition(Vector2 cursorPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cursorPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveCursorToPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00016A7C File Offset: 0x00014C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510810, XrefRangeEnd = 510817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cursorPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveCursorToPosition_Internal_FamOrAssem_Void_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00016AC8 File Offset: 0x00014CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510863, RefRangeEnd = 510864, XrefRangeStart = 510817, XrefRangeEnd = 510863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectToPosition(Vector2 cursorPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cursorPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectToPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00016B08 File Offset: 0x00014D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510864, XrefRangeEnd = 510868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00016B3C File Offset: 0x00014D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510868, XrefRangeEnd = 510872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00016B70 File Offset: 0x00014D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510872, XrefRangeEnd = 510876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00016BA4 File Offset: 0x00014DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510876, XrefRangeEnd = 510881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00016BD8 File Offset: 0x00014DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510881, XrefRangeEnd = 510882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectTextEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectTextEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00016C0C File Offset: 0x00014E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510882, XrefRangeEnd = 510883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectTextStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectTextStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00016C40 File Offset: 0x00014E40
		[CallerCount(0)]
		public unsafe void MouseDragSelectsWholeWords(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref on;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MouseDragSelectsWholeWords_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00016C80 File Offset: 0x00014E80
		[CallerCount(0)]
		public unsafe void DblClickSnap(TextEditor.DblClickSnapping snapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapping;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_DblClickSnap_Public_Void_DblClickSnapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00016CC0 File Offset: 0x00014EC0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 510892, RefRangeEnd = 510900, XrefRangeStart = 510883, XrefRangeEnd = 510892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGraphicalLineStart(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_GetGraphicalLineStart_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00016D0C File Offset: 0x00014F0C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 510909, RefRangeEnd = 510917, XrefRangeStart = 510900, XrefRangeEnd = 510909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGraphicalLineEnd(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_GetGraphicalLineEnd_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00016D58 File Offset: 0x00014F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510917, XrefRangeEnd = 510923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNextSeperator(int startPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_FindNextSeperator_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00016DA4 File Offset: 0x00014FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510923, XrefRangeEnd = 510931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPrevSeperator(int startPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_FindPrevSeperator_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00016DF0 File Offset: 0x00014FF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 510940, RefRangeEnd = 510945, XrefRangeStart = 510931, XrefRangeEnd = 510940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveWordRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveWordRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00016E24 File Offset: 0x00015024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510945, XrefRangeEnd = 510949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToStartOfNextWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveToStartOfNextWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00016E58 File Offset: 0x00015058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510949, XrefRangeEnd = 510953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToEndOfPreviousWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveToEndOfPreviousWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00016E8C File Offset: 0x0001508C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510953, XrefRangeEnd = 510955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectToStartOfNextWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectToStartOfNextWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00016EC0 File Offset: 0x000150C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510955, XrefRangeEnd = 510957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectToEndOfPreviousWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectToEndOfPreviousWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00016EF4 File Offset: 0x000150F4
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 510965, RefRangeEnd = 511000, XrefRangeStart = 510957, XrefRangeEnd = 510965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextEditor.CharacterType ClassifyChar(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_ClassifyChar_Private_CharacterType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00016F40 File Offset: 0x00015140
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 511004, RefRangeEnd = 511009, XrefRangeStart = 511000, XrefRangeEnd = 511004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindStartOfNextWord(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_FindStartOfNextWord_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00016F8C File Offset: 0x0001518C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 511016, RefRangeEnd = 511021, XrefRangeStart = 511009, XrefRangeEnd = 511016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindEndOfPreviousWord(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_FindEndOfPreviousWord_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00016FD8 File Offset: 0x000151D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 511033, RefRangeEnd = 511038, XrefRangeStart = 511021, XrefRangeEnd = 511033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveWordLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MoveWordLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0001700C File Offset: 0x0001520C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511038, XrefRangeEnd = 511046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectWordRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectWordRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00017040 File Offset: 0x00015240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511046, XrefRangeEnd = 511054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectWordLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectWordLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00017074 File Offset: 0x00015274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511054, XrefRangeEnd = 511060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandSelectGraphicalLineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_ExpandSelectGraphicalLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000170A8 File Offset: 0x000152A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511060, XrefRangeEnd = 511066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandSelectGraphicalLineEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_ExpandSelectGraphicalLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000170DC File Offset: 0x000152DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511066, XrefRangeEnd = 511068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectGraphicalLineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectGraphicalLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00017110 File Offset: 0x00015310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511068, XrefRangeEnd = 511070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectGraphicalLineEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectGraphicalLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00017144 File Offset: 0x00015344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511070, XrefRangeEnd = 511073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectParagraphForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectParagraphForward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00017178 File Offset: 0x00015378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511075, RefRangeEnd = 511076, XrefRangeStart = 511073, XrefRangeEnd = 511075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectParagraphBackward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectParagraphBackward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000171AC File Offset: 0x000153AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511108, RefRangeEnd = 511109, XrefRangeStart = 511076, XrefRangeEnd = 511108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCurrentWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectCurrentWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000171E0 File Offset: 0x000153E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511109, XrefRangeEnd = 511116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindEndOfClassification(int p, TextEditor.Direction dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_FindEndOfClassification_Private_Int32_Int32_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00017238 File Offset: 0x00015438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511116, XrefRangeEnd = 511120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCurrentParagraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SelectCurrentParagraph_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001726C File Offset: 0x0001546C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511120, XrefRangeEnd = 511125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollOffsetIfNeeded(Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_UpdateScrollOffsetIfNeeded_Public_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000172B0 File Offset: 0x000154B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 511155, RefRangeEnd = 511159, XrefRangeStart = 511125, XrefRangeEnd = 511155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000172E4 File Offset: 0x000154E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511211, RefRangeEnd = 511212, XrefRangeStart = 511159, XrefRangeEnd = 511211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawCursor(string newText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_DrawCursor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00017328 File Offset: 0x00015528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511212, XrefRangeEnd = 511320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref operation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textIsReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_PerformOperation_Private_Boolean_TextEditOp_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00017380 File Offset: 0x00015580
		[CallerCount(0)]
		public unsafe void SaveBackup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_SaveBackup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000173B4 File Offset: 0x000155B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511320, XrefRangeEnd = 511322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Cut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_Cut_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000173F0 File Offset: 0x000155F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511329, RefRangeEnd = 511330, XrefRangeStart = 511322, XrefRangeEnd = 511329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_Copy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00017424 File Offset: 0x00015624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511330, XrefRangeEnd = 511352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReplaceNewlinesWithSpaces(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_ReplaceNewlinesWithSpaces_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00017460 File Offset: 0x00015660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511352, XrefRangeEnd = 511370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Paste()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_Paste_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001749C File Offset: 0x0001569C
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 511375, RefRangeEnd = 511412, XrefRangeStart = 511370, XrefRangeEnd = 511375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MapKey(string key, TextEditor.TextEditOp action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextEditOp_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000174E0 File Offset: 0x000156E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511556, RefRangeEnd = 511557, XrefRangeStart = 511412, XrefRangeEnd = 511556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitKeyActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_InitKeyActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00017514 File Offset: 0x00015714
		[CallerCount(0)]
		public unsafe void DetectFocusChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_DetectFocusChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00017548 File Offset: 0x00015748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511557, XrefRangeEnd = 511567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDetectFocusChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextEditor.NativeMethodInfoPtr_OnDetectFocusChange_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00017584 File Offset: 0x00015784
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCursorIndexChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextEditor.NativeMethodInfoPtr_OnCursorIndexChange_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000175C0 File Offset: 0x000157C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelectIndexChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextEditor.NativeMethodInfoPtr_OnSelectIndexChange_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000175FC File Offset: 0x000157FC
		[CallerCount(0)]
		public unsafe void ClampTextIndex(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_ClampTextIndex_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001763C File Offset: 0x0001583C
		[CallerCount(127)]
		[CachedScanResults(RefRangeStart = 511573, RefRangeEnd = 511700, XrefRangeStart = 511567, XrefRangeEnd = 511573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureValidCodePointIndex(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_EnsureValidCodePointIndex_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0001767C File Offset: 0x0001587C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511700, XrefRangeEnd = 511704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidCodePointIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_IsValidCodePointIndex_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000176C8 File Offset: 0x000158C8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 511709, RefRangeEnd = 511734, XrefRangeStart = 511704, XrefRangeEnd = 511709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PreviousCodePointIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_PreviousCodePointIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00017714 File Offset: 0x00015914
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 511739, RefRangeEnd = 511765, XrefRangeStart = 511734, XrefRangeEnd = 511739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NextCodePointIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr_NextCodePointIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000439F File Offset: 0x0000259F
		public TextEditor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00017760 File Offset: 0x00015960
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x000043A8 File Offset: 0x000025A8
		public unsafe TouchScreenKeyboard keyboardOnScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_keyboardOnScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_keyboardOnScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00017790 File Offset: 0x00015990
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x000043C7 File Offset: 0x000025C7
		public unsafe int controlID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_controlID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_controlID)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x000177B8 File Offset: 0x000159B8
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x000043E2 File Offset: 0x000025E2
		public unsafe GUIStyle style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x000177E8 File Offset: 0x000159E8
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00004401 File Offset: 0x00002601
		public unsafe bool multiline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_multiline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_multiline)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00017810 File Offset: 0x00015A10
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x0000441C File Offset: 0x0000261C
		public unsafe bool hasHorizontalCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_hasHorizontalCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_hasHorizontalCursorPos)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00017838 File Offset: 0x00015A38
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00004437 File Offset: 0x00002637
		public unsafe bool isPasswordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_isPasswordField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_isPasswordField)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00017860 File Offset: 0x00015A60
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00004452 File Offset: 0x00002652
		public unsafe bool m_HasFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_HasFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_HasFocus)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00017888 File Offset: 0x00015A88
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x0000446D File Offset: 0x0000266D
		public unsafe Vector2 scrollOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_scrollOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_scrollOffset)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x000178B0 File Offset: 0x00015AB0
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00004488 File Offset: 0x00002688
		public unsafe GUIContent m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000178E0 File Offset: 0x00015AE0
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x000044A7 File Offset: 0x000026A7
		public unsafe Rect m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00017908 File Offset: 0x00015B08
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x000044C2 File Offset: 0x000026C2
		public unsafe int m_CursorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_CursorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_CursorIndex)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00017930 File Offset: 0x00015B30
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x000044DD File Offset: 0x000026DD
		public unsafe int m_SelectIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_SelectIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_SelectIndex)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00017958 File Offset: 0x00015B58
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x000044F8 File Offset: 0x000026F8
		public unsafe bool m_RevealCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_RevealCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_RevealCursor)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00017980 File Offset: 0x00015B80
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00004513 File Offset: 0x00002713
		public unsafe Vector2 graphicalCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_graphicalCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_graphicalCursorPos)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000179A8 File Offset: 0x00015BA8
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x0000452E File Offset: 0x0000272E
		public unsafe Vector2 graphicalSelectCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_graphicalSelectCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_graphicalSelectCursorPos)) = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000179D0 File Offset: 0x00015BD0
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00004549 File Offset: 0x00002749
		public unsafe bool m_MouseDragSelectsWholeWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords)) = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000179F8 File Offset: 0x00015BF8
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00004564 File Offset: 0x00002764
		public unsafe int m_DblClickInitPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickInitPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickInitPos)) = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00017A20 File Offset: 0x00015C20
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x0000457F File Offset: 0x0000277F
		public unsafe TextEditor.DblClickSnapping m_DblClickSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickSnap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickSnap)) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00017A48 File Offset: 0x00015C48
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0000459A File Offset: 0x0000279A
		public unsafe bool m_bJustSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_bJustSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_bJustSelected)) = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00017A70 File Offset: 0x00015C70
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x000045B5 File Offset: 0x000027B5
		public unsafe int m_iAltCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_iAltCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_iAltCursorPos)) = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00017A98 File Offset: 0x00015C98
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x000045D0 File Offset: 0x000027D0
		public unsafe string oldText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_oldText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_oldText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00017AC0 File Offset: 0x00015CC0
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x000045EF File Offset: 0x000027EF
		public unsafe int oldPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_oldPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_oldPos)) = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00017AE8 File Offset: 0x00015CE8
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x0000460A File Offset: 0x0000280A
		public unsafe int oldSelectPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_oldSelectPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_oldSelectPos)) = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00017B10 File Offset: 0x00015D10
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00004625 File Offset: 0x00002825
		public unsafe static Dictionary<Event, TextEditor.TextEditOp> s_Keyactions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextEditor.NativeFieldInfoPtr_s_Keyactions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Event, TextEditor.TextEditOp>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextEditor.NativeFieldInfoPtr_s_Keyactions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00017B38 File Offset: 0x00015D38
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00004637 File Offset: 0x00002837
		public GUIContent content
		{
			get
			{
				return this.m_Content;
			}
			set
			{
				this.m_Content = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00017B50 File Offset: 0x00015D50
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00004641 File Offset: 0x00002841
		public TextEditor.DblClickSnapping doubleClickSnapping
		{
			get
			{
				return this.m_DblClickSnap;
			}
			set
			{
				this.m_DblClickSnap = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00017B68 File Offset: 0x00015D68
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x0000464B File Offset: 0x0000284B
		public int altCursorPosition
		{
			get
			{
				return this.m_iAltCursorPos;
			}
			set
			{
				this.m_iAltCursorPos = value;
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00017B80 File Offset: 0x00015D80
		public bool CanPaste()
		{
			return GUIUtility.systemCopyBuffer.Length != 0;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00017BA0 File Offset: 0x00015DA0
		public string SelectedText
		{
			get
			{
				bool flag = this.cursorIndex == this.selectIndex;
				string text;
				if (flag)
				{
					text = "";
				}
				else
				{
					bool flag2 = this.cursorIndex < this.selectIndex;
					if (flag2)
					{
						text = this.text.Substring(this.cursorIndex, this.selectIndex - this.cursorIndex);
					}
					else
					{
						text = this.text.Substring(this.selectIndex, this.cursorIndex - this.selectIndex);
					}
				}
				return text;
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00017C20 File Offset: 0x00015E20
		public void MoveSelectionToAltCursor()
		{
			bool flag = this.m_iAltCursorPos == -1;
			if (!flag)
			{
				int iAltCursorPos = this.m_iAltCursorPos;
				string selectedText = this.SelectedText;
				this.m_Content.text = this.text.Insert(iAltCursorPos, selectedText);
				bool flag2 = iAltCursorPos < this.cursorIndex;
				if (flag2)
				{
					this.cursorIndex += selectedText.Length;
					this.selectIndex += selectedText.Length;
				}
				this.DeleteSelection();
				this.selectIndex = (this.cursorIndex = iAltCursorPos);
				this.ClearCursorPos();
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00017CC0 File Offset: 0x00015EC0
		public void MoveAltCursorToPosition(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPosition + this.scrollOffset);
			this.m_iAltCursorPos = Mathf.Min(this.text.Length, cursorStringIndex);
			this.DetectFocusChange();
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00017D10 File Offset: 0x00015F10
		public bool IsOverSelection(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPosition + this.scrollOffset);
			return cursorStringIndex < Mathf.Max(this.cursorIndex, this.selectIndex) && cursorStringIndex > Mathf.Min(this.cursorIndex, this.selectIndex);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00004655 File Offset: 0x00002855
		public void Undo()
		{
			this.m_Content.text = this.oldText;
			this.cursorIndex = this.oldPos;
			this.selectIndex = this.oldSelectPos;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00017D74 File Offset: 0x00015F74
		public Il2CppStructArray<Rect> GetHyperlinksRect()
		{
			return this.style.Internal_GetHyperlinksRect(this.localPosition, this.m_Content);
		}

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_keyboardOnScreen;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_controlID;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_multiline;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_hasHorizontalCursorPos;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_isPasswordField;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFocus;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_scrollOffset;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorIndex;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectIndex;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_m_RevealCursor;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_graphicalCursorPos;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_graphicalSelectCursorPos;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseDragSelectsWholeWords;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_m_DblClickInitPos;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_m_DblClickSnap;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_m_bJustSelected;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_m_iAltCursorPos;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_oldText;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_oldPos;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_oldSelectPos;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_s_Keyactions;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Rect_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Rect_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Internal_Virtual_New_get_Rect_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_ClearCursorPos_Private_Void_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_OnFocus_Public_Void_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_OnLostFocus_Public_Void_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_GrabGraphicalCursorPos_Private_Void_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_HandleKeyEvent_Public_Boolean_Event_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_Boolean_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLineBack_Public_Boolean_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWordBack_Public_Boolean_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWordForward_Public_Boolean_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Boolean_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_Backspace_Public_Boolean_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Public_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_SelectNone_Public_Void_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSelection_Public_Boolean_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceSelection_Public_Void_String_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Char_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Public_Void_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Public_Void_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Public_Void_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Public_Void_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_MoveLineStart_Public_Void_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_MoveLineEnd_Public_Void_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_MoveGraphicalLineStart_Public_Void_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_MoveGraphicalLineEnd_Public_Void_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextStart_Public_Void_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextEnd_Public_Void_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfEndOfLine_Private_Int32_Int32_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_MoveParagraphForward_Public_Void_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_MoveParagraphBackward_Public_Void_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_MoveCursorToPosition_Public_Void_Vector2_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_MoveCursorToPosition_Internal_FamOrAssem_Void_Vector2_Boolean_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_SelectToPosition_Public_Void_Vector2_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_SelectLeft_Public_Void_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_SelectRight_Public_Void_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_SelectUp_Public_Void_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_SelectDown_Public_Void_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_SelectTextEnd_Public_Void_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_SelectTextStart_Public_Void_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_MouseDragSelectsWholeWords_Public_Void_Boolean_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_DblClickSnap_Public_Void_DblClickSnapping_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicalLineStart_Private_Int32_Int32_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicalLineEnd_Private_Int32_Int32_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_FindNextSeperator_Private_Int32_Int32_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_FindPrevSeperator_Private_Int32_Int32_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_MoveWordRight_Public_Void_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_MoveToStartOfNextWord_Public_Void_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_MoveToEndOfPreviousWord_Public_Void_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_SelectToStartOfNextWord_Public_Void_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_SelectToEndOfPreviousWord_Public_Void_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_ClassifyChar_Private_CharacterType_Int32_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_FindStartOfNextWord_Public_Int32_Int32_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfPreviousWord_Private_Int32_Int32_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_MoveWordLeft_Public_Void_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_SelectWordRight_Public_Void_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_SelectWordLeft_Public_Void_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_ExpandSelectGraphicalLineStart_Public_Void_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_ExpandSelectGraphicalLineEnd_Public_Void_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_SelectGraphicalLineStart_Public_Void_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_SelectGraphicalLineEnd_Public_Void_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_SelectParagraphForward_Public_Void_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_SelectParagraphBackward_Public_Void_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_SelectCurrentWord_Public_Void_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfClassification_Private_Int32_Int32_Direction_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_SelectCurrentParagraph_Public_Void_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollOffsetIfNeeded_Public_Void_Event_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_DrawCursor_Public_Void_String_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_PerformOperation_Private_Boolean_TextEditOp_Boolean_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_SaveBackup_Public_Void_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_Cut_Public_Boolean_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Void_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceNewlinesWithSpaces_Private_Static_String_String_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_Paste_Public_Boolean_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextEditOp_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_InitKeyActions_Private_Void_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_DetectFocusChange_Public_Void_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_OnDetectFocusChange_Internal_Virtual_New_Void_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_OnCursorIndexChange_Internal_Virtual_New_Void_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectIndexChange_Internal_Virtual_New_Void_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_ClampTextIndex_Private_Void_byref_Int32_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_EnsureValidCodePointIndex_Private_Void_byref_Int32_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCodePointIndex_Private_Boolean_Int32_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_PreviousCodePointIndex_Private_Int32_Int32_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_NextCodePointIndex_Private_Int32_Int32_0;

		// Token: 0x0200009D RID: 157
		[OriginalName("UnityEngine.IMGUIModule.dll", "", "DblClickSnapping")]
		public enum DblClickSnapping : byte
		{
			// Token: 0x040003E6 RID: 998
			WORDS,
			// Token: 0x040003E7 RID: 999
			PARAGRAPHS
		}

		// Token: 0x0200009E RID: 158
		[OriginalName("UnityEngine.IMGUIModule.dll", "", "CharacterType")]
		public enum CharacterType
		{
			// Token: 0x040003E9 RID: 1001
			LetterLike,
			// Token: 0x040003EA RID: 1002
			Symbol,
			// Token: 0x040003EB RID: 1003
			Symbol2,
			// Token: 0x040003EC RID: 1004
			WhiteSpace
		}

		// Token: 0x0200009F RID: 159
		[OriginalName("UnityEngine.IMGUIModule.dll", "", "Direction")]
		public enum Direction
		{
			// Token: 0x040003EE RID: 1006
			Forward,
			// Token: 0x040003EF RID: 1007
			Backward
		}

		// Token: 0x020000A0 RID: 160
		[OriginalName("UnityEngine.IMGUIModule.dll", "", "TextEditOp")]
		public enum TextEditOp
		{
			// Token: 0x040003F1 RID: 1009
			MoveLeft,
			// Token: 0x040003F2 RID: 1010
			MoveRight,
			// Token: 0x040003F3 RID: 1011
			MoveUp,
			// Token: 0x040003F4 RID: 1012
			MoveDown,
			// Token: 0x040003F5 RID: 1013
			MoveLineStart,
			// Token: 0x040003F6 RID: 1014
			MoveLineEnd,
			// Token: 0x040003F7 RID: 1015
			MoveTextStart,
			// Token: 0x040003F8 RID: 1016
			MoveTextEnd,
			// Token: 0x040003F9 RID: 1017
			MovePageUp,
			// Token: 0x040003FA RID: 1018
			MovePageDown,
			// Token: 0x040003FB RID: 1019
			MoveGraphicalLineStart,
			// Token: 0x040003FC RID: 1020
			MoveGraphicalLineEnd,
			// Token: 0x040003FD RID: 1021
			MoveWordLeft,
			// Token: 0x040003FE RID: 1022
			MoveWordRight,
			// Token: 0x040003FF RID: 1023
			MoveParagraphForward,
			// Token: 0x04000400 RID: 1024
			MoveParagraphBackward,
			// Token: 0x04000401 RID: 1025
			MoveToStartOfNextWord,
			// Token: 0x04000402 RID: 1026
			MoveToEndOfPreviousWord,
			// Token: 0x04000403 RID: 1027
			SelectLeft,
			// Token: 0x04000404 RID: 1028
			SelectRight,
			// Token: 0x04000405 RID: 1029
			SelectUp,
			// Token: 0x04000406 RID: 1030
			SelectDown,
			// Token: 0x04000407 RID: 1031
			SelectTextStart,
			// Token: 0x04000408 RID: 1032
			SelectTextEnd,
			// Token: 0x04000409 RID: 1033
			SelectPageUp,
			// Token: 0x0400040A RID: 1034
			SelectPageDown,
			// Token: 0x0400040B RID: 1035
			ExpandSelectGraphicalLineStart,
			// Token: 0x0400040C RID: 1036
			ExpandSelectGraphicalLineEnd,
			// Token: 0x0400040D RID: 1037
			SelectGraphicalLineStart,
			// Token: 0x0400040E RID: 1038
			SelectGraphicalLineEnd,
			// Token: 0x0400040F RID: 1039
			SelectWordLeft,
			// Token: 0x04000410 RID: 1040
			SelectWordRight,
			// Token: 0x04000411 RID: 1041
			SelectToEndOfPreviousWord,
			// Token: 0x04000412 RID: 1042
			SelectToStartOfNextWord,
			// Token: 0x04000413 RID: 1043
			SelectParagraphBackward,
			// Token: 0x04000414 RID: 1044
			SelectParagraphForward,
			// Token: 0x04000415 RID: 1045
			Delete,
			// Token: 0x04000416 RID: 1046
			Backspace,
			// Token: 0x04000417 RID: 1047
			DeleteWordBack,
			// Token: 0x04000418 RID: 1048
			DeleteWordForward,
			// Token: 0x04000419 RID: 1049
			DeleteLineBack,
			// Token: 0x0400041A RID: 1050
			Cut,
			// Token: 0x0400041B RID: 1051
			Copy,
			// Token: 0x0400041C RID: 1052
			Paste,
			// Token: 0x0400041D RID: 1053
			SelectAll,
			// Token: 0x0400041E RID: 1054
			SelectNone,
			// Token: 0x0400041F RID: 1055
			ScrollStart,
			// Token: 0x04000420 RID: 1056
			ScrollEnd,
			// Token: 0x04000421 RID: 1057
			ScrollPageUp,
			// Token: 0x04000422 RID: 1058
			ScrollPageDown
		}
	}
}
