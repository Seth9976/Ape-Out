using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.ComponentControls.Data;
using Il2CppRewired.Internal;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x02000045 RID: 69
	[Serializable]
	public sealed class TiltControl : CustomControllerControl
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x00042610 File Offset: 0x00040810
		// Note: this type is marked as 'beforefieldinit'.
		static TiltControl()
		{
			Il2CppClassPointerStore<TiltControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "TiltControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TiltControl>.NativeClassPtr);
			TiltControl.NativeFieldInfoPtr_maxFullTiltAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "maxFullTiltAngle");
			TiltControl.NativeFieldInfoPtr_maxAngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "maxAngleOffset");
			TiltControl.NativeFieldInfoPtr__allowedTiltDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_allowedTiltDirections");
			TiltControl.NativeFieldInfoPtr__horizontalTiltCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_horizontalTiltCustomControllerElement");
			TiltControl.NativeFieldInfoPtr__horizontalTiltLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_horizontalTiltLimit");
			TiltControl.NativeFieldInfoPtr__horizontalRestAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_horizontalRestAngle");
			TiltControl.NativeFieldInfoPtr__forwardTiltCustomControllerElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_forwardTiltCustomControllerElement");
			TiltControl.NativeFieldInfoPtr__forwardTiltLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_forwardTiltLimit");
			TiltControl.NativeFieldInfoPtr__forwardRestAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_forwardRestAngle");
			TiltControl.NativeFieldInfoPtr__axis2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_axis2D");
			TiltControl.NativeFieldInfoPtr__useHAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_useHAxis");
			TiltControl.NativeFieldInfoPtr__useFAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_useFAxis");
			TiltControl.NativeFieldInfoPtr__getAccelerationValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, "_getAccelerationValue");
			TiltControl.NativeMethodInfoPtr_get_axesToUse_Public_get_TiltDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664213);
			TiltControl.NativeMethodInfoPtr_set_axesToUse_Public_set_Void_TiltDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664214);
			TiltControl.NativeMethodInfoPtr_get_horizontalTiltCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664215);
			TiltControl.NativeMethodInfoPtr_get_horizontalTiltLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664216);
			TiltControl.NativeMethodInfoPtr_set_horizontalTiltLimit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664217);
			TiltControl.NativeMethodInfoPtr_get_horizontalRestAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664218);
			TiltControl.NativeMethodInfoPtr_set_horizontalRestAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664219);
			TiltControl.NativeMethodInfoPtr_get_forwardTiltCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664220);
			TiltControl.NativeMethodInfoPtr_get_forwardTiltLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664221);
			TiltControl.NativeMethodInfoPtr_set_forwardTiltLimit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664222);
			TiltControl.NativeMethodInfoPtr_get_forwardRestAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664223);
			TiltControl.NativeMethodInfoPtr_set_forwardRestAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664224);
			TiltControl.NativeMethodInfoPtr_get_horizontalAxisCalibration_Public_get_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664225);
			TiltControl.NativeMethodInfoPtr_get_verticalAxisCalibration_Public_get_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664226);
			TiltControl.NativeMethodInfoPtr_get_deadZoneType_Public_get_Axis2DCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664227);
			TiltControl.NativeMethodInfoPtr_get_axis2DCalibration_Public_get_Axis2DCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664228);
			TiltControl.NativeMethodInfoPtr_get_axis2D_Internal_get_StandaloneAxis2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664229);
			TiltControl.NativeMethodInfoPtr_get_acceleration_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664230);
			TiltControl.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664231);
			TiltControl.NativeMethodInfoPtr_SetAccelerationSourceCallback_Public_Void_Func_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664232);
			TiltControl.NativeMethodInfoPtr_SetRestOrientation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664233);
			TiltControl.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664234);
			TiltControl.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664235);
			TiltControl.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664236);
			TiltControl.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664237);
			TiltControl.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664238);
			TiltControl.NativeMethodInfoPtr_XwmHgkvOOijOTJUcRFwCESsbgMUJ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664239);
			TiltControl.NativeMethodInfoPtr_pAmbhBqgIQiivQwoREfPhLBjLeN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664240);
			TiltControl.NativeMethodInfoPtr_UnMFjSCmAMGvytjoLOAahnsmUzmO_Private_Void_TiltDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiltControl>.NativeClassPtr, 100664241);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00042988 File Offset: 0x00040B88
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x000429C4 File Offset: 0x00040BC4
		public unsafe TiltControl.TiltDirection axesToUse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_axesToUse_Public_get_TiltDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246052, XrefRangeEnd = 246053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_set_axesToUse_Public_set_Void_TiltDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00042A04 File Offset: 0x00040C04
		public unsafe CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_horizontalTiltCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr3) : null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00042A44 File Offset: 0x00040C44
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00042A80 File Offset: 0x00040C80
		public unsafe float horizontalTiltLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_horizontalTiltLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246053, XrefRangeEnd = 246054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_set_horizontalTiltLimit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00042AC0 File Offset: 0x00040CC0
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00042AFC File Offset: 0x00040CFC
		public unsafe float horizontalRestAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_horizontalRestAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246054, XrefRangeEnd = 246055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_set_horizontalRestAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00042B3C File Offset: 0x00040D3C
		public unsafe CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_forwardTiltCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr3) : null;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00042B7C File Offset: 0x00040D7C
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00042BB8 File Offset: 0x00040DB8
		public unsafe float forwardTiltLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_forwardTiltLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246055, XrefRangeEnd = 246056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_set_forwardTiltLimit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00042BF8 File Offset: 0x00040DF8
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00042C34 File Offset: 0x00040E34
		public unsafe float forwardRestAngle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 91998, RefRangeEnd = 91999, XrefRangeStart = 91998, XrefRangeEnd = 91999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_forwardRestAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246056, XrefRangeEnd = 246057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_set_forwardRestAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00042C74 File Offset: 0x00040E74
		public unsafe AxisCalibration horizontalAxisCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_horizontalAxisCalibration_Public_get_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00042CB4 File Offset: 0x00040EB4
		public unsafe AxisCalibration verticalAxisCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_verticalAxisCalibration_Public_get_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00042CF4 File Offset: 0x00040EF4
		public unsafe Axis2DCalibration deadZoneType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_deadZoneType_Public_get_Axis2DCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Axis2DCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00042D34 File Offset: 0x00040F34
		public unsafe Axis2DCalibration axis2DCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_axis2DCalibration_Public_get_Axis2DCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Axis2DCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00042D74 File Offset: 0x00040F74
		public unsafe StandaloneAxis2D axis2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_axis2D_Internal_get_StandaloneAxis2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandaloneAxis2D>(intPtr3) : null;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00042DB4 File Offset: 0x00040FB4
		public unsafe Vector3 acceleration
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 246063, RefRangeEnd = 246070, XrefRangeStart = 246057, XrefRangeEnd = 246063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_get_acceleration_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00042DF0 File Offset: 0x00040FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246070, XrefRangeEnd = 246084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TiltControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TiltControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00042E2C File Offset: 0x0004102C
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 214194, RefRangeEnd = 214233, XrefRangeStart = 214194, XrefRangeEnd = 214233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAccelerationSourceCallback(Func<Vector3> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_SetAccelerationSourceCallback_Public_Void_Func_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00042E70 File Offset: 0x00041070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246084, XrefRangeEnd = 246089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRestOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_SetRestOrientation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00042EA4 File Offset: 0x000410A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246089, XrefRangeEnd = 246091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00042ED8 File Offset: 0x000410D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246091, XrefRangeEnd = 246093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool nSRkgireMOAkpBoLMmrDfIispUMG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00042F14 File Offset: 0x00041114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246093, XrefRangeEnd = 246094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NFTSnGXuZXafcZHIgcYanOLckXY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00042F48 File Offset: 0x00041148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246094, XrefRangeEnd = 246098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void zKEQtrzzyQhnNzFWJQGLGZUsGJG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00042F7C File Offset: 0x0004117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246098, XrefRangeEnd = 246105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00042FB0 File Offset: 0x000411B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246122, RefRangeEnd = 246123, XrefRangeStart = 246105, XrefRangeEnd = 246122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void XwmHgkvOOijOTJUcRFwCESsbgMUJ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_XwmHgkvOOijOTJUcRFwCESsbgMUJ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00042FE4 File Offset: 0x000411E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246128, RefRangeEnd = 246130, XrefRangeStart = 246123, XrefRangeEnd = 246128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void pAmbhBqgIQiivQwoREfPhLBjLeN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_pAmbhBqgIQiivQwoREfPhLBjLeN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00043018 File Offset: 0x00041218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246135, RefRangeEnd = 246137, XrefRangeStart = 246130, XrefRangeEnd = 246135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnMFjSCmAMGvytjoLOAahnsmUzmO(TiltControl.TiltDirection A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TiltControl.NativeMethodInfoPtr_UnMFjSCmAMGvytjoLOAahnsmUzmO_Private_Void_TiltDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00003B28 File Offset: 0x00001D28
		public TiltControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00043058 File Offset: 0x00041258
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00003B31 File Offset: 0x00001D31
		public unsafe static float maxFullTiltAngle
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TiltControl.NativeFieldInfoPtr_maxFullTiltAngle, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TiltControl.NativeFieldInfoPtr_maxFullTiltAngle, (void*)(&value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00043074 File Offset: 0x00041274
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00003B3F File Offset: 0x00001D3F
		public unsafe static float maxAngleOffset
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TiltControl.NativeFieldInfoPtr_maxAngleOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TiltControl.NativeFieldInfoPtr_maxAngleOffset, (void*)(&value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00043090 File Offset: 0x00041290
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00003B4D File Offset: 0x00001D4D
		public unsafe TiltControl.TiltDirection _allowedTiltDirections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__allowedTiltDirections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__allowedTiltDirections)) = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000430B8 File Offset: 0x000412B8
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00003B68 File Offset: 0x00001D68
		public unsafe CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__horizontalTiltCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__horizontalTiltCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000430E8 File Offset: 0x000412E8
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00003B87 File Offset: 0x00001D87
		public unsafe float _horizontalTiltLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__horizontalTiltLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__horizontalTiltLimit)) = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00043110 File Offset: 0x00041310
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00003BA2 File Offset: 0x00001DA2
		public unsafe float _horizontalRestAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__horizontalRestAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__horizontalRestAngle)) = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00043138 File Offset: 0x00041338
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00003BBD File Offset: 0x00001DBD
		public unsafe CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__forwardTiltCustomControllerElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTargetSetForFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__forwardTiltCustomControllerElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00043168 File Offset: 0x00041368
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00003BDC File Offset: 0x00001DDC
		public unsafe float _forwardTiltLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__forwardTiltLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__forwardTiltLimit)) = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00043190 File Offset: 0x00041390
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00003BF7 File Offset: 0x00001DF7
		public unsafe float _forwardRestAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__forwardRestAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__forwardRestAngle)) = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x000431B8 File Offset: 0x000413B8
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00003C12 File Offset: 0x00001E12
		public unsafe StandaloneAxis2D _axis2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__axis2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__axis2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000431E8 File Offset: 0x000413E8
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00003C31 File Offset: 0x00001E31
		public unsafe bool _useHAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__useHAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__useHAxis)) = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00043210 File Offset: 0x00041410
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00003C4C File Offset: 0x00001E4C
		public unsafe bool _useFAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__useFAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__useFAxis)) = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00043238 File Offset: 0x00041438
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00003C67 File Offset: 0x00001E67
		public unsafe Func<Vector3> _getAccelerationValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__getAccelerationValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TiltControl.NativeFieldInfoPtr__getAccelerationValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_maxFullTiltAngle;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr_maxAngleOffset;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr__allowedTiltDirections;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr__horizontalTiltCustomControllerElement;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr__horizontalTiltLimit;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr__horizontalRestAngle;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr__forwardTiltCustomControllerElement;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr__forwardTiltLimit;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr__forwardRestAngle;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr__axis2D;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr__useHAxis;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr__useFAxis;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr__getAccelerationValue;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_get_axesToUse_Public_get_TiltDirection_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_set_axesToUse_Public_set_Void_TiltDirection_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalTiltCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalTiltLimit_Public_get_Single_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalTiltLimit_Public_set_Void_Single_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalRestAngle_Public_get_Single_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalRestAngle_Public_set_Void_Single_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_get_forwardTiltCustomControllerElement_Public_get_CustomControllerElementTargetSetForFloat_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_get_forwardTiltLimit_Public_get_Single_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_set_forwardTiltLimit_Public_set_Void_Single_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_get_forwardRestAngle_Public_get_Single_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_set_forwardRestAngle_Public_set_Void_Single_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAxisCalibration_Public_get_AxisCalibration_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAxisCalibration_Public_get_AxisCalibration_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_get_deadZoneType_Public_get_Axis2DCalibration_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_get_axis2DCalibration_Public_get_Axis2DCalibration_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_get_axis2D_Internal_get_StandaloneAxis2D_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_get_acceleration_Private_get_Vector3_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_SetAccelerationSourceCallback_Public_Void_Func_1_Vector3_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_SetRestOrientation_Public_Void_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_nSRkgireMOAkpBoLMmrDfIispUMG_Internal_Virtual_Boolean_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Internal_Virtual_Void_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Virtual_Void_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_ClearValue_Public_Virtual_Void_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_XwmHgkvOOijOTJUcRFwCESsbgMUJ_Private_Void_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_pAmbhBqgIQiivQwoREfPhLBjLeN_Private_Void_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_UnMFjSCmAMGvytjoLOAahnsmUzmO_Private_Void_TiltDirection_0;

		// Token: 0x0200023F RID: 575
		[OriginalName("Rewired_Core.dll", "", "TiltDirection")]
		public enum TiltDirection
		{
			// Token: 0x04002FD2 RID: 12242
			Both,
			// Token: 0x04002FD3 RID: 12243
			Horizontal,
			// Token: 0x04002FD4 RID: 12244
			Forward
		}
	}
}
