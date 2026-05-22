using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.ComponentControls.Effects
{
	// Token: 0x0200004C RID: 76
	public sealed class TouchJoystickAngleIndicator : MonoBehaviour
	{
		// Token: 0x060007D5 RID: 2005 RVA: 0x0004BAC8 File Offset: 0x00049CC8
		// Note: this type is marked as 'beforefieldinit'.
		static TouchJoystickAngleIndicator()
		{
			Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Effects", "TouchJoystickAngleIndicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr);
			TouchJoystickAngleIndicator.NativeFieldInfoPtr__visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "_visible");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr__targetAngleFromRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "_targetAngleFromRotation");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr__targetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "_targetAngle");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr__fadeWithValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "_fadeWithValue");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr__fadeWithAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "_fadeWithAngle");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr__fadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "_fadeRange");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr__activeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "_activeColor");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr__normalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "_normalColor");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr_zwJHjzDPmvFTlzYvcIeuvFQsBhY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "zwJHjzDPmvFTlzYvcIeuvFQsBhY");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr_GiZelSplzgAQqIxdnaEoBHfWMnw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "GiZelSplzgAQqIxdnaEoBHfWMnw");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr_mYHdpMgNreJVEgcigDRgnKtXHMJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "mYHdpMgNreJVEgcigDRgnKtXHMJ");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr_UhGwOzyMNAHJQmbPJFXZgzOxUVg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "UhGwOzyMNAHJQmbPJFXZgzOxUVg");
			TouchJoystickAngleIndicator.NativeFieldInfoPtr_fnxRjitGBPGheCvVIVGWeDaqAGEI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, "fnxRjitGBPGheCvVIVGWeDaqAGEI");
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664586);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664587);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_targetAngleFromRotation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664588);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_targetAngleFromRotation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664589);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_targetAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664590);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_targetAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664591);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_fadeWithValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664592);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_fadeWithValue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664593);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_fadeWithAngle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664594);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_fadeWithAngle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664595);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_fadeRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664596);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_fadeRange_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664597);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_activeColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664598);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_activeColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664599);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_normalColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664600);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664601);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_image_Internal_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664602);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_currentSprite_Internal_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664603);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_rectTransform_Internal_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664604);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664605);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_uJTBnTIrAokQFlIcCrRDIuzmtOr_Internal_Boolean_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664606);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664607);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664608);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664609);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664610);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664611);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_jiCgAYeThQbZBaNDTkJtkimAkEK_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664612);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_dCiovMqNBDGtIfsINUNzKXggfdKH_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664613);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_LkMBdoeVUAqijzqacIwORTFVyvM_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664614);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_PhJCjikfSaldYwoRmkMqkxasPaV_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664615);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664616);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_BkdWfJFyZNlYrACLLezDhHBsJAvV_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664617);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_gCmkkLrXiPLGYMdHnYCHyCxoZbf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664618);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnVisibilityChanged_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664619);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnTouchJoystickStickPositionChanged_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664620);
			TouchJoystickAngleIndicator.NativeMethodInfoPtr_zcKBFosVCnCVuJtXcSlJxqwBSXX_Private_Virtual_Final_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr, 100664621);
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0004BECC File Offset: 0x0004A0CC
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0004BF08 File Offset: 0x0004A108
		public unsafe bool visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248739, XrefRangeEnd = 248740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0004BF48 File Offset: 0x0004A148
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0004BF84 File Offset: 0x0004A184
		public unsafe bool targetAngleFromRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_targetAngleFromRotation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_targetAngleFromRotation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0004BFC4 File Offset: 0x0004A1C4
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0004C000 File Offset: 0x0004A200
		public unsafe float targetAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248740, XrefRangeEnd = 248745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_targetAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_targetAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0004C040 File Offset: 0x0004A240
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0004C07C File Offset: 0x0004A27C
		public unsafe bool fadeWithValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_fadeWithValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_fadeWithValue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x0004C0BC File Offset: 0x0004A2BC
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0004C0F8 File Offset: 0x0004A2F8
		public unsafe bool fadeWithAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_fadeWithAngle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_fadeWithAngle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0004C138 File Offset: 0x0004A338
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0004C174 File Offset: 0x0004A374
		public unsafe float fadeRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_fadeRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_fadeRange_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0004C1B4 File Offset: 0x0004A3B4
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x0004C1F0 File Offset: 0x0004A3F0
		public unsafe Color activeColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_activeColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_activeColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0004C230 File Offset: 0x0004A430
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x0004C26C File Offset: 0x0004A46C
		public unsafe Color normalColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_normalColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0004C2AC File Offset: 0x0004A4AC
		public unsafe Image image
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 248748, RefRangeEnd = 248754, XrefRangeStart = 248745, XrefRangeEnd = 248748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_image_Internal_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0004C2EC File Offset: 0x0004A4EC
		public unsafe Sprite currentSprite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248754, XrefRangeEnd = 248780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_currentSprite_Internal_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0004C32C File Offset: 0x0004A52C
		public unsafe RectTransform rectTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248780, XrefRangeEnd = 248783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_get_rectTransform_Internal_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0004C36C File Offset: 0x0004A56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248783, XrefRangeEnd = 248786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchJoystickAngleIndicator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystickAngleIndicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0004C3A8 File Offset: 0x0004A5A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248814, RefRangeEnd = 248815, XrefRangeStart = 248786, XrefRangeEnd = 248814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool uJTBnTIrAokQFlIcCrRDIuzmtOr(out Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_uJTBnTIrAokQFlIcCrRDIuzmtOr_Internal_Boolean_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0004C3F4 File Offset: 0x0004A5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248815, XrefRangeEnd = 248818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0004C428 File Offset: 0x0004A628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248818, XrefRangeEnd = 248824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0004C45C File Offset: 0x0004A65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248824, XrefRangeEnd = 248825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0004C490 File Offset: 0x0004A690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248825, XrefRangeEnd = 248830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0004C4C4 File Offset: 0x0004A6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248830, XrefRangeEnd = 248831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0004C4F8 File Offset: 0x0004A6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248831, XrefRangeEnd = 248832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_jiCgAYeThQbZBaNDTkJtkimAkEK_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0004C544 File Offset: 0x0004A744
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 248858, RefRangeEnd = 248866, XrefRangeStart = 248832, XrefRangeEnd = 248858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dCiovMqNBDGtIfsINUNzKXggfdKH(Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_dCiovMqNBDGtIfsINUNzKXggfdKH_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0004C584 File Offset: 0x0004A784
		[CallerCount(0)]
		public unsafe void LkMBdoeVUAqijzqacIwORTFVyvM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_LkMBdoeVUAqijzqacIwORTFVyvM_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0004C5B8 File Offset: 0x0004A7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248866, XrefRangeEnd = 248867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhJCjikfSaldYwoRmkMqkxasPaV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_PhJCjikfSaldYwoRmkMqkxasPaV_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0004C5EC File Offset: 0x0004A7EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0004C620 File Offset: 0x0004A820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248879, RefRangeEnd = 248881, XrefRangeStart = 248867, XrefRangeEnd = 248879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BkdWfJFyZNlYrACLLezDhHBsJAvV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_BkdWfJFyZNlYrACLLezDhHBsJAvV_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0004C654 File Offset: 0x0004A854
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248884, RefRangeEnd = 248886, XrefRangeStart = 248881, XrefRangeEnd = 248884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void gCmkkLrXiPLGYMdHnYCHyCxoZbf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_gCmkkLrXiPLGYMdHnYCHyCxoZbf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0004C688 File Offset: 0x0004A888
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnVisibilityChanged_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0004C6C8 File Offset: 0x0004A8C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248903, RefRangeEnd = 248905, XrefRangeStart = 248886, XrefRangeEnd = 248903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTouchJoystickStickPositionChanged(Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_OnTouchJoystickStickPositionChanged_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0004C708 File Offset: 0x0004A908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248905, XrefRangeEnd = 248906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zcKBFosVCnCVuJtXcSlJxqwBSXX(Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickAngleIndicator.NativeMethodInfoPtr_zcKBFosVCnCVuJtXcSlJxqwBSXX_Private_Virtual_Final_New_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0000497E File Offset: 0x00002B7E
		public TouchJoystickAngleIndicator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0004C748 File Offset: 0x0004A948
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x00004987 File Offset: 0x00002B87
		public unsafe bool _visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__visible)) = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0004C770 File Offset: 0x0004A970
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x000049A2 File Offset: 0x00002BA2
		public unsafe bool _targetAngleFromRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__targetAngleFromRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__targetAngleFromRotation)) = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x0004C798 File Offset: 0x0004A998
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x000049BD File Offset: 0x00002BBD
		public unsafe float _targetAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__targetAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__targetAngle)) = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0004C7C0 File Offset: 0x0004A9C0
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x000049D8 File Offset: 0x00002BD8
		public unsafe bool _fadeWithValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__fadeWithValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__fadeWithValue)) = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x0004C7E8 File Offset: 0x0004A9E8
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x000049F3 File Offset: 0x00002BF3
		public unsafe bool _fadeWithAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__fadeWithAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__fadeWithAngle)) = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x0004C810 File Offset: 0x0004AA10
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00004A0E File Offset: 0x00002C0E
		public unsafe float _fadeRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__fadeRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__fadeRange)) = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x0004C838 File Offset: 0x0004AA38
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x00004A29 File Offset: 0x00002C29
		public unsafe Color _activeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__activeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__activeColor)) = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x0004C860 File Offset: 0x0004AA60
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x00004A44 File Offset: 0x00002C44
		public unsafe Color _normalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__normalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr__normalColor)) = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0004C888 File Offset: 0x0004AA88
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x00004A5F File Offset: 0x00002C5F
		public unsafe Image zwJHjzDPmvFTlzYvcIeuvFQsBhY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_zwJHjzDPmvFTlzYvcIeuvFQsBhY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_zwJHjzDPmvFTlzYvcIeuvFQsBhY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0004C8B8 File Offset: 0x0004AAB8
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00004A7E File Offset: 0x00002C7E
		public unsafe RectTransform GiZelSplzgAQqIxdnaEoBHfWMnw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_GiZelSplzgAQqIxdnaEoBHfWMnw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_GiZelSplzgAQqIxdnaEoBHfWMnw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x0004C8E8 File Offset: 0x0004AAE8
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00004A9D File Offset: 0x00002C9D
		public unsafe Vector2 mYHdpMgNreJVEgcigDRgnKtXHMJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_mYHdpMgNreJVEgcigDRgnKtXHMJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_mYHdpMgNreJVEgcigDRgnKtXHMJ)) = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0004C910 File Offset: 0x0004AB10
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public unsafe bool UhGwOzyMNAHJQmbPJFXZgzOxUVg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_UhGwOzyMNAHJQmbPJFXZgzOxUVg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_UhGwOzyMNAHJQmbPJFXZgzOxUVg)) = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0004C938 File Offset: 0x0004AB38
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00004AD3 File Offset: 0x00002CD3
		public unsafe IRegistrar<TouchJoystickAngleIndicator> fnxRjitGBPGheCvVIVGWeDaqAGEI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_fnxRjitGBPGheCvVIVGWeDaqAGEI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRegistrar<TouchJoystickAngleIndicator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickAngleIndicator.NativeFieldInfoPtr_fnxRjitGBPGheCvVIVGWeDaqAGEI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr__visible;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr__targetAngleFromRotation;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeFieldInfoPtr__targetAngle;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeFieldInfoPtr__fadeWithValue;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr__fadeWithAngle;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr__fadeRange;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr__activeColor;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeFieldInfoPtr__normalColor;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_zwJHjzDPmvFTlzYvcIeuvFQsBhY;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr_GiZelSplzgAQqIxdnaEoBHfWMnw;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeFieldInfoPtr_mYHdpMgNreJVEgcigDRgnKtXHMJ;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeFieldInfoPtr_UhGwOzyMNAHJQmbPJFXZgzOxUVg;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeFieldInfoPtr_fnxRjitGBPGheCvVIVGWeDaqAGEI;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Public_get_Boolean_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_get_targetAngleFromRotation_Public_get_Boolean_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_set_targetAngleFromRotation_Public_set_Void_Boolean_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_get_targetAngle_Public_get_Single_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_set_targetAngle_Public_set_Void_Single_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeWithValue_Public_get_Boolean_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeWithValue_Public_set_Void_Boolean_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeWithAngle_Public_get_Boolean_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeWithAngle_Public_set_Void_Boolean_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeRange_Public_get_Single_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeRange_Public_set_Void_Single_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_get_activeColor_Public_get_Color_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_set_activeColor_Public_set_Void_Color_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_get_normalColor_Public_get_Color_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_get_image_Internal_get_Image_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSprite_Internal_get_Sprite_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Internal_get_RectTransform_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_uJTBnTIrAokQFlIcCrRDIuzmtOr_Internal_Boolean_byref_Vector2_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_jiCgAYeThQbZBaNDTkJtkimAkEK_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_dCiovMqNBDGtIfsINUNzKXggfdKH_Private_Void_Vector2_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_LkMBdoeVUAqijzqacIwORTFVyvM_Private_Void_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_PhJCjikfSaldYwoRmkMqkxasPaV_Private_Void_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_BkdWfJFyZNlYrACLLezDhHBsJAvV_Private_Void_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_gCmkkLrXiPLGYMdHnYCHyCxoZbf_Private_Void_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityChanged_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_OnTouchJoystickStickPositionChanged_Public_Void_Vector2_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_zcKBFosVCnCVuJtXcSlJxqwBSXX_Private_Virtual_Final_New_Void_Vector2_0;
	}
}
