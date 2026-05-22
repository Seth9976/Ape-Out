using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200009A RID: 154
	public sealed class PlayerMouse : PlayerController
	{
		// Token: 0x060011F4 RID: 4596 RVA: 0x000704A4 File Offset: 0x0006E6A4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMouse()
		{
			Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "PlayerMouse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr);
			PlayerMouse.NativeFieldInfoPtr_mOklQgiztlGoJeMUbFrySXqlUpe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "mOklQgiztlGoJeMUbFrySXqlUpe");
			PlayerMouse.NativeFieldInfoPtr_IJVKGuRlcJiBZuNmiwOwrDpdRhO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "IJVKGuRlcJiBZuNmiwOwrDpdRhO");
			PlayerMouse.NativeFieldInfoPtr_XwsImLqEGBYnTZRMvuAmOREkUst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "XwsImLqEGBYnTZRMvuAmOREkUst");
			PlayerMouse.NativeFieldInfoPtr_GBbQxFaHmYtwjBVxddgUVJVGGql = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "GBbQxFaHmYtwjBVxddgUVJVGGql");
			PlayerMouse.NativeFieldInfoPtr_rZghqedXRnbVhWiZdAqZjBplhrob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "rZghqedXRnbVhWiZdAqZjBplhrob");
			PlayerMouse.NativeFieldInfoPtr_QmnDWzFRKGgKtCSDMTZSDdMHKzK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "QmnDWzFRKGgKtCSDMTZSDdMHKzK");
			PlayerMouse.NativeFieldInfoPtr_SXCxuGjAaTnVocptTaBRRQrndtwC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "SXCxuGjAaTnVocptTaBRRQrndtwC");
			PlayerMouse.NativeFieldInfoPtr_GzRgsaIepOhzpOjYLbstFiPKEVbH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "GzRgsaIepOhzpOjYLbstFiPKEVbH");
			PlayerMouse.NativeFieldInfoPtr_xQkVHowYTpkviBYHaMHZXTeTtqZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "xQkVHowYTpkviBYHaMHZXTeTtqZ");
			PlayerMouse.NativeFieldInfoPtr_UGFNwzeMxgKkLUulqeOjTMFnDQla = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "UGFNwzeMxgKkLUulqeOjTMFnDQla");
			PlayerMouse.NativeFieldInfoPtr_WiSbizWoNsOKeKaJeGRGCNgtktq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "WiSbizWoNsOKeKaJeGRGCNgtktq");
			PlayerMouse.NativeFieldInfoPtr_nzgkDNdbwsFohCGIwpAeqkqkIcDL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "nzgkDNdbwsFohCGIwpAeqkqkIcDL");
			PlayerMouse.NativeFieldInfoPtr_wBRKCSjqIRhWbnDRMxInvRbHcGZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "wBRKCSjqIRhWbnDRMxInvRbHcGZ");
			PlayerMouse.NativeFieldInfoPtr_zeBtwqoLTchNaogLtTUpZZARUoZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "zeBtwqoLTchNaogLtTUpZZARUoZ");
			PlayerMouse.NativeFieldInfoPtr_aUJlrhtNVbhnbprSYBKdajTMXTkF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "aUJlrhtNVbhnbprSYBKdajTMXTkF");
			PlayerMouse.NativeFieldInfoPtr_ItOEENaSWcaHqzWRZqijiIKRgfJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "ItOEENaSWcaHqzWRZqijiIKRgfJ");
			PlayerMouse.NativeFieldInfoPtr_rDIGuFpvGqnFrZnSbhWVaPKWlYL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "rDIGuFpvGqnFrZnSbhWVaPKWlYL");
			PlayerMouse.NativeFieldInfoPtr_rUhbMOkKNrywbbyYRdFDSKHADiqD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "rUhbMOkKNrywbbyYRdFDSKHADiqD");
			PlayerMouse.NativeFieldInfoPtr_RHPDYrHkMFtoKPdyxokfeZpmSQSb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "RHPDYrHkMFtoKPdyxokfeZpmSQSb");
			PlayerMouse.NativeFieldInfoPtr_zSgAbPznnhkoFgltldjpjszOzccK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "zSgAbPznnhkoFgltldjpjszOzccK");
			PlayerMouse.NativeFieldInfoPtr_fHpbqKukJTTCmUEceNpHhbjzXPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "fHpbqKukJTTCmUEceNpHhbjzXPC");
			PlayerMouse.NativeFieldInfoPtr_BIsdqvFaobocronFAESpUCJAqpB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "BIsdqvFaobocronFAESpUCJAqpB");
			PlayerMouse.NativeFieldInfoPtr_MjiOsObFGTDAuHfjVtpWIEBgccxZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "MjiOsObFGTDAuHfjVtpWIEBgccxZ");
			PlayerMouse.NativeFieldInfoPtr_tWYdZprZIzPVifjBvzWiFilyrOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "tWYdZprZIzPVifjBvzWiFilyrOI");
			PlayerMouse.NativeFieldInfoPtr_eBsvthmvzhrmSYctTIlMUwxPmus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "eBsvthmvzhrmSYctTIlMUwxPmus");
			PlayerMouse.NativeFieldInfoPtr_rSahUNXbVmzhornLxdrsDXBcrdIU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "rSahUNXbVmzhornLxdrsDXBcrdIU");
			PlayerMouse.NativeFieldInfoPtr_TfsoZYHQMdqdtFlHDBsyoghCqsZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "TfsoZYHQMdqdtFlHDBsyoghCqsZ");
			PlayerMouse.NativeFieldInfoPtr_ZIlfCsNrPtiQHtguiwXkAMscvmr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "ZIlfCsNrPtiQHtguiwXkAMscvmr");
			PlayerMouse.NativeFieldInfoPtr_OaxbtQqRzViukFlqDFuXlEGlUTb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "OaxbtQqRzViukFlqDFuXlEGlUTb");
			PlayerMouse.NativeFieldInfoPtr_GHCuoIKcIIbOrjxNJZwujCAIIah = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "GHCuoIKcIIbOrjxNJZwujCAIIah");
			PlayerMouse.NativeFieldInfoPtr_FFWukBItqFdxHqMyiAANmCHfcrTc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "FFWukBItqFdxHqMyiAANmCHfcrTc");
			PlayerMouse.NativeFieldInfoPtr_nkqXIVFRbFiyxBPfKjcCbhACIdqI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "nkqXIVFRbFiyxBPfKjcCbhACIdqI");
			PlayerMouse.NativeFieldInfoPtr_mFdJqmIjDwIRbyWDEOpUGoWQlxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "mFdJqmIjDwIRbyWDEOpUGoWQlxy");
			PlayerMouse.NativeFieldInfoPtr_rFbcjuqPRnGuKNbwXnbUttwpFpk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "rFbcjuqPRnGuKNbwXnbUttwpFpk");
			PlayerMouse.NativeFieldInfoPtr_tqeCPBgZAtqKymKrnchZAZElVRrm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "tqeCPBgZAtqKymKrnchZAZElVRrm");
			PlayerMouse.NativeFieldInfoPtr_OiFKhQdCNESZSaOAvYrYSTuQenH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "OiFKhQdCNESZSaOAvYrYSTuQenH");
			PlayerMouse.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "YtejDiqaLAxxRnmscggDavQFcLz");
			PlayerMouse.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "ikzytTXFFDqNPkVCCmeRclgjukz");
			PlayerMouse.NativeMethodInfoPtr__ctor_Private_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666322);
			PlayerMouse.NativeMethodInfoPtr_get_defaultToCenter_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666323);
			PlayerMouse.NativeMethodInfoPtr_set_defaultToCenter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666324);
			PlayerMouse.NativeMethodInfoPtr_get_clampToMovementArea_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666325);
			PlayerMouse.NativeMethodInfoPtr_set_clampToMovementArea_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666326);
			PlayerMouse.NativeMethodInfoPtr_get_movementArea_Public_Virtual_Final_New_get_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666327);
			PlayerMouse.NativeMethodInfoPtr_set_movementArea_Public_Virtual_Final_New_set_Void_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666328);
			PlayerMouse.NativeMethodInfoPtr_get_movementAreaUnit_Public_Virtual_Final_New_get_MovementAreaUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666329);
			PlayerMouse.NativeMethodInfoPtr_set_movementAreaUnit_Public_Virtual_Final_New_set_Void_MovementAreaUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666330);
			PlayerMouse.NativeMethodInfoPtr_get_screenPosition_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666331);
			PlayerMouse.NativeMethodInfoPtr_set_screenPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666332);
			PlayerMouse.NativeMethodInfoPtr_get_screenPositionPrev_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666333);
			PlayerMouse.NativeMethodInfoPtr_get_screenPositionDelta_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666334);
			PlayerMouse.NativeMethodInfoPtr_get_xAxis_Public_Virtual_Final_New_get_MouseAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666335);
			PlayerMouse.NativeMethodInfoPtr_get_yAxis_Public_Virtual_Final_New_get_MouseAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666336);
			PlayerMouse.NativeMethodInfoPtr_get_wheel_Public_Virtual_Final_New_get_MouseWheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666337);
			PlayerMouse.NativeMethodInfoPtr_get_leftButton_Public_Virtual_Final_New_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666338);
			PlayerMouse.NativeMethodInfoPtr_get_rightButton_Public_Virtual_Final_New_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666339);
			PlayerMouse.NativeMethodInfoPtr_get_middleButton_Public_Virtual_Final_New_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666340);
			PlayerMouse.NativeMethodInfoPtr_get_pointerSpeed_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666341);
			PlayerMouse.NativeMethodInfoPtr_set_pointerSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666342);
			PlayerMouse.NativeMethodInfoPtr_get_useHardwarePointerPosition_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666343);
			PlayerMouse.NativeMethodInfoPtr_set_useHardwarePointerPosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666344);
			PlayerMouse.NativeMethodInfoPtr_add_ScreenPositionChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666345);
			PlayerMouse.NativeMethodInfoPtr_remove_ScreenPositionChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666346);
			PlayerMouse.NativeMethodInfoPtr_Update_Protected_Virtual_Boolean_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666347);
			PlayerMouse.NativeMethodInfoPtr_UpdateFinished_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666348);
			PlayerMouse.NativeMethodInfoPtr_ClearVars_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666349);
			PlayerMouse.NativeMethodInfoPtr_nxmARXxiyVCiACMbutSFFXVGqeoM_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666350);
			PlayerMouse.NativeMethodInfoPtr_ZSJWqpMAhZKhPcARbvjFsgENuGo_Private_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666351);
			PlayerMouse.NativeMethodInfoPtr_NyvZgAZwDrcShDVMljFpPPBmtNX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666352);
			PlayerMouse.NativeMethodInfoPtr_aujGJBtqgdDKftuyIXMUhunPcdP_Private_Static_Single_Axis_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666353);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666354);
			PlayerMouse.NativeMethodInfoPtr_NrvxhgnjcDmjeIdQqgpndmCbjwif_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666355);
			PlayerMouse.NativeMethodInfoPtr_mphxJIfWAzWREMypyzmjIRAgXnl_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666356);
			PlayerMouse.NativeMethodInfoPtr_OQVCCOBKjGgchxHuRHIxRFtYhxhN_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666357);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666358);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666359);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666360);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666361);
			PlayerMouse.NativeMethodInfoPtr_lCXemqrZsgUhCfTWmorHVGADRQm_Private_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666362);
			PlayerMouse.NativeMethodInfoPtr_IrnxTVxqPjcTGlzgoFIbvuyffjY_Private_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100666363);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00070B14 File Offset: 0x0006ED14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261765, RefRangeEnd = 261768, XrefRangeStart = 261614, XrefRangeEnd = 261765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMouse(PlayerMouse.Definition definition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr__ctor_Private_Void_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00070B60 File Offset: 0x0006ED60
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x00070B9C File Offset: 0x0006ED9C
		public unsafe bool defaultToCenter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 261772, RefRangeEnd = 261775, XrefRangeStart = 261768, XrefRangeEnd = 261772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_defaultToCenter_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_defaultToCenter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00070BDC File Offset: 0x0006EDDC
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x00070C18 File Offset: 0x0006EE18
		public unsafe bool clampToMovementArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_clampToMovementArea_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_clampToMovementArea_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x00070C58 File Offset: 0x0006EE58
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x00070C94 File Offset: 0x0006EE94
		public unsafe ScreenRect movementArea
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 261782, RefRangeEnd = 261787, XrefRangeStart = 261775, XrefRangeEnd = 261782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_movementArea_Public_Virtual_Final_New_get_ScreenRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_movementArea_Public_Virtual_Final_New_set_Void_ScreenRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00070CD4 File Offset: 0x0006EED4
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x00070D10 File Offset: 0x0006EF10
		public unsafe PlayerMouse.MovementAreaUnit movementAreaUnit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 261791, RefRangeEnd = 261794, XrefRangeStart = 261787, XrefRangeEnd = 261791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_movementAreaUnit_Public_Virtual_Final_New_get_MovementAreaUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_movementAreaUnit_Public_Virtual_Final_New_set_Void_MovementAreaUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x00070D50 File Offset: 0x0006EF50
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x00070D8C File Offset: 0x0006EF8C
		public unsafe Vector2 screenPosition
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 261799, RefRangeEnd = 261803, XrefRangeStart = 261794, XrefRangeEnd = 261799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_screenPosition_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261803, XrefRangeEnd = 261804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_screenPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x00070DCC File Offset: 0x0006EFCC
		public unsafe Vector2 screenPositionPrev
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261804, XrefRangeEnd = 261809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_screenPositionPrev_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00070E08 File Offset: 0x0006F008
		public unsafe Vector2 screenPositionDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261809, XrefRangeEnd = 261814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_screenPositionDelta_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00070E44 File Offset: 0x0006F044
		public unsafe PlayerController.MouseAxis xAxis
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 261823, RefRangeEnd = 261825, XrefRangeStart = 261814, XrefRangeEnd = 261823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_xAxis_Public_Virtual_Final_New_get_MouseAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x00070E84 File Offset: 0x0006F084
		public unsafe PlayerController.MouseAxis yAxis
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 261834, RefRangeEnd = 261836, XrefRangeStart = 261825, XrefRangeEnd = 261834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_yAxis_Public_Virtual_Final_New_get_MouseAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x00070EC4 File Offset: 0x0006F0C4
		public unsafe PlayerController.MouseWheel wheel
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 261848, RefRangeEnd = 261854, XrefRangeStart = 261836, XrefRangeEnd = 261848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_wheel_Public_Virtual_Final_New_get_MouseWheel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseWheel>(intPtr3) : null;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x00070F04 File Offset: 0x0006F104
		public unsafe PlayerController.Button leftButton
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 261863, RefRangeEnd = 261866, XrefRangeStart = 261854, XrefRangeEnd = 261863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_leftButton_Public_Virtual_Final_New_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Button>(intPtr3) : null;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x00070F44 File Offset: 0x0006F144
		public unsafe PlayerController.Button rightButton
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 261875, RefRangeEnd = 261878, XrefRangeStart = 261866, XrefRangeEnd = 261875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_rightButton_Public_Virtual_Final_New_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Button>(intPtr3) : null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x00070F84 File Offset: 0x0006F184
		public unsafe PlayerController.Button middleButton
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 261887, RefRangeEnd = 261890, XrefRangeStart = 261878, XrefRangeEnd = 261887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_middleButton_Public_Virtual_Final_New_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Button>(intPtr3) : null;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x00070FC4 File Offset: 0x0006F1C4
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x00071000 File Offset: 0x0006F200
		public unsafe float pointerSpeed
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 261894, RefRangeEnd = 261897, XrefRangeStart = 261890, XrefRangeEnd = 261894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_pointerSpeed_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 261901, RefRangeEnd = 261904, XrefRangeStart = 261897, XrefRangeEnd = 261901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_pointerSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00071040 File Offset: 0x0006F240
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x0007107C File Offset: 0x0006F27C
		public unsafe bool useHardwarePointerPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261904, XrefRangeEnd = 261908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_useHardwarePointerPosition_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261908, XrefRangeEnd = 261915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_useHardwarePointerPosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000710BC File Offset: 0x0006F2BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261922, RefRangeEnd = 261925, XrefRangeStart = 261915, XrefRangeEnd = 261922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ScreenPositionChangedEvent(Action<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_add_ScreenPositionChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00071100 File Offset: 0x0006F300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261928, RefRangeEnd = 261931, XrefRangeStart = 261925, XrefRangeEnd = 261928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ScreenPositionChangedEvent(Action<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_remove_ScreenPositionChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00071144 File Offset: 0x0006F344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261931, XrefRangeEnd = 261965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Update_Protected_Virtual_Boolean_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00071190 File Offset: 0x0006F390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261965, XrefRangeEnd = 261975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_UpdateFinished_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000711C4 File Offset: 0x0006F3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261975, XrefRangeEnd = 261980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearVars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_ClearVars_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000711F8 File Offset: 0x0006F3F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 261980, RefRangeEnd = 261984, XrefRangeStart = 261980, XrefRangeEnd = 261980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void nxmARXxiyVCiACMbutSFFXVGqeoM(Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_nxmARXxiyVCiACMbutSFFXVGqeoM_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00071238 File Offset: 0x0006F438
		[CallerCount(0)]
		public unsafe ScreenRect ZSJWqpMAhZKhPcARbvjFsgENuGo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_ZSJWqpMAhZKhPcARbvjFsgENuGo_Private_ScreenRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00071274 File Offset: 0x0006F474
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 261988, RefRangeEnd = 261993, XrefRangeStart = 261984, XrefRangeEnd = 261988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NyvZgAZwDrcShDVMljFpPPBmtNX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_NyvZgAZwDrcShDVMljFpPPBmtNX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000712A8 File Offset: 0x0006F4A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261993, RefRangeEnd = 261995, XrefRangeStart = 261993, XrefRangeEnd = 261993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float aujGJBtqgdDKftuyIXMUhunPcdP(PlayerController.Axis A_0, float A_1, float A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_aujGJBtqgdDKftuyIXMUhunPcdP_Private_Static_Single_Axis_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00071308 File Offset: 0x0006F508
		public unsafe bool Rewired.UI.IMouseInputSource.enabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261995, XrefRangeEnd = 261996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00071344 File Offset: 0x0006F544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261996, XrefRangeEnd = 261997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NrvxhgnjcDmjeIdQqgpndmCbjwif(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_NrvxhgnjcDmjeIdQqgpndmCbjwif_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00071390 File Offset: 0x0006F590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261997, XrefRangeEnd = 261998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool mphxJIfWAzWREMypyzmjIRAgXnl(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_mphxJIfWAzWREMypyzmjIRAgXnl_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000713DC File Offset: 0x0006F5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261998, XrefRangeEnd = 261999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OQVCCOBKjGgchxHuRHIxRFtYhxhN(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_OQVCCOBKjGgchxHuRHIxRFtYhxhN_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x00071428 File Offset: 0x0006F628
		public unsafe Vector2 Rewired.UI.IMouseInputSource.screenPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00071464 File Offset: 0x0006F664
		public unsafe Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x000714A0 File Offset: 0x0006F6A0
		public unsafe Vector2 Rewired.UI.IMouseInputSource.wheelDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261999, XrefRangeEnd = 262003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x000714DC File Offset: 0x0006F6DC
		public unsafe bool Rewired.UI.IMouseInputSource.locked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00071518 File Offset: 0x0006F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262003, XrefRangeEnd = 262010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool lCXemqrZsgUhCfTWmorHVGADRQm(PlayerController.Axis A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_lCXemqrZsgUhCfTWmorHVGADRQm_Private_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0007155C File Offset: 0x0006F75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262010, XrefRangeEnd = 262017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IrnxTVxqPjcTGlzgoFIbvuyffjY(PlayerController.Axis A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_IrnxTVxqPjcTGlzgoFIbvuyffjY_Private_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00007EDC File Offset: 0x000060DC
		public PlayerMouse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x000715A0 File Offset: 0x0006F7A0
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x00007EE5 File Offset: 0x000060E5
		public unsafe static bool mOklQgiztlGoJeMUbFrySXqlUpe
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_mOklQgiztlGoJeMUbFrySXqlUpe, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_mOklQgiztlGoJeMUbFrySXqlUpe, (void*)(&value));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x000715BC File Offset: 0x0006F7BC
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x00007EF3 File Offset: 0x000060F3
		public unsafe static float IJVKGuRlcJiBZuNmiwOwrDpdRhO
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_IJVKGuRlcJiBZuNmiwOwrDpdRhO, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_IJVKGuRlcJiBZuNmiwOwrDpdRhO, (void*)(&value));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x000715D8 File Offset: 0x0006F7D8
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x00007F01 File Offset: 0x00006101
		public unsafe static bool XwsImLqEGBYnTZRMvuAmOREkUst
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_XwsImLqEGBYnTZRMvuAmOREkUst, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_XwsImLqEGBYnTZRMvuAmOREkUst, (void*)(&value));
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000715F4 File Offset: 0x0006F7F4
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x00007F0F File Offset: 0x0000610F
		public unsafe static bool GBbQxFaHmYtwjBVxddgUVJVGGql
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_GBbQxFaHmYtwjBVxddgUVJVGGql, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_GBbQxFaHmYtwjBVxddgUVJVGGql, (void*)(&value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00071610 File Offset: 0x0006F810
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x00007F1D File Offset: 0x0000611D
		public unsafe static PlayerMouse.MovementAreaUnit rZghqedXRnbVhWiZdAqZjBplhrob
		{
			get
			{
				PlayerMouse.MovementAreaUnit movementAreaUnit;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_rZghqedXRnbVhWiZdAqZjBplhrob, (void*)(&movementAreaUnit));
				return movementAreaUnit;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_rZghqedXRnbVhWiZdAqZjBplhrob, (void*)(&value));
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x0007162C File Offset: 0x0006F82C
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x00007F2B File Offset: 0x0000612B
		public unsafe static int QmnDWzFRKGgKtCSDMTZSDdMHKzK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_QmnDWzFRKGgKtCSDMTZSDdMHKzK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_QmnDWzFRKGgKtCSDMTZSDdMHKzK, (void*)(&value));
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00071648 File Offset: 0x0006F848
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x00007F39 File Offset: 0x00006139
		public unsafe static int SXCxuGjAaTnVocptTaBRRQrndtwC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_SXCxuGjAaTnVocptTaBRRQrndtwC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_SXCxuGjAaTnVocptTaBRRQrndtwC, (void*)(&value));
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00071664 File Offset: 0x0006F864
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x00007F47 File Offset: 0x00006147
		public unsafe static string GzRgsaIepOhzpOjYLbstFiPKEVbH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_GzRgsaIepOhzpOjYLbstFiPKEVbH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_GzRgsaIepOhzpOjYLbstFiPKEVbH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00071684 File Offset: 0x0006F884
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x00007F59 File Offset: 0x00006159
		public unsafe static string xQkVHowYTpkviBYHaMHZXTeTtqZ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_xQkVHowYTpkviBYHaMHZXTeTtqZ, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_xQkVHowYTpkviBYHaMHZXTeTtqZ, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x000716A4 File Offset: 0x0006F8A4
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x00007F6B File Offset: 0x0000616B
		public unsafe static string UGFNwzeMxgKkLUulqeOjTMFnDQla
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_UGFNwzeMxgKkLUulqeOjTMFnDQla, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_UGFNwzeMxgKkLUulqeOjTMFnDQla, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x000716C4 File Offset: 0x0006F8C4
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x00007F7D File Offset: 0x0000617D
		public unsafe static string WiSbizWoNsOKeKaJeGRGCNgtktq
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_WiSbizWoNsOKeKaJeGRGCNgtktq, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_WiSbizWoNsOKeKaJeGRGCNgtktq, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x000716E4 File Offset: 0x0006F8E4
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x00007F8F File Offset: 0x0000618F
		public unsafe static string nzgkDNdbwsFohCGIwpAeqkqkIcDL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_nzgkDNdbwsFohCGIwpAeqkqkIcDL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_nzgkDNdbwsFohCGIwpAeqkqkIcDL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00071704 File Offset: 0x0006F904
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x00007FA1 File Offset: 0x000061A1
		public unsafe static string wBRKCSjqIRhWbnDRMxInvRbHcGZ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_wBRKCSjqIRhWbnDRMxInvRbHcGZ, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_wBRKCSjqIRhWbnDRMxInvRbHcGZ, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00071724 File Offset: 0x0006F924
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x00007FB3 File Offset: 0x000061B3
		public unsafe static string zeBtwqoLTchNaogLtTUpZZARUoZ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_zeBtwqoLTchNaogLtTUpZZARUoZ, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_zeBtwqoLTchNaogLtTUpZZARUoZ, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00071744 File Offset: 0x0006F944
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x00007FC5 File Offset: 0x000061C5
		public unsafe static string aUJlrhtNVbhnbprSYBKdajTMXTkF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_aUJlrhtNVbhnbprSYBKdajTMXTkF, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_aUJlrhtNVbhnbprSYBKdajTMXTkF, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00071764 File Offset: 0x0006F964
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x00007FD7 File Offset: 0x000061D7
		public unsafe static string ItOEENaSWcaHqzWRZqijiIKRgfJ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_ItOEENaSWcaHqzWRZqijiIKRgfJ, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_ItOEENaSWcaHqzWRZqijiIKRgfJ, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00071784 File Offset: 0x0006F984
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00007FE9 File Offset: 0x000061E9
		public unsafe static ScreenRect rDIGuFpvGqnFrZnSbhWVaPKWlYL
		{
			get
			{
				ScreenRect screenRect;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_rDIGuFpvGqnFrZnSbhWVaPKWlYL, (void*)(&screenRect));
				return screenRect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_rDIGuFpvGqnFrZnSbhWVaPKWlYL, (void*)(&value));
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x000717A0 File Offset: 0x0006F9A0
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x00007FF7 File Offset: 0x000061F7
		public unsafe int rUhbMOkKNrywbbyYRdFDSKHADiqD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_rUhbMOkKNrywbbyYRdFDSKHADiqD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_rUhbMOkKNrywbbyYRdFDSKHADiqD)) = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x000717C8 File Offset: 0x0006F9C8
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00008012 File Offset: 0x00006212
		public unsafe int RHPDYrHkMFtoKPdyxokfeZpmSQSb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_RHPDYrHkMFtoKPdyxokfeZpmSQSb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_RHPDYrHkMFtoKPdyxokfeZpmSQSb)) = value;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x000717F0 File Offset: 0x0006F9F0
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x0000802D File Offset: 0x0000622D
		public unsafe int zSgAbPznnhkoFgltldjpjszOzccK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_zSgAbPznnhkoFgltldjpjszOzccK);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_zSgAbPznnhkoFgltldjpjszOzccK)) = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00071818 File Offset: 0x0006FA18
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x00008048 File Offset: 0x00006248
		public unsafe int fHpbqKukJTTCmUEceNpHhbjzXPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_fHpbqKukJTTCmUEceNpHhbjzXPC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_fHpbqKukJTTCmUEceNpHhbjzXPC)) = value;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00071840 File Offset: 0x0006FA40
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x00008063 File Offset: 0x00006263
		public unsafe int BIsdqvFaobocronFAESpUCJAqpB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_BIsdqvFaobocronFAESpUCJAqpB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_BIsdqvFaobocronFAESpUCJAqpB)) = value;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00071868 File Offset: 0x0006FA68
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x0000807E File Offset: 0x0000627E
		public unsafe int MjiOsObFGTDAuHfjVtpWIEBgccxZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_MjiOsObFGTDAuHfjVtpWIEBgccxZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_MjiOsObFGTDAuHfjVtpWIEBgccxZ)) = value;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00071890 File Offset: 0x0006FA90
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x00008099 File Offset: 0x00006299
		public unsafe bool tWYdZprZIzPVifjBvzWiFilyrOI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_tWYdZprZIzPVifjBvzWiFilyrOI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_tWYdZprZIzPVifjBvzWiFilyrOI)) = value;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x000718B8 File Offset: 0x0006FAB8
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x000080B4 File Offset: 0x000062B4
		public unsafe Vector2 eBsvthmvzhrmSYctTIlMUwxPmus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_eBsvthmvzhrmSYctTIlMUwxPmus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_eBsvthmvzhrmSYctTIlMUwxPmus)) = value;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x000718E0 File Offset: 0x0006FAE0
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x000080CF File Offset: 0x000062CF
		public unsafe Vector2 rSahUNXbVmzhornLxdrsDXBcrdIU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_rSahUNXbVmzhornLxdrsDXBcrdIU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_rSahUNXbVmzhornLxdrsDXBcrdIU)) = value;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00071908 File Offset: 0x0006FB08
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x000080EA File Offset: 0x000062EA
		public unsafe Vector2 TfsoZYHQMdqdtFlHDBsyoghCqsZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_TfsoZYHQMdqdtFlHDBsyoghCqsZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_TfsoZYHQMdqdtFlHDBsyoghCqsZ)) = value;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00071930 File Offset: 0x0006FB30
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x00008105 File Offset: 0x00006305
		public unsafe Vector2 ZIlfCsNrPtiQHtguiwXkAMscvmr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_ZIlfCsNrPtiQHtguiwXkAMscvmr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_ZIlfCsNrPtiQHtguiwXkAMscvmr)) = value;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00071958 File Offset: 0x0006FB58
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x00008120 File Offset: 0x00006320
		public unsafe Vector2 OaxbtQqRzViukFlqDFuXlEGlUTb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_OaxbtQqRzViukFlqDFuXlEGlUTb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_OaxbtQqRzViukFlqDFuXlEGlUTb)) = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00071980 File Offset: 0x0006FB80
		// (set) Token: 0x0600125B RID: 4699 RVA: 0x0000813B File Offset: 0x0000633B
		public unsafe float GHCuoIKcIIbOrjxNJZwujCAIIah
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_GHCuoIKcIIbOrjxNJZwujCAIIah);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_GHCuoIKcIIbOrjxNJZwujCAIIah)) = value;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x000719A8 File Offset: 0x0006FBA8
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x00008156 File Offset: 0x00006356
		public unsafe bool FFWukBItqFdxHqMyiAANmCHfcrTc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_FFWukBItqFdxHqMyiAANmCHfcrTc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_FFWukBItqFdxHqMyiAANmCHfcrTc)) = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x000719D0 File Offset: 0x0006FBD0
		// (set) Token: 0x0600125F RID: 4703 RVA: 0x00008171 File Offset: 0x00006371
		public unsafe Action<Vector2> nkqXIVFRbFiyxBPfKjcCbhACIdqI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_nkqXIVFRbFiyxBPfKjcCbhACIdqI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_nkqXIVFRbFiyxBPfKjcCbhACIdqI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00071A00 File Offset: 0x0006FC00
		// (set) Token: 0x06001261 RID: 4705 RVA: 0x00008190 File Offset: 0x00006390
		public unsafe bool mFdJqmIjDwIRbyWDEOpUGoWQlxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_mFdJqmIjDwIRbyWDEOpUGoWQlxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_mFdJqmIjDwIRbyWDEOpUGoWQlxy)) = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00071A28 File Offset: 0x0006FC28
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x000081AB File Offset: 0x000063AB
		public unsafe ScreenRect rFbcjuqPRnGuKNbwXnbUttwpFpk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_rFbcjuqPRnGuKNbwXnbUttwpFpk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_rFbcjuqPRnGuKNbwXnbUttwpFpk)) = value;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00071A50 File Offset: 0x0006FC50
		// (set) Token: 0x06001265 RID: 4709 RVA: 0x000081C6 File Offset: 0x000063C6
		public unsafe bool tqeCPBgZAtqKymKrnchZAZElVRrm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_tqeCPBgZAtqKymKrnchZAZElVRrm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_tqeCPBgZAtqKymKrnchZAZElVRrm)) = value;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00071A78 File Offset: 0x0006FC78
		// (set) Token: 0x06001267 RID: 4711 RVA: 0x000081E1 File Offset: 0x000063E1
		public unsafe PlayerMouse.MovementAreaUnit OiFKhQdCNESZSaOAvYrYSTuQenH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_OiFKhQdCNESZSaOAvYrYSTuQenH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr_OiFKhQdCNESZSaOAvYrYSTuQenH)) = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00071AA0 File Offset: 0x0006FCA0
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x000081FC File Offset: 0x000063FC
		public unsafe static Predicate<PlayerController.Axis> YtejDiqaLAxxRnmscggDavQFcLz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<PlayerController.Axis>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00071AC8 File Offset: 0x0006FCC8
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x0000820E File Offset: 0x0000640E
		public unsafe static Predicate<PlayerController.Axis> ikzytTXFFDqNPkVCCmeRclgjukz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMouse.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<PlayerController.Axis>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMouse.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeFieldInfoPtr_mOklQgiztlGoJeMUbFrySXqlUpe;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeFieldInfoPtr_IJVKGuRlcJiBZuNmiwOwrDpdRhO;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeFieldInfoPtr_XwsImLqEGBYnTZRMvuAmOREkUst;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeFieldInfoPtr_GBbQxFaHmYtwjBVxddgUVJVGGql;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeFieldInfoPtr_rZghqedXRnbVhWiZdAqZjBplhrob;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeFieldInfoPtr_QmnDWzFRKGgKtCSDMTZSDdMHKzK;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeFieldInfoPtr_SXCxuGjAaTnVocptTaBRRQrndtwC;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr_GzRgsaIepOhzpOjYLbstFiPKEVbH;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeFieldInfoPtr_xQkVHowYTpkviBYHaMHZXTeTtqZ;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeFieldInfoPtr_UGFNwzeMxgKkLUulqeOjTMFnDQla;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeFieldInfoPtr_WiSbizWoNsOKeKaJeGRGCNgtktq;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeFieldInfoPtr_nzgkDNdbwsFohCGIwpAeqkqkIcDL;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeFieldInfoPtr_wBRKCSjqIRhWbnDRMxInvRbHcGZ;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeFieldInfoPtr_zeBtwqoLTchNaogLtTUpZZARUoZ;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr_aUJlrhtNVbhnbprSYBKdajTMXTkF;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr_ItOEENaSWcaHqzWRZqijiIKRgfJ;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr_rDIGuFpvGqnFrZnSbhWVaPKWlYL;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeFieldInfoPtr_rUhbMOkKNrywbbyYRdFDSKHADiqD;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeFieldInfoPtr_RHPDYrHkMFtoKPdyxokfeZpmSQSb;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeFieldInfoPtr_zSgAbPznnhkoFgltldjpjszOzccK;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeFieldInfoPtr_fHpbqKukJTTCmUEceNpHhbjzXPC;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeFieldInfoPtr_BIsdqvFaobocronFAESpUCJAqpB;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeFieldInfoPtr_MjiOsObFGTDAuHfjVtpWIEBgccxZ;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeFieldInfoPtr_tWYdZprZIzPVifjBvzWiFilyrOI;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeFieldInfoPtr_eBsvthmvzhrmSYctTIlMUwxPmus;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeFieldInfoPtr_rSahUNXbVmzhornLxdrsDXBcrdIU;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeFieldInfoPtr_TfsoZYHQMdqdtFlHDBsyoghCqsZ;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeFieldInfoPtr_ZIlfCsNrPtiQHtguiwXkAMscvmr;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeFieldInfoPtr_OaxbtQqRzViukFlqDFuXlEGlUTb;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeFieldInfoPtr_GHCuoIKcIIbOrjxNJZwujCAIIah;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeFieldInfoPtr_FFWukBItqFdxHqMyiAANmCHfcrTc;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeFieldInfoPtr_nkqXIVFRbFiyxBPfKjcCbhACIdqI;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeFieldInfoPtr_mFdJqmIjDwIRbyWDEOpUGoWQlxy;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeFieldInfoPtr_rFbcjuqPRnGuKNbwXnbUttwpFpk;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeFieldInfoPtr_tqeCPBgZAtqKymKrnchZAZElVRrm;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeFieldInfoPtr_OiFKhQdCNESZSaOAvYrYSTuQenH;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Definition_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultToCenter_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultToCenter_Public_set_Void_Boolean_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_get_clampToMovementArea_Public_get_Boolean_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_set_clampToMovementArea_Public_set_Void_Boolean_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_get_movementArea_Public_Virtual_Final_New_get_ScreenRect_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_set_movementArea_Public_Virtual_Final_New_set_Void_ScreenRect_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_get_movementAreaUnit_Public_Virtual_Final_New_get_MovementAreaUnit_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_set_movementAreaUnit_Public_Virtual_Final_New_set_Void_MovementAreaUnit_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPosition_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_set_screenPosition_Public_set_Void_Vector2_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPositionPrev_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPositionDelta_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_Virtual_Final_New_get_MouseAxis_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_Virtual_Final_New_get_MouseAxis_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_get_wheel_Public_Virtual_Final_New_get_MouseWheel_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_get_leftButton_Public_Virtual_Final_New_get_Button_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_get_rightButton_Public_Virtual_Final_New_get_Button_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_get_middleButton_Public_Virtual_Final_New_get_Button_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerSpeed_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerSpeed_Public_set_Void_Single_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_get_useHardwarePointerPosition_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_set_useHardwarePointerPosition_Public_set_Void_Boolean_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_add_ScreenPositionChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Vector2_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_remove_ScreenPositionChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Vector2_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Boolean_UpdateLoopType_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFinished_Protected_Virtual_Void_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_ClearVars_Protected_Virtual_Void_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_nxmARXxiyVCiACMbutSFFXVGqeoM_Private_Void_Vector2_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_ZSJWqpMAhZKhPcARbvjFsgENuGo_Private_ScreenRect_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_NyvZgAZwDrcShDVMljFpPPBmtNX_Private_Void_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_aujGJBtqgdDKftuyIXMUhunPcdP_Private_Static_Single_Axis_Single_Single_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_NrvxhgnjcDmjeIdQqgpndmCbjwif_Private_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_mphxJIfWAzWREMypyzmjIRAgXnl_Private_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_OQVCCOBKjGgchxHuRHIxRFtYhxhN_Private_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_lCXemqrZsgUhCfTWmorHVGADRQm_Private_Static_Boolean_Axis_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_IrnxTVxqPjcTGlzgoFIbvuyffjY_Private_Static_Boolean_Axis_0;

		// Token: 0x020002AE RID: 686
		public new sealed class Definition : PlayerController.Definition
		{
			// Token: 0x06003CE1 RID: 15585 RVA: 0x00123744 File Offset: 0x00121944
			// Note: this type is marked as 'beforefieldinit'.
			static Definition()
			{
				Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "Definition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr);
				PlayerMouse.Definition.NativeFieldInfoPtr_defaultToCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr, "defaultToCenter");
				PlayerMouse.Definition.NativeFieldInfoPtr_clampToMovementArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr, "clampToMovementArea");
				PlayerMouse.Definition.NativeFieldInfoPtr_movementArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr, "movementArea");
				PlayerMouse.Definition.NativeFieldInfoPtr_movementAreaUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr, "movementAreaUnit");
				PlayerMouse.Definition.NativeFieldInfoPtr_pointerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr, "pointerSpeed");
				PlayerMouse.Definition.NativeFieldInfoPtr_useHardwarePointerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr, "useHardwarePointerPosition");
				PlayerMouse.Definition.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr, 100666365);
			}

			// Token: 0x06003CE2 RID: 15586 RVA: 0x001237FC File Offset: 0x001219FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 261524, RefRangeEnd = 261525, XrefRangeStart = 261520, XrefRangeEnd = 261524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Definition()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMouse.Definition>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.Definition.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CE3 RID: 15587 RVA: 0x00015940 File Offset: 0x00013B40
			public Definition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700129C RID: 4764
			// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x00123838 File Offset: 0x00121A38
			// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x00015949 File Offset: 0x00013B49
			public unsafe bool defaultToCenter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_defaultToCenter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_defaultToCenter)) = value;
				}
			}

			// Token: 0x1700129D RID: 4765
			// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x00123860 File Offset: 0x00121A60
			// (set) Token: 0x06003CE7 RID: 15591 RVA: 0x00015964 File Offset: 0x00013B64
			public unsafe bool clampToMovementArea
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_clampToMovementArea);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_clampToMovementArea)) = value;
				}
			}

			// Token: 0x1700129E RID: 4766
			// (get) Token: 0x06003CE8 RID: 15592 RVA: 0x00123888 File Offset: 0x00121A88
			// (set) Token: 0x06003CE9 RID: 15593 RVA: 0x0001597F File Offset: 0x00013B7F
			public unsafe ScreenRect movementArea
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_movementArea);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_movementArea)) = value;
				}
			}

			// Token: 0x1700129F RID: 4767
			// (get) Token: 0x06003CEA RID: 15594 RVA: 0x001238B0 File Offset: 0x00121AB0
			// (set) Token: 0x06003CEB RID: 15595 RVA: 0x0001599A File Offset: 0x00013B9A
			public unsafe PlayerMouse.MovementAreaUnit movementAreaUnit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_movementAreaUnit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_movementAreaUnit)) = value;
				}
			}

			// Token: 0x170012A0 RID: 4768
			// (get) Token: 0x06003CEC RID: 15596 RVA: 0x001238D8 File Offset: 0x00121AD8
			// (set) Token: 0x06003CED RID: 15597 RVA: 0x000159B5 File Offset: 0x00013BB5
			public unsafe float pointerSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_pointerSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_pointerSpeed)) = value;
				}
			}

			// Token: 0x170012A1 RID: 4769
			// (get) Token: 0x06003CEE RID: 15598 RVA: 0x00123900 File Offset: 0x00121B00
			// (set) Token: 0x06003CEF RID: 15599 RVA: 0x000159D0 File Offset: 0x00013BD0
			public unsafe bool useHardwarePointerPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_useHardwarePointerPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.Definition.NativeFieldInfoPtr_useHardwarePointerPosition)) = value;
				}
			}

			// Token: 0x040032BB RID: 12987
			private static readonly IntPtr NativeFieldInfoPtr_defaultToCenter;

			// Token: 0x040032BC RID: 12988
			private static readonly IntPtr NativeFieldInfoPtr_clampToMovementArea;

			// Token: 0x040032BD RID: 12989
			private static readonly IntPtr NativeFieldInfoPtr_movementArea;

			// Token: 0x040032BE RID: 12990
			private static readonly IntPtr NativeFieldInfoPtr_movementAreaUnit;

			// Token: 0x040032BF RID: 12991
			private static readonly IntPtr NativeFieldInfoPtr_pointerSpeed;

			// Token: 0x040032C0 RID: 12992
			private static readonly IntPtr NativeFieldInfoPtr_useHardwarePointerPosition;

			// Token: 0x040032C1 RID: 12993
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
		}

		// Token: 0x020002AF RID: 687
		public new static class Factory : global::Il2CppSystem.Object
		{
			// Token: 0x06003CF0 RID: 15600 RVA: 0x00123928 File Offset: 0x00121B28
			// Note: this type is marked as 'beforefieldinit'.
			static Factory()
			{
				Il2CppClassPointerStore<PlayerMouse.Factory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "Factory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMouse.Factory>.NativeClassPtr);
				PlayerMouse.Factory.NativeMethodInfoPtr_Create_Public_Static_PlayerMouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse.Factory>.NativeClassPtr, 100666366);
				PlayerMouse.Factory.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Private_Static_PlayerMouse_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse.Factory>.NativeClassPtr, 100666367);
				PlayerMouse.Factory.NativeMethodInfoPtr_Create_Public_Static_PlayerMouse_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse.Factory>.NativeClassPtr, 100666368);
			}

			// Token: 0x06003CF1 RID: 15601 RVA: 0x00123990 File Offset: 0x00121B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261525, XrefRangeEnd = 261526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PlayerMouse Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.Factory.NativeMethodInfoPtr_Create_Public_Static_PlayerMouse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerMouse>(intPtr3) : null;
			}

			// Token: 0x06003CF2 RID: 15602 RVA: 0x001239C4 File Offset: 0x00121BC4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 261608, RefRangeEnd = 261610, XrefRangeStart = 261526, XrefRangeEnd = 261608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PlayerMouse dSubCKSikOaufAaxCnPWeKqiPeHk(int A_0, int A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.Factory.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Private_Static_PlayerMouse_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerMouse>(intPtr3) : null;
			}

			// Token: 0x06003CF3 RID: 15603 RVA: 0x00123A14 File Offset: 0x00121C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261610, XrefRangeEnd = 261614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PlayerMouse Create(PlayerMouse.Definition definition)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.Factory.NativeMethodInfoPtr_Create_Public_Static_PlayerMouse_Definition_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerMouse>(intPtr3) : null;
				}
			}

			// Token: 0x06003CF4 RID: 15604 RVA: 0x000159EB File Offset: 0x00013BEB
			public Factory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040032C2 RID: 12994
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayerMouse_0;

			// Token: 0x040032C3 RID: 12995
			private static readonly IntPtr NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Private_Static_PlayerMouse_Int32_Int32_0;

			// Token: 0x040032C4 RID: 12996
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayerMouse_Definition_0;
		}

		// Token: 0x020002B0 RID: 688
		[OriginalName("Rewired_Core.dll", "", "MovementAreaUnit")]
		public enum MovementAreaUnit
		{
			// Token: 0x040032C6 RID: 12998
			Screen,
			// Token: 0x040032C7 RID: 12999
			Pixel
		}
	}
}
