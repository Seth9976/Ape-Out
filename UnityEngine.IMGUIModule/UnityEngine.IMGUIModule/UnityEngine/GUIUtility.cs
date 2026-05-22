using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public class GUIUtility : Object
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x0001164C File Offset: 0x0000F84C
		// Note: this type is marked as 'beforefieldinit'.
		static GUIUtility()
		{
			Il2CppClassPointerStore<GUIUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr);
			GUIUtility.NativeFieldInfoPtr_s_ControlCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_ControlCount");
			GUIUtility.NativeFieldInfoPtr_s_SkinMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_SkinMode");
			GUIUtility.NativeFieldInfoPtr_s_OriginalID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_OriginalID");
			GUIUtility.NativeFieldInfoPtr_takeCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "takeCapture");
			GUIUtility.NativeFieldInfoPtr_releaseCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "releaseCapture");
			GUIUtility.NativeFieldInfoPtr_processEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "processEvent");
			GUIUtility.NativeFieldInfoPtr_endContainerGUIFromException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "endContainerGUIFromException");
			GUIUtility.NativeFieldInfoPtr_guiChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "guiChanged");
			GUIUtility.NativeFieldInfoPtr__guiIsExiting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "<guiIsExiting>k__BackingField");
			GUIUtility.NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_HasCurrentWindowKeyFocusFunc");
			GUIUtility.NativeMethodInfoPtr_get_pixelsPerPoint_Internal_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663667);
			GUIUtility.NativeMethodInfoPtr_get_guiDepth_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663668);
			GUIUtility.NativeMethodInfoPtr_set_mouseUsed_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663669);
			GUIUtility.NativeMethodInfoPtr_set_textFieldInput_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663670);
			GUIUtility.NativeMethodInfoPtr_get_systemCopyBuffer_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663671);
			GUIUtility.NativeMethodInfoPtr_set_systemCopyBuffer_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663672);
			GUIUtility.NativeMethodInfoPtr_Internal_GetControlID_Private_Static_Int32_Int32_FocusType_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663673);
			GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663674);
			GUIUtility.NativeMethodInfoPtr_get_compositionString_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663675);
			GUIUtility.NativeMethodInfoPtr_set_compositionCursorPos_Internal_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663676);
			GUIUtility.NativeMethodInfoPtr_Internal_GetHotControl_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663677);
			GUIUtility.NativeMethodInfoPtr_Internal_GetKeyboardControl_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663678);
			GUIUtility.NativeMethodInfoPtr_Internal_SetHotControl_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663679);
			GUIUtility.NativeMethodInfoPtr_Internal_SetKeyboardControl_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663680);
			GUIUtility.NativeMethodInfoPtr_Internal_GetDefaultSkin_Private_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663681);
			GUIUtility.NativeMethodInfoPtr_Internal_ExitGUI_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663682);
			GUIUtility.NativeMethodInfoPtr_MarkGUIChanged_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663683);
			GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_FocusType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663684);
			GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663685);
			GUIUtility.NativeMethodInfoPtr_GetStateObject_Public_Static_Object_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663686);
			GUIUtility.NativeMethodInfoPtr_set_guiIsExiting_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663687);
			GUIUtility.NativeMethodInfoPtr_get_hotControl_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663688);
			GUIUtility.NativeMethodInfoPtr_set_hotControl_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663689);
			GUIUtility.NativeMethodInfoPtr_TakeCapture_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663690);
			GUIUtility.NativeMethodInfoPtr_RemoveCapture_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663691);
			GUIUtility.NativeMethodInfoPtr_get_keyboardControl_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663692);
			GUIUtility.NativeMethodInfoPtr_set_keyboardControl_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663693);
			GUIUtility.NativeMethodInfoPtr_HasKeyFocus_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663694);
			GUIUtility.NativeMethodInfoPtr_GetDefaultSkin_Internal_Static_GUISkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663695);
			GUIUtility.NativeMethodInfoPtr_ProcessEvent_Internal_Static_Void_Int32_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663696);
			GUIUtility.NativeMethodInfoPtr_BeginGUI_Internal_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663697);
			GUIUtility.NativeMethodInfoPtr_EndGUI_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663698);
			GUIUtility.NativeMethodInfoPtr_EndGUIFromException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663699);
			GUIUtility.NativeMethodInfoPtr_EndContainerGUIFromException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663700);
			GUIUtility.NativeMethodInfoPtr_ResetGlobalState_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663701);
			GUIUtility.NativeMethodInfoPtr_IsExitGUIException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663702);
			GUIUtility.NativeMethodInfoPtr_ShouldRethrowException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663703);
			GUIUtility.NativeMethodInfoPtr_CheckOnGUI_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663704);
			GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663705);
			GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663706);
			GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663707);
			GUIUtility.NativeMethodInfoPtr_Internal_GetControlID_Injected_Private_Static_Int32_Int32_FocusType_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663709);
			GUIUtility.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663710);
			GUIUtility.get_hasModalWindowDelegateField = IL2CPP.ResolveICall<GUIUtility.get_hasModalWindowDelegate>("UnityEngine.GUIUtility::get_hasModalWindow");
			GUIUtility.get_mouseUsedDelegateField = IL2CPP.ResolveICall<GUIUtility.get_mouseUsedDelegate>("UnityEngine.GUIUtility::get_mouseUsed");
			GUIUtility.get_textFieldInputDelegateField = IL2CPP.ResolveICall<GUIUtility.get_textFieldInputDelegate>("UnityEngine.GUIUtility::get_textFieldInput");
			GUIUtility.get_manualTex2SRGBEnabledDelegateField = IL2CPP.ResolveICall<GUIUtility.get_manualTex2SRGBEnabledDelegate>("UnityEngine.GUIUtility::get_manualTex2SRGBEnabled");
			GUIUtility.set_manualTex2SRGBEnabledDelegateField = IL2CPP.ResolveICall<GUIUtility.set_manualTex2SRGBEnabledDelegate>("UnityEngine.GUIUtility::set_manualTex2SRGBEnabled");
			GUIUtility.BeginContainerFromOwnerDelegateField = IL2CPP.ResolveICall<GUIUtility.BeginContainerFromOwnerDelegate>("UnityEngine.GUIUtility::BeginContainerFromOwner");
			GUIUtility.BeginContainerDelegateField = IL2CPP.ResolveICall<GUIUtility.BeginContainerDelegate>("UnityEngine.GUIUtility::BeginContainer");
			GUIUtility.Internal_EndContainerDelegateField = IL2CPP.ResolveICall<GUIUtility.Internal_EndContainerDelegate>("UnityEngine.GUIUtility::Internal_EndContainer");
			GUIUtility.GetPermanentControlIDDelegateField = IL2CPP.ResolveICall<GUIUtility.GetPermanentControlIDDelegate>("UnityEngine.GUIUtility::GetPermanentControlID");
			GUIUtility.CheckForTabEventDelegateField = IL2CPP.ResolveICall<GUIUtility.CheckForTabEventDelegate>("UnityEngine.GUIUtility::CheckForTabEvent");
			GUIUtility.SetKeyboardControlToFirstControlIdDelegateField = IL2CPP.ResolveICall<GUIUtility.SetKeyboardControlToFirstControlIdDelegate>("UnityEngine.GUIUtility::SetKeyboardControlToFirstControlId");
			GUIUtility.SetKeyboardControlToLastControlIdDelegateField = IL2CPP.ResolveICall<GUIUtility.SetKeyboardControlToLastControlIdDelegate>("UnityEngine.GUIUtility::SetKeyboardControlToLastControlId");
			GUIUtility.HasFocusableControlsDelegateField = IL2CPP.ResolveICall<GUIUtility.HasFocusableControlsDelegate>("UnityEngine.GUIUtility::HasFocusableControls");
			GUIUtility.OwnsIdDelegateField = IL2CPP.ResolveICall<GUIUtility.OwnsIdDelegate>("UnityEngine.GUIUtility::OwnsId");
			GUIUtility.get_imeCompositionModeDelegateField = IL2CPP.ResolveICall<GUIUtility.get_imeCompositionModeDelegate>("UnityEngine.GUIUtility::get_imeCompositionMode");
			GUIUtility.set_imeCompositionModeDelegateField = IL2CPP.ResolveICall<GUIUtility.set_imeCompositionModeDelegate>("UnityEngine.GUIUtility::set_imeCompositionMode");
			GUIUtility.GetChangedDelegateField = IL2CPP.ResolveICall<GUIUtility.GetChangedDelegate>("UnityEngine.GUIUtility::GetChanged");
			GUIUtility.SetChangedDelegateField = IL2CPP.ResolveICall<GUIUtility.SetChangedDelegate>("UnityEngine.GUIUtility::SetChanged");
			GUIUtility.SetDidGUIWindowsEatLastEventDelegateField = IL2CPP.ResolveICall<GUIUtility.SetDidGUIWindowsEatLastEventDelegate>("UnityEngine.GUIUtility::SetDidGUIWindowsEatLastEvent");
			GUIUtility.Internal_GetBuiltinSkinDelegateField = IL2CPP.ResolveICall<GUIUtility.Internal_GetBuiltinSkinDelegate>("UnityEngine.GUIUtility::Internal_GetBuiltinSkin");
			GUIUtility.get_s_EditorScreenPointOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.get_s_EditorScreenPointOffset_InjectedDelegate>("UnityEngine.GUIUtility::get_s_EditorScreenPointOffset_Injected");
			GUIUtility.set_s_EditorScreenPointOffset_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.set_s_EditorScreenPointOffset_InjectedDelegate>("UnityEngine.GUIUtility::set_s_EditorScreenPointOffset_Injected");
			GUIUtility.AlignRectToDevice_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.AlignRectToDevice_InjectedDelegate>("UnityEngine.GUIUtility::AlignRectToDevice_Injected");
			GUIUtility.get_compositionCursorPos_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.get_compositionCursorPos_InjectedDelegate>("UnityEngine.GUIUtility::get_compositionCursorPos_Injected");
			GUIUtility.Internal_MultiplyPoint_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.Internal_MultiplyPoint_InjectedDelegate>("UnityEngine.GUIUtility::Internal_MultiplyPoint_Injected");
			GUIUtility.InternalWindowToScreenPoint_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.InternalWindowToScreenPoint_InjectedDelegate>("UnityEngine.GUIUtility::InternalWindowToScreenPoint_Injected");
			GUIUtility.InternalScreenToWindowPoint_InjectedDelegateField = IL2CPP.ResolveICall<GUIUtility.InternalScreenToWindowPoint_InjectedDelegate>("UnityEngine.GUIUtility::InternalScreenToWindowPoint_Injected");
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00011C38 File Offset: 0x0000FE38
		public unsafe static float pixelsPerPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509321, XrefRangeEnd = 509325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_pixelsPerPoint_Internal_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00011C68 File Offset: 0x0000FE68
		public unsafe static int guiDepth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509325, XrefRangeEnd = 509329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_guiDepth_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00003A07 File Offset: 0x00001C07
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00011C98 File Offset: 0x0000FE98
		public unsafe static bool mouseUsed
		{
			get
			{
				return GUIUtility.get_mouseUsedDelegateField();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509329, XrefRangeEnd = 509333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_mouseUsed_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00003A13 File Offset: 0x00001C13
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x00011CCC File Offset: 0x0000FECC
		public unsafe static bool textFieldInput
		{
			get
			{
				return GUIUtility.get_textFieldInputDelegateField();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509333, XrefRangeEnd = 509337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_textFieldInput_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00011D00 File Offset: 0x0000FF00
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x00011D2C File Offset: 0x0000FF2C
		public unsafe static string systemCopyBuffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509337, XrefRangeEnd = 509341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_systemCopyBuffer_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509341, XrefRangeEnd = 509345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_systemCopyBuffer_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00011D64 File Offset: 0x0000FF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509345, XrefRangeEnd = 509350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetControlID(int hint, FocusType focusType, Rect rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focusType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetControlID_Private_Static_Int32_Int32_FocusType_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 509359, RefRangeEnd = 509366, XrefRangeStart = 509350, XrefRangeEnd = 509359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetControlID(int hint, FocusType focusType, Rect rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focusType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00011E1C File Offset: 0x0001001C
		public unsafe static string compositionString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 509370, RefRangeEnd = 509371, XrefRangeStart = 509366, XrefRangeEnd = 509370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_compositionString_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000127D4 File Offset: 0x000109D4
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00011E48 File Offset: 0x00010048
		public unsafe static Vector2 compositionCursorPos
		{
			get
			{
				Vector2 vector;
				GUIUtility.get_compositionCursorPos_Injected(out vector);
				return vector;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509371, XrefRangeEnd = 509376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_compositionCursorPos_Internal_Static_set_Void_Vector2_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00011E7C File Offset: 0x0001007C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509376, XrefRangeEnd = 509380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetHotControl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetHotControl_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00011EAC File Offset: 0x000100AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509380, XrefRangeEnd = 509384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetKeyboardControl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetKeyboardControl_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00011EDC File Offset: 0x000100DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509384, XrefRangeEnd = 509388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetHotControl(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_SetHotControl_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00011F10 File Offset: 0x00010110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509388, XrefRangeEnd = 509392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetKeyboardControl(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_SetKeyboardControl_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00011F44 File Offset: 0x00010144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509392, XrefRangeEnd = 509396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_GetDefaultSkin(int skinMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skinMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetDefaultSkin_Private_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00011F84 File Offset: 0x00010184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509396, XrefRangeEnd = 509400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ExitGUI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_ExitGUI_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00011FAC File Offset: 0x000101AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509400, XrefRangeEnd = 509405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkGUIChanged()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_MarkGUIChanged_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00011FD4 File Offset: 0x000101D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509405, XrefRangeEnd = 509409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetControlID(FocusType focus)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_FocusType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00012014 File Offset: 0x00010214
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 509413, RefRangeEnd = 509430, XrefRangeStart = 509409, XrefRangeEnd = 509413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetControlID(int hint, FocusType focus)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00012060 File Offset: 0x00010260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 509434, RefRangeEnd = 509436, XrefRangeStart = 509430, XrefRangeEnd = 509434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetStateObject(Type t, int controlID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_GetStateObject_Public_Static_Object_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00003AF6 File Offset: 0x00001CF6
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x000120B4 File Offset: 0x000102B4
		public unsafe static bool guiIsExiting
		{
			get
			{
				return GUIUtility._guiIsExiting_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509436, XrefRangeEnd = 509440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_guiIsExiting_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x000120E8 File Offset: 0x000102E8
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00012118 File Offset: 0x00010318
		public unsafe static int hotControl
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 509447, RefRangeEnd = 509454, XrefRangeStart = 509440, XrefRangeEnd = 509447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_hotControl_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 509461, RefRangeEnd = 509468, XrefRangeStart = 509454, XrefRangeEnd = 509461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_hotControl_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001214C File Offset: 0x0001034C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509468, XrefRangeEnd = 509473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TakeCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_TakeCapture_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00012174 File Offset: 0x00010374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509473, XrefRangeEnd = 509478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_RemoveCapture_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001219C File Offset: 0x0001039C
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x000121CC File Offset: 0x000103CC
		public unsafe static int keyboardControl
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 509485, RefRangeEnd = 509499, XrefRangeStart = 509478, XrefRangeEnd = 509485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_get_keyboardControl_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 509506, RefRangeEnd = 509508, XrefRangeStart = 509499, XrefRangeEnd = 509506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_keyboardControl_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00012200 File Offset: 0x00010400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509508, XrefRangeEnd = 509513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasKeyFocus(int controlID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_HasKeyFocus_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00012240 File Offset: 0x00010440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509513, XrefRangeEnd = 509520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUISkin GetDefaultSkin()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_GetDefaultSkin_Internal_Static_GUISkin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr3) : null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00012274 File Offset: 0x00010474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509520, XrefRangeEnd = 509529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeEventPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_ProcessEvent_Internal_Static_Void_Int32_IntPtr_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000122C4 File Offset: 0x000104C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509529, XrefRangeEnd = 509553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skinMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useGUILayout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_BeginGUI_Internal_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00012314 File Offset: 0x00010514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509553, XrefRangeEnd = 509581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndGUI(int layoutType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layoutType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_EndGUI_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00012348 File Offset: 0x00010548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509581, XrefRangeEnd = 509594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndGUIFromException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_EndGUIFromException_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0001238C File Offset: 0x0001058C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509594, XrefRangeEnd = 509599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndContainerGUIFromException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_EndContainerGUIFromException_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000123D0 File Offset: 0x000105D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509599, XrefRangeEnd = 509617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetGlobalState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_ResetGlobalState_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000123F8 File Offset: 0x000105F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509617, XrefRangeEnd = 509622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsExitGUIException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_IsExitGUIException_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0001243C File Offset: 0x0001063C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509622, XrefRangeEnd = 509630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldRethrowException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_ShouldRethrowException_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00012480 File Offset: 0x00010680
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 509635, RefRangeEnd = 509659, XrefRangeStart = 509630, XrefRangeEnd = 509635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckOnGUI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_CheckOnGUI_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000124A8 File Offset: 0x000106A8
		[CallerCount(0)]
		public unsafe static bool HitTest(Rect rect, Vector2 point, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00012504 File Offset: 0x00010704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509659, XrefRangeEnd = 509662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectManipulationDevice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00012560 File Offset: 0x00010760
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 509675, RefRangeEnd = 509681, XrefRangeStart = 509662, XrefRangeEnd = 509675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HitTest(Rect rect, Event evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Event_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000125B0 File Offset: 0x000107B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509681, XrefRangeEnd = 509685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focusType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_Internal_GetControlID_Injected_Private_Static_Int32_Int32_FocusType_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001260C File Offset: 0x0001080C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509685, XrefRangeEnd = 509689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_compositionCursorPos_Injected(ref Vector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIUtility.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00003945 File Offset: 0x00001B45
		public GUIUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00012640 File Offset: 0x00010840
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x0000394E File Offset: 0x00001B4E
		public unsafe static int s_ControlCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_s_ControlCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_s_ControlCount, (void*)(&value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0001265C File Offset: 0x0001085C
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x0000395C File Offset: 0x00001B5C
		public unsafe static int s_SkinMode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_s_SkinMode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_s_SkinMode, (void*)(&value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00012678 File Offset: 0x00010878
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0000396A File Offset: 0x00001B6A
		public unsafe static int s_OriginalID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_s_OriginalID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_s_OriginalID, (void*)(&value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00012694 File Offset: 0x00010894
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00003978 File Offset: 0x00001B78
		public unsafe static Action takeCapture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_takeCapture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_takeCapture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x000126BC File Offset: 0x000108BC
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0000398A File Offset: 0x00001B8A
		public unsafe static Action releaseCapture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_releaseCapture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_releaseCapture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x000126E4 File Offset: 0x000108E4
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x0000399C File Offset: 0x00001B9C
		public unsafe static Func<int, IntPtr, bool> processEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_processEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IntPtr, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_processEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0001270C File Offset: 0x0001090C
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000039AE File Offset: 0x00001BAE
		public unsafe static Func<Exception, bool> endContainerGUIFromException
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_endContainerGUIFromException, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_endContainerGUIFromException, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00012734 File Offset: 0x00010934
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000039C0 File Offset: 0x00001BC0
		public unsafe static Action guiChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_guiChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_guiChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0001275C File Offset: 0x0001095C
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x000039D2 File Offset: 0x00001BD2
		public unsafe static bool _guiIsExiting_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr__guiIsExiting_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr__guiIsExiting_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00012778 File Offset: 0x00010978
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000039E0 File Offset: 0x00001BE0
		public unsafe static Func<bool> s_HasCurrentWindowKeyFocusFunc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIUtility.NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIUtility.NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000039F2 File Offset: 0x00001BF2
		public static bool hasModalWindow
		{
			get
			{
				return GUIUtility.get_hasModalWindowDelegateField();
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x000127A0 File Offset: 0x000109A0
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x000039FE File Offset: 0x00001BFE
		public static Vector2 s_EditorScreenPointOffset
		{
			get
			{
				Vector2 vector;
				GUIUtility.get_s_EditorScreenPointOffset_Injected(out vector);
				return vector;
			}
			set
			{
				GUIUtility.set_s_EditorScreenPointOffset_Injected(ref value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00003A1F File Offset: 0x00001C1F
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00003A2B File Offset: 0x00001C2B
		public static bool manualTex2SRGBEnabled
		{
			get
			{
				return GUIUtility.get_manualTex2SRGBEnabledDelegateField();
			}
			set
			{
				GUIUtility.set_manualTex2SRGBEnabledDelegateField(value);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00003A38 File Offset: 0x00001C38
		public static void BeginContainerFromOwner(ScriptableObject owner)
		{
			GUIUtility.BeginContainerFromOwnerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(owner));
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00003A4A File Offset: 0x00001C4A
		public static void BeginContainer(ObjectGUIState objectGUIState)
		{
			GUIUtility.BeginContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(objectGUIState));
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00003A5C File Offset: 0x00001C5C
		public static void Internal_EndContainer()
		{
			GUIUtility.Internal_EndContainerDelegateField();
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00003A68 File Offset: 0x00001C68
		public static int GetPermanentControlID()
		{
			return GUIUtility.GetPermanentControlIDDelegateField();
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00003A74 File Offset: 0x00001C74
		public static int CheckForTabEvent(Event evt)
		{
			return GUIUtility.CheckForTabEventDelegateField(IL2CPP.Il2CppObjectBaseToPtr(evt));
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00003A86 File Offset: 0x00001C86
		public static void SetKeyboardControlToFirstControlId()
		{
			GUIUtility.SetKeyboardControlToFirstControlIdDelegateField();
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00003A92 File Offset: 0x00001C92
		public static void SetKeyboardControlToLastControlId()
		{
			GUIUtility.SetKeyboardControlToLastControlIdDelegateField();
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00003A9E File Offset: 0x00001C9E
		public static bool HasFocusableControls()
		{
			return GUIUtility.HasFocusableControlsDelegateField();
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00003AAA File Offset: 0x00001CAA
		public static bool OwnsId(int id)
		{
			return GUIUtility.OwnsIdDelegateField(id);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000127B8 File Offset: 0x000109B8
		public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels)
		{
			Rect rect2;
			GUIUtility.AlignRectToDevice_Injected(ref rect, out widthInPixels, out heightInPixels, out rect2);
			return rect2;
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00003AB7 File Offset: 0x00001CB7
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003AC3 File Offset: 0x00001CC3
		public static IMECompositionMode imeCompositionMode
		{
			get
			{
				return GUIUtility.get_imeCompositionModeDelegateField();
			}
			set
			{
				GUIUtility.set_imeCompositionModeDelegateField(value);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000127EC File Offset: 0x000109EC
		public static Vector3 Internal_MultiplyPoint(Vector3 point, Matrix4x4 transform)
		{
			Vector3 vector;
			GUIUtility.Internal_MultiplyPoint_Injected(ref point, ref transform, out vector);
			return vector;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00003AD0 File Offset: 0x00001CD0
		public static bool GetChanged()
		{
			return GUIUtility.GetChangedDelegateField();
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00003ADC File Offset: 0x00001CDC
		public static void SetChanged(bool changed)
		{
			GUIUtility.SetChangedDelegateField(changed);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00003AE9 File Offset: 0x00001CE9
		public static void SetDidGUIWindowsEatLastEvent(bool value)
		{
			GUIUtility.SetDidGUIWindowsEatLastEventDelegateField(value);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00012808 File Offset: 0x00010A08
		public static Object Internal_GetBuiltinSkin(int skin)
		{
			IntPtr intPtr = GUIUtility.Internal_GetBuiltinSkinDelegateField(skin);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00012830 File Offset: 0x00010A30
		public static Vector2 InternalWindowToScreenPoint(Vector2 windowPoint)
		{
			Vector2 vector;
			GUIUtility.InternalWindowToScreenPoint_Injected(ref windowPoint, out vector);
			return vector;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00012848 File Offset: 0x00010A48
		public static Vector2 InternalScreenToWindowPoint(Vector2 screenPoint)
		{
			Vector2 vector;
			GUIUtility.InternalScreenToWindowPoint_Injected(ref screenPoint, out vector);
			return vector;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00012860 File Offset: 0x00010A60
		public static int GetControlID(GUIContent contents, FocusType focus)
		{
			return GUIUtility.GetControlID(contents.hash, focus);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00012880 File Offset: 0x00010A80
		public static int GetControlID(FocusType focus, Rect position)
		{
			return GUIUtility.GetControlID(0, focus, position);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0001289C File Offset: 0x00010A9C
		public static int GetControlID(GUIContent contents, FocusType focus, Rect position)
		{
			return GUIUtility.GetControlID(contents.hash, focus, position);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000128BC File Offset: 0x00010ABC
		public static Object QueryStateObject(Type t, int controlID)
		{
			return GUIStateObjects.QueryStateObject(t, controlID);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00003AFD File Offset: 0x00001CFD
		public static void ExitGUI()
		{
			throw new ExitGUIException();
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000128D8 File Offset: 0x00010AD8
		public static GUISkin GetDefaultSkin(int skinMode)
		{
			return GUIUtility.Internal_GetDefaultSkin(skinMode).TryCast<GUISkin>();
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000128F8 File Offset: 0x00010AF8
		public static GUISkin GetBuiltinSkin(int skin)
		{
			return GUIUtility.Internal_GetBuiltinSkin(skin).TryCast<GUISkin>();
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00003B05 File Offset: 0x00001D05
		public static void EndContainer()
		{
			GUIUtility.Internal_EndContainer();
			GUIUtility.Internal_ExitGUI();
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00003B14 File Offset: 0x00001D14
		public static void CleanupRoots()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00012918 File Offset: 0x00010B18
		public static float RoundToPixelGrid(float v)
		{
			return Mathf.Floor(v * GUIUtility.pixelsPerPoint + 0.48f) / GUIUtility.pixelsPerPoint;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00012944 File Offset: 0x00010B44
		public static Vector2 GUIToScreenPoint(Vector2 guiPoint)
		{
			return GUIUtility.InternalWindowToScreenPoint(GUIClip.UnclipToWindow(guiPoint));
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00012964 File Offset: 0x00010B64
		public static Rect GUIToScreenRect(Rect guiRect)
		{
			Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(guiRect.x, guiRect.y));
			guiRect.x = vector.x;
			guiRect.y = vector.y;
			return guiRect;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000129AC File Offset: 0x00010BAC
		public static Vector2 ScreenToGUIPoint(Vector2 screenPoint)
		{
			return GUIClip.ClipToWindow(GUIUtility.InternalScreenToWindowPoint(screenPoint));
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000129CC File Offset: 0x00010BCC
		public static Rect ScreenToGUIRect(Rect screenRect)
		{
			Vector2 vector = GUIUtility.ScreenToGUIPoint(new Vector2(screenRect.x, screenRect.y));
			screenRect.x = vector.x;
			screenRect.y = vector.y;
			return screenRect;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00012A14 File Offset: 0x00010C14
		public static void RotateAroundPivot(float angle, Vector2 pivotPoint)
		{
			Matrix4x4 matrix = GUI.matrix;
			GUI.matrix = Matrix4x4.identity;
			Vector2 vector = GUIClip.Unclip(pivotPoint);
			Matrix4x4 matrix4x = Matrix4x4.TRS(vector, Quaternion.Euler(0f, 0f, angle), Vector3.one) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
			GUI.matrix = matrix4x * matrix;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00012A88 File Offset: 0x00010C88
		public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint)
		{
			Matrix4x4 matrix = GUI.matrix;
			Vector2 vector = GUIClip.Unclip(pivotPoint);
			Matrix4x4 matrix4x = Matrix4x4.TRS(vector, Quaternion.identity, new Vector3(scale.x, scale.y, 1f)) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
			GUI.matrix = matrix4x * matrix;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00012AF8 File Offset: 0x00010CF8
		public static Rect AlignRectToDevice(Rect rect)
		{
			int num;
			int num2;
			return GUIUtility.AlignRectToDevice(rect, out num, out num2);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00003B21 File Offset: 0x00001D21
		public static void get_s_EditorScreenPointOffset_Injected(out Vector2 ret)
		{
			GUIUtility.get_s_EditorScreenPointOffset_InjectedDelegateField(out ret);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00003B2E File Offset: 0x00001D2E
		public static void set_s_EditorScreenPointOffset_Injected(ref Vector2 value)
		{
			GUIUtility.set_s_EditorScreenPointOffset_InjectedDelegateField(ref value);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00003B3B File Offset: 0x00001D3B
		public static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret)
		{
			GUIUtility.AlignRectToDevice_InjectedDelegateField(ref rect, out widthInPixels, out heightInPixels, out ret);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00003B4B File Offset: 0x00001D4B
		public static void get_compositionCursorPos_Injected(out Vector2 ret)
		{
			GUIUtility.get_compositionCursorPos_InjectedDelegateField(out ret);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00003B58 File Offset: 0x00001D58
		public static void Internal_MultiplyPoint_Injected(ref Vector3 point, ref Matrix4x4 transform, out Vector3 ret)
		{
			GUIUtility.Internal_MultiplyPoint_InjectedDelegateField(ref point, ref transform, out ret);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00003B67 File Offset: 0x00001D67
		public static void InternalWindowToScreenPoint_Injected(ref Vector2 windowPoint, out Vector2 ret)
		{
			GUIUtility.InternalWindowToScreenPoint_InjectedDelegateField(ref windowPoint, out ret);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00003B75 File Offset: 0x00001D75
		public static void InternalScreenToWindowPoint_Injected(ref Vector2 screenPoint, out Vector2 ret)
		{
			GUIUtility.InternalScreenToWindowPoint_InjectedDelegateField(ref screenPoint, out ret);
		}

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_s_ControlCount;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_s_SkinMode;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_s_OriginalID;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_takeCapture;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_releaseCapture;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_processEvent;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_endContainerGUIFromException;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_guiChanged;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr__guiIsExiting_k__BackingField;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerPoint_Internal_Static_get_Single_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_get_guiDepth_Internal_Static_get_Int32_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseUsed_Internal_Static_set_Void_Boolean_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_set_textFieldInput_Internal_Static_set_Void_Boolean_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_get_systemCopyBuffer_Public_Static_get_String_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_set_systemCopyBuffer_Public_Static_set_Void_String_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetControlID_Private_Static_Int32_Int32_FocusType_Rect_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_Rect_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Internal_Static_get_String_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Internal_Static_set_Void_Vector2_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetHotControl_Private_Static_Int32_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetKeyboardControl_Private_Static_Int32_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetHotControl_Private_Static_Void_Int32_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetKeyboardControl_Private_Static_Void_Int32_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetDefaultSkin_Private_Static_Object_Int32_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ExitGUI_Private_Static_Void_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_MarkGUIChanged_Private_Static_Void_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_GetControlID_Public_Static_Int32_FocusType_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_GetStateObject_Public_Static_Object_Type_Int32_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_set_guiIsExiting_Internal_Static_set_Void_Boolean_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_get_hotControl_Public_Static_get_Int32_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_set_hotControl_Public_Static_set_Void_Int32_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_TakeCapture_Internal_Static_Void_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCapture_Internal_Static_Void_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardControl_Public_Static_get_Int32_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardControl_Public_Static_set_Void_Int32_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_HasKeyFocus_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultSkin_Internal_Static_GUISkin_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Internal_Static_Void_Int32_IntPtr_byref_Boolean_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_BeginGUI_Internal_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_EndGUI_Internal_Static_Void_Int32_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_EndGUIFromException_Internal_Static_Boolean_Exception_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_EndContainerGUIFromException_Internal_Static_Boolean_Exception_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_ResetGlobalState_Internal_Static_Void_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_IsExitGUIException_Internal_Static_Boolean_Exception_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRethrowException_Internal_Static_Boolean_Exception_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_CheckOnGUI_Internal_Static_Void_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Int32_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Boolean_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Event_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetControlID_Injected_Private_Static_Int32_Int32_FocusType_byref_Rect_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x04000278 RID: 632
		private static readonly GUIUtility.get_hasModalWindowDelegate get_hasModalWindowDelegateField;

		// Token: 0x04000279 RID: 633
		private static readonly GUIUtility.get_mouseUsedDelegate get_mouseUsedDelegateField;

		// Token: 0x0400027A RID: 634
		private static readonly GUIUtility.get_textFieldInputDelegate get_textFieldInputDelegateField;

		// Token: 0x0400027B RID: 635
		private static readonly GUIUtility.get_manualTex2SRGBEnabledDelegate get_manualTex2SRGBEnabledDelegateField;

		// Token: 0x0400027C RID: 636
		private static readonly GUIUtility.set_manualTex2SRGBEnabledDelegate set_manualTex2SRGBEnabledDelegateField;

		// Token: 0x0400027D RID: 637
		private static readonly GUIUtility.BeginContainerFromOwnerDelegate BeginContainerFromOwnerDelegateField;

		// Token: 0x0400027E RID: 638
		private static readonly GUIUtility.BeginContainerDelegate BeginContainerDelegateField;

		// Token: 0x0400027F RID: 639
		private static readonly GUIUtility.Internal_EndContainerDelegate Internal_EndContainerDelegateField;

		// Token: 0x04000280 RID: 640
		private static readonly GUIUtility.GetPermanentControlIDDelegate GetPermanentControlIDDelegateField;

		// Token: 0x04000281 RID: 641
		private static readonly GUIUtility.CheckForTabEventDelegate CheckForTabEventDelegateField;

		// Token: 0x04000282 RID: 642
		private static readonly GUIUtility.SetKeyboardControlToFirstControlIdDelegate SetKeyboardControlToFirstControlIdDelegateField;

		// Token: 0x04000283 RID: 643
		private static readonly GUIUtility.SetKeyboardControlToLastControlIdDelegate SetKeyboardControlToLastControlIdDelegateField;

		// Token: 0x04000284 RID: 644
		private static readonly GUIUtility.HasFocusableControlsDelegate HasFocusableControlsDelegateField;

		// Token: 0x04000285 RID: 645
		private static readonly GUIUtility.OwnsIdDelegate OwnsIdDelegateField;

		// Token: 0x04000286 RID: 646
		private static readonly GUIUtility.get_imeCompositionModeDelegate get_imeCompositionModeDelegateField;

		// Token: 0x04000287 RID: 647
		private static readonly GUIUtility.set_imeCompositionModeDelegate set_imeCompositionModeDelegateField;

		// Token: 0x04000288 RID: 648
		private static readonly GUIUtility.GetChangedDelegate GetChangedDelegateField;

		// Token: 0x04000289 RID: 649
		private static readonly GUIUtility.SetChangedDelegate SetChangedDelegateField;

		// Token: 0x0400028A RID: 650
		private static readonly GUIUtility.SetDidGUIWindowsEatLastEventDelegate SetDidGUIWindowsEatLastEventDelegateField;

		// Token: 0x0400028B RID: 651
		private static readonly GUIUtility.Internal_GetBuiltinSkinDelegate Internal_GetBuiltinSkinDelegateField;

		// Token: 0x0400028C RID: 652
		private static readonly GUIUtility.get_s_EditorScreenPointOffset_InjectedDelegate get_s_EditorScreenPointOffset_InjectedDelegateField;

		// Token: 0x0400028D RID: 653
		private static readonly GUIUtility.set_s_EditorScreenPointOffset_InjectedDelegate set_s_EditorScreenPointOffset_InjectedDelegateField;

		// Token: 0x0400028E RID: 654
		private static readonly GUIUtility.AlignRectToDevice_InjectedDelegate AlignRectToDevice_InjectedDelegateField;

		// Token: 0x0400028F RID: 655
		private static readonly GUIUtility.get_compositionCursorPos_InjectedDelegate get_compositionCursorPos_InjectedDelegateField;

		// Token: 0x04000290 RID: 656
		private static readonly GUIUtility.Internal_MultiplyPoint_InjectedDelegate Internal_MultiplyPoint_InjectedDelegateField;

		// Token: 0x04000291 RID: 657
		private static readonly GUIUtility.InternalWindowToScreenPoint_InjectedDelegate InternalWindowToScreenPoint_InjectedDelegateField;

		// Token: 0x04000292 RID: 658
		private static readonly GUIUtility.InternalScreenToWindowPoint_InjectedDelegate InternalScreenToWindowPoint_InjectedDelegateField;

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060006E6 RID: 1766
		private delegate bool get_hasModalWindowDelegate();

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060006E8 RID: 1768
		private delegate bool get_mouseUsedDelegate();

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060006EA RID: 1770
		private delegate bool get_textFieldInputDelegate();

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060006EC RID: 1772
		private delegate bool get_manualTex2SRGBEnabledDelegate();

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060006EE RID: 1774
		private delegate void set_manualTex2SRGBEnabledDelegate(bool value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060006F0 RID: 1776
		private delegate void BeginContainerFromOwnerDelegate(IntPtr owner);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060006F2 RID: 1778
		private delegate void BeginContainerDelegate(IntPtr objectGUIState);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060006F4 RID: 1780
		private delegate void Internal_EndContainerDelegate();

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060006F6 RID: 1782
		private delegate int GetPermanentControlIDDelegate();

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060006F8 RID: 1784
		private delegate int CheckForTabEventDelegate(IntPtr evt);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060006FA RID: 1786
		private delegate void SetKeyboardControlToFirstControlIdDelegate();

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060006FC RID: 1788
		private delegate void SetKeyboardControlToLastControlIdDelegate();

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060006FE RID: 1790
		private delegate bool HasFocusableControlsDelegate();

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x06000700 RID: 1792
		private delegate bool OwnsIdDelegate(int id);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x06000702 RID: 1794
		private delegate IMECompositionMode get_imeCompositionModeDelegate();

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x06000704 RID: 1796
		private delegate void set_imeCompositionModeDelegate(IMECompositionMode value);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000706 RID: 1798
		private delegate bool GetChangedDelegate();

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000708 RID: 1800
		private delegate void SetChangedDelegate(bool changed);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x0600070A RID: 1802
		private delegate void SetDidGUIWindowsEatLastEventDelegate(bool value);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x0600070C RID: 1804
		private delegate IntPtr Internal_GetBuiltinSkinDelegate(int skin);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x0600070E RID: 1806
		private delegate void get_s_EditorScreenPointOffset_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000710 RID: 1808
		private delegate void set_s_EditorScreenPointOffset_InjectedDelegate(IntPtr value);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000712 RID: 1810
		private delegate void AlignRectToDevice_InjectedDelegate(IntPtr rect, [Out] IntPtr widthInPixels, [Out] IntPtr heightInPixels, [Out] IntPtr ret);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x06000714 RID: 1812
		private delegate void get_compositionCursorPos_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000716 RID: 1814
		private delegate void Internal_MultiplyPoint_InjectedDelegate(IntPtr point, IntPtr transform, [Out] IntPtr ret);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000718 RID: 1816
		private delegate void InternalWindowToScreenPoint_InjectedDelegate(IntPtr windowPoint, [Out] IntPtr ret);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x0600071A RID: 1818
		private delegate void InternalScreenToWindowPoint_InjectedDelegate(IntPtr screenPoint, [Out] IntPtr ret);
	}
}
