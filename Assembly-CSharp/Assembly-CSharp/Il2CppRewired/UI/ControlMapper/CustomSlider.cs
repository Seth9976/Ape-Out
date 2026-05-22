using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001F3 RID: 499
	public class CustomSlider : Slider
	{
		// Token: 0x06003CC2 RID: 15554 RVA: 0x000E31AC File Offset: 0x000E13AC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomSlider()
		{
			Il2CppClassPointerStore<CustomSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "CustomSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr);
			CustomSlider.NativeFieldInfoPtr__disabledHighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, "_disabledHighlightedSprite");
			CustomSlider.NativeFieldInfoPtr__disabledHighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, "_disabledHighlightedColor");
			CustomSlider.NativeFieldInfoPtr__disabledHighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, "_disabledHighlightedTrigger");
			CustomSlider.NativeFieldInfoPtr__autoNavUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, "_autoNavUp");
			CustomSlider.NativeFieldInfoPtr__autoNavDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, "_autoNavDown");
			CustomSlider.NativeFieldInfoPtr__autoNavLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, "_autoNavLeft");
			CustomSlider.NativeFieldInfoPtr__autoNavRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, "_autoNavRight");
			CustomSlider.NativeFieldInfoPtr_isHighlightDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, "isHighlightDisabled");
			CustomSlider.NativeFieldInfoPtr__CancelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, "_CancelEvent");
			CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668934);
			CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668935);
			CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668936);
			CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668937);
			CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668938);
			CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668939);
			CustomSlider.NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668940);
			CustomSlider.NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668941);
			CustomSlider.NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668942);
			CustomSlider.NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668943);
			CustomSlider.NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668944);
			CustomSlider.NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668945);
			CustomSlider.NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668946);
			CustomSlider.NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668947);
			CustomSlider.NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668948);
			CustomSlider.NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668949);
			CustomSlider.NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668950);
			CustomSlider.NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668951);
			CustomSlider.NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668952);
			CustomSlider.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668953);
			CustomSlider.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668954);
			CustomSlider.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668955);
			CustomSlider.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668956);
			CustomSlider.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668957);
			CustomSlider.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668958);
			CustomSlider.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668959);
			CustomSlider.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668960);
			CustomSlider.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668961);
			CustomSlider.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668962);
			CustomSlider.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668963);
			CustomSlider.NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668964);
			CustomSlider.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668965);
			CustomSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100668966);
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x000E3524 File Offset: 0x000E1724
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x000E3564 File Offset: 0x000E1764
		public unsafe virtual Sprite disabledHighlightedSprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x000E35A8 File Offset: 0x000E17A8
		// (set) Token: 0x06003CC6 RID: 15558 RVA: 0x000E35E4 File Offset: 0x000E17E4
		public unsafe virtual Color disabledHighlightedColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x000E3624 File Offset: 0x000E1824
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x000E365C File Offset: 0x000E185C
		public unsafe virtual string disabledHighlightedTrigger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x000E36A0 File Offset: 0x000E18A0
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x000E36DC File Offset: 0x000E18DC
		public unsafe virtual bool autoNavUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x000E371C File Offset: 0x000E191C
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x000E3758 File Offset: 0x000E1958
		public unsafe virtual bool autoNavDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x000E3798 File Offset: 0x000E1998
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x000E37D4 File Offset: 0x000E19D4
		public unsafe virtual bool autoNavLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x000E3814 File Offset: 0x000E1A14
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x000E3850 File Offset: 0x000E1A50
		public unsafe virtual bool autoNavRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x000E3890 File Offset: 0x000E1A90
		public unsafe bool isDisabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x000E38CC File Offset: 0x000E1ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98142, XrefRangeEnd = 98145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__CancelEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x000E3910 File Offset: 0x000E1B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98145, XrefRangeEnd = 98148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__CancelEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x000E3954 File Offset: 0x000E1B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_CancelEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x000E3998 File Offset: 0x000E1B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_CancelEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x000E39DC File Offset: 0x000E1BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98148, XrefRangeEnd = 98149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Selectable FindSelectableOnLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomSlider.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x000E3A28 File Offset: 0x000E1C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98149, XrefRangeEnd = 98150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Selectable FindSelectableOnRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomSlider.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x000E3A74 File Offset: 0x000E1C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98150, XrefRangeEnd = 98151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Selectable FindSelectableOnUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomSlider.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x000E3AC0 File Offset: 0x000E1CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98151, XrefRangeEnd = 98152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Selectable FindSelectableOnDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomSlider.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x000E3B0C File Offset: 0x000E1D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98152, XrefRangeEnd = 98192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasGroupChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomSlider.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x000E3B48 File Offset: 0x000E1D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98192, XrefRangeEnd = 98198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DoStateTransition(Selectable.SelectionState state, bool instant)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomSlider.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x000E3BA0 File Offset: 0x000E1DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98198, XrefRangeEnd = 98211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void StartColorTween(Color targetColor, bool instant)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x000E3BEC File Offset: 0x000E1DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98211, XrefRangeEnd = 98226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void DoSpriteSwap(Sprite newSprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x000E3C30 File Offset: 0x000E1E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98270, RefRangeEnd = 98271, XrefRangeStart = 98226, XrefRangeEnd = 98270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void TriggerAnimation(string triggername)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(triggername);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x000E3C74 File Offset: 0x000E1E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98271, XrefRangeEnd = 98272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomSlider.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x000E3CC4 File Offset: 0x000E1EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98272, XrefRangeEnd = 98275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomSlider.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x000E3D14 File Offset: 0x000E1F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98277, RefRangeEnd = 98278, XrefRangeStart = 98275, XrefRangeEnd = 98277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateHightlightDisabled(bool isSelected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSelected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x000E3D54 File Offset: 0x000E1F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98278, XrefRangeEnd = 98279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x000E3D98 File Offset: 0x000E1F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98279, XrefRangeEnd = 98290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomSlider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00025CBA File Offset: 0x00023EBA
		public CustomSlider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06003CE5 RID: 15589 RVA: 0x000E3DD4 File Offset: 0x000E1FD4
		// (set) Token: 0x06003CE6 RID: 15590 RVA: 0x00025CC3 File Offset: 0x00023EC3
		public unsafe Sprite _disabledHighlightedSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x000E3E04 File Offset: 0x000E2004
		// (set) Token: 0x06003CE8 RID: 15592 RVA: 0x00025CE2 File Offset: 0x00023EE2
		public unsafe Color _disabledHighlightedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedColor)) = value;
			}
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06003CE9 RID: 15593 RVA: 0x000E3E2C File Offset: 0x000E202C
		// (set) Token: 0x06003CEA RID: 15594 RVA: 0x00025CFD File Offset: 0x00023EFD
		public unsafe string _disabledHighlightedTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x000E3E54 File Offset: 0x000E2054
		// (set) Token: 0x06003CEC RID: 15596 RVA: 0x00025D1C File Offset: 0x00023F1C
		public unsafe bool _autoNavUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavUp)) = value;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x000E3E7C File Offset: 0x000E207C
		// (set) Token: 0x06003CEE RID: 15598 RVA: 0x00025D37 File Offset: 0x00023F37
		public unsafe bool _autoNavDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavDown)) = value;
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x000E3EA4 File Offset: 0x000E20A4
		// (set) Token: 0x06003CF0 RID: 15600 RVA: 0x00025D52 File Offset: 0x00023F52
		public unsafe bool _autoNavLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavLeft)) = value;
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x000E3ECC File Offset: 0x000E20CC
		// (set) Token: 0x06003CF2 RID: 15602 RVA: 0x00025D6D File Offset: 0x00023F6D
		public unsafe bool _autoNavRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavRight)) = value;
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x000E3EF4 File Offset: 0x000E20F4
		// (set) Token: 0x06003CF4 RID: 15604 RVA: 0x00025D88 File Offset: 0x00023F88
		public unsafe bool isHighlightDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr_isHighlightDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr_isHighlightDisabled)) = value;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x000E3F1C File Offset: 0x000E211C
		// (set) Token: 0x06003CF6 RID: 15606 RVA: 0x00025DA3 File Offset: 0x00023FA3
		public unsafe UnityAction _CancelEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__CancelEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__CancelEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024F4 RID: 9460
		private static readonly IntPtr NativeFieldInfoPtr__disabledHighlightedSprite;

		// Token: 0x040024F5 RID: 9461
		private static readonly IntPtr NativeFieldInfoPtr__disabledHighlightedColor;

		// Token: 0x040024F6 RID: 9462
		private static readonly IntPtr NativeFieldInfoPtr__disabledHighlightedTrigger;

		// Token: 0x040024F7 RID: 9463
		private static readonly IntPtr NativeFieldInfoPtr__autoNavUp;

		// Token: 0x040024F8 RID: 9464
		private static readonly IntPtr NativeFieldInfoPtr__autoNavDown;

		// Token: 0x040024F9 RID: 9465
		private static readonly IntPtr NativeFieldInfoPtr__autoNavLeft;

		// Token: 0x040024FA RID: 9466
		private static readonly IntPtr NativeFieldInfoPtr__autoNavRight;

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeFieldInfoPtr_isHighlightDisabled;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeFieldInfoPtr__CancelEvent;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x040024FE RID: 9470
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0;

		// Token: 0x040024FF RID: 9471
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0;

		// Token: 0x04002500 RID: 9472
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0;

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0;

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0;

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0;

		// Token: 0x04002519 RID: 9497
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
