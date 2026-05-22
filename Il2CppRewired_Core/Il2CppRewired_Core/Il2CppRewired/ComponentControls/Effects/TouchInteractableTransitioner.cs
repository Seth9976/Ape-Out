using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.ComponentControls.Effects
{
	// Token: 0x0200004A RID: 74
	public sealed class TouchInteractableTransitioner : MonoBehaviour
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x00046770 File Offset: 0x00044970
		// Note: this type is marked as 'beforefieldinit'.
		static TouchInteractableTransitioner()
		{
			Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Effects", "TouchInteractableTransitioner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr);
			TouchInteractableTransitioner.NativeFieldInfoPtr__visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, "_visible");
			TouchInteractableTransitioner.NativeFieldInfoPtr__transitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, "_transitionType");
			TouchInteractableTransitioner.NativeFieldInfoPtr__transitionColorTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, "_transitionColorTint");
			TouchInteractableTransitioner.NativeFieldInfoPtr__transitionSpriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, "_transitionSpriteState");
			TouchInteractableTransitioner.NativeFieldInfoPtr__transitionAnimationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, "_transitionAnimationTriggers");
			TouchInteractableTransitioner.NativeFieldInfoPtr__targetGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, "_targetGraphic");
			TouchInteractableTransitioner.NativeFieldInfoPtr__syncFadeDurationWithTransitionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, "_syncFadeDurationWithTransitionEvent");
			TouchInteractableTransitioner.NativeFieldInfoPtr__syncColorTintWithTransitionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, "_syncColorTintWithTransitionEvent");
			TouchInteractableTransitioner.NativeFieldInfoPtr_LSwsfLrkcgDaotpsqBqqkRcwUgI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, "LSwsfLrkcgDaotpsqBqqkRcwUgI");
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664378);
			TouchInteractableTransitioner.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664379);
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_transitionType_Public_get_TransitionTypeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664380);
			TouchInteractableTransitioner.NativeMethodInfoPtr_set_transitionType_Public_set_Void_TransitionTypeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664381);
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_transitionColorTint_Public_get_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664382);
			TouchInteractableTransitioner.NativeMethodInfoPtr_set_transitionColorTint_Public_set_Void_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664383);
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_transitionSpriteState_Public_get_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664384);
			TouchInteractableTransitioner.NativeMethodInfoPtr_set_transitionSpriteState_Public_set_Void_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664385);
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_transitionAnimationTriggers_Public_get_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664386);
			TouchInteractableTransitioner.NativeMethodInfoPtr_set_transitionAnimationTriggers_Public_set_Void_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664387);
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664388);
			TouchInteractableTransitioner.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664389);
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_syncFadeDurationWithTransitionEvent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664390);
			TouchInteractableTransitioner.NativeMethodInfoPtr_set_syncFadeDurationWithTransitionEvent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664391);
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_syncColorTintWithTransitionEvent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664392);
			TouchInteractableTransitioner.NativeMethodInfoPtr_set_syncColorTintWithTransitionEvent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664393);
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_image_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664394);
			TouchInteractableTransitioner.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664395);
			TouchInteractableTransitioner.NativeMethodInfoPtr_get_animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664396);
			TouchInteractableTransitioner.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664397);
			TouchInteractableTransitioner.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664398);
			TouchInteractableTransitioner.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664399);
			TouchInteractableTransitioner.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664400);
			TouchInteractableTransitioner.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664401);
			TouchInteractableTransitioner.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664402);
			TouchInteractableTransitioner.NativeMethodInfoPtr_OnCanvasGroupWasChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664403);
			TouchInteractableTransitioner.NativeMethodInfoPtr_OnAnimationPropertiesWereApplied_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664404);
			TouchInteractableTransitioner.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664405);
			TouchInteractableTransitioner.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664406);
			TouchInteractableTransitioner.NativeMethodInfoPtr_SNkEVJdvPsXhwCsTTSNXYRVKKvr_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664407);
			TouchInteractableTransitioner.NativeMethodInfoPtr_jiCgAYeThQbZBaNDTkJtkimAkEK_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664408);
			TouchInteractableTransitioner.NativeMethodInfoPtr_OxHRVbdRhIlYfTSUphaWusbflPv_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664409);
			TouchInteractableTransitioner.NativeMethodInfoPtr_YPzyEwcWCPOkXhXcDWAUzOXyyVX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664410);
			TouchInteractableTransitioner.NativeMethodInfoPtr_vIiGbQVpVOwnJzdNuCqvMLBrdUPb_Private_Void_InteractionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664411);
			TouchInteractableTransitioner.NativeMethodInfoPtr_lqbyOQkiMqtTSHaLwWVyHDlZnTq_Private_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664412);
			TouchInteractableTransitioner.NativeMethodInfoPtr_ufYoiZWDQoKqVxfNABfXoMNaCvFb_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664413);
			TouchInteractableTransitioner.NativeMethodInfoPtr_lceHbganfbdhOUKTvhWNbmIhtZXK_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664414);
			TouchInteractableTransitioner.NativeMethodInfoPtr_OnInteractionStateTransition_Public_Virtual_Final_New_Void_InteractionStateTransitionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664415);
			TouchInteractableTransitioner.NativeMethodInfoPtr_OnVisibilityChanged_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr, 100664416);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00046B60 File Offset: 0x00044D60
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00046B9C File Offset: 0x00044D9C
		public unsafe bool visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247151, XrefRangeEnd = 247152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00046BDC File Offset: 0x00044DDC
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00046C18 File Offset: 0x00044E18
		public unsafe TouchInteractable.TransitionTypeFlags transitionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_transitionType_Public_get_TransitionTypeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247152, XrefRangeEnd = 247153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_set_transitionType_Public_set_Void_TransitionTypeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00046C58 File Offset: 0x00044E58
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00046C94 File Offset: 0x00044E94
		public unsafe ColorBlock transitionColorTint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_transitionColorTint_Public_get_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247153, XrefRangeEnd = 247154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_set_transitionColorTint_Public_set_Void_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00046CD4 File Offset: 0x00044ED4
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00046D0C File Offset: 0x00044F0C
		public unsafe SpriteState transitionSpriteState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_transitionSpriteState_Public_get_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SpriteState(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247154, XrefRangeEnd = 247156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_set_transitionSpriteState_Public_set_Void_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00046D54 File Offset: 0x00044F54
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00046D94 File Offset: 0x00044F94
		public unsafe AnimationTriggers transitionAnimationTriggers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_transitionAnimationTriggers_Public_get_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247156, XrefRangeEnd = 247157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_set_transitionAnimationTriggers_Public_set_Void_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00046DD8 File Offset: 0x00044FD8
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00046E18 File Offset: 0x00045018
		public unsafe Graphic targetGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247157, XrefRangeEnd = 247174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00046E5C File Offset: 0x0004505C
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00046E98 File Offset: 0x00045098
		public unsafe bool syncFadeDurationWithTransitionEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_syncFadeDurationWithTransitionEvent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247174, XrefRangeEnd = 247175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_set_syncFadeDurationWithTransitionEvent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00046ED8 File Offset: 0x000450D8
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00046F14 File Offset: 0x00045114
		public unsafe bool syncColorTintWithTransitionEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_syncColorTintWithTransitionEvent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247175, XrefRangeEnd = 247176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_set_syncColorTintWithTransitionEvent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00046F54 File Offset: 0x00045154
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00046F94 File Offset: 0x00045194
		public unsafe Image image
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 247177, RefRangeEnd = 247179, XrefRangeStart = 247176, XrefRangeEnd = 247177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_image_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247179, XrefRangeEnd = 247196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00046FD8 File Offset: 0x000451D8
		public unsafe Animator animator
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 247204, RefRangeEnd = 247212, XrefRangeStart = 247196, XrefRangeEnd = 247204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_get_animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00047018 File Offset: 0x00045218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247212, XrefRangeEnd = 247219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchInteractableTransitioner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInteractableTransitioner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00047054 File Offset: 0x00045254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247219, XrefRangeEnd = 247239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00047088 File Offset: 0x00045288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247239, XrefRangeEnd = 247244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000470BC File Offset: 0x000452BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247244, XrefRangeEnd = 247247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000470F0 File Offset: 0x000452F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247247, XrefRangeEnd = 247257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00047124 File Offset: 0x00045324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247257, XrefRangeEnd = 247262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00047158 File Offset: 0x00045358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247262, XrefRangeEnd = 247263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanvasGroupWasChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_OnCanvasGroupWasChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0004718C File Offset: 0x0004538C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAnimationPropertiesWereApplied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_OnAnimationPropertiesWereApplied_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000471C0 File Offset: 0x000453C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000471F4 File Offset: 0x000453F4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 247269, RefRangeEnd = 247284, XrefRangeStart = 247263, XrefRangeEnd = 247269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void iJzeeVgTFhPQqdRTfUGBACRnMOF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00047228 File Offset: 0x00045428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247284, XrefRangeEnd = 247285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SNkEVJdvPsXhwCsTTSNXYRVKKvr(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_SNkEVJdvPsXhwCsTTSNXYRVKKvr_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00047268 File Offset: 0x00045468
		[CallerCount(0)]
		public unsafe void jiCgAYeThQbZBaNDTkJtkimAkEK(bool A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_jiCgAYeThQbZBaNDTkJtkimAkEK_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000472B4 File Offset: 0x000454B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247285, XrefRangeEnd = 247289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OxHRVbdRhIlYfTSUphaWusbflPv()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_OxHRVbdRhIlYfTSUphaWusbflPv_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000472F0 File Offset: 0x000454F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YPzyEwcWCPOkXhXcDWAUzOXyyVX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_YPzyEwcWCPOkXhXcDWAUzOXyyVX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00047324 File Offset: 0x00045524
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 247304, RefRangeEnd = 247311, XrefRangeStart = 247289, XrefRangeEnd = 247304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void vIiGbQVpVOwnJzdNuCqvMLBrdUPb(TouchInteractable.InteractionState A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_vIiGbQVpVOwnJzdNuCqvMLBrdUPb_Private_Void_InteractionState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00047370 File Offset: 0x00045570
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 247324, RefRangeEnd = 247329, XrefRangeStart = 247311, XrefRangeEnd = 247324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lqbyOQkiMqtTSHaLwWVyHDlZnTq(Color A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_lqbyOQkiMqtTSHaLwWVyHDlZnTq_Private_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000473BC File Offset: 0x000455BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 247344, RefRangeEnd = 247349, XrefRangeStart = 247329, XrefRangeEnd = 247344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ufYoiZWDQoKqVxfNABfXoMNaCvFb(Sprite A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_ufYoiZWDQoKqVxfNABfXoMNaCvFb_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00047400 File Offset: 0x00045600
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 247390, RefRangeEnd = 247395, XrefRangeStart = 247349, XrefRangeEnd = 247390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lceHbganfbdhOUKTvhWNbmIhtZXK(string A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_lceHbganfbdhOUKTvhWNbmIhtZXK_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00047444 File Offset: 0x00045644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247395, XrefRangeEnd = 247422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_OnInteractionStateTransition_Public_Virtual_Final_New_Void_InteractionStateTransitionArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00047488 File Offset: 0x00045688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVisibilityChanged(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInteractableTransitioner.NativeMethodInfoPtr_OnVisibilityChanged_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00004117 File Offset: 0x00002317
		public TouchInteractableTransitioner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x000474C8 File Offset: 0x000456C8
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00004120 File Offset: 0x00002320
		public unsafe bool _visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__visible)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x000474F0 File Offset: 0x000456F0
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x0000413B File Offset: 0x0000233B
		public unsafe TouchInteractable.TransitionTypeFlags _transitionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__transitionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__transitionType)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00047518 File Offset: 0x00045718
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00004156 File Offset: 0x00002356
		public unsafe ColorBlock _transitionColorTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__transitionColorTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__transitionColorTint)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00047540 File Offset: 0x00045740
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00004171 File Offset: 0x00002371
		public SpriteState _transitionSpriteState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__transitionSpriteState);
				return new SpriteState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__transitionSpriteState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00047570 File Offset: 0x00045770
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x0000419F File Offset: 0x0000239F
		public unsafe AnimationTriggers _transitionAnimationTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__transitionAnimationTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__transitionAnimationTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x000475A0 File Offset: 0x000457A0
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x000041BE File Offset: 0x000023BE
		public unsafe Graphic _targetGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__targetGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__targetGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x000475D0 File Offset: 0x000457D0
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x000041DD File Offset: 0x000023DD
		public unsafe bool _syncFadeDurationWithTransitionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__syncFadeDurationWithTransitionEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__syncFadeDurationWithTransitionEvent)) = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x000475F8 File Offset: 0x000457F8
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x000041F8 File Offset: 0x000023F8
		public unsafe bool _syncColorTintWithTransitionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__syncColorTintWithTransitionEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr__syncColorTintWithTransitionEvent)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00047620 File Offset: 0x00045820
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00004213 File Offset: 0x00002413
		public unsafe TouchInteractable.InteractionState LSwsfLrkcgDaotpsqBqqkRcwUgI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr_LSwsfLrkcgDaotpsqBqqkRcwUgI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInteractableTransitioner.NativeFieldInfoPtr_LSwsfLrkcgDaotpsqBqqkRcwUgI)) = value;
			}
		}

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr__visible;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr__transitionType;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr__transitionColorTint;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr__transitionSpriteState;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr__transitionAnimationTriggers;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr__targetGraphic;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr__syncFadeDurationWithTransitionEvent;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr__syncColorTintWithTransitionEvent;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_LSwsfLrkcgDaotpsqBqqkRcwUgI;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Public_get_Boolean_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionType_Public_get_TransitionTypeFlags_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_set_transitionType_Public_set_Void_TransitionTypeFlags_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionColorTint_Public_get_ColorBlock_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_set_transitionColorTint_Public_set_Void_ColorBlock_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionSpriteState_Public_get_SpriteState_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_set_transitionSpriteState_Public_set_Void_SpriteState_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionAnimationTriggers_Public_get_AnimationTriggers_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_set_transitionAnimationTriggers_Public_set_Void_AnimationTriggers_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_get_syncFadeDurationWithTransitionEvent_Public_get_Boolean_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_set_syncFadeDurationWithTransitionEvent_Public_set_Void_Boolean_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_get_syncColorTintWithTransitionEvent_Public_get_Boolean_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_set_syncColorTintWithTransitionEvent_Public_set_Void_Boolean_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Image_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Image_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_get_animator_Public_get_Animator_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupWasChanged_Private_Void_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_OnAnimationPropertiesWereApplied_Private_Void_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_iJzeeVgTFhPQqdRTfUGBACRnMOF_Private_Void_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_SNkEVJdvPsXhwCsTTSNXYRVKKvr_Private_Void_Boolean_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_jiCgAYeThQbZBaNDTkJtkimAkEK_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_OxHRVbdRhIlYfTSUphaWusbflPv_Private_Boolean_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_YPzyEwcWCPOkXhXcDWAUzOXyyVX_Private_Void_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_vIiGbQVpVOwnJzdNuCqvMLBrdUPb_Private_Void_InteractionState_Boolean_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_lqbyOQkiMqtTSHaLwWVyHDlZnTq_Private_Void_Color_Boolean_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_ufYoiZWDQoKqVxfNABfXoMNaCvFb_Private_Void_Sprite_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_lceHbganfbdhOUKTvhWNbmIhtZXK_Private_Void_String_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_OnInteractionStateTransition_Public_Virtual_Final_New_Void_InteractionStateTransitionArgs_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityChanged_Public_Virtual_Final_New_Void_Boolean_0;
	}
}
