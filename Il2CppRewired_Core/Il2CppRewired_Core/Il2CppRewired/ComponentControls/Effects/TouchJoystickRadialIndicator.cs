using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.ComponentControls.Effects
{
	// Token: 0x0200004D RID: 77
	public sealed class TouchJoystickRadialIndicator : MonoBehaviour
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x0004C968 File Offset: 0x0004AB68
		// Note: this type is marked as 'beforefieldinit'.
		static TouchJoystickRadialIndicator()
		{
			Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Effects", "TouchJoystickRadialIndicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr);
			TouchJoystickRadialIndicator.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, "_scale");
			TouchJoystickRadialIndicator.NativeFieldInfoPtr__preserveSpriteAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, "_preserveSpriteAspectRatio");
			TouchJoystickRadialIndicator.NativeFieldInfoPtr__scaleRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, "_scaleRatio");
			TouchJoystickRadialIndicator.NativeFieldInfoPtr__aspectRatioX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, "_aspectRatioX");
			TouchJoystickRadialIndicator.NativeFieldInfoPtr__aspectRatioY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, "_aspectRatioY");
			TouchJoystickRadialIndicator.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, "_offset");
			TouchJoystickRadialIndicator.NativeFieldInfoPtr_SsUNvZdMmoMAjwWFScGjjmGfgeXf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, "SsUNvZdMmoMAjwWFScGjjmGfgeXf");
			TouchJoystickRadialIndicator.NativeFieldInfoPtr_GiZelSplzgAQqIxdnaEoBHfWMnw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, "GiZelSplzgAQqIxdnaEoBHfWMnw");
			TouchJoystickRadialIndicator.NativeFieldInfoPtr_EVARXXulAgoJFRbAhqkZbXctRte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, "EVARXXulAgoJFRbAhqkZbXctRte");
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_scale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664622);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_scale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664623);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_preserveSpriteAspectRatio_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664624);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_preserveSpriteAspectRatio_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664625);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_scaleRatio_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664626);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_scaleRatio_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664627);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_aspectRatioX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664628);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_aspectRatioX_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664629);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_aspectRatioY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664630);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_aspectRatioY_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664631);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_offset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664632);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_offset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664633);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664634);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_LMjqtMghaNWxPdBVsckyYKFbFbR_Private_Virtual_Final_New_Void_TouchJoystickAngleIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664635);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_cHHCwHrqTScagFKfhqRxEpgpbDok_Private_Virtual_Final_New_Void_TouchJoystickAngleIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664636);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664637);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664638);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664639);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664640);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_rKwlhqulJzaSvFEZeSXyPdajfBt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664641);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_dCiovMqNBDGtIfsINUNzKXggfdKH_Private_Void_TouchJoystickAngleIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664642);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664643);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr_CkeCBVVRljzOqltPzjFgScsFztP_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664644);
			TouchJoystickRadialIndicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr, 100664645);
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0004CC2C File Offset: 0x0004AE2C
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0004CC68 File Offset: 0x0004AE68
		public unsafe bool scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_scale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248906, XrefRangeEnd = 248907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_scale_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0004CCA8 File Offset: 0x0004AEA8
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x0004CCE4 File Offset: 0x0004AEE4
		public unsafe bool preserveSpriteAspectRatio
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_preserveSpriteAspectRatio_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248907, XrefRangeEnd = 248908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_preserveSpriteAspectRatio_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x0004CD24 File Offset: 0x0004AF24
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x0004CD60 File Offset: 0x0004AF60
		public unsafe float scaleRatio
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_scaleRatio_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248908, XrefRangeEnd = 248910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_scaleRatio_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x0004CDA0 File Offset: 0x0004AFA0
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x0004CDDC File Offset: 0x0004AFDC
		public unsafe float aspectRatioX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_aspectRatioX_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248910, XrefRangeEnd = 248912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_aspectRatioX_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0004CE1C File Offset: 0x0004B01C
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x0004CE58 File Offset: 0x0004B058
		public unsafe float aspectRatioY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_aspectRatioY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248912, XrefRangeEnd = 248914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_aspectRatioY_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0004CE98 File Offset: 0x0004B098
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x0004CED4 File Offset: 0x0004B0D4
		public unsafe float offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_offset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248914, XrefRangeEnd = 248915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_set_offset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x0004CF14 File Offset: 0x0004B114
		public unsafe RectTransform rectTransform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 248918, RefRangeEnd = 248920, XrefRangeStart = 248915, XrefRangeEnd = 248918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0004CF54 File Offset: 0x0004B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248920, XrefRangeEnd = 248938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LMjqtMghaNWxPdBVsckyYKFbFbR(TouchJoystickAngleIndicator A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_LMjqtMghaNWxPdBVsckyYKFbFbR_Private_Virtual_Final_New_Void_TouchJoystickAngleIndicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0004CF98 File Offset: 0x0004B198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248938, XrefRangeEnd = 248952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cHHCwHrqTScagFKfhqRxEpgpbDok(TouchJoystickAngleIndicator A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_cHHCwHrqTScagFKfhqRxEpgpbDok_Private_Virtual_Final_New_Void_TouchJoystickAngleIndicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0004CFDC File Offset: 0x0004B1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248952, XrefRangeEnd = 248953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0004D010 File Offset: 0x0004B210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248953, XrefRangeEnd = 248957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0004D044 File Offset: 0x0004B244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0004D078 File Offset: 0x0004B278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248957, XrefRangeEnd = 248959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0004D0AC File Offset: 0x0004B2AC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 248968, RefRangeEnd = 248978, XrefRangeStart = 248959, XrefRangeEnd = 248968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void rKwlhqulJzaSvFEZeSXyPdajfBt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_rKwlhqulJzaSvFEZeSXyPdajfBt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0004D0E0 File Offset: 0x0004B2E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249041, RefRangeEnd = 249043, XrefRangeStart = 248978, XrefRangeEnd = 249041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dCiovMqNBDGtIfsINUNzKXggfdKH(TouchJoystickAngleIndicator A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_dCiovMqNBDGtIfsINUNzKXggfdKH_Private_Void_TouchJoystickAngleIndicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0004D124 File Offset: 0x0004B324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0004D158 File Offset: 0x0004B358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249069, RefRangeEnd = 249070, XrefRangeStart = 249043, XrefRangeEnd = 249069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CkeCBVVRljzOqltPzjFgScsFztP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr_CkeCBVVRljzOqltPzjFgScsFztP_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0004D18C File Offset: 0x0004B38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249070, XrefRangeEnd = 249081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchJoystickRadialIndicator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystickRadialIndicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchJoystickRadialIndicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00004AF2 File Offset: 0x00002CF2
		public TouchJoystickRadialIndicator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0004D1C8 File Offset: 0x0004B3C8
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00004AFB File Offset: 0x00002CFB
		public unsafe bool _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__scale)) = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0004D1F0 File Offset: 0x0004B3F0
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00004B16 File Offset: 0x00002D16
		public unsafe bool _preserveSpriteAspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__preserveSpriteAspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__preserveSpriteAspectRatio)) = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0004D218 File Offset: 0x0004B418
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00004B31 File Offset: 0x00002D31
		public unsafe float _scaleRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__scaleRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__scaleRatio)) = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x0004D240 File Offset: 0x0004B440
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00004B4C File Offset: 0x00002D4C
		public unsafe float _aspectRatioX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__aspectRatioX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__aspectRatioX)) = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0004D268 File Offset: 0x0004B468
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00004B67 File Offset: 0x00002D67
		public unsafe float _aspectRatioY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__aspectRatioY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__aspectRatioY)) = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0004D290 File Offset: 0x0004B490
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00004B82 File Offset: 0x00002D82
		public unsafe float _offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr__offset)) = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0004D2B8 File Offset: 0x0004B4B8
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00004B9D File Offset: 0x00002D9D
		public unsafe static Vector2 SsUNvZdMmoMAjwWFScGjjmGfgeXf
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TouchJoystickRadialIndicator.NativeFieldInfoPtr_SsUNvZdMmoMAjwWFScGjjmGfgeXf, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchJoystickRadialIndicator.NativeFieldInfoPtr_SsUNvZdMmoMAjwWFScGjjmGfgeXf, (void*)(&value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0004D2D4 File Offset: 0x0004B4D4
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00004BAB File Offset: 0x00002DAB
		public unsafe RectTransform GiZelSplzgAQqIxdnaEoBHfWMnw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr_GiZelSplzgAQqIxdnaEoBHfWMnw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr_GiZelSplzgAQqIxdnaEoBHfWMnw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0004D304 File Offset: 0x0004B504
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00004BCA File Offset: 0x00002DCA
		public unsafe List<TouchJoystickAngleIndicator> EVARXXulAgoJFRbAhqkZbXctRte
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr_EVARXXulAgoJFRbAhqkZbXctRte);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TouchJoystickAngleIndicator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchJoystickRadialIndicator.NativeFieldInfoPtr_EVARXXulAgoJFRbAhqkZbXctRte), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeFieldInfoPtr__preserveSpriteAspectRatio;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr__scaleRatio;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr__aspectRatioX;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeFieldInfoPtr__aspectRatioY;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr__offset;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_SsUNvZdMmoMAjwWFScGjjmGfgeXf;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_GiZelSplzgAQqIxdnaEoBHfWMnw;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_EVARXXulAgoJFRbAhqkZbXctRte;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Boolean_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Boolean_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_get_preserveSpriteAspectRatio_Public_get_Boolean_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_set_preserveSpriteAspectRatio_Public_set_Void_Boolean_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleRatio_Public_get_Single_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleRatio_Public_set_Void_Single_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_get_aspectRatioX_Public_get_Single_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_set_aspectRatioX_Public_set_Void_Single_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_get_aspectRatioY_Public_get_Single_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_set_aspectRatioY_Public_set_Void_Single_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_get_offset_Public_get_Single_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_set_offset_Public_set_Void_Single_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_LMjqtMghaNWxPdBVsckyYKFbFbR_Private_Virtual_Final_New_Void_TouchJoystickAngleIndicator_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_cHHCwHrqTScagFKfhqRxEpgpbDok_Private_Virtual_Final_New_Void_TouchJoystickAngleIndicator_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_rKwlhqulJzaSvFEZeSXyPdajfBt_Private_Void_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_dCiovMqNBDGtIfsINUNzKXggfdKH_Private_Void_TouchJoystickAngleIndicator_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_CkeCBVVRljzOqltPzjFgScsFztP_Private_Void_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
