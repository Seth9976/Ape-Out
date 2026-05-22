using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000034 RID: 52
	public class Selectable : UIBehaviour
	{
		// Token: 0x06000682 RID: 1666 RVA: 0x0001FD88 File Offset: 0x0001DF88
		// Note: this type is marked as 'beforefieldinit'.
		static Selectable()
		{
			Il2CppClassPointerStore<Selectable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Selectable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Selectable>.NativeClassPtr);
			Selectable.NativeFieldInfoPtr_s_Selectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "s_Selectables");
			Selectable.NativeFieldInfoPtr_s_SelectableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "s_SelectableCount");
			Selectable.NativeFieldInfoPtr_m_EnableCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_EnableCalled");
			Selectable.NativeFieldInfoPtr_m_Navigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Navigation");
			Selectable.NativeFieldInfoPtr_m_Transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Transition");
			Selectable.NativeFieldInfoPtr_m_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Colors");
			Selectable.NativeFieldInfoPtr_m_SpriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_SpriteState");
			Selectable.NativeFieldInfoPtr_m_AnimationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_AnimationTriggers");
			Selectable.NativeFieldInfoPtr_m_Interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Interactable");
			Selectable.NativeFieldInfoPtr_m_TargetGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_TargetGraphic");
			Selectable.NativeFieldInfoPtr_m_GroupsAllowInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_GroupsAllowInteraction");
			Selectable.NativeFieldInfoPtr_m_CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_CurrentIndex");
			Selectable.NativeFieldInfoPtr__isPointerInside_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "<isPointerInside>k__BackingField");
			Selectable.NativeFieldInfoPtr__isPointerDown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "<isPointerDown>k__BackingField");
			Selectable.NativeFieldInfoPtr__hasSelection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "<hasSelection>k__BackingField");
			Selectable.NativeFieldInfoPtr_m_CanvasGroupCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_CanvasGroupCache");
			Selectable.NativeMethodInfoPtr_get_allSelectablesArray_Public_Static_get_Il2CppReferenceArray_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664339);
			Selectable.NativeMethodInfoPtr_get_allSelectableCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664340);
			Selectable.NativeMethodInfoPtr_get_allSelectables_Public_Static_get_List_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664341);
			Selectable.NativeMethodInfoPtr_AllSelectablesNoAlloc_Public_Static_Int32_Il2CppReferenceArray_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664342);
			Selectable.NativeMethodInfoPtr_get_navigation_Public_get_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664343);
			Selectable.NativeMethodInfoPtr_set_navigation_Public_set_Void_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664344);
			Selectable.NativeMethodInfoPtr_get_transition_Public_get_Transition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664345);
			Selectable.NativeMethodInfoPtr_set_transition_Public_set_Void_Transition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664346);
			Selectable.NativeMethodInfoPtr_get_colors_Public_get_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664347);
			Selectable.NativeMethodInfoPtr_set_colors_Public_set_Void_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664348);
			Selectable.NativeMethodInfoPtr_get_spriteState_Public_get_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664349);
			Selectable.NativeMethodInfoPtr_set_spriteState_Public_set_Void_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664350);
			Selectable.NativeMethodInfoPtr_get_animationTriggers_Public_get_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664351);
			Selectable.NativeMethodInfoPtr_set_animationTriggers_Public_set_Void_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664352);
			Selectable.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664353);
			Selectable.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664354);
			Selectable.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664355);
			Selectable.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664356);
			Selectable.NativeMethodInfoPtr_get_isPointerInside_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664357);
			Selectable.NativeMethodInfoPtr_set_isPointerInside_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664358);
			Selectable.NativeMethodInfoPtr_get_isPointerDown_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664359);
			Selectable.NativeMethodInfoPtr_set_isPointerDown_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664360);
			Selectable.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664361);
			Selectable.NativeMethodInfoPtr_set_hasSelection_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664362);
			Selectable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664363);
			Selectable.NativeMethodInfoPtr_get_image_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664364);
			Selectable.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664365);
			Selectable.NativeMethodInfoPtr_get_animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664366);
			Selectable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664367);
			Selectable.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664368);
			Selectable.NativeMethodInfoPtr_ParentGroupAllowsInteraction_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664369);
			Selectable.NativeMethodInfoPtr_IsInteractable_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664370);
			Selectable.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664371);
			Selectable.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664372);
			Selectable.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664373);
			Selectable.NativeMethodInfoPtr_OnSetProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664374);
			Selectable.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664375);
			Selectable.NativeMethodInfoPtr_get_currentSelectionState_Protected_get_SelectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664376);
			Selectable.NativeMethodInfoPtr_InstantClearState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664377);
			Selectable.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_New_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664378);
			Selectable.NativeMethodInfoPtr_FindSelectable_Public_Selectable_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664379);
			Selectable.NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664380);
			Selectable.NativeMethodInfoPtr_Navigate_Private_Void_AxisEventData_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664381);
			Selectable.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664382);
			Selectable.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664383);
			Selectable.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664384);
			Selectable.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664385);
			Selectable.NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664386);
			Selectable.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664387);
			Selectable.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664388);
			Selectable.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664389);
			Selectable.NativeMethodInfoPtr_IsHighlighted_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664390);
			Selectable.NativeMethodInfoPtr_IsPressed_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664391);
			Selectable.NativeMethodInfoPtr_EvaluateAndTransitionToSelectionState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664392);
			Selectable.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664393);
			Selectable.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664394);
			Selectable.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664395);
			Selectable.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664396);
			Selectable.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664397);
			Selectable.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664398);
			Selectable.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664399);
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x000203BC File Offset: 0x0001E5BC
		public unsafe static Il2CppReferenceArray<Selectable> allSelectablesArray
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 527341, RefRangeEnd = 527342, XrefRangeStart = 527330, XrefRangeEnd = 527341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_allSelectablesArray_Public_Static_get_Il2CppReferenceArray_1_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x000203F0 File Offset: 0x0001E5F0
		public unsafe static int allSelectableCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527342, XrefRangeEnd = 527346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_allSelectableCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00020420 File Offset: 0x0001E620
		public unsafe static List<Selectable> allSelectables
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527346, XrefRangeEnd = 527356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_allSelectables_Public_Static_get_List_1_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00020454 File Offset: 0x0001E654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 527367, RefRangeEnd = 527368, XrefRangeStart = 527356, XrefRangeEnd = 527367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AllSelectablesNoAlloc(Il2CppReferenceArray<Selectable> selectables)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_AllSelectablesNoAlloc_Public_Static_Int32_Il2CppReferenceArray_1_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00020498 File Offset: 0x0001E698
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x000204D0 File Offset: 0x0001E6D0
		public unsafe Navigation navigation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_navigation_Public_get_Navigation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Navigation(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 527371, RefRangeEnd = 527375, XrefRangeStart = 527368, XrefRangeEnd = 527371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_navigation_Public_set_Void_Navigation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00020518 File Offset: 0x0001E718
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00020554 File Offset: 0x0001E754
		public unsafe Selectable.Transition transition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_transition_Public_get_Transition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527375, XrefRangeEnd = 527379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_transition_Public_set_Void_Transition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00020594 File Offset: 0x0001E794
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x000205D0 File Offset: 0x0001E7D0
		public unsafe ColorBlock colors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_colors_Public_get_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 527382, RefRangeEnd = 527386, XrefRangeStart = 527379, XrefRangeEnd = 527382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_colors_Public_set_Void_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00020610 File Offset: 0x0001E810
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00020648 File Offset: 0x0001E848
		public unsafe SpriteState spriteState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_spriteState_Public_get_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SpriteState(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527386, XrefRangeEnd = 527389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_spriteState_Public_set_Void_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00020690 File Offset: 0x0001E890
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x000206D0 File Offset: 0x0001E8D0
		public unsafe AnimationTriggers animationTriggers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_animationTriggers_Public_get_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527389, XrefRangeEnd = 527393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_animationTriggers_Public_set_Void_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00020714 File Offset: 0x0001E914
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00020754 File Offset: 0x0001E954
		public unsafe Graphic targetGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527393, XrefRangeEnd = 527397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00020798 File Offset: 0x0001E998
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x000207D4 File Offset: 0x0001E9D4
		public unsafe bool interactable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 527439, RefRangeEnd = 527445, XrefRangeStart = 527397, XrefRangeEnd = 527439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00020814 File Offset: 0x0001EA14
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00020850 File Offset: 0x0001EA50
		public unsafe bool isPointerInside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_isPointerInside_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_isPointerInside_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00020890 File Offset: 0x0001EA90
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x000208CC File Offset: 0x0001EACC
		public unsafe bool isPointerDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_isPointerDown_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_isPointerDown_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0002090C File Offset: 0x0001EB0C
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00020948 File Offset: 0x0001EB48
		public unsafe bool hasSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_hasSelection_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00020988 File Offset: 0x0001EB88
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 527462, RefRangeEnd = 527473, XrefRangeStart = 527445, XrefRangeEnd = 527462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Selectable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x000209C4 File Offset: 0x0001EBC4
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00020A04 File Offset: 0x0001EC04
		public unsafe Image image
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 527474, RefRangeEnd = 527482, XrefRangeStart = 527473, XrefRangeEnd = 527474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_image_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 429503, RefRangeEnd = 429504, XrefRangeStart = 429503, XrefRangeEnd = 429504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00020A48 File Offset: 0x0001EC48
		public unsafe Animator animator
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 527485, RefRangeEnd = 527497, XrefRangeStart = 527482, XrefRangeEnd = 527485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00020A88 File Offset: 0x0001EC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527497, XrefRangeEnd = 527512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00020AC4 File Offset: 0x0001ECC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527512, XrefRangeEnd = 527514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasGroupChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00020B00 File Offset: 0x0001ED00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 527544, RefRangeEnd = 527549, XrefRangeStart = 527514, XrefRangeEnd = 527544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParentGroupAllowsInteraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_ParentGroupAllowsInteraction_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00020B3C File Offset: 0x0001ED3C
		[CallerCount(0)]
		public unsafe virtual bool IsInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_IsInteractable_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00020B84 File Offset: 0x0001ED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527549, XrefRangeEnd = 527550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00020BC0 File Offset: 0x0001EDC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 527602, RefRangeEnd = 527607, XrefRangeStart = 527550, XrefRangeEnd = 527602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00020BFC File Offset: 0x0001EDFC
		[CallerCount(0)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00020C38 File Offset: 0x0001EE38
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 527610, RefRangeEnd = 527633, XrefRangeStart = 527607, XrefRangeEnd = 527610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSetProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_OnSetProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00020C6C File Offset: 0x0001EE6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 527643, RefRangeEnd = 527650, XrefRangeStart = 527633, XrefRangeEnd = 527643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00020CA8 File Offset: 0x0001EEA8
		public unsafe Selectable.SelectionState currentSelectionState
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 527650, RefRangeEnd = 527664, XrefRangeStart = 527650, XrefRangeEnd = 527650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_currentSelectionState_Protected_get_SelectionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00020CE4 File Offset: 0x0001EEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527664, XrefRangeEnd = 527665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InstantClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_InstantClearState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00020D20 File Offset: 0x0001EF20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 527677, RefRangeEnd = 527684, XrefRangeStart = 527665, XrefRangeEnd = 527677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_New_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00020D78 File Offset: 0x0001EF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527684, XrefRangeEnd = 527763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable FindSelectable(Vector3 dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_FindSelectable_Public_Selectable_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00020DC4 File Offset: 0x0001EFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 527781, RefRangeEnd = 527782, XrefRangeStart = 527763, XrefRangeEnd = 527781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00020E14 File Offset: 0x0001F014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 527797, RefRangeEnd = 527798, XrefRangeStart = 527782, XrefRangeEnd = 527797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Navigate(AxisEventData eventData, Selectable sel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_Navigate_Private_Void_AxisEventData_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00020E68 File Offset: 0x0001F068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 527798, RefRangeEnd = 527800, XrefRangeStart = 527798, XrefRangeEnd = 527798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Selectable FindSelectableOnLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00020EB4 File Offset: 0x0001F0B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 527800, RefRangeEnd = 527802, XrefRangeStart = 527800, XrefRangeEnd = 527800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Selectable FindSelectableOnRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00020F00 File Offset: 0x0001F100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 527802, RefRangeEnd = 527804, XrefRangeStart = 527802, XrefRangeEnd = 527802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Selectable FindSelectableOnUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00020F4C File Offset: 0x0001F14C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 527804, RefRangeEnd = 527806, XrefRangeStart = 527804, XrefRangeEnd = 527804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Selectable FindSelectableOnDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00020F98 File Offset: 0x0001F198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 527808, RefRangeEnd = 527810, XrefRangeStart = 527806, XrefRangeEnd = 527808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527810, XrefRangeEnd = 527823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartColorTween(Color targetColor, bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00021034 File Offset: 0x0001F234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527823, XrefRangeEnd = 527838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSpriteSwap(Sprite newSprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00021078 File Offset: 0x0001F278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 527875, RefRangeEnd = 527877, XrefRangeStart = 527838, XrefRangeEnd = 527875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerAnimation(string triggername)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(triggername);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000210BC File Offset: 0x0001F2BC
		[CallerCount(0)]
		public unsafe bool IsHighlighted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_IsHighlighted_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000210F8 File Offset: 0x0001F2F8
		[CallerCount(0)]
		public unsafe bool IsPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_IsPressed_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00021134 File Offset: 0x0001F334
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 527878, RefRangeEnd = 527881, XrefRangeStart = 527877, XrefRangeEnd = 527878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateAndTransitionToSelectionState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_EvaluateAndTransitionToSelectionState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00021168 File Offset: 0x0001F368
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 527903, RefRangeEnd = 527907, XrefRangeStart = 527881, XrefRangeEnd = 527903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000211B8 File Offset: 0x0001F3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527907, XrefRangeEnd = 527908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00021208 File Offset: 0x0001F408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527908, XrefRangeEnd = 527909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00021258 File Offset: 0x0001F458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527909, XrefRangeEnd = 527910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000212A8 File Offset: 0x0001F4A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 527911, RefRangeEnd = 527916, XrefRangeStart = 527910, XrefRangeEnd = 527911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000212F8 File Offset: 0x0001F4F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 527917, RefRangeEnd = 527922, XrefRangeStart = 527916, XrefRangeEnd = 527917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00021348 File Offset: 0x0001F548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527922, XrefRangeEnd = 527947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00004461 File Offset: 0x00002661
		public Selectable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00021384 File Offset: 0x0001F584
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x0000446A File Offset: 0x0000266A
		public unsafe static Il2CppReferenceArray<Selectable> s_Selectables
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Selectable.NativeFieldInfoPtr_s_Selectables, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Selectable.NativeFieldInfoPtr_s_Selectables, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x000213AC File Offset: 0x0001F5AC
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x0000447C File Offset: 0x0000267C
		public unsafe static int s_SelectableCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Selectable.NativeFieldInfoPtr_s_SelectableCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Selectable.NativeFieldInfoPtr_s_SelectableCount, (void*)(&value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x000213C8 File Offset: 0x0001F5C8
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x0000448A File Offset: 0x0000268A
		public unsafe bool m_EnableCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_EnableCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_EnableCalled)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x000213F0 File Offset: 0x0001F5F0
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x000044A5 File Offset: 0x000026A5
		public Navigation m_Navigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Navigation);
				return new Navigation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Navigation>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Navigation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Navigation>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00021420 File Offset: 0x0001F620
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x000044D3 File Offset: 0x000026D3
		public unsafe Selectable.Transition m_Transition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Transition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Transition)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00021448 File Offset: 0x0001F648
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x000044EE File Offset: 0x000026EE
		public unsafe ColorBlock m_Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Colors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Colors)) = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00021470 File Offset: 0x0001F670
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00004509 File Offset: 0x00002709
		public SpriteState m_SpriteState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_SpriteState);
				return new SpriteState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_SpriteState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x000214A0 File Offset: 0x0001F6A0
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00004537 File Offset: 0x00002737
		public unsafe AnimationTriggers m_AnimationTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_AnimationTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_AnimationTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x000214D0 File Offset: 0x0001F6D0
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00004556 File Offset: 0x00002756
		public unsafe bool m_Interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Interactable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Interactable)) = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x000214F8 File Offset: 0x0001F6F8
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00004571 File Offset: 0x00002771
		public unsafe Graphic m_TargetGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_TargetGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_TargetGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00021528 File Offset: 0x0001F728
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00004590 File Offset: 0x00002790
		public unsafe bool m_GroupsAllowInteraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_GroupsAllowInteraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_GroupsAllowInteraction)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00021550 File Offset: 0x0001F750
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x000045AB File Offset: 0x000027AB
		public unsafe int m_CurrentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CurrentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CurrentIndex)) = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00021578 File Offset: 0x0001F778
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x000045C6 File Offset: 0x000027C6
		public unsafe bool _isPointerInside_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerInside_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerInside_k__BackingField)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x000215A0 File Offset: 0x0001F7A0
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x000045E1 File Offset: 0x000027E1
		public unsafe bool _isPointerDown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerDown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerDown_k__BackingField)) = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x000215C8 File Offset: 0x0001F7C8
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x000045FC File Offset: 0x000027FC
		public unsafe bool _hasSelection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__hasSelection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__hasSelection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x000215F0 File Offset: 0x0001F7F0
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00004617 File Offset: 0x00002817
		public unsafe List<CanvasGroup> m_CanvasGroupCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CanvasGroupCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CanvasGroupCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeFieldInfoPtr_s_Selectables;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_s_SelectableCount;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableCalled;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr_m_Navigation;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_m_Transition;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_m_Colors;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteState;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationTriggers;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_m_Interactable;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetGraphic;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupsAllowInteraction;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentIndex;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeFieldInfoPtr__isPointerInside_k__BackingField;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr__isPointerDown_k__BackingField;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr__hasSelection_k__BackingField;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroupCache;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_get_allSelectablesArray_Public_Static_get_Il2CppReferenceArray_1_Selectable_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_get_allSelectableCount_Public_Static_get_Int32_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_get_allSelectables_Public_Static_get_List_1_Selectable_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_AllSelectablesNoAlloc_Public_Static_Int32_Il2CppReferenceArray_1_Selectable_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_get_navigation_Public_get_Navigation_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_set_navigation_Public_set_Void_Navigation_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_get_transition_Public_get_Transition_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_set_transition_Public_set_Void_Transition_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_get_colors_Public_get_ColorBlock_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_set_colors_Public_set_Void_ColorBlock_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteState_Public_get_SpriteState_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteState_Public_set_Void_SpriteState_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_get_animationTriggers_Public_get_AnimationTriggers_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_set_animationTriggers_Public_set_Void_AnimationTriggers_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_get_isPointerInside_Private_get_Boolean_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_set_isPointerInside_Private_set_Void_Boolean_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_get_isPointerDown_Private_get_Boolean_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_set_isPointerDown_Private_set_Void_Boolean_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_set_hasSelection_Private_set_Void_Boolean_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Image_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Image_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_get_animator_Public_get_Animator_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_ParentGroupAllowsInteraction_Private_Boolean_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_IsInteractable_Public_Virtual_New_Boolean_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_OnSetProperty_Private_Void_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSelectionState_Protected_get_SelectionState_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_InstantClearState_Protected_Virtual_New_Void_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_New_Void_SelectionState_Boolean_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectable_Public_Selectable_Vector3_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Private_Void_AxisEventData_Selectable_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_New_Selectable_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_New_Selectable_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_New_Selectable_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_New_Selectable_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_IsHighlighted_Protected_Boolean_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_IsPressed_Protected_Boolean_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndTransitionToSelectionState_Private_Void_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0;

		// Token: 0x020000A8 RID: 168
		[OriginalName("UnityEngine.UI.dll", "", "Transition")]
		public enum Transition
		{
			// Token: 0x0400097F RID: 2431
			None,
			// Token: 0x04000980 RID: 2432
			ColorTint,
			// Token: 0x04000981 RID: 2433
			SpriteSwap,
			// Token: 0x04000982 RID: 2434
			Animation
		}

		// Token: 0x020000A9 RID: 169
		[OriginalName("UnityEngine.UI.dll", "", "SelectionState")]
		public enum SelectionState
		{
			// Token: 0x04000984 RID: 2436
			Normal,
			// Token: 0x04000985 RID: 2437
			Highlighted,
			// Token: 0x04000986 RID: 2438
			Pressed,
			// Token: 0x04000987 RID: 2439
			Selected,
			// Token: 0x04000988 RID: 2440
			Disabled
		}
	}
}
