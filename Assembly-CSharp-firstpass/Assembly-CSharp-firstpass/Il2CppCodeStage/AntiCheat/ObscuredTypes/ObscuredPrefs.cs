using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x020001FE RID: 510
	public static class ObscuredPrefs : global::Il2CppSystem.Object
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x000788C4 File Offset: 0x00076AC4
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredPrefs()
		{
			Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredPrefs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr);
			ObscuredPrefs.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "Version");
			ObscuredPrefs.NativeFieldInfoPtr_RawNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "RawNotFound");
			ObscuredPrefs.NativeFieldInfoPtr_DataSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "DataSeparator");
			ObscuredPrefs.NativeFieldInfoPtr_foreignSavesReported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "foreignSavesReported");
			ObscuredPrefs.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "cryptoKey");
			ObscuredPrefs.NativeFieldInfoPtr_deviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "deviceId");
			ObscuredPrefs.NativeFieldInfoPtr_deviceIdHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "deviceIdHash");
			ObscuredPrefs.NativeFieldInfoPtr_onAlterationDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "onAlterationDetected");
			ObscuredPrefs.NativeFieldInfoPtr_preservePlayerPrefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "preservePlayerPrefs");
			ObscuredPrefs.NativeFieldInfoPtr_onPossibleForeignSavesDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "onPossibleForeignSavesDetected");
			ObscuredPrefs.NativeFieldInfoPtr_lockToDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "lockToDevice");
			ObscuredPrefs.NativeFieldInfoPtr_readForeignSaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "readForeignSaves");
			ObscuredPrefs.NativeFieldInfoPtr_emergencyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "emergencyMode");
			ObscuredPrefs.NativeFieldInfoPtr_DEPRECATED_RAW_SEPARATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "DEPRECATED_RAW_SEPARATOR");
			ObscuredPrefs.NativeFieldInfoPtr_deprecatedDeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, "deprecatedDeviceId");
			ObscuredPrefs.NativeMethodInfoPtr_set_CryptoKey_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667546);
			ObscuredPrefs.NativeMethodInfoPtr_get_CryptoKey_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667547);
			ObscuredPrefs.NativeMethodInfoPtr_get_DeviceId_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667548);
			ObscuredPrefs.NativeMethodInfoPtr_set_DeviceId_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667549);
			ObscuredPrefs.NativeMethodInfoPtr_get_DeviceID_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667550);
			ObscuredPrefs.NativeMethodInfoPtr_set_DeviceID_Internal_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667551);
			ObscuredPrefs.NativeMethodInfoPtr_get_DeviceIdHash_Private_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667552);
			ObscuredPrefs.NativeMethodInfoPtr_ForceLockToDeviceInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667553);
			ObscuredPrefs.NativeMethodInfoPtr_SetNewCryptoKey_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667554);
			ObscuredPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667555);
			ObscuredPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667556);
			ObscuredPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667557);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptIntValue_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667558);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptIntValue_Public_Static_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667559);
			ObscuredPrefs.NativeMethodInfoPtr_SetUInt_Public_Static_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667560);
			ObscuredPrefs.NativeMethodInfoPtr_GetUInt_Public_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667561);
			ObscuredPrefs.NativeMethodInfoPtr_GetUInt_Public_Static_UInt32_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667562);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptUIntValue_Public_Static_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667563);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptUIntValue_Public_Static_UInt32_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667564);
			ObscuredPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667565);
			ObscuredPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667566);
			ObscuredPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667567);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptStringValue_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667568);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptStringValue_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667569);
			ObscuredPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667570);
			ObscuredPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667571);
			ObscuredPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667572);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptFloatValue_Public_Static_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667573);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptFloatValue_Public_Static_Single_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667574);
			ObscuredPrefs.NativeMethodInfoPtr_SetDouble_Public_Static_Void_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667575);
			ObscuredPrefs.NativeMethodInfoPtr_GetDouble_Public_Static_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667576);
			ObscuredPrefs.NativeMethodInfoPtr_GetDouble_Public_Static_Double_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667577);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptDoubleValue_Private_Static_String_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667578);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptDoubleValue_Private_Static_Double_String_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667579);
			ObscuredPrefs.NativeMethodInfoPtr_SetDecimal_Public_Static_Void_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667580);
			ObscuredPrefs.NativeMethodInfoPtr_GetDecimal_Public_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667581);
			ObscuredPrefs.NativeMethodInfoPtr_GetDecimal_Public_Static_Decimal_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667582);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptDecimalValue_Private_Static_String_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667583);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptDecimalValue_Private_Static_Decimal_String_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667584);
			ObscuredPrefs.NativeMethodInfoPtr_SetLong_Public_Static_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667585);
			ObscuredPrefs.NativeMethodInfoPtr_GetLong_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667586);
			ObscuredPrefs.NativeMethodInfoPtr_GetLong_Public_Static_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667587);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptLongValue_Private_Static_String_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667588);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptLongValue_Private_Static_Int64_String_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667589);
			ObscuredPrefs.NativeMethodInfoPtr_SetULong_Public_Static_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667590);
			ObscuredPrefs.NativeMethodInfoPtr_GetULong_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667591);
			ObscuredPrefs.NativeMethodInfoPtr_GetULong_Public_Static_UInt64_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667592);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptULongValue_Private_Static_String_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667593);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptULongValue_Private_Static_UInt64_String_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667594);
			ObscuredPrefs.NativeMethodInfoPtr_SetBool_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667595);
			ObscuredPrefs.NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667596);
			ObscuredPrefs.NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667597);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptBoolValue_Private_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667598);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptBoolValue_Private_Static_Boolean_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667599);
			ObscuredPrefs.NativeMethodInfoPtr_SetByteArray_Public_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667600);
			ObscuredPrefs.NativeMethodInfoPtr_GetByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667601);
			ObscuredPrefs.NativeMethodInfoPtr_GetByteArray_Public_Static_Il2CppStructArray_1_Byte_String_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667602);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptByteArrayValue_Private_Static_String_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667603);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptByteArrayValue_Private_Static_Il2CppStructArray_1_Byte_String_String_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667604);
			ObscuredPrefs.NativeMethodInfoPtr_ConstructByteArray_Private_Static_Il2CppStructArray_1_Byte_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667605);
			ObscuredPrefs.NativeMethodInfoPtr_SetVector2_Public_Static_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667606);
			ObscuredPrefs.NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667607);
			ObscuredPrefs.NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667608);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptVector2Value_Private_Static_String_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667609);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptVector2Value_Private_Static_Vector2_String_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667610);
			ObscuredPrefs.NativeMethodInfoPtr_SetVector3_Public_Static_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667611);
			ObscuredPrefs.NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667612);
			ObscuredPrefs.NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667613);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptVector3Value_Private_Static_String_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667614);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptVector3Value_Private_Static_Vector3_String_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667615);
			ObscuredPrefs.NativeMethodInfoPtr_SetQuaternion_Public_Static_Void_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667616);
			ObscuredPrefs.NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667617);
			ObscuredPrefs.NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667618);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptQuaternionValue_Private_Static_String_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667619);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptQuaternionValue_Private_Static_Quaternion_String_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667620);
			ObscuredPrefs.NativeMethodInfoPtr_SetColor_Public_Static_Void_String_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667621);
			ObscuredPrefs.NativeMethodInfoPtr_GetColor_Public_Static_Color32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667622);
			ObscuredPrefs.NativeMethodInfoPtr_GetColor_Public_Static_Color32_String_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667623);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptColorValue_Private_Static_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667624);
			ObscuredPrefs.NativeMethodInfoPtr_SetRect_Public_Static_Void_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667625);
			ObscuredPrefs.NativeMethodInfoPtr_GetRect_Public_Static_Rect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667626);
			ObscuredPrefs.NativeMethodInfoPtr_GetRect_Public_Static_Rect_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667627);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptRectValue_Private_Static_String_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667628);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptRectValue_Private_Static_Rect_String_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667629);
			ObscuredPrefs.NativeMethodInfoPtr_SetRawValue_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667630);
			ObscuredPrefs.NativeMethodInfoPtr_GetRawValue_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667631);
			ObscuredPrefs.NativeMethodInfoPtr_GetRawValueType_Public_Static_DataType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667632);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptKey_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667633);
			ObscuredPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667634);
			ObscuredPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667635);
			ObscuredPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667636);
			ObscuredPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667637);
			ObscuredPrefs.NativeMethodInfoPtr_GetEncryptedPrefsString_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667638);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptData_Private_Static_String_String_Il2CppStructArray_1_Byte_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667639);
			ObscuredPrefs.NativeMethodInfoPtr_DecryptData_Internal_Static_Il2CppStructArray_1_Byte_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667640);
			ObscuredPrefs.NativeMethodInfoPtr_CalculateChecksum_Private_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667641);
			ObscuredPrefs.NativeMethodInfoPtr_SavesTampered_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667642);
			ObscuredPrefs.NativeMethodInfoPtr_PossibleForeignSavesDetected_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667643);
			ObscuredPrefs.NativeMethodInfoPtr_GetDeviceId_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667644);
			ObscuredPrefs.NativeMethodInfoPtr_EncryptDecryptBytes_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667645);
			ObscuredPrefs.NativeMethodInfoPtr_DeprecatedDecryptValue_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667646);
			ObscuredPrefs.NativeMethodInfoPtr_DeprecatedCalculateChecksum_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667647);
			ObscuredPrefs.NativeMethodInfoPtr_get_DeprecatedDeviceId_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredPrefs>.NativeClassPtr, 100667648);
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x00079264 File Offset: 0x00077464
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0007922C File Offset: 0x0007742C
		public unsafe static string CryptoKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24018, XrefRangeEnd = 24022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_get_CryptoKey_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24014, XrefRangeEnd = 24018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_set_CryptoKey_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x00079290 File Offset: 0x00077490
		// (set) Token: 0x06001A9C RID: 6812 RVA: 0x000792BC File Offset: 0x000774BC
		public unsafe static string DeviceId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 24032, RefRangeEnd = 24035, XrefRangeStart = 24022, XrefRangeEnd = 24032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_get_DeviceId_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24035, XrefRangeEnd = 24039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_set_DeviceId_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x000792F4 File Offset: 0x000774F4
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x00079320 File Offset: 0x00077520
		public unsafe static string DeviceID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24039, XrefRangeEnd = 24043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_get_DeviceID_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24043, XrefRangeEnd = 24051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_set_DeviceID_Internal_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x00079358 File Offset: 0x00077558
		public unsafe static uint DeviceIdHash
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 24062, RefRangeEnd = 24064, XrefRangeStart = 24051, XrefRangeEnd = 24062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_get_DeviceIdHash_Private_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00079388 File Offset: 0x00077588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24064, XrefRangeEnd = 24080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceLockToDeviceInit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_ForceLockToDeviceInit_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x000793B0 File Offset: 0x000775B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24080, XrefRangeEnd = 24088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(string newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetNewCryptoKey_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x000793E8 File Offset: 0x000775E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24104, RefRangeEnd = 24106, XrefRangeStart = 24088, XrefRangeEnd = 24104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInt(string key, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0007942C File Offset: 0x0007762C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24106, XrefRangeEnd = 24110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00079470 File Offset: 0x00077670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24126, RefRangeEnd = 24127, XrefRangeStart = 24110, XrefRangeEnd = 24126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt(string key, int defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000794C0 File Offset: 0x000776C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24127, XrefRangeEnd = 24138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptIntValue(string key, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptIntValue_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0007950C File Offset: 0x0007770C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24138, XrefRangeEnd = 24156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptIntValue_Public_Static_Int32_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00079570 File Offset: 0x00077770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24156, XrefRangeEnd = 24169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUInt(string key, uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetUInt_Public_Static_Void_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000795B4 File Offset: 0x000777B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24169, XrefRangeEnd = 24183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetUInt(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetUInt_Public_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x000795F8 File Offset: 0x000777F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24183, XrefRangeEnd = 24193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetUInt(string key, uint defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetUInt_Public_Static_UInt32_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00079648 File Offset: 0x00077848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24193, XrefRangeEnd = 24201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptUIntValue(string key, uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptUIntValue_Public_Static_String_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00079694 File Offset: 0x00077894
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 24211, RefRangeEnd = 24215, XrefRangeStart = 24201, XrefRangeEnd = 24211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptUIntValue_Public_Static_UInt32_String_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x000796F8 File Offset: 0x000778F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24226, RefRangeEnd = 24227, XrefRangeStart = 24215, XrefRangeEnd = 24226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetString(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00079740 File Offset: 0x00077940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24227, XrefRangeEnd = 24233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0007977C File Offset: 0x0007797C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24249, RefRangeEnd = 24250, XrefRangeStart = 24233, XrefRangeEnd = 24249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string key, string defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x000797CC File Offset: 0x000779CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24250, XrefRangeEnd = 24256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptStringValue(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptStringValue_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0007981C File Offset: 0x00077A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24256, XrefRangeEnd = 24263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptStringValue_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0007987C File Offset: 0x00077A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24276, RefRangeEnd = 24278, XrefRangeStart = 24263, XrefRangeEnd = 24276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFloat(string key, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x000798C0 File Offset: 0x00077AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24278, XrefRangeEnd = 24282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFloat(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00079904 File Offset: 0x00077B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24298, RefRangeEnd = 24299, XrefRangeStart = 24282, XrefRangeEnd = 24298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFloat(string key, float defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00079954 File Offset: 0x00077B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24299, XrefRangeEnd = 24307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptFloatValue(string key, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptFloatValue_Public_Static_String_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000799A0 File Offset: 0x00077BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24307, XrefRangeEnd = 24325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptFloatValue_Public_Static_Single_String_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00079A04 File Offset: 0x00077C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24325, XrefRangeEnd = 24345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDouble(string key, double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetDouble_Public_Static_Void_String_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00079A48 File Offset: 0x00077C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24345, XrefRangeEnd = 24359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetDouble(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetDouble_Public_Static_Double_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00079A8C File Offset: 0x00077C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24359, XrefRangeEnd = 24369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetDouble(string key, double defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetDouble_Public_Static_Double_String_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00079ADC File Offset: 0x00077CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24369, XrefRangeEnd = 24384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptDoubleValue(string key, double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptDoubleValue_Private_Static_String_String_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x00079B28 File Offset: 0x00077D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24399, RefRangeEnd = 24401, XrefRangeStart = 24384, XrefRangeEnd = 24399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptDoubleValue_Private_Static_Double_String_String_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00079B8C File Offset: 0x00077D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24401, XrefRangeEnd = 24407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDecimal(string key, Decimal value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetDecimal_Public_Static_Void_String_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00079BD0 File Offset: 0x00077DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24407, XrefRangeEnd = 24425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal GetDecimal(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetDecimal_Public_Static_Decimal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00079C14 File Offset: 0x00077E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24425, XrefRangeEnd = 24436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal GetDecimal(string key, Decimal defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetDecimal_Public_Static_Decimal_String_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00079C64 File Offset: 0x00077E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24461, RefRangeEnd = 24462, XrefRangeStart = 24436, XrefRangeEnd = 24461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptDecimalValue(string key, Decimal value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptDecimalValue_Private_Static_String_String_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00079CB0 File Offset: 0x00077EB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24477, RefRangeEnd = 24479, XrefRangeStart = 24462, XrefRangeEnd = 24477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal DecryptDecimalValue(string key, string encryptedInput, Decimal defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptDecimalValue_Private_Static_Decimal_String_String_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00079D14 File Offset: 0x00077F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24479, XrefRangeEnd = 24495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLong(string key, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetLong_Public_Static_Void_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00079D58 File Offset: 0x00077F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24495, XrefRangeEnd = 24509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLong(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetLong_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00079D9C File Offset: 0x00077F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24509, XrefRangeEnd = 24519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLong(string key, long defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetLong_Public_Static_Int64_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00079DEC File Offset: 0x00077FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24519, XrefRangeEnd = 24530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptLongValue(string key, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptLongValue_Private_Static_String_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00079E38 File Offset: 0x00078038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24563, RefRangeEnd = 24565, XrefRangeStart = 24530, XrefRangeEnd = 24563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptLongValue_Private_Static_Int64_String_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00079E9C File Offset: 0x0007809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24565, XrefRangeEnd = 24585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetULong(string key, ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetULong_Public_Static_Void_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00079EE0 File Offset: 0x000780E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24585, XrefRangeEnd = 24599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong GetULong(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetULong_Public_Static_UInt64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00079F24 File Offset: 0x00078124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24599, XrefRangeEnd = 24609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong GetULong(string key, ulong defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetULong_Public_Static_UInt64_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00079F74 File Offset: 0x00078174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24609, XrefRangeEnd = 24624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptULongValue(string key, ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptULongValue_Private_Static_String_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00079FC0 File Offset: 0x000781C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24661, RefRangeEnd = 24663, XrefRangeStart = 24624, XrefRangeEnd = 24661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong DecryptULongValue(string key, string encryptedInput, ulong defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptULongValue_Private_Static_UInt64_String_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0007A024 File Offset: 0x00078224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24663, XrefRangeEnd = 24681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBool(string key, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetBool_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0007A068 File Offset: 0x00078268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24681, XrefRangeEnd = 24695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetBool(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0007A0AC File Offset: 0x000782AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24695, XrefRangeEnd = 24705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetBool(string key, bool defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0007A0FC File Offset: 0x000782FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24705, XrefRangeEnd = 24718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptBoolValue(string key, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptBoolValue_Private_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0007A148 File Offset: 0x00078348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24727, RefRangeEnd = 24729, XrefRangeStart = 24718, XrefRangeEnd = 24727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptBoolValue_Private_Static_Boolean_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0007A1AC File Offset: 0x000783AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24729, XrefRangeEnd = 24738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetByteArray(string key, Il2CppStructArray<byte> value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetByteArray_Public_Static_Void_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0007A1F4 File Offset: 0x000783F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24738, XrefRangeEnd = 24752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetByteArray(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0007A238 File Offset: 0x00078438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24752, XrefRangeEnd = 24766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetByteArray_Public_Static_Il2CppStructArray_1_Byte_String_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0007A298 File Offset: 0x00078498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24766, XrefRangeEnd = 24770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptByteArrayValue(string key, Il2CppStructArray<byte> value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptByteArrayValue_Private_Static_String_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0007A2E8 File Offset: 0x000784E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24779, RefRangeEnd = 24781, XrefRangeStart = 24770, XrefRangeEnd = 24779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptByteArrayValue_Private_Static_Il2CppStructArray_1_Byte_String_String_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0007A35C File Offset: 0x0007855C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24784, RefRangeEnd = 24786, XrefRangeStart = 24781, XrefRangeEnd = 24784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ConstructByteArray(byte value, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_ConstructByteArray_Private_Static_Il2CppStructArray_1_Byte_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0007A3AC File Offset: 0x000785AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24786, XrefRangeEnd = 24792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVector2(string key, Vector2 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetVector2_Public_Static_Void_String_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0007A3F0 File Offset: 0x000785F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24792, XrefRangeEnd = 24808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetVector2(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0007A434 File Offset: 0x00078634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24808, XrefRangeEnd = 24818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0007A484 File Offset: 0x00078684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24872, RefRangeEnd = 24873, XrefRangeStart = 24818, XrefRangeEnd = 24872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptVector2Value(string key, Vector2 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptVector2Value_Private_Static_String_String_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0007A4D0 File Offset: 0x000786D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24886, RefRangeEnd = 24888, XrefRangeStart = 24873, XrefRangeEnd = 24886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptVector2Value_Private_Static_Vector2_String_String_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0007A534 File Offset: 0x00078734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24888, XrefRangeEnd = 24894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVector3(string key, Vector3 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetVector3_Public_Static_Void_String_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x0007A578 File Offset: 0x00078778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24894, XrefRangeEnd = 24911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetVector3(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0007A5BC File Offset: 0x000787BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24911, XrefRangeEnd = 24922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0007A60C File Offset: 0x0007880C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24995, RefRangeEnd = 24996, XrefRangeStart = 24922, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptVector3Value(string key, Vector3 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptVector3Value_Private_Static_String_String_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0007A658 File Offset: 0x00078858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25010, RefRangeEnd = 25012, XrefRangeStart = 24996, XrefRangeEnd = 25010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptVector3Value_Private_Static_Vector3_String_String_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0007A6BC File Offset: 0x000788BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25012, XrefRangeEnd = 25018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetQuaternion(string key, Quaternion value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetQuaternion_Public_Static_Void_String_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0007A700 File Offset: 0x00078900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25018, XrefRangeEnd = 25034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion GetQuaternion(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0007A744 File Offset: 0x00078944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25034, XrefRangeEnd = 25045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0007A794 File Offset: 0x00078994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25137, RefRangeEnd = 25139, XrefRangeStart = 25045, XrefRangeEnd = 25137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptQuaternionValue(string key, Quaternion value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptQuaternionValue_Private_Static_String_String_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0007A7E0 File Offset: 0x000789E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25179, RefRangeEnd = 25181, XrefRangeStart = 25139, XrefRangeEnd = 25179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptQuaternionValue_Private_Static_Quaternion_String_String_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0007A844 File Offset: 0x00078A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25181, XrefRangeEnd = 25194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetColor(string key, Color32 value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetColor_Public_Static_Void_String_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0007A888 File Offset: 0x00078A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25194, XrefRangeEnd = 25208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GetColor(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetColor_Public_Static_Color32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0007A8CC File Offset: 0x00078ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25208, XrefRangeEnd = 25218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GetColor(string key, Color32 defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetColor_Public_Static_Color32_String_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0007A91C File Offset: 0x00078B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25218, XrefRangeEnd = 25226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptColorValue(string key, uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptColorValue_Private_Static_String_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0007A968 File Offset: 0x00078B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25226, XrefRangeEnd = 25232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRect(string key, Rect value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetRect_Public_Static_Void_String_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0007A9AC File Offset: 0x00078BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25232, XrefRangeEnd = 25246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetRect(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetRect_Public_Static_Rect_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0007A9F0 File Offset: 0x00078BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25246, XrefRangeEnd = 25257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetRect(string key, Rect defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetRect_Public_Static_Rect_String_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0007AA40 File Offset: 0x00078C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25349, RefRangeEnd = 25351, XrefRangeStart = 25257, XrefRangeEnd = 25349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptRectValue(string key, Rect value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptRectValue_Private_Static_String_String_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0007AA8C File Offset: 0x00078C8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25391, RefRangeEnd = 25393, XrefRangeStart = 25351, XrefRangeEnd = 25391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptRectValue_Private_Static_Rect_String_String_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0007AAF0 File Offset: 0x00078CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25393, XrefRangeEnd = 25398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRawValue(string key, string encryptedValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SetRawValue_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0007AB38 File Offset: 0x00078D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25398, XrefRangeEnd = 25403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRawValue(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetRawValue_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0007AB74 File Offset: 0x00078D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25403, XrefRangeEnd = 25411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredPrefs.DataType GetRawValueType(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetRawValueType_Public_Static_DataType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0007ABB8 File Offset: 0x00078DB8
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 25428, RefRangeEnd = 25477, XrefRangeStart = 25411, XrefRangeEnd = 25428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptKey_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0007ABF4 File Offset: 0x00078DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25477, XrefRangeEnd = 25480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0007AC38 File Offset: 0x00078E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25480, XrefRangeEnd = 25489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0007AC70 File Offset: 0x00078E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25489, XrefRangeEnd = 25493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0007AC98 File Offset: 0x00078E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25493, XrefRangeEnd = 25497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Save()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0007ACC0 File Offset: 0x00078EC0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 25515, RefRangeEnd = 25539, XrefRangeStart = 25497, XrefRangeEnd = 25515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetEncryptedPrefsString_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0007AD10 File Offset: 0x00078F10
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 25571, RefRangeEnd = 25598, XrefRangeStart = 25539, XrefRangeEnd = 25571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptData(string key, Il2CppStructArray<byte> cleanBytes, ObscuredPrefs.DataType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cleanBytes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptData_Private_Static_String_String_Il2CppStructArray_1_Byte_DataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0007AD6C File Offset: 0x00078F6C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25643, RefRangeEnd = 25657, XrefRangeStart = 25598, XrefRangeEnd = 25643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> DecryptData(string key, string encryptedInput)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encryptedInput);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DecryptData_Internal_Static_Il2CppStructArray_1_Byte_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0007ADC4 File Offset: 0x00078FC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25667, XrefRangeStart = 25657, XrefRangeEnd = 25665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint CalculateChecksum(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_CalculateChecksum_Private_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0007AE08 File Offset: 0x00079008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25675, RefRangeEnd = 25676, XrefRangeStart = 25667, XrefRangeEnd = 25675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SavesTampered()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_SavesTampered_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0007AE30 File Offset: 0x00079030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25686, RefRangeEnd = 25688, XrefRangeStart = 25676, XrefRangeEnd = 25686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PossibleForeignSavesDetected()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_PossibleForeignSavesDetected_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0007AE58 File Offset: 0x00079058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25692, RefRangeEnd = 25694, XrefRangeStart = 25688, XrefRangeEnd = 25692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_GetDeviceId_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0007AE84 File Offset: 0x00079084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25697, RefRangeEnd = 25699, XrefRangeStart = 25694, XrefRangeEnd = 25697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> EncryptDecryptBytes(Il2CppStructArray<byte> bytes, int dataLength, string key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_EncryptDecryptBytes_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0007AEE8 File Offset: 0x000790E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 25750, RefRangeEnd = 25756, XrefRangeStart = 25699, XrefRangeEnd = 25750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DeprecatedDecryptValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DeprecatedDecryptValue_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0007AF24 File Offset: 0x00079124
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 25770, RefRangeEnd = 25774, XrefRangeStart = 25756, XrefRangeEnd = 25770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DeprecatedCalculateChecksum(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_DeprecatedCalculateChecksum_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0007AF60 File Offset: 0x00079160
		public unsafe static string DeprecatedDeviceId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 25785, RefRangeEnd = 25787, XrefRangeStart = 25774, XrefRangeEnd = 25785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredPrefs.NativeMethodInfoPtr_get_DeprecatedDeviceId_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0000A0B6 File Offset: 0x000082B6
		public ObscuredPrefs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0007AF8C File Offset: 0x0007918C
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0000A0BF File Offset: 0x000082BF
		public unsafe static byte Version
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_Version, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_Version, (void*)(&value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0007AFA8 File Offset: 0x000791A8
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0000A0CD File Offset: 0x000082CD
		public unsafe static string RawNotFound
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_RawNotFound, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_RawNotFound, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0007AFC8 File Offset: 0x000791C8
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0000A0DF File Offset: 0x000082DF
		public unsafe static string DataSeparator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_DataSeparator, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_DataSeparator, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0007AFE8 File Offset: 0x000791E8
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x0000A0F1 File Offset: 0x000082F1
		public unsafe static bool foreignSavesReported
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_foreignSavesReported, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_foreignSavesReported, (void*)(&value));
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0007B004 File Offset: 0x00079204
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x0000A0FF File Offset: 0x000082FF
		public unsafe static string cryptoKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_cryptoKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_cryptoKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0007B024 File Offset: 0x00079224
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x0000A111 File Offset: 0x00008311
		public unsafe static string deviceId
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_deviceId, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_deviceId, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x0007B044 File Offset: 0x00079244
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0000A123 File Offset: 0x00008323
		public unsafe static uint deviceIdHash
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_deviceIdHash, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_deviceIdHash, (void*)(&value));
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0007B060 File Offset: 0x00079260
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0000A131 File Offset: 0x00008331
		public unsafe static Action onAlterationDetected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_onAlterationDetected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_onAlterationDetected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x0007B088 File Offset: 0x00079288
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x0000A143 File Offset: 0x00008343
		public unsafe static bool preservePlayerPrefs
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_preservePlayerPrefs, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_preservePlayerPrefs, (void*)(&value));
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x0007B0A4 File Offset: 0x000792A4
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x0000A151 File Offset: 0x00008351
		public unsafe static Action onPossibleForeignSavesDetected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_onPossibleForeignSavesDetected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_onPossibleForeignSavesDetected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x0007B0CC File Offset: 0x000792CC
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x0000A163 File Offset: 0x00008363
		public unsafe static ObscuredPrefs.DeviceLockLevel lockToDevice
		{
			get
			{
				ObscuredPrefs.DeviceLockLevel deviceLockLevel;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_lockToDevice, (void*)(&deviceLockLevel));
				return deviceLockLevel;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_lockToDevice, (void*)(&value));
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x0007B0E8 File Offset: 0x000792E8
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x0000A171 File Offset: 0x00008371
		public unsafe static bool readForeignSaves
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_readForeignSaves, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_readForeignSaves, (void*)(&value));
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0007B104 File Offset: 0x00079304
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0000A17F File Offset: 0x0000837F
		public unsafe static bool emergencyMode
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_emergencyMode, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_emergencyMode, (void*)(&value));
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0007B120 File Offset: 0x00079320
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x0000A18D File Offset: 0x0000838D
		public unsafe static char DEPRECATED_RAW_SEPARATOR
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_DEPRECATED_RAW_SEPARATOR, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_DEPRECATED_RAW_SEPARATOR, (void*)(&value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x0007B13C File Offset: 0x0007933C
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0000A19B File Offset: 0x0000839B
		public unsafe static string deprecatedDeviceId
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredPrefs.NativeFieldInfoPtr_deprecatedDeviceId, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredPrefs.NativeFieldInfoPtr_deprecatedDeviceId, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeFieldInfoPtr_RawNotFound;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeFieldInfoPtr_DataSeparator;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeFieldInfoPtr_foreignSavesReported;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeFieldInfoPtr_deviceId;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeFieldInfoPtr_deviceIdHash;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeFieldInfoPtr_onAlterationDetected;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeFieldInfoPtr_preservePlayerPrefs;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeFieldInfoPtr_onPossibleForeignSavesDetected;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeFieldInfoPtr_lockToDevice;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeFieldInfoPtr_readForeignSaves;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeFieldInfoPtr_emergencyMode;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeFieldInfoPtr_DEPRECATED_RAW_SEPARATOR;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeFieldInfoPtr_deprecatedDeviceId;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_set_CryptoKey_Public_Static_set_Void_String_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_get_CryptoKey_Public_Static_get_String_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceId_Public_Static_get_String_0;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceId_Public_Static_set_Void_String_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceID_Internal_Static_get_String_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceID_Internal_Static_set_Void_String_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceIdHash_Private_Static_get_UInt32_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_ForceLockToDeviceInit_Public_Static_Void_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Internal_Static_Void_String_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_0;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeMethodInfoPtr_EncryptIntValue_Public_Static_String_String_Int32_0;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeMethodInfoPtr_DecryptIntValue_Public_Static_Int32_String_String_Int32_0;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeMethodInfoPtr_SetUInt_Public_Static_Void_String_UInt32_0;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeMethodInfoPtr_GetUInt_Public_Static_UInt32_String_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeMethodInfoPtr_GetUInt_Public_Static_UInt32_String_UInt32_0;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeMethodInfoPtr_EncryptUIntValue_Public_Static_String_String_UInt32_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr_DecryptUIntValue_Public_Static_UInt32_String_String_UInt32_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_EncryptStringValue_Public_Static_String_String_String_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_DecryptStringValue_Public_Static_String_String_String_String_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_EncryptFloatValue_Public_Static_String_String_Single_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_DecryptFloatValue_Public_Static_Single_String_String_Single_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_SetDouble_Public_Static_Void_String_Double_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr_GetDouble_Public_Static_Double_String_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_GetDouble_Public_Static_Double_String_Double_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDoubleValue_Private_Static_String_String_Double_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_DecryptDoubleValue_Private_Static_Double_String_String_Double_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_SetDecimal_Public_Static_Void_String_Decimal_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_GetDecimal_Public_Static_Decimal_String_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_GetDecimal_Public_Static_Decimal_String_Decimal_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecimalValue_Private_Static_String_String_Decimal_0;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeMethodInfoPtr_DecryptDecimalValue_Private_Static_Decimal_String_String_Decimal_0;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeMethodInfoPtr_SetLong_Public_Static_Void_String_Int64_0;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeMethodInfoPtr_GetLong_Public_Static_Int64_String_0;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeMethodInfoPtr_GetLong_Public_Static_Int64_String_Int64_0;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeMethodInfoPtr_EncryptLongValue_Private_Static_String_String_Int64_0;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeMethodInfoPtr_DecryptLongValue_Private_Static_Int64_String_String_Int64_0;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeMethodInfoPtr_SetULong_Public_Static_Void_String_UInt64_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr_GetULong_Public_Static_UInt64_String_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_GetULong_Public_Static_UInt64_String_UInt64_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_EncryptULongValue_Private_Static_String_String_UInt64_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_DecryptULongValue_Private_Static_UInt64_String_String_UInt64_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Static_Void_String_Boolean_0;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_0;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_Boolean_0;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeMethodInfoPtr_EncryptBoolValue_Private_Static_String_String_Boolean_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr_DecryptBoolValue_Private_Static_Boolean_String_String_Boolean_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_SetByteArray_Public_Static_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_GetByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_GetByteArray_Public_Static_Il2CppStructArray_1_Byte_String_Byte_Int32_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_EncryptByteArrayValue_Private_Static_String_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_DecryptByteArrayValue_Private_Static_Il2CppStructArray_1_Byte_String_String_Byte_Int32_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr_ConstructByteArray_Private_Static_Il2CppStructArray_1_Byte_Byte_Int32_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr_SetVector2_Public_Static_Void_String_Vector2_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_Vector2_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_EncryptVector2Value_Private_Static_String_String_Vector2_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_DecryptVector2Value_Private_Static_Vector2_String_String_Vector2_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_SetVector3_Public_Static_Void_String_Vector3_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_Vector3_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_EncryptVector3Value_Private_Static_String_String_Vector3_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_DecryptVector3Value_Private_Static_Vector3_String_String_Vector3_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_SetQuaternion_Public_Static_Void_String_Quaternion_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_Quaternion_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_EncryptQuaternionValue_Private_Static_String_String_Quaternion_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_DecryptQuaternionValue_Private_Static_Quaternion_String_String_Quaternion_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_String_Color32_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color32_String_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color32_String_Color32_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_EncryptColorValue_Private_Static_String_String_UInt32_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_SetRect_Public_Static_Void_String_Rect_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr_GetRect_Public_Static_Rect_String_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr_GetRect_Public_Static_Rect_String_Rect_0;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_EncryptRectValue_Private_Static_String_String_Rect_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeMethodInfoPtr_DecryptRectValue_Private_Static_Rect_String_String_Rect_0;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeMethodInfoPtr_SetRawValue_Public_Static_Void_String_String_0;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr_GetRawValue_Public_Static_String_String_0;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr_GetRawValueType_Public_Static_DataType_String_0;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeMethodInfoPtr_EncryptKey_Public_Static_String_String_0;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_0;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr_GetEncryptedPrefsString_Private_Static_String_String_String_0;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeMethodInfoPtr_EncryptData_Private_Static_String_String_Il2CppStructArray_1_Byte_DataType_0;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr_DecryptData_Internal_Static_Il2CppStructArray_1_Byte_String_String_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr_CalculateChecksum_Private_Static_UInt32_String_0;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeMethodInfoPtr_SavesTampered_Private_Static_Void_0;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr_PossibleForeignSavesDetected_Private_Static_Void_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceId_Private_Static_String_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecryptBytes_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_String_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_DeprecatedDecryptValue_Private_Static_String_String_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_DeprecatedCalculateChecksum_Private_Static_String_String_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_get_DeprecatedDeviceId_Private_Static_get_String_0;

		// Token: 0x020002BB RID: 699
		[OriginalName("Assembly-CSharp-firstpass.dll", "", "DataType")]
		public enum DataType : byte
		{
			// Token: 0x0400229D RID: 8861
			Unknown,
			// Token: 0x0400229E RID: 8862
			Int = 5,
			// Token: 0x0400229F RID: 8863
			UInt = 10,
			// Token: 0x040022A0 RID: 8864
			String = 15,
			// Token: 0x040022A1 RID: 8865
			Float = 20,
			// Token: 0x040022A2 RID: 8866
			Double = 25,
			// Token: 0x040022A3 RID: 8867
			Decimal = 27,
			// Token: 0x040022A4 RID: 8868
			Long = 30,
			// Token: 0x040022A5 RID: 8869
			ULong = 32,
			// Token: 0x040022A6 RID: 8870
			Bool = 35,
			// Token: 0x040022A7 RID: 8871
			ByteArray = 40,
			// Token: 0x040022A8 RID: 8872
			Vector2 = 45,
			// Token: 0x040022A9 RID: 8873
			Vector3 = 50,
			// Token: 0x040022AA RID: 8874
			Quaternion = 55,
			// Token: 0x040022AB RID: 8875
			Color = 60,
			// Token: 0x040022AC RID: 8876
			Rect = 65
		}

		// Token: 0x020002BC RID: 700
		[OriginalName("Assembly-CSharp-firstpass.dll", "", "DeviceLockLevel")]
		public enum DeviceLockLevel : byte
		{
			// Token: 0x040022AE RID: 8878
			None,
			// Token: 0x040022AF RID: 8879
			Soft,
			// Token: 0x040022B0 RID: 8880
			Strict
		}
	}
}
