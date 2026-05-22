using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x0200018E RID: 398
	public class PS4ControllerExtension : Controller.Extension
	{
		// Token: 0x060028F9 RID: 10489 RVA: 0x000CEED8 File Offset: 0x000CD0D8
		// Note: this type is marked as 'beforefieldinit'.
		static PS4ControllerExtension()
		{
			Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "PS4ControllerExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr);
			PS4ControllerExtension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, "KGQsYBfjblOxfiUZWLkipVdVFYP");
			PS4ControllerExtension.NativeMethodInfoPtr_get_Source_Private_get_IPS4ControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673235);
			PS4ControllerExtension.NativeMethodInfoPtr_get_joystick_Internal_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673236);
			PS4ControllerExtension.NativeMethodInfoPtr__ctor_Internal_Void_IPS4ControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673237);
			PS4ControllerExtension.NativeMethodInfoPtr__ctor_Protected_Void_PS4ControllerExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673238);
			PS4ControllerExtension.NativeMethodInfoPtr_get_deviceHandle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673239);
			PS4ControllerExtension.NativeMethodInfoPtr_get_userStatusCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673240);
			PS4ControllerExtension.NativeMethodInfoPtr_get_userIsPrimary_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673241);
			PS4ControllerExtension.NativeMethodInfoPtr_get_userId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673242);
			PS4ControllerExtension.NativeMethodInfoPtr_get_userColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673243);
			PS4ControllerExtension.NativeMethodInfoPtr_get_userColorId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673244);
			PS4ControllerExtension.NativeMethodInfoPtr_get_userName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673245);
			PS4ControllerExtension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673246);
			PS4ControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673247);
			PS4ControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673248);
			PS4ControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673249);
			PS4ControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673250);
			PS4ControllerExtension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673251);
			PS4ControllerExtension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673252);
			PS4ControllerExtension.NativeMethodInfoPtr_GetAccelerometerValueRaw_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673253);
			PS4ControllerExtension.NativeMethodInfoPtr_GetAccelerometerValue_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673254);
			PS4ControllerExtension.NativeMethodInfoPtr_GetLastGyroscopeValueRaw_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673255);
			PS4ControllerExtension.NativeMethodInfoPtr_GetLastGyroscopeValue_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673256);
			PS4ControllerExtension.NativeMethodInfoPtr_GetOrientationRaw_Public_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673257);
			PS4ControllerExtension.NativeMethodInfoPtr_GetOrientation_Public_Virtual_Final_New_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673258);
			PS4ControllerExtension.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673259);
			PS4ControllerExtension.NativeMethodInfoPtr_SetMotionSensorState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673260);
			PS4ControllerExtension.NativeMethodInfoPtr_SetTiltCorrectionState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673261);
			PS4ControllerExtension.NativeMethodInfoPtr_SetAngularVelocityDeadbandState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673262);
			PS4ControllerExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673263);
			PS4ControllerExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673264);
			PS4ControllerExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673265);
			PS4ControllerExtension.NativeMethodInfoPtr_ResetLight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673266);
			PS4ControllerExtension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673267);
			PS4ControllerExtension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673268);
			PS4ControllerExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673269);
			PS4ControllerExtension.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673270);
			PS4ControllerExtension.NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, 100673271);
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x000CF200 File Offset: 0x000CD400
		public unsafe IPS4ControllerExtensionSource Source
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 309057, RefRangeEnd = 309087, XrefRangeStart = 309055, XrefRangeEnd = 309057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_Source_Private_get_IPS4ControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPS4ControllerExtensionSource>(intPtr3) : null;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x000CF240 File Offset: 0x000CD440
		public unsafe Joystick joystick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309087, XrefRangeEnd = 309089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_joystick_Internal_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr3) : null;
			}
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x000CF280 File Offset: 0x000CD480
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 309109, RefRangeEnd = 309118, XrefRangeStart = 309089, XrefRangeEnd = 309109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PS4ControllerExtension(IPS4ControllerExtensionSource source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr__ctor_Internal_Void_IPS4ControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000CF2CC File Offset: 0x000CD4CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 309142, RefRangeEnd = 309147, XrefRangeStart = 309118, XrefRangeEnd = 309142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PS4ControllerExtension(PS4ControllerExtension source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr__ctor_Protected_Void_PS4ControllerExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x000CF318 File Offset: 0x000CD518
		public unsafe int deviceHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309147, XrefRangeEnd = 309157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_deviceHandle_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x000CF354 File Offset: 0x000CD554
		public unsafe int userStatusCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309157, XrefRangeEnd = 309167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_userStatusCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x000CF390 File Offset: 0x000CD590
		public unsafe bool userIsPrimary
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309167, XrefRangeEnd = 309177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_userIsPrimary_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x000CF3CC File Offset: 0x000CD5CC
		public unsafe int userId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309177, XrefRangeEnd = 309187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_userId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x000CF408 File Offset: 0x000CD608
		public unsafe Color userColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309187, XrefRangeEnd = 309198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_userColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x000CF444 File Offset: 0x000CD644
		public unsafe int userColorId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309198, XrefRangeEnd = 309208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_userColorId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x000CF480 File Offset: 0x000CD680
		public unsafe string userName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309208, XrefRangeEnd = 309220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_userName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x000CF4B8 File Offset: 0x000CD6B8
		public unsafe virtual int vibrationMotorCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309220, XrefRangeEnd = 309230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x000CF4F4 File Offset: 0x000CD6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309230, XrefRangeEnd = 309238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVibration(int motorIndex, float motorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x000CF540 File Offset: 0x000CD740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309238, XrefRangeEnd = 309239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVibration(int motorIndex, float motorLevel, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000CF59C File Offset: 0x000CD79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309239, XrefRangeEnd = 309240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x000CF5F8 File Offset: 0x000CD7F8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 309264, RefRangeEnd = 309279, XrefRangeStart = 309240, XrefRangeEnd = 309264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000CF660 File Offset: 0x000CD860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309292, RefRangeEnd = 309294, XrefRangeStart = 309279, XrefRangeEnd = 309292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetVibration(int motorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000CF6AC File Offset: 0x000CD8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309294, XrefRangeEnd = 309309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000CF6E0 File Offset: 0x000CD8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309309, XrefRangeEnd = 309322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 GetAccelerometerValueRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_GetAccelerometerValueRaw_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000CF71C File Offset: 0x000CD91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309322, XrefRangeEnd = 309335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 GetAccelerometerValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_GetAccelerometerValue_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000CF758 File Offset: 0x000CD958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309335, XrefRangeEnd = 309348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLastGyroscopeValueRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_GetLastGyroscopeValueRaw_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000CF794 File Offset: 0x000CD994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309348, XrefRangeEnd = 309361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLastGyroscopeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_GetLastGyroscopeValue_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000CF7D0 File Offset: 0x000CD9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309361, XrefRangeEnd = 309374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetOrientationRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_GetOrientationRaw_Public_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000CF80C File Offset: 0x000CDA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309374, XrefRangeEnd = 309387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Quaternion GetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_GetOrientation_Public_Virtual_Final_New_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000CF848 File Offset: 0x000CDA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309387, XrefRangeEnd = 309398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000CF87C File Offset: 0x000CDA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309398, XrefRangeEnd = 309409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMotionSensorState(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetMotionSensorState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000CF8BC File Offset: 0x000CDABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309409, XrefRangeEnd = 309420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTiltCorrectionState(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetTiltCorrectionState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000CF8FC File Offset: 0x000CDAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309420, XrefRangeEnd = 309431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAngularVelocityDeadbandState(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetAngularVelocityDeadbandState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000CF93C File Offset: 0x000CDB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309431, XrefRangeEnd = 309436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLightColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000CF97C File Offset: 0x000CDB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309436, XrefRangeEnd = 309444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLightColor(float red, float green, float blue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref red;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000CF9D8 File Offset: 0x000CDBD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309461, RefRangeEnd = 309463, XrefRangeStart = 309444, XrefRangeEnd = 309461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLightColor(float red, float green, float blue, float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref red;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000CFA40 File Offset: 0x000CDC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309463, XrefRangeEnd = 309474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_ResetLight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000CFA74 File Offset: 0x000CDC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309474, XrefRangeEnd = 309486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PS4ControllerExtension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000CFAC0 File Offset: 0x000CDCC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SouFSqCHNLMbAzpFusEqgKLXdOQA(IControllerExtensionSource A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PS4ControllerExtension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000CFB10 File Offset: 0x000CDD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309486, XrefRangeEnd = 309490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension dLAxRoWNebGZzafOZSROBGeqqVrC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PS4ControllerExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000CFB5C File Offset: 0x000CDD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BicogWPgevrFZwICbwpkHBEuTLD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000CFB90 File Offset: 0x000CDD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309490, XrefRangeEnd = 309495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void mVQYCbUBHoFNvrjgeeLvwddRTuC(int A_1, float A_2, float A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0000FB4B File Offset: 0x0000DD4B
		public PS4ControllerExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x000CFBEC File Offset: 0x000CDDEC
		// (set) Token: 0x06002921 RID: 10529 RVA: 0x0000FB54 File Offset: 0x0000DD54
		public unsafe Il2CppReferenceArray<TimerAbs> KGQsYBfjblOxfiUZWLkipVdVFYP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4ControllerExtension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimerAbs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4ControllerExtension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Private_get_IPS4ControllerExtensionSource_0;

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeMethodInfoPtr_get_joystick_Internal_get_Joystick_0;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IPS4ControllerExtensionSource_0;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_PS4ControllerExtension_0;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceHandle_Public_get_Int32_0;

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeMethodInfoPtr_get_userStatusCode_Public_get_Int32_0;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeMethodInfoPtr_get_userIsPrimary_Public_get_Boolean_0;

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeMethodInfoPtr_get_userId_Public_get_Int32_0;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeMethodInfoPtr_get_userColor_Public_get_Color_0;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeMethodInfoPtr_get_userColorId_Public_get_Int32_0;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeMethodInfoPtr_get_userName_Public_get_String_0;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeMethodInfoPtr_GetAccelerometerValueRaw_Public_Virtual_Final_New_Vector3_0;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeMethodInfoPtr_GetAccelerometerValue_Public_Virtual_Final_New_Vector3_0;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeMethodInfoPtr_GetLastGyroscopeValueRaw_Public_Vector3_0;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr_GetLastGyroscopeValue_Public_Vector3_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr_GetOrientationRaw_Public_Quaternion_0;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeMethodInfoPtr_GetOrientation_Public_Virtual_Final_New_Quaternion_0;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeMethodInfoPtr_SetMotionSensorState_Public_Void_Boolean_0;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeMethodInfoPtr_SetTiltCorrectionState_Public_Void_Boolean_0;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeMethodInfoPtr_SetAngularVelocityDeadbandState_Public_Void_Boolean_0;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Color_0;

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_0;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0;

		// Token: 0x040022DD RID: 8925
		private static readonly IntPtr NativeMethodInfoPtr_ResetLight_Public_Void_0;

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_Int32_Single_Single_0;

		// Token: 0x0200038D RID: 909
		public class zZSkGlNrFpsjyUOUCFiMkhCMGeI : global::Il2CppSystem.Object
		{
			// Token: 0x06004B55 RID: 19285 RVA: 0x0015852C File Offset: 0x0015672C
			// Note: this type is marked as 'beforefieldinit'.
			static zZSkGlNrFpsjyUOUCFiMkhCMGeI()
			{
				Il2CppClassPointerStore<PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4ControllerExtension>.NativeClassPtr, "zZSkGlNrFpsjyUOUCFiMkhCMGeI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI>.NativeClassPtr);
				PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI>.NativeClassPtr, "biBJftmjAXeWoBqMpeqfZEjZwtg");
				PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI.NativeMethodInfoPtr__ctor_Public_Void_IPS4ControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI>.NativeClassPtr, 100673272);
			}

			// Token: 0x06004B56 RID: 19286 RVA: 0x00158580 File Offset: 0x00156780
			[CallerCount(0)]
			public unsafe zZSkGlNrFpsjyUOUCFiMkhCMGeI(IPS4ControllerExtensionSource source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI.NativeMethodInfoPtr__ctor_Public_Void_IPS4ControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B57 RID: 19287 RVA: 0x0001BB8B File Offset: 0x00019D8B
			public zZSkGlNrFpsjyUOUCFiMkhCMGeI(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001799 RID: 6041
			// (get) Token: 0x06004B58 RID: 19288 RVA: 0x001585CC File Offset: 0x001567CC
			// (set) Token: 0x06004B59 RID: 19289 RVA: 0x0001BB94 File Offset: 0x00019D94
			public unsafe IPS4ControllerExtensionSource biBJftmjAXeWoBqMpeqfZEjZwtg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPS4ControllerExtensionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4ControllerExtension.zZSkGlNrFpsjyUOUCFiMkhCMGeI.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CEF RID: 15599
			private static readonly IntPtr NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg;

			// Token: 0x04003CF0 RID: 15600
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IPS4ControllerExtensionSource_0;
		}
	}
}
