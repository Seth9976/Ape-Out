using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001F2 RID: 498
	public class MathTools : global::Il2CppSystem.Object
	{
		// Token: 0x06003263 RID: 12899 RVA: 0x000FB16C File Offset: 0x000F936C
		// Note: this type is marked as 'beforefieldinit'.
		static MathTools()
		{
			Il2CppClassPointerStore<MathTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "MathTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathTools>.NativeClassPtr);
			MathTools.NativeFieldInfoPtr_vTzJgiPQEAcacgyNTOXjqPgyJTf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathTools>.NativeClassPtr, "vTzJgiPQEAcacgyNTOXjqPgyJTf");
			MathTools.NativeFieldInfoPtr_OuDydHOvnMQdeNgIaWbOgATYhZF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathTools>.NativeClassPtr, "OuDydHOvnMQdeNgIaWbOgATYhZF");
			MathTools.NativeFieldInfoPtr_bXlGHHFgXYnpWoiaRSteAFrCDyVa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathTools>.NativeClassPtr, "bXlGHHFgXYnpWoiaRSteAFrCDyVa");
			MathTools.NativeFieldInfoPtr_PI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathTools>.NativeClassPtr, "PI");
			MathTools.NativeFieldInfoPtr_Infinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathTools>.NativeClassPtr, "Infinity");
			MathTools.NativeFieldInfoPtr_NegativeInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathTools>.NativeClassPtr, "NegativeInfinity");
			MathTools.NativeFieldInfoPtr_Deg2Rad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathTools>.NativeClassPtr, "Deg2Rad");
			MathTools.NativeFieldInfoPtr_Rad2Deg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathTools>.NativeClassPtr, "Rad2Deg");
			MathTools.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathTools>.NativeClassPtr, "Epsilon");
			MathTools.NativeMethodInfoPtr_Abs_Public_Static_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676031);
			MathTools.NativeMethodInfoPtr_Abs_Public_Static_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676032);
			MathTools.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676033);
			MathTools.NativeMethodInfoPtr_Abs_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676034);
			MathTools.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676035);
			MathTools.NativeMethodInfoPtr_Abs_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676036);
			MathTools.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676037);
			MathTools.NativeMethodInfoPtr_ApproximatelyZero_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676038);
			MathTools.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676039);
			MathTools.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676040);
			MathTools.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676041);
			MathTools.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676042);
			MathTools.NativeMethodInfoPtr_IsExactlyEqual_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676043);
			MathTools.NativeMethodInfoPtr_IsExactlyEqual_Public_Static_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676044);
			MathTools.NativeMethodInfoPtr_IsNear_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676045);
			MathTools.NativeMethodInfoPtr_IsNear_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676046);
			MathTools.NativeMethodInfoPtr_IsNearZero_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676047);
			MathTools.NativeMethodInfoPtr_IsNearZero_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676048);
			MathTools.NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676049);
			MathTools.NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676050);
			MathTools.NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676051);
			MathTools.NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_byref_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676052);
			MathTools.NativeMethodInfoPtr_RoundOffIfNearWholeNumber_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676053);
			MathTools.NativeMethodInfoPtr_RoundOffIfNearWholeNumber_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676054);
			MathTools.NativeMethodInfoPtr_IsEven_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676055);
			MathTools.NativeMethodInfoPtr_ValueInNewRange_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676056);
			MathTools.NativeMethodInfoPtr_ValueInNewRange_Public_Static_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676057);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676058);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676059);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676060);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676061);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676062);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676063);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676064);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676065);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676066);
			MathTools.NativeMethodInfoPtr_Max_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676067);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676068);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676069);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676070);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676071);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676072);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676073);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676074);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676075);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676076);
			MathTools.NativeMethodInfoPtr_Min_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676077);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676078);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676079);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676080);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676081);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676082);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676083);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676084);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676085);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676086);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676087);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676088);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676089);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676090);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676091);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676092);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676093);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676094);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676095);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676096);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676097);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676098);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676099);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676100);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676101);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676102);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676103);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676104);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676105);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676106);
			MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676107);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676108);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676109);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676110);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676111);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676112);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676113);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676114);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676115);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676116);
			MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676117);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676118);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_SByte_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676119);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Int16_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676120);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_UInt16_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676121);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676122);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676123);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Int64_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676124);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676125);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676126);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676127);
			MathTools.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676128);
			MathTools.NativeMethodInfoPtr_ClampAngle360_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676129);
			MathTools.NativeMethodInfoPtr_ReverseAngleRotationDirection_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676130);
			MathTools.NativeMethodInfoPtr_AngleIsNear_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676131);
			MathTools.NativeMethodInfoPtr_AngleIsBetween_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676132);
			MathTools.NativeMethodInfoPtr_mdZphWzimSDchgqQNIWvKpBviCl_Internal_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676133);
			MathTools.NativeMethodInfoPtr_IntPow_Public_Static_Int32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676134);
			MathTools.NativeMethodInfoPtr_RoundUpToPowerOf2_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676135);
			MathTools.NativeMethodInfoPtr_BooleanToSign_Public_Static_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676136);
			MathTools.NativeMethodInfoPtr_SignToBoolean_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676137);
			MathTools.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676138);
			MathTools.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676139);
			MathTools.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676140);
			MathTools.NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676141);
			MathTools.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676142);
			MathTools.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676143);
			MathTools.NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676144);
			MathTools.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676145);
			MathTools.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676146);
			MathTools.NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676147);
			MathTools.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676148);
			MathTools.NativeMethodInfoPtr_Log_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676149);
			MathTools.NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676150);
			MathTools.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676151);
			MathTools.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676152);
			MathTools.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676153);
			MathTools.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676154);
			MathTools.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676155);
			MathTools.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676156);
			MathTools.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676157);
			MathTools.NativeMethodInfoPtr_Sign_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676158);
			MathTools.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676159);
			MathTools.NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676160);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676161);
			MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676162);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676163);
			MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676164);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676165);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676166);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676167);
			MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676168);
			MathTools.NativeMethodInfoPtr_Cross_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676169);
			MathTools.NativeMethodInfoPtr_Multiply_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676170);
			MathTools.NativeMethodInfoPtr_RectContains_Public_Static_Boolean_Rect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676171);
			MathTools.NativeMethodInfoPtr_RotateWorldPoint_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676172);
			MathTools.NativeMethodInfoPtr_RotateLocalPoint_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676173);
			MathTools.NativeMethodInfoPtr_LineIntersectsRect_Public_Static_Boolean_Vector2_Vector2_Rect_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676174);
			MathTools.NativeMethodInfoPtr_LineSegementsIntersect_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676175);
			MathTools.NativeMethodInfoPtr_NVeFPCCqgxINaIxTHNpRVWZSTtwL_Private_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676176);
			MathTools.NativeMethodInfoPtr_RectContains_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676177);
			MathTools.NativeMethodInfoPtr_GetOffsetToContainRect_Public_Static_Boolean_Rect_Rect_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676178);
			MathTools.NativeMethodInfoPtr_TransformTo_Public_Static_Matrix4x4_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676179);
			MathTools.NativeMethodInfoPtr_TransformRect_Public_Static_Rect_Rect_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676180);
			MathTools.NativeMethodInfoPtr_SnapVectorToNearestAngle_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676181);
			MathTools.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676182);
			MathTools.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathTools>.NativeClassPtr, 100676183);
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x000FBE44 File Offset: 0x000FA044
		[CallerCount(0)]
		public unsafe static sbyte Abs(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Abs_Public_Static_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000FBE84 File Offset: 0x000FA084
		[CallerCount(0)]
		public unsafe static short Abs(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Abs_Public_Static_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x000FBEC4 File Offset: 0x000FA0C4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 338253, RefRangeEnd = 338264, XrefRangeStart = 338253, XrefRangeEnd = 338253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Abs(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000FBF04 File Offset: 0x000FA104
		[CallerCount(0)]
		public unsafe static long Abs(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Abs_Public_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x000FBF44 File Offset: 0x000FA144
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 338264, RefRangeEnd = 338322, XrefRangeStart = 338264, XrefRangeEnd = 338264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Abs(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x000FBF84 File Offset: 0x000FA184
		[CallerCount(0)]
		public unsafe static double Abs(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Abs_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x000FBFC4 File Offset: 0x000FA1C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 338322, RefRangeEnd = 338327, XrefRangeStart = 338322, XrefRangeEnd = 338322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x000FC010 File Offset: 0x000FA210
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 338327, RefRangeEnd = 338334, XrefRangeStart = 338327, XrefRangeEnd = 338327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ApproximatelyZero(float a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_ApproximatelyZero_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x000FC050 File Offset: 0x000FA250
		[CallerCount(0)]
		public unsafe static bool IsZero(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x000FC090 File Offset: 0x000FA290
		[CallerCount(0)]
		public unsafe static bool IsZero(float value, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x000FC0DC File Offset: 0x000FA2DC
		[CallerCount(0)]
		public unsafe static bool IsZero(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x000FC11C File Offset: 0x000FA31C
		[CallerCount(0)]
		public unsafe static bool IsZero(double value, double threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x000FC168 File Offset: 0x000FA368
		[CallerCount(0)]
		public unsafe static bool IsExactlyEqual(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsExactlyEqual_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x000FC1B4 File Offset: 0x000FA3B4
		[CallerCount(0)]
		public unsafe static bool IsExactlyEqual(double a, double b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsExactlyEqual_Public_Static_Boolean_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000FC200 File Offset: 0x000FA400
		[CallerCount(0)]
		public unsafe static bool IsNear(float value, float targetValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsNear_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000FC24C File Offset: 0x000FA44C
		[CallerCount(0)]
		public unsafe static bool IsNear(float value, float targetValue, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsNear_Public_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000FC2A8 File Offset: 0x000FA4A8
		[CallerCount(0)]
		public unsafe static bool IsNearZero(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsNearZero_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x000FC2E8 File Offset: 0x000FA4E8
		[CallerCount(0)]
		public unsafe static bool IsNearZero(float value, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsNearZero_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x000FC334 File Offset: 0x000FA534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338334, XrefRangeEnd = 338338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNearOrWholeNumber(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x000FC374 File Offset: 0x000FA574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338338, XrefRangeEnd = 338342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNearOrWholeNumber(float value, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x000FC3C0 File Offset: 0x000FA5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338342, XrefRangeEnd = 338346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNearOrWholeNumber(float value, out int number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x000FC40C File Offset: 0x000FA60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338346, XrefRangeEnd = 338350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNearOrWholeNumber(float value, out int number, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_byref_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x000FC468 File Offset: 0x000FA668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338350, XrefRangeEnd = 338355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RoundOffIfNearWholeNumber(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_RoundOffIfNearWholeNumber_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000FC4A8 File Offset: 0x000FA6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338355, XrefRangeEnd = 338360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RoundOffIfNearWholeNumber(float value, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_RoundOffIfNearWholeNumber_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x000FC4F4 File Offset: 0x000FA6F4
		[CallerCount(0)]
		public unsafe static bool IsEven(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsEven_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000FC534 File Offset: 0x000FA734
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 338361, RefRangeEnd = 338367, XrefRangeStart = 338360, XrefRangeEnd = 338361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ValueInNewRange(float oldValue, float oldMin, float oldMax, float newMin, float newMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMin;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_ValueInNewRange_Public_Static_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000FC5AC File Offset: 0x000FA7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338367, XrefRangeEnd = 338368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ValueInNewRange(int oldValue, int oldMin, int oldMax, int newMin, int newMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMin;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_ValueInNewRange_Public_Static_Int32_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000FC624 File Offset: 0x000FA824
		[CallerCount(0)]
		public unsafe static sbyte Max(sbyte a, sbyte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_SByte_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x000FC670 File Offset: 0x000FA870
		[CallerCount(0)]
		public unsafe static byte Max(byte a, byte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x000FC6BC File Offset: 0x000FA8BC
		[CallerCount(0)]
		public unsafe static short Max(short a, short b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_Int16_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x000FC708 File Offset: 0x000FA908
		[CallerCount(0)]
		public unsafe static ushort Max(ushort a, ushort b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_UInt16_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x000FC754 File Offset: 0x000FA954
		[CallerCount(0)]
		public unsafe static int Max(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x000FC7A0 File Offset: 0x000FA9A0
		[CallerCount(0)]
		public unsafe static uint Max(uint a, uint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x000FC7EC File Offset: 0x000FA9EC
		[CallerCount(0)]
		public unsafe static long Max(long a, long b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x000FC838 File Offset: 0x000FAA38
		[CallerCount(0)]
		public unsafe static ulong Max(ulong a, ulong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x000FC884 File Offset: 0x000FAA84
		[CallerCount(0)]
		public unsafe static float Max(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x000FC8D0 File Offset: 0x000FAAD0
		[CallerCount(0)]
		public unsafe static double Max(double a, double b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Max_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000FC91C File Offset: 0x000FAB1C
		[CallerCount(0)]
		public unsafe static sbyte Min(sbyte a, sbyte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_SByte_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000FC968 File Offset: 0x000FAB68
		[CallerCount(0)]
		public unsafe static byte Min(byte a, byte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000FC9B4 File Offset: 0x000FABB4
		[CallerCount(0)]
		public unsafe static short Min(short a, short b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_Int16_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000FCA00 File Offset: 0x000FAC00
		[CallerCount(0)]
		public unsafe static ushort Min(ushort a, ushort b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_UInt16_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000FCA4C File Offset: 0x000FAC4C
		[CallerCount(0)]
		public unsafe static int Min(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000FCA98 File Offset: 0x000FAC98
		[CallerCount(0)]
		public unsafe static uint Min(uint a, uint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x000FCAE4 File Offset: 0x000FACE4
		[CallerCount(0)]
		public unsafe static long Min(long a, long b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000FCB30 File Offset: 0x000FAD30
		[CallerCount(0)]
		public unsafe static ulong Min(ulong a, ulong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000FCB7C File Offset: 0x000FAD7C
		[CallerCount(0)]
		public unsafe static float Min(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000FCBC8 File Offset: 0x000FADC8
		[CallerCount(0)]
		public unsafe static double Min(double a, double b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Min_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x000FCC14 File Offset: 0x000FAE14
		[CallerCount(0)]
		public unsafe static sbyte MaxMagnitude(sbyte a, sbyte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_SByte_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x000FCC60 File Offset: 0x000FAE60
		[CallerCount(0)]
		public unsafe static byte MaxMagnitude(byte a, byte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x000FCCAC File Offset: 0x000FAEAC
		[CallerCount(0)]
		public unsafe static short MaxMagnitude(short a, short b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Int16_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x000FCCF8 File Offset: 0x000FAEF8
		[CallerCount(0)]
		public unsafe static ushort MaxMagnitude(ushort a, ushort b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_UInt16_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x000FCD44 File Offset: 0x000FAF44
		[CallerCount(0)]
		public unsafe static int MaxMagnitude(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000FCD90 File Offset: 0x000FAF90
		[CallerCount(0)]
		public unsafe static uint MaxMagnitude(uint a, uint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000FCDDC File Offset: 0x000FAFDC
		[CallerCount(0)]
		public unsafe static long MaxMagnitude(long a, long b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000FCE28 File Offset: 0x000FB028
		[CallerCount(0)]
		public unsafe static ulong MaxMagnitude(ulong a, ulong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000FCE74 File Offset: 0x000FB074
		[CallerCount(0)]
		public unsafe static float MaxMagnitude(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000FCEC0 File Offset: 0x000FB0C0
		[CallerCount(0)]
		public unsafe static double MaxMagnitude(double a, double b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x000FCF0C File Offset: 0x000FB10C
		[CallerCount(0)]
		public unsafe static sbyte MinMagnitude(sbyte a, sbyte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_SByte_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000FCF58 File Offset: 0x000FB158
		[CallerCount(0)]
		public unsafe static byte MinMagnitude(byte a, byte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000FCFA4 File Offset: 0x000FB1A4
		[CallerCount(0)]
		public unsafe static short MinMagnitude(short a, short b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Int16_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000FCFF0 File Offset: 0x000FB1F0
		[CallerCount(0)]
		public unsafe static ushort MinMagnitude(ushort a, ushort b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_UInt16_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000FD03C File Offset: 0x000FB23C
		[CallerCount(0)]
		public unsafe static int MinMagnitude(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000FD088 File Offset: 0x000FB288
		[CallerCount(0)]
		public unsafe static uint MinMagnitude(uint a, uint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000FD0D4 File Offset: 0x000FB2D4
		[CallerCount(0)]
		public unsafe static long MinMagnitude(long a, long b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000FD120 File Offset: 0x000FB320
		[CallerCount(0)]
		public unsafe static ulong MinMagnitude(ulong a, ulong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000FD16C File Offset: 0x000FB36C
		[CallerCount(0)]
		public unsafe static float MinMagnitude(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000FD1B8 File Offset: 0x000FB3B8
		[CallerCount(0)]
		public unsafe static double MinMagnitude(double a, double b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x000FD204 File Offset: 0x000FB404
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(sbyte a, sbyte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x000FD250 File Offset: 0x000FB450
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(byte a, byte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x000FD29C File Offset: 0x000FB49C
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(short a, short b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000FD2E8 File Offset: 0x000FB4E8
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(ushort a, ushort b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000FD334 File Offset: 0x000FB534
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x000FD380 File Offset: 0x000FB580
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(uint a, uint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x000FD3CC File Offset: 0x000FB5CC
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(long a, long b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000FD418 File Offset: 0x000FB618
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(ulong a, ulong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000FD464 File Offset: 0x000FB664
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x000FD4B0 File Offset: 0x000FB6B0
		[CallerCount(0)]
		public unsafe static bool IsMoreMagnitudeOrEqual(double a, double b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x000FD4FC File Offset: 0x000FB6FC
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(sbyte a, sbyte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x000FD548 File Offset: 0x000FB748
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(byte a, byte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x000FD594 File Offset: 0x000FB794
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(short a, short b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x000FD5E0 File Offset: 0x000FB7E0
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(ushort a, ushort b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x000FD62C File Offset: 0x000FB82C
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x000FD678 File Offset: 0x000FB878
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(uint a, uint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x000FD6C4 File Offset: 0x000FB8C4
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(long a, long b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x000FD710 File Offset: 0x000FB910
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(ulong a, ulong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x000FD75C File Offset: 0x000FB95C
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x000FD7A8 File Offset: 0x000FB9A8
		[CallerCount(0)]
		public unsafe static bool IsLessMagnitudeOrEqual(double a, double b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x000FD7F4 File Offset: 0x000FB9F4
		[CallerCount(0)]
		public unsafe static byte Clamp(byte value, byte min, byte max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Byte_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x000FD850 File Offset: 0x000FBA50
		[CallerCount(0)]
		public unsafe static sbyte Clamp(sbyte value, sbyte min, sbyte max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_SByte_SByte_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x000FD8AC File Offset: 0x000FBAAC
		[CallerCount(0)]
		public unsafe static short Clamp(short value, short min, short max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Int16_Int16_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x000FD908 File Offset: 0x000FBB08
		[CallerCount(0)]
		public unsafe static ushort Clamp(ushort value, ushort min, ushort max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_UInt16_UInt16_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x000FD964 File Offset: 0x000FBB64
		[CallerCount(0)]
		public unsafe static int Clamp(int value, int min, int max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x000FD9C0 File Offset: 0x000FBBC0
		[CallerCount(0)]
		public unsafe static uint Clamp(uint value, uint min, uint max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x000FDA1C File Offset: 0x000FBC1C
		[CallerCount(0)]
		public unsafe static long Clamp(long value, long min, long max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Int64_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x000FDA78 File Offset: 0x000FBC78
		[CallerCount(0)]
		public unsafe static ulong Clamp(ulong value, ulong min, ulong max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x000FDAD4 File Offset: 0x000FBCD4
		[CallerCount(0)]
		public unsafe static float Clamp(float value, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x000FDB30 File Offset: 0x000FBD30
		[CallerCount(0)]
		public unsafe static double Clamp(double value, double min, double max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Double_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000FDB8C File Offset: 0x000FBD8C
		[CallerCount(0)]
		public unsafe static float Clamp01(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x000FDBCC File Offset: 0x000FBDCC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 338372, RefRangeEnd = 338387, XrefRangeStart = 338368, XrefRangeEnd = 338372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ClampAngle360(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_ClampAngle360_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x000FDC0C File Offset: 0x000FBE0C
		[CallerCount(0)]
		public unsafe static float ReverseAngleRotationDirection(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_ReverseAngleRotationDirection_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x000FDC4C File Offset: 0x000FBE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338387, XrefRangeEnd = 338392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AngleIsNear(float angle, float targetAngle, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_AngleIsNear_Public_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x000FDCA8 File Offset: 0x000FBEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338392, XrefRangeEnd = 338397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AngleIsBetween(float angle, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_AngleIsBetween_Public_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000FDD04 File Offset: 0x000FBF04
		[CallerCount(0)]
		public unsafe static bool mdZphWzimSDchgqQNIWvKpBviCl(int A_0, int A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_mdZphWzimSDchgqQNIWvKpBviCl_Internal_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000FDD50 File Offset: 0x000FBF50
		[CallerCount(0)]
		public unsafe static int IntPow(int x, uint pow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_IntPow_Public_Static_Int32_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x000FDD9C File Offset: 0x000FBF9C
		[CallerCount(0)]
		public unsafe static uint RoundUpToPowerOf2(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_RoundUpToPowerOf2_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x000FDDDC File Offset: 0x000FBFDC
		[CallerCount(0)]
		public unsafe static float BooleanToSign(bool b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_BooleanToSign_Public_Static_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x000FDE1C File Offset: 0x000FC01C
		[CallerCount(0)]
		public unsafe static bool SignToBoolean(float sign)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sign;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_SignToBoolean_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x000FDE5C File Offset: 0x000FC05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338397, XrefRangeEnd = 338401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Sin(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x000FDE9C File Offset: 0x000FC09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338401, XrefRangeEnd = 338405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Cos(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000FDEDC File Offset: 0x000FC0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338405, XrefRangeEnd = 338409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Tan(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000FDF1C File Offset: 0x000FC11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338409, XrefRangeEnd = 338413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Asin(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x000FDF5C File Offset: 0x000FC15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338413, XrefRangeEnd = 338417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Acos(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x000FDF9C File Offset: 0x000FC19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338417, XrefRangeEnd = 338421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Atan(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x000FDFDC File Offset: 0x000FC1DC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 338425, RefRangeEnd = 338443, XrefRangeStart = 338421, XrefRangeEnd = 338425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Atan2(float y, float x)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000FE028 File Offset: 0x000FC228
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 338446, RefRangeEnd = 338464, XrefRangeStart = 338443, XrefRangeEnd = 338446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Sqrt(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x000FE068 File Offset: 0x000FC268
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 338468, RefRangeEnd = 338485, XrefRangeStart = 338464, XrefRangeEnd = 338468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Pow(float value, float p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x000FE0B4 File Offset: 0x000FC2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338485, XrefRangeEnd = 338489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Exp(float power)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref power;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x000FE0F4 File Offset: 0x000FC2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338489, XrefRangeEnd = 338493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log(float value, float p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x000FE140 File Offset: 0x000FC340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338493, XrefRangeEnd = 338497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Log_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x000FE180 File Offset: 0x000FC380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338497, XrefRangeEnd = 338501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log10(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x000FE1C0 File Offset: 0x000FC3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338501, XrefRangeEnd = 338505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Ceil(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x000FE200 File Offset: 0x000FC400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338509, RefRangeEnd = 338510, XrefRangeStart = 338505, XrefRangeEnd = 338509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Floor(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x000FE240 File Offset: 0x000FC440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338514, RefRangeEnd = 338516, XrefRangeStart = 338510, XrefRangeEnd = 338514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Round(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x000FE280 File Offset: 0x000FC480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338516, XrefRangeEnd = 338520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CeilToInt(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x000FE2C0 File Offset: 0x000FC4C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338524, RefRangeEnd = 338526, XrefRangeStart = 338520, XrefRangeEnd = 338524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FloorToInt(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x000FE300 File Offset: 0x000FC500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338526, XrefRangeEnd = 338530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RoundToInt(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x000FE340 File Offset: 0x000FC540
		[CallerCount(0)]
		public unsafe static float Sign(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x000FE380 File Offset: 0x000FC580
		[CallerCount(0)]
		public unsafe static int Sign(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Sign_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x000FE3C0 File Offset: 0x000FC5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338530, XrefRangeEnd = 338534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Repeat(float t, float length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x000FE40C File Offset: 0x000FC60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338534, XrefRangeEnd = 338538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float DeltaAngle(float current, float target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x000FE458 File Offset: 0x000FC658
		[CallerCount(0)]
		public unsafe static Vector2 MaxMagnitude(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x000FE4A4 File Offset: 0x000FC6A4
		[CallerCount(0)]
		public unsafe static Vector3 MaxMagnitude(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MaxMagnitude_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x000FE4F0 File Offset: 0x000FC6F0
		[CallerCount(0)]
		public unsafe static Vector2 MinMagnitude(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x000FE53C File Offset: 0x000FC73C
		[CallerCount(0)]
		public unsafe static Vector3 MinMagnitude(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_MinMagnitude_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x000FE588 File Offset: 0x000FC788
		[CallerCount(0)]
		public unsafe static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x000FE5E4 File Offset: 0x000FC7E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338539, RefRangeEnd = 338540, XrefRangeStart = 338538, XrefRangeEnd = 338539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Clamp(Vector2 value, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x000FE640 File Offset: 0x000FC840
		[CallerCount(0)]
		public unsafe static Vector2 Clamp(Vector3 value, Vector3 min, Vector3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x000FE69C File Offset: 0x000FC89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338540, XrefRangeEnd = 338541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Clamp(Vector3 value, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x000FE6F8 File Offset: 0x000FC8F8
		[CallerCount(0)]
		public unsafe static float Cross(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Cross_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x000FE744 File Offset: 0x000FC944
		[CallerCount(0)]
		public unsafe static float Multiply(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_Multiply_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x000FE790 File Offset: 0x000FC990
		[CallerCount(0)]
		public unsafe static bool RectContains(Rect rect, Vector2 pos, float rotation = 0f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_RectContains_Public_Static_Boolean_Rect_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x000FE7EC File Offset: 0x000FC9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338541, XrefRangeEnd = 338551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 RotateWorldPoint(Vector2 point, Vector2 center, float angle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref center;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_RotateWorldPoint_Public_Static_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x000FE848 File Offset: 0x000FCA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338551, XrefRangeEnd = 338561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 RotateLocalPoint(Vector2 point, float angle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_RotateLocalPoint_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x000FE894 File Offset: 0x000FCA94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338569, RefRangeEnd = 338570, XrefRangeStart = 338561, XrefRangeEnd = 338569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LineIntersectsRect(Vector2 point1, Vector2 point2, Rect rect, out float sqrMagnitude)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sqrMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_LineIntersectsRect_Public_Static_Boolean_Vector2_Vector2_Rect_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x000FE8FC File Offset: 0x000FCAFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 338573, RefRangeEnd = 338577, XrefRangeStart = 338570, XrefRangeEnd = 338573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LineSegementsIntersect(Vector2 line1p1, Vector2 line1p2, Vector2 line2p1, Vector2 line2p2, out Vector2 intersection, bool collinearIntersects = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref line1p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line1p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line2p1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line2p2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intersection;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collinearIntersects;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_LineSegementsIntersect_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x000FE980 File Offset: 0x000FCB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338577, XrefRangeEnd = 338579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NVeFPCCqgxINaIxTHNpRVWZSTtwL(Vector2 A_0, Vector2 A_1, Vector2 A_2, Vector2 A_3, out Vector2 A_4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_NVeFPCCqgxINaIxTHNpRVWZSTtwL_Private_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x000FE9F8 File Offset: 0x000FCBF8
		[CallerCount(0)]
		public unsafe static bool RectContains(Rect container, Rect child)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref container;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref child;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_RectContains_Public_Static_Boolean_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x000FEA44 File Offset: 0x000FCC44
		[CallerCount(0)]
		public unsafe static bool GetOffsetToContainRect(Rect container, Rect child, out Vector2 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref container;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref child;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_GetOffsetToContainRect_Public_Static_Boolean_Rect_Rect_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x000FEAA0 File Offset: 0x000FCCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338579, XrefRangeEnd = 338584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 TransformTo(Transform from, Transform to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_TransformTo_Public_Static_Matrix4x4_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000FEAF4 File Offset: 0x000FCCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338584, XrefRangeEnd = 338589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect TransformRect(Rect fromRect, Transform from, Transform to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_TransformRect_Public_Static_Rect_Rect_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x000FEB58 File Offset: 0x000FCD58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338605, RefRangeEnd = 338606, XrefRangeStart = 338589, XrefRangeEnd = 338605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 SnapVectorToNearestAngle(Vector2 vector, float angle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_SnapVectorToNearestAngle_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x000FEBA4 File Offset: 0x000FCDA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338608, RefRangeEnd = 338610, XrefRangeStart = 338606, XrefRangeEnd = 338608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x000FEC00 File Offset: 0x000FCE00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MathTools()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MathTools>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathTools.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x00011D29 File Offset: 0x0000FF29
		public MathTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x000FEC3C File Offset: 0x000FCE3C
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x00011D32 File Offset: 0x0000FF32
		public unsafe static float vTzJgiPQEAcacgyNTOXjqPgyJTf
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathTools.NativeFieldInfoPtr_vTzJgiPQEAcacgyNTOXjqPgyJTf, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathTools.NativeFieldInfoPtr_vTzJgiPQEAcacgyNTOXjqPgyJTf, (void*)(&value));
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x000FEC58 File Offset: 0x000FCE58
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x00011D40 File Offset: 0x0000FF40
		public unsafe static double OuDydHOvnMQdeNgIaWbOgATYhZF
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(MathTools.NativeFieldInfoPtr_OuDydHOvnMQdeNgIaWbOgATYhZF, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathTools.NativeFieldInfoPtr_OuDydHOvnMQdeNgIaWbOgATYhZF, (void*)(&value));
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x000FEC74 File Offset: 0x000FCE74
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x00011D4E File Offset: 0x0000FF4E
		public unsafe static float bXlGHHFgXYnpWoiaRSteAFrCDyVa
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathTools.NativeFieldInfoPtr_bXlGHHFgXYnpWoiaRSteAFrCDyVa, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathTools.NativeFieldInfoPtr_bXlGHHFgXYnpWoiaRSteAFrCDyVa, (void*)(&value));
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x000FEC90 File Offset: 0x000FCE90
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x00011D5C File Offset: 0x0000FF5C
		public unsafe static float PI
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathTools.NativeFieldInfoPtr_PI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathTools.NativeFieldInfoPtr_PI, (void*)(&value));
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06003306 RID: 13062 RVA: 0x000FECAC File Offset: 0x000FCEAC
		// (set) Token: 0x06003307 RID: 13063 RVA: 0x00011D6A File Offset: 0x0000FF6A
		public unsafe static float Infinity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathTools.NativeFieldInfoPtr_Infinity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathTools.NativeFieldInfoPtr_Infinity, (void*)(&value));
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06003308 RID: 13064 RVA: 0x000FECC8 File Offset: 0x000FCEC8
		// (set) Token: 0x06003309 RID: 13065 RVA: 0x00011D78 File Offset: 0x0000FF78
		public unsafe static float NegativeInfinity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathTools.NativeFieldInfoPtr_NegativeInfinity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathTools.NativeFieldInfoPtr_NegativeInfinity, (void*)(&value));
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x0600330A RID: 13066 RVA: 0x000FECE4 File Offset: 0x000FCEE4
		// (set) Token: 0x0600330B RID: 13067 RVA: 0x00011D86 File Offset: 0x0000FF86
		public unsafe static float Deg2Rad
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathTools.NativeFieldInfoPtr_Deg2Rad, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathTools.NativeFieldInfoPtr_Deg2Rad, (void*)(&value));
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x0600330C RID: 13068 RVA: 0x000FED00 File Offset: 0x000FCF00
		// (set) Token: 0x0600330D RID: 13069 RVA: 0x00011D94 File Offset: 0x0000FF94
		public unsafe static float Rad2Deg
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathTools.NativeFieldInfoPtr_Rad2Deg, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathTools.NativeFieldInfoPtr_Rad2Deg, (void*)(&value));
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x0600330E RID: 13070 RVA: 0x000FED1C File Offset: 0x000FCF1C
		// (set) Token: 0x0600330F RID: 13071 RVA: 0x00011DA2 File Offset: 0x0000FFA2
		public unsafe static float Epsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathTools.NativeFieldInfoPtr_Epsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathTools.NativeFieldInfoPtr_Epsilon, (void*)(&value));
			}
		}

		// Token: 0x04002AED RID: 10989
		private static readonly IntPtr NativeFieldInfoPtr_vTzJgiPQEAcacgyNTOXjqPgyJTf;

		// Token: 0x04002AEE RID: 10990
		private static readonly IntPtr NativeFieldInfoPtr_OuDydHOvnMQdeNgIaWbOgATYhZF;

		// Token: 0x04002AEF RID: 10991
		private static readonly IntPtr NativeFieldInfoPtr_bXlGHHFgXYnpWoiaRSteAFrCDyVa;

		// Token: 0x04002AF0 RID: 10992
		private static readonly IntPtr NativeFieldInfoPtr_PI;

		// Token: 0x04002AF1 RID: 10993
		private static readonly IntPtr NativeFieldInfoPtr_Infinity;

		// Token: 0x04002AF2 RID: 10994
		private static readonly IntPtr NativeFieldInfoPtr_NegativeInfinity;

		// Token: 0x04002AF3 RID: 10995
		private static readonly IntPtr NativeFieldInfoPtr_Deg2Rad;

		// Token: 0x04002AF4 RID: 10996
		private static readonly IntPtr NativeFieldInfoPtr_Rad2Deg;

		// Token: 0x04002AF5 RID: 10997
		private static readonly IntPtr NativeFieldInfoPtr_Epsilon;

		// Token: 0x04002AF6 RID: 10998
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_SByte_SByte_0;

		// Token: 0x04002AF7 RID: 10999
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int16_Int16_0;

		// Token: 0x04002AF8 RID: 11000
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0;

		// Token: 0x04002AF9 RID: 11001
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int64_Int64_0;

		// Token: 0x04002AFA RID: 11002
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;

		// Token: 0x04002AFB RID: 11003
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Double_Double_0;

		// Token: 0x04002AFC RID: 11004
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04002AFD RID: 11005
		private static readonly IntPtr NativeMethodInfoPtr_ApproximatelyZero_Public_Static_Boolean_Single_0;

		// Token: 0x04002AFE RID: 11006
		private static readonly IntPtr NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Single_0;

		// Token: 0x04002AFF RID: 11007
		private static readonly IntPtr NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04002B00 RID: 11008
		private static readonly IntPtr NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Double_0;

		// Token: 0x04002B01 RID: 11009
		private static readonly IntPtr NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Double_Double_0;

		// Token: 0x04002B02 RID: 11010
		private static readonly IntPtr NativeMethodInfoPtr_IsExactlyEqual_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04002B03 RID: 11011
		private static readonly IntPtr NativeMethodInfoPtr_IsExactlyEqual_Public_Static_Boolean_Double_Double_0;

		// Token: 0x04002B04 RID: 11012
		private static readonly IntPtr NativeMethodInfoPtr_IsNear_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04002B05 RID: 11013
		private static readonly IntPtr NativeMethodInfoPtr_IsNear_Public_Static_Boolean_Single_Single_Single_0;

		// Token: 0x04002B06 RID: 11014
		private static readonly IntPtr NativeMethodInfoPtr_IsNearZero_Public_Static_Boolean_Single_0;

		// Token: 0x04002B07 RID: 11015
		private static readonly IntPtr NativeMethodInfoPtr_IsNearZero_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04002B08 RID: 11016
		private static readonly IntPtr NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_0;

		// Token: 0x04002B09 RID: 11017
		private static readonly IntPtr NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04002B0A RID: 11018
		private static readonly IntPtr NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_byref_Int32_0;

		// Token: 0x04002B0B RID: 11019
		private static readonly IntPtr NativeMethodInfoPtr_IsNearOrWholeNumber_Public_Static_Boolean_Single_byref_Int32_Single_0;

		// Token: 0x04002B0C RID: 11020
		private static readonly IntPtr NativeMethodInfoPtr_RoundOffIfNearWholeNumber_Public_Static_Single_Single_0;

		// Token: 0x04002B0D RID: 11021
		private static readonly IntPtr NativeMethodInfoPtr_RoundOffIfNearWholeNumber_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B0E RID: 11022
		private static readonly IntPtr NativeMethodInfoPtr_IsEven_Public_Static_Boolean_Int32_0;

		// Token: 0x04002B0F RID: 11023
		private static readonly IntPtr NativeMethodInfoPtr_ValueInNewRange_Public_Static_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04002B10 RID: 11024
		private static readonly IntPtr NativeMethodInfoPtr_ValueInNewRange_Public_Static_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002B11 RID: 11025
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_SByte_SByte_SByte_0;

		// Token: 0x04002B12 RID: 11026
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Byte_Byte_Byte_0;

		// Token: 0x04002B13 RID: 11027
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int16_Int16_Int16_0;

		// Token: 0x04002B14 RID: 11028
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_UInt16_UInt16_UInt16_0;

		// Token: 0x04002B15 RID: 11029
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04002B16 RID: 11030
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04002B17 RID: 11031
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04002B18 RID: 11032
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x04002B19 RID: 11033
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B1A RID: 11034
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Double_Double_Double_0;

		// Token: 0x04002B1B RID: 11035
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_SByte_SByte_SByte_0;

		// Token: 0x04002B1C RID: 11036
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Byte_Byte_Byte_0;

		// Token: 0x04002B1D RID: 11037
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int16_Int16_Int16_0;

		// Token: 0x04002B1E RID: 11038
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_UInt16_UInt16_UInt16_0;

		// Token: 0x04002B1F RID: 11039
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04002B20 RID: 11040
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04002B21 RID: 11041
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04002B22 RID: 11042
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x04002B23 RID: 11043
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B24 RID: 11044
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Double_Double_Double_0;

		// Token: 0x04002B25 RID: 11045
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_SByte_SByte_SByte_0;

		// Token: 0x04002B26 RID: 11046
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_Byte_Byte_Byte_0;

		// Token: 0x04002B27 RID: 11047
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_Int16_Int16_Int16_0;

		// Token: 0x04002B28 RID: 11048
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_UInt16_UInt16_UInt16_0;

		// Token: 0x04002B29 RID: 11049
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04002B2A RID: 11050
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04002B2B RID: 11051
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04002B2C RID: 11052
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x04002B2D RID: 11053
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B2E RID: 11054
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_Double_Double_Double_0;

		// Token: 0x04002B2F RID: 11055
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_SByte_SByte_SByte_0;

		// Token: 0x04002B30 RID: 11056
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_Byte_Byte_Byte_0;

		// Token: 0x04002B31 RID: 11057
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_Int16_Int16_Int16_0;

		// Token: 0x04002B32 RID: 11058
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_UInt16_UInt16_UInt16_0;

		// Token: 0x04002B33 RID: 11059
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04002B34 RID: 11060
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04002B35 RID: 11061
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04002B36 RID: 11062
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x04002B37 RID: 11063
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B38 RID: 11064
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_Double_Double_Double_0;

		// Token: 0x04002B39 RID: 11065
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_SByte_SByte_0;

		// Token: 0x04002B3A RID: 11066
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Byte_Byte_0;

		// Token: 0x04002B3B RID: 11067
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Int16_Int16_0;

		// Token: 0x04002B3C RID: 11068
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_UInt16_UInt16_0;

		// Token: 0x04002B3D RID: 11069
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002B3E RID: 11070
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_UInt32_UInt32_0;

		// Token: 0x04002B3F RID: 11071
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Int64_Int64_0;

		// Token: 0x04002B40 RID: 11072
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_UInt64_UInt64_0;

		// Token: 0x04002B41 RID: 11073
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04002B42 RID: 11074
		private static readonly IntPtr NativeMethodInfoPtr_IsMoreMagnitudeOrEqual_Public_Static_Boolean_Double_Double_0;

		// Token: 0x04002B43 RID: 11075
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_SByte_SByte_0;

		// Token: 0x04002B44 RID: 11076
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Byte_Byte_0;

		// Token: 0x04002B45 RID: 11077
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Int16_Int16_0;

		// Token: 0x04002B46 RID: 11078
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_UInt16_UInt16_0;

		// Token: 0x04002B47 RID: 11079
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002B48 RID: 11080
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_UInt32_UInt32_0;

		// Token: 0x04002B49 RID: 11081
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Int64_Int64_0;

		// Token: 0x04002B4A RID: 11082
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_UInt64_UInt64_0;

		// Token: 0x04002B4B RID: 11083
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04002B4C RID: 11084
		private static readonly IntPtr NativeMethodInfoPtr_IsLessMagnitudeOrEqual_Public_Static_Boolean_Double_Double_0;

		// Token: 0x04002B4D RID: 11085
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Byte_Byte_Byte_Byte_0;

		// Token: 0x04002B4E RID: 11086
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_SByte_SByte_SByte_SByte_0;

		// Token: 0x04002B4F RID: 11087
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int16_Int16_Int16_Int16_0;

		// Token: 0x04002B50 RID: 11088
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_UInt16_UInt16_UInt16_UInt16_0;

		// Token: 0x04002B51 RID: 11089
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002B52 RID: 11090
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002B53 RID: 11091
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int64_Int64_Int64_Int64_0;

		// Token: 0x04002B54 RID: 11092
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x04002B55 RID: 11093
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04002B56 RID: 11094
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Double_Double_Double_Double_0;

		// Token: 0x04002B57 RID: 11095
		private static readonly IntPtr NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0;

		// Token: 0x04002B58 RID: 11096
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle360_Public_Static_Single_Single_0;

		// Token: 0x04002B59 RID: 11097
		private static readonly IntPtr NativeMethodInfoPtr_ReverseAngleRotationDirection_Public_Static_Single_Single_0;

		// Token: 0x04002B5A RID: 11098
		private static readonly IntPtr NativeMethodInfoPtr_AngleIsNear_Public_Static_Boolean_Single_Single_Single_0;

		// Token: 0x04002B5B RID: 11099
		private static readonly IntPtr NativeMethodInfoPtr_AngleIsBetween_Public_Static_Boolean_Single_Single_Single_0;

		// Token: 0x04002B5C RID: 11100
		private static readonly IntPtr NativeMethodInfoPtr_mdZphWzimSDchgqQNIWvKpBviCl_Internal_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002B5D RID: 11101
		private static readonly IntPtr NativeMethodInfoPtr_IntPow_Public_Static_Int32_Int32_UInt32_0;

		// Token: 0x04002B5E RID: 11102
		private static readonly IntPtr NativeMethodInfoPtr_RoundUpToPowerOf2_Public_Static_UInt32_UInt32_0;

		// Token: 0x04002B5F RID: 11103
		private static readonly IntPtr NativeMethodInfoPtr_BooleanToSign_Public_Static_Single_Boolean_0;

		// Token: 0x04002B60 RID: 11104
		private static readonly IntPtr NativeMethodInfoPtr_SignToBoolean_Public_Static_Boolean_Single_0;

		// Token: 0x04002B61 RID: 11105
		private static readonly IntPtr NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0;

		// Token: 0x04002B62 RID: 11106
		private static readonly IntPtr NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0;

		// Token: 0x04002B63 RID: 11107
		private static readonly IntPtr NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0;

		// Token: 0x04002B64 RID: 11108
		private static readonly IntPtr NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0;

		// Token: 0x04002B65 RID: 11109
		private static readonly IntPtr NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0;

		// Token: 0x04002B66 RID: 11110
		private static readonly IntPtr NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0;

		// Token: 0x04002B67 RID: 11111
		private static readonly IntPtr NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B68 RID: 11112
		private static readonly IntPtr NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0;

		// Token: 0x04002B69 RID: 11113
		private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B6A RID: 11114
		private static readonly IntPtr NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0;

		// Token: 0x04002B6B RID: 11115
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B6C RID: 11116
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_0;

		// Token: 0x04002B6D RID: 11117
		private static readonly IntPtr NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0;

		// Token: 0x04002B6E RID: 11118
		private static readonly IntPtr NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0;

		// Token: 0x04002B6F RID: 11119
		private static readonly IntPtr NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0;

		// Token: 0x04002B70 RID: 11120
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Single_Single_0;

		// Token: 0x04002B71 RID: 11121
		private static readonly IntPtr NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0;

		// Token: 0x04002B72 RID: 11122
		private static readonly IntPtr NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0;

		// Token: 0x04002B73 RID: 11123
		private static readonly IntPtr NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0;

		// Token: 0x04002B74 RID: 11124
		private static readonly IntPtr NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0;

		// Token: 0x04002B75 RID: 11125
		private static readonly IntPtr NativeMethodInfoPtr_Sign_Public_Static_Int32_Int32_0;

		// Token: 0x04002B76 RID: 11126
		private static readonly IntPtr NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B77 RID: 11127
		private static readonly IntPtr NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0;

		// Token: 0x04002B78 RID: 11128
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04002B79 RID: 11129
		private static readonly IntPtr NativeMethodInfoPtr_MaxMagnitude_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04002B7A RID: 11130
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04002B7B RID: 11131
		private static readonly IntPtr NativeMethodInfoPtr_MinMagnitude_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04002B7C RID: 11132
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector2_Vector2_Vector2_0;

		// Token: 0x04002B7D RID: 11133
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector2_Single_Single_0;

		// Token: 0x04002B7E RID: 11134
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector3_Vector3_Vector3_0;

		// Token: 0x04002B7F RID: 11135
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector3_Single_Single_0;

		// Token: 0x04002B80 RID: 11136
		private static readonly IntPtr NativeMethodInfoPtr_Cross_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x04002B81 RID: 11137
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x04002B82 RID: 11138
		private static readonly IntPtr NativeMethodInfoPtr_RectContains_Public_Static_Boolean_Rect_Vector2_Single_0;

		// Token: 0x04002B83 RID: 11139
		private static readonly IntPtr NativeMethodInfoPtr_RotateWorldPoint_Public_Static_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x04002B84 RID: 11140
		private static readonly IntPtr NativeMethodInfoPtr_RotateLocalPoint_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04002B85 RID: 11141
		private static readonly IntPtr NativeMethodInfoPtr_LineIntersectsRect_Public_Static_Boolean_Vector2_Vector2_Rect_byref_Single_0;

		// Token: 0x04002B86 RID: 11142
		private static readonly IntPtr NativeMethodInfoPtr_LineSegementsIntersect_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_Boolean_0;

		// Token: 0x04002B87 RID: 11143
		private static readonly IntPtr NativeMethodInfoPtr_NVeFPCCqgxINaIxTHNpRVWZSTtwL_Private_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_0;

		// Token: 0x04002B88 RID: 11144
		private static readonly IntPtr NativeMethodInfoPtr_RectContains_Public_Static_Boolean_Rect_Rect_0;

		// Token: 0x04002B89 RID: 11145
		private static readonly IntPtr NativeMethodInfoPtr_GetOffsetToContainRect_Public_Static_Boolean_Rect_Rect_byref_Vector2_0;

		// Token: 0x04002B8A RID: 11146
		private static readonly IntPtr NativeMethodInfoPtr_TransformTo_Public_Static_Matrix4x4_Transform_Transform_0;

		// Token: 0x04002B8B RID: 11147
		private static readonly IntPtr NativeMethodInfoPtr_TransformRect_Public_Static_Rect_Rect_Transform_Transform_0;

		// Token: 0x04002B8C RID: 11148
		private static readonly IntPtr NativeMethodInfoPtr_SnapVectorToNearestAngle_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04002B8D RID: 11149
		private static readonly IntPtr NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x04002B8E RID: 11150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
