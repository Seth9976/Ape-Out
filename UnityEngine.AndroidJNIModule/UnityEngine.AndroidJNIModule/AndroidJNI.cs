using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public static class AndroidJNI : Object
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00005AB0 File Offset: 0x00003CB0
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJNI()
		{
			Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr);
			AndroidJNI.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663386);
			AndroidJNI.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663387);
			AndroidJNI.NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663388);
			AndroidJNI.NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663389);
			AndroidJNI.NativeMethodInfoPtr_PushLocalFrame_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663390);
			AndroidJNI.NativeMethodInfoPtr_PopLocalFrame_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663391);
			AndroidJNI.NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663392);
			AndroidJNI.NativeMethodInfoPtr_DeleteGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663393);
			AndroidJNI.NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663394);
			AndroidJNI.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663395);
			AndroidJNI.NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663396);
			AndroidJNI.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663397);
			AndroidJNI.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663398);
			AndroidJNI.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663399);
			AndroidJNI.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663400);
			AndroidJNI.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663401);
			AndroidJNI.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663402);
			AndroidJNI.NativeMethodInfoPtr_GetStaticFieldID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663403);
			AndroidJNI.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663404);
			AndroidJNI.NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663405);
			AndroidJNI.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663406);
			AndroidJNI.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663407);
			AndroidJNI.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663408);
			AndroidJNI.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663409);
			AndroidJNI.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663410);
			AndroidJNI.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663411);
			AndroidJNI.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663412);
			AndroidJNI.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663413);
			AndroidJNI.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663414);
			AndroidJNI.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663415);
			AndroidJNI.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663416);
			AndroidJNI.NativeMethodInfoPtr_GetStringField_Public_Static_String_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663417);
			AndroidJNI.NativeMethodInfoPtr_GetObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663418);
			AndroidJNI.NativeMethodInfoPtr_GetBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663419);
			AndroidJNI.NativeMethodInfoPtr_GetSByteField_Public_Static_SByte_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663420);
			AndroidJNI.NativeMethodInfoPtr_GetCharField_Public_Static_Char_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663421);
			AndroidJNI.NativeMethodInfoPtr_GetShortField_Public_Static_Int16_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663422);
			AndroidJNI.NativeMethodInfoPtr_GetIntField_Public_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663423);
			AndroidJNI.NativeMethodInfoPtr_GetLongField_Public_Static_Int64_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663424);
			AndroidJNI.NativeMethodInfoPtr_GetFloatField_Public_Static_Single_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663425);
			AndroidJNI.NativeMethodInfoPtr_GetDoubleField_Public_Static_Double_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663426);
			AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663427);
			AndroidJNI.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663428);
			AndroidJNI.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663429);
			AndroidJNI.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663430);
			AndroidJNI.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663431);
			AndroidJNI.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663432);
			AndroidJNI.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663433);
			AndroidJNI.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663434);
			AndroidJNI.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663435);
			AndroidJNI.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663436);
			AndroidJNI.NativeMethodInfoPtr_CallStaticVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663437);
			AndroidJNI.NativeMethodInfoPtr_GetStaticStringField_Public_Static_String_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663438);
			AndroidJNI.NativeMethodInfoPtr_GetStaticObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663439);
			AndroidJNI.NativeMethodInfoPtr_GetStaticBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663440);
			AndroidJNI.NativeMethodInfoPtr_GetStaticSByteField_Public_Static_SByte_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663441);
			AndroidJNI.NativeMethodInfoPtr_GetStaticCharField_Public_Static_Char_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663442);
			AndroidJNI.NativeMethodInfoPtr_GetStaticShortField_Public_Static_Int16_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663443);
			AndroidJNI.NativeMethodInfoPtr_GetStaticIntField_Public_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663444);
			AndroidJNI.NativeMethodInfoPtr_GetStaticLongField_Public_Static_Int64_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663445);
			AndroidJNI.NativeMethodInfoPtr_GetStaticFloatField_Public_Static_Single_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663446);
			AndroidJNI.NativeMethodInfoPtr_GetStaticDoubleField_Public_Static_Double_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663447);
			AndroidJNI.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663448);
			AndroidJNI.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663449);
			AndroidJNI.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663450);
			AndroidJNI.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663451);
			AndroidJNI.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663452);
			AndroidJNI.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663453);
			AndroidJNI.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663454);
			AndroidJNI.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663455);
			AndroidJNI.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663456);
			AndroidJNI.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663457);
			AndroidJNI.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663458);
			AndroidJNI.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663459);
			AndroidJNI.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663460);
			AndroidJNI.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663461);
			AndroidJNI.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663462);
			AndroidJNI.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663463);
			AndroidJNI.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663464);
			AndroidJNI.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663465);
			AndroidJNI.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663466);
			AndroidJNI.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663467);
			AndroidJNI.NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663468);
			AndroidJNI.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663469);
			AndroidJNI.NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663470);
			AndroidJNI.AttachCurrentThreadDelegateField = IL2CPP.ResolveICall<AndroidJNI.AttachCurrentThreadDelegate>("UnityEngine.AndroidJNI::AttachCurrentThread");
			AndroidJNI.DetachCurrentThreadDelegateField = IL2CPP.ResolveICall<AndroidJNI.DetachCurrentThreadDelegate>("UnityEngine.AndroidJNI::DetachCurrentThread");
			AndroidJNI.GetVersionDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetVersionDelegate>("UnityEngine.AndroidJNI::GetVersion");
			AndroidJNI.FromReflectedFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.FromReflectedFieldDelegate>("UnityEngine.AndroidJNI::FromReflectedField");
			AndroidJNI.ToReflectedMethodDelegateField = IL2CPP.ResolveICall<AndroidJNI.ToReflectedMethodDelegate>("UnityEngine.AndroidJNI::ToReflectedMethod");
			AndroidJNI.ToReflectedFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.ToReflectedFieldDelegate>("UnityEngine.AndroidJNI::ToReflectedField");
			AndroidJNI.GetSuperclassDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetSuperclassDelegate>("UnityEngine.AndroidJNI::GetSuperclass");
			AndroidJNI.IsAssignableFromDelegateField = IL2CPP.ResolveICall<AndroidJNI.IsAssignableFromDelegate>("UnityEngine.AndroidJNI::IsAssignableFrom");
			AndroidJNI.ThrowDelegateField = IL2CPP.ResolveICall<AndroidJNI.ThrowDelegate>("UnityEngine.AndroidJNI::Throw");
			AndroidJNI.ThrowNewDelegateField = IL2CPP.ResolveICall<AndroidJNI.ThrowNewDelegate>("UnityEngine.AndroidJNI::ThrowNew");
			AndroidJNI.ExceptionDescribeDelegateField = IL2CPP.ResolveICall<AndroidJNI.ExceptionDescribeDelegate>("UnityEngine.AndroidJNI::ExceptionDescribe");
			AndroidJNI.FatalErrorDelegateField = IL2CPP.ResolveICall<AndroidJNI.FatalErrorDelegate>("UnityEngine.AndroidJNI::FatalError");
			AndroidJNI.IsSameObjectDelegateField = IL2CPP.ResolveICall<AndroidJNI.IsSameObjectDelegate>("UnityEngine.AndroidJNI::IsSameObject");
			AndroidJNI.EnsureLocalCapacityDelegateField = IL2CPP.ResolveICall<AndroidJNI.EnsureLocalCapacityDelegate>("UnityEngine.AndroidJNI::EnsureLocalCapacity");
			AndroidJNI.AllocObjectDelegateField = IL2CPP.ResolveICall<AndroidJNI.AllocObjectDelegate>("UnityEngine.AndroidJNI::AllocObject");
			AndroidJNI.IsInstanceOfDelegateField = IL2CPP.ResolveICall<AndroidJNI.IsInstanceOfDelegate>("UnityEngine.AndroidJNI::IsInstanceOf");
			AndroidJNI.NewStringDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewStringDelegate>("UnityEngine.AndroidJNI::NewString");
			AndroidJNI.NewStringUTFDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewStringUTFDelegate>("UnityEngine.AndroidJNI::NewStringUTF");
			AndroidJNI.GetStringLengthDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringLengthDelegate>("UnityEngine.AndroidJNI::GetStringLength");
			AndroidJNI.GetStringUTFLengthDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringUTFLengthDelegate>("UnityEngine.AndroidJNI::GetStringUTFLength");
			AndroidJNI.GetStringUTFCharsDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringUTFCharsDelegate>("UnityEngine.AndroidJNI::GetStringUTFChars");
			AndroidJNI.CallVoidMethodDelegateField = IL2CPP.ResolveICall<AndroidJNI.CallVoidMethodDelegate>("UnityEngine.AndroidJNI::CallVoidMethod");
			AndroidJNI.SetStringFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStringFieldDelegate>("UnityEngine.AndroidJNI::SetStringField");
			AndroidJNI.SetObjectFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetObjectFieldDelegate>("UnityEngine.AndroidJNI::SetObjectField");
			AndroidJNI.SetBooleanFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetBooleanFieldDelegate>("UnityEngine.AndroidJNI::SetBooleanField");
			AndroidJNI.SetSByteFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetSByteFieldDelegate>("UnityEngine.AndroidJNI::SetSByteField");
			AndroidJNI.SetCharFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetCharFieldDelegate>("UnityEngine.AndroidJNI::SetCharField");
			AndroidJNI.SetShortFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetShortFieldDelegate>("UnityEngine.AndroidJNI::SetShortField");
			AndroidJNI.SetIntFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetIntFieldDelegate>("UnityEngine.AndroidJNI::SetIntField");
			AndroidJNI.SetLongFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetLongFieldDelegate>("UnityEngine.AndroidJNI::SetLongField");
			AndroidJNI.SetFloatFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetFloatFieldDelegate>("UnityEngine.AndroidJNI::SetFloatField");
			AndroidJNI.SetDoubleFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetDoubleFieldDelegate>("UnityEngine.AndroidJNI::SetDoubleField");
			AndroidJNI.SetStaticStringFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticStringFieldDelegate>("UnityEngine.AndroidJNI::SetStaticStringField");
			AndroidJNI.SetStaticObjectFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticObjectFieldDelegate>("UnityEngine.AndroidJNI::SetStaticObjectField");
			AndroidJNI.SetStaticBooleanFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticBooleanFieldDelegate>("UnityEngine.AndroidJNI::SetStaticBooleanField");
			AndroidJNI.SetStaticSByteFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticSByteFieldDelegate>("UnityEngine.AndroidJNI::SetStaticSByteField");
			AndroidJNI.SetStaticCharFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticCharFieldDelegate>("UnityEngine.AndroidJNI::SetStaticCharField");
			AndroidJNI.SetStaticShortFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticShortFieldDelegate>("UnityEngine.AndroidJNI::SetStaticShortField");
			AndroidJNI.SetStaticIntFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticIntFieldDelegate>("UnityEngine.AndroidJNI::SetStaticIntField");
			AndroidJNI.SetStaticLongFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticLongFieldDelegate>("UnityEngine.AndroidJNI::SetStaticLongField");
			AndroidJNI.SetStaticFloatFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticFloatFieldDelegate>("UnityEngine.AndroidJNI::SetStaticFloatField");
			AndroidJNI.SetStaticDoubleFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticDoubleFieldDelegate>("UnityEngine.AndroidJNI::SetStaticDoubleField");
			AndroidJNI.FromObjectArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.FromObjectArrayDelegate>("UnityEngine.AndroidJNI::FromObjectArray");
			AndroidJNI.NewBooleanArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewBooleanArrayDelegate>("UnityEngine.AndroidJNI::NewBooleanArray");
			AndroidJNI.NewSByteArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewSByteArrayDelegate>("UnityEngine.AndroidJNI::NewSByteArray");
			AndroidJNI.NewCharArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewCharArrayDelegate>("UnityEngine.AndroidJNI::NewCharArray");
			AndroidJNI.NewShortArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewShortArrayDelegate>("UnityEngine.AndroidJNI::NewShortArray");
			AndroidJNI.NewIntArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewIntArrayDelegate>("UnityEngine.AndroidJNI::NewIntArray");
			AndroidJNI.NewLongArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewLongArrayDelegate>("UnityEngine.AndroidJNI::NewLongArray");
			AndroidJNI.NewFloatArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewFloatArrayDelegate>("UnityEngine.AndroidJNI::NewFloatArray");
			AndroidJNI.NewDoubleArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewDoubleArrayDelegate>("UnityEngine.AndroidJNI::NewDoubleArray");
			AndroidJNI.GetBooleanArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetBooleanArrayElementDelegate>("UnityEngine.AndroidJNI::GetBooleanArrayElement");
			AndroidJNI.GetSByteArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetSByteArrayElementDelegate>("UnityEngine.AndroidJNI::GetSByteArrayElement");
			AndroidJNI.GetCharArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetCharArrayElementDelegate>("UnityEngine.AndroidJNI::GetCharArrayElement");
			AndroidJNI.GetShortArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetShortArrayElementDelegate>("UnityEngine.AndroidJNI::GetShortArrayElement");
			AndroidJNI.GetIntArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetIntArrayElementDelegate>("UnityEngine.AndroidJNI::GetIntArrayElement");
			AndroidJNI.GetLongArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetLongArrayElementDelegate>("UnityEngine.AndroidJNI::GetLongArrayElement");
			AndroidJNI.GetFloatArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetFloatArrayElementDelegate>("UnityEngine.AndroidJNI::GetFloatArrayElement");
			AndroidJNI.GetDoubleArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetDoubleArrayElementDelegate>("UnityEngine.AndroidJNI::GetDoubleArrayElement");
			AndroidJNI.SetBooleanArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetBooleanArrayElementDelegate>("UnityEngine.AndroidJNI::SetBooleanArrayElement");
			AndroidJNI.SetSByteArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetSByteArrayElementDelegate>("UnityEngine.AndroidJNI::SetSByteArrayElement");
			AndroidJNI.SetCharArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetCharArrayElementDelegate>("UnityEngine.AndroidJNI::SetCharArrayElement");
			AndroidJNI.SetShortArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetShortArrayElementDelegate>("UnityEngine.AndroidJNI::SetShortArrayElement");
			AndroidJNI.SetIntArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetIntArrayElementDelegate>("UnityEngine.AndroidJNI::SetIntArrayElement");
			AndroidJNI.SetLongArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetLongArrayElementDelegate>("UnityEngine.AndroidJNI::SetLongArrayElement");
			AndroidJNI.SetFloatArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetFloatArrayElementDelegate>("UnityEngine.AndroidJNI::SetFloatArrayElement");
			AndroidJNI.SetDoubleArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetDoubleArrayElementDelegate>("UnityEngine.AndroidJNI::SetDoubleArrayElement");
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006574 File Offset: 0x00004774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482732, XrefRangeEnd = 482736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FindClass(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000065B8 File Offset: 0x000047B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482736, XrefRangeEnd = 482740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refMethod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000065F8 File Offset: 0x000047F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482740, XrefRangeEnd = 482744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ExceptionOccurred()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006628 File Offset: 0x00004828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482744, XrefRangeEnd = 482748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExceptionClear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006650 File Offset: 0x00004850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482748, XrefRangeEnd = 482752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PushLocalFrame(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_PushLocalFrame_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006690 File Offset: 0x00004890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482752, XrefRangeEnd = 482756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr PopLocalFrame(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_PopLocalFrame_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000066D0 File Offset: 0x000048D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482756, XrefRangeEnd = 482760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006710 File Offset: 0x00004910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482760, XrefRangeEnd = 482764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_DeleteGlobalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006744 File Offset: 0x00004944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482764, XrefRangeEnd = 482768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewWeakGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006784 File Offset: 0x00004984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482768, XrefRangeEnd = 482772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteWeakGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000067B8 File Offset: 0x000049B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482772, XrefRangeEnd = 482776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewLocalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000067F8 File Offset: 0x000049F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482776, XrefRangeEnd = 482780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteLocalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000682C File Offset: 0x00004A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482780, XrefRangeEnd = 482784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000688C File Offset: 0x00004A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482784, XrefRangeEnd = 482788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetObjectClass(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000068CC File Offset: 0x00004ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482792, RefRangeEnd = 482793, XrefRangeStart = 482788, XrefRangeEnd = 482792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr clazz, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006930 File Offset: 0x00004B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482793, XrefRangeEnd = 482797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006994 File Offset: 0x00004B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482801, RefRangeEnd = 482802, XrefRangeStart = 482797, XrefRangeEnd = 482801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000069F8 File Offset: 0x00004BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482802, XrefRangeEnd = 482806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticFieldID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006A5C File Offset: 0x00004C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482806, XrefRangeEnd = 482810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewString(string chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006AA0 File Offset: 0x00004CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewStringFromStr(string chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006AE4 File Offset: 0x00004CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482810, XrefRangeEnd = 482814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringChars(IntPtr str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref str;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006B1C File Offset: 0x00004D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482818, RefRangeEnd = 482819, XrefRangeStart = 482814, XrefRangeEnd = 482818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStringMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006B74 File Offset: 0x00004D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482819, XrefRangeEnd = 482823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006BD4 File Offset: 0x00004DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482823, XrefRangeEnd = 482827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CallIntMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00006C34 File Offset: 0x00004E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482827, XrefRangeEnd = 482831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006C94 File Offset: 0x00004E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482831, XrefRangeEnd = 482835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short CallShortMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006CF4 File Offset: 0x00004EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482835, XrefRangeEnd = 482839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00006D54 File Offset: 0x00004F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482839, XrefRangeEnd = 482843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char CallCharMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00006DB4 File Offset: 0x00004FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482843, XrefRangeEnd = 482847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CallFloatMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00006E14 File Offset: 0x00005014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482847, XrefRangeEnd = 482851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006E74 File Offset: 0x00005074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482851, XrefRangeEnd = 482855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CallLongMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006ED4 File Offset: 0x000050D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482855, XrefRangeEnd = 482859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStringField_Public_Static_String_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006F1C File Offset: 0x0000511C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482859, XrefRangeEnd = 482863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006F68 File Offset: 0x00005168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482863, XrefRangeEnd = 482867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006FB4 File Offset: 0x000051B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482867, XrefRangeEnd = 482871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetSByteField_Public_Static_SByte_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007000 File Offset: 0x00005200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482871, XrefRangeEnd = 482875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetCharField_Public_Static_Char_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000704C File Offset: 0x0000524C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482875, XrefRangeEnd = 482879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetShortField_Public_Static_Int16_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007098 File Offset: 0x00005298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482879, XrefRangeEnd = 482883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetIntField_Public_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000070E4 File Offset: 0x000052E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482883, XrefRangeEnd = 482887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetLongField_Public_Static_Int64_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007130 File Offset: 0x00005330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482887, XrefRangeEnd = 482891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetFloatField_Public_Static_Single_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000717C File Offset: 0x0000537C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482891, XrefRangeEnd = 482895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetDoubleField_Public_Static_Double_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000071C8 File Offset: 0x000053C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482899, RefRangeEnd = 482900, XrefRangeStart = 482895, XrefRangeEnd = 482899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00007220 File Offset: 0x00005420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482900, XrefRangeEnd = 482904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007280 File Offset: 0x00005480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482904, XrefRangeEnd = 482908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000072E0 File Offset: 0x000054E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482908, XrefRangeEnd = 482912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007340 File Offset: 0x00005540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482912, XrefRangeEnd = 482916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000073A0 File Offset: 0x000055A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482916, XrefRangeEnd = 482920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007400 File Offset: 0x00005600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482920, XrefRangeEnd = 482924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007460 File Offset: 0x00005660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482924, XrefRangeEnd = 482928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000074C0 File Offset: 0x000056C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482928, XrefRangeEnd = 482932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007520 File Offset: 0x00005720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482932, XrefRangeEnd = 482936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007580 File Offset: 0x00005780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482936, XrefRangeEnd = 482940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000075D4 File Offset: 0x000057D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482940, XrefRangeEnd = 482944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticStringField_Public_Static_String_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000761C File Offset: 0x0000581C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482944, XrefRangeEnd = 482948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007668 File Offset: 0x00005868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482948, XrefRangeEnd = 482952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000076B4 File Offset: 0x000058B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482952, XrefRangeEnd = 482956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticSByteField_Public_Static_SByte_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00007700 File Offset: 0x00005900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482956, XrefRangeEnd = 482960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticCharField_Public_Static_Char_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000774C File Offset: 0x0000594C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482960, XrefRangeEnd = 482964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticShortField_Public_Static_Int16_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007798 File Offset: 0x00005998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482964, XrefRangeEnd = 482968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticIntField_Public_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000077E4 File Offset: 0x000059E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482968, XrefRangeEnd = 482972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticLongField_Public_Static_Int64_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007830 File Offset: 0x00005A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482972, XrefRangeEnd = 482976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticFloatField_Public_Static_Single_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000787C File Offset: 0x00005A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482976, XrefRangeEnd = 482980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticDoubleField_Public_Static_Double_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000078C8 File Offset: 0x00005AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482980, XrefRangeEnd = 482984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToBooleanArray(Il2CppStructArray<bool> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000790C File Offset: 0x00005B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482984, XrefRangeEnd = 482988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToByteArray(Il2CppStructArray<byte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007950 File Offset: 0x00005B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482988, XrefRangeEnd = 482992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToSByteArray(Il2CppStructArray<sbyte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00007994 File Offset: 0x00005B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482992, XrefRangeEnd = 482996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToCharArray(Il2CppStructArray<char> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000079D8 File Offset: 0x00005BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482996, XrefRangeEnd = 483000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToShortArray(Il2CppStructArray<short> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007A1C File Offset: 0x00005C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483000, XrefRangeEnd = 483004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToIntArray(Il2CppStructArray<int> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00007A60 File Offset: 0x00005C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483004, XrefRangeEnd = 483008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToLongArray(Il2CppStructArray<long> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007AA4 File Offset: 0x00005CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483008, XrefRangeEnd = 483012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToFloatArray(Il2CppStructArray<float> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483012, XrefRangeEnd = 483016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToDoubleArray(Il2CppStructArray<double> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00007B2C File Offset: 0x00005D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483016, XrefRangeEnd = 483020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array, IntPtr arrayClass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayClass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007B7C File Offset: 0x00005D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483020, XrefRangeEnd = 483024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> FromBooleanArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007BBC File Offset: 0x00005DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483024, XrefRangeEnd = 483028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007BFC File Offset: 0x00005DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483028, XrefRangeEnd = 483032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<sbyte> FromSByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007C3C File Offset: 0x00005E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483032, XrefRangeEnd = 483036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> FromCharArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00007C7C File Offset: 0x00005E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483036, XrefRangeEnd = 483040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<short> FromShortArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007CBC File Offset: 0x00005EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483040, XrefRangeEnd = 483044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> FromIntArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007CFC File Offset: 0x00005EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483044, XrefRangeEnd = 483048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<long> FromLongArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007D3C File Offset: 0x00005F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483048, XrefRangeEnd = 483052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> FromFloatArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00007D7C File Offset: 0x00005F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483052, XrefRangeEnd = 483056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<double> FromDoubleArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr3) : null;
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00007DBC File Offset: 0x00005FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483056, XrefRangeEnd = 483060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetArrayLength(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00007DFC File Offset: 0x00005FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483060, XrefRangeEnd = 483064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clazz;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref obj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007E58 File Offset: 0x00006058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483064, XrefRangeEnd = 483068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007EA4 File Offset: 0x000060A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483068, XrefRangeEnd = 483072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref obj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002359 File Offset: 0x00000559
		public AndroidJNI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002362 File Offset: 0x00000562
		public static int AttachCurrentThread()
		{
			return AndroidJNI.AttachCurrentThreadDelegateField();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000236E File Offset: 0x0000056E
		public static int DetachCurrentThread()
		{
			return AndroidJNI.DetachCurrentThreadDelegateField();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000237A File Offset: 0x0000057A
		public static int GetVersion()
		{
			return AndroidJNI.GetVersionDelegateField();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002386 File Offset: 0x00000586
		public static IntPtr FromReflectedField(IntPtr refField)
		{
			return AndroidJNI.FromReflectedFieldDelegateField(refField);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002393 File Offset: 0x00000593
		public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic)
		{
			return AndroidJNI.ToReflectedMethodDelegateField(clazz, methodID, isStatic);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000023A2 File Offset: 0x000005A2
		public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic)
		{
			return AndroidJNI.ToReflectedFieldDelegateField(clazz, fieldID, isStatic);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000023B1 File Offset: 0x000005B1
		public static IntPtr GetSuperclass(IntPtr clazz)
		{
			return AndroidJNI.GetSuperclassDelegateField(clazz);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000023BE File Offset: 0x000005BE
		public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2)
		{
			return AndroidJNI.IsAssignableFromDelegateField(clazz1, clazz2);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000023CC File Offset: 0x000005CC
		public static int Throw(IntPtr obj)
		{
			return AndroidJNI.ThrowDelegateField(obj);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000023D9 File Offset: 0x000005D9
		public static int ThrowNew(IntPtr clazz, string message)
		{
			return AndroidJNI.ThrowNewDelegateField(clazz, IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000023EC File Offset: 0x000005EC
		public static void ExceptionDescribe()
		{
			AndroidJNI.ExceptionDescribeDelegateField();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000023F8 File Offset: 0x000005F8
		public static void FatalError(string message)
		{
			AndroidJNI.FatalErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000240A File Offset: 0x0000060A
		public static bool IsSameObject(IntPtr obj1, IntPtr obj2)
		{
			return AndroidJNI.IsSameObjectDelegateField(obj1, obj2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002418 File Offset: 0x00000618
		public static int EnsureLocalCapacity(int capacity)
		{
			return AndroidJNI.EnsureLocalCapacityDelegateField(capacity);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002425 File Offset: 0x00000625
		public static IntPtr AllocObject(IntPtr clazz)
		{
			return AndroidJNI.AllocObjectDelegateField(clazz);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002432 File Offset: 0x00000632
		public static bool IsInstanceOf(IntPtr obj, IntPtr clazz)
		{
			return AndroidJNI.IsInstanceOfDelegateField(obj, clazz);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002440 File Offset: 0x00000640
		public static IntPtr NewString(Il2CppStructArray<char> chars)
		{
			return AndroidJNI.NewStringDelegateField(IL2CPP.Il2CppObjectBaseToPtr(chars));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002452 File Offset: 0x00000652
		public static IntPtr NewStringUTF(string bytes)
		{
			return AndroidJNI.NewStringUTFDelegateField(IL2CPP.ManagedStringToIl2Cpp(bytes));
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002464 File Offset: 0x00000664
		public static int GetStringLength(IntPtr str)
		{
			return AndroidJNI.GetStringLengthDelegateField(str);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002471 File Offset: 0x00000671
		public static int GetStringUTFLength(IntPtr str)
		{
			return AndroidJNI.GetStringUTFLengthDelegateField(str);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00007EF4 File Offset: 0x000060F4
		public static string GetStringUTFChars(IntPtr str)
		{
			IntPtr intPtr = AndroidJNI.GetStringUTFCharsDelegateField(str);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007F14 File Offset: 0x00006114
		public static byte CallByteMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return (byte)AndroidJNI.CallSByteMethod(obj, methodID, args);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000247E File Offset: 0x0000067E
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			AndroidJNI.CallVoidMethodDelegateField(obj, methodID, IL2CPP.Il2CppObjectBaseToPtr(args));
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00007F30 File Offset: 0x00006130
		public static byte GetByteField(IntPtr obj, IntPtr fieldID)
		{
			return (byte)AndroidJNI.GetSByteField(obj, fieldID);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002492 File Offset: 0x00000692
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
			AndroidJNI.SetStringFieldDelegateField(obj, fieldID, IL2CPP.ManagedStringToIl2Cpp(val));
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000024A6 File Offset: 0x000006A6
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
			AndroidJNI.SetObjectFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000024B5 File Offset: 0x000006B5
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
			AndroidJNI.SetBooleanFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000024C4 File Offset: 0x000006C4
		public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val)
		{
			AndroidJNI.SetSByteField(obj, fieldID, (sbyte)val);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000024D1 File Offset: 0x000006D1
		public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
		{
			AndroidJNI.SetSByteFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000024E0 File Offset: 0x000006E0
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
			AndroidJNI.SetCharFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000024EF File Offset: 0x000006EF
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
			AndroidJNI.SetShortFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000024FE File Offset: 0x000006FE
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
			AndroidJNI.SetIntFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000250D File Offset: 0x0000070D
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
			AndroidJNI.SetLongFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000251C File Offset: 0x0000071C
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
			AndroidJNI.SetFloatFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000252B File Offset: 0x0000072B
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
			AndroidJNI.SetDoubleFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00007F4C File Offset: 0x0000614C
		public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return (byte)AndroidJNI.CallStaticSByteMethod(clazz, methodID, args);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00007F68 File Offset: 0x00006168
		public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID)
		{
			return (byte)AndroidJNI.GetStaticSByteField(clazz, fieldID);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000253A File Offset: 0x0000073A
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
			AndroidJNI.SetStaticStringFieldDelegateField(clazz, fieldID, IL2CPP.ManagedStringToIl2Cpp(val));
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000254E File Offset: 0x0000074E
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
			AndroidJNI.SetStaticObjectFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000255D File Offset: 0x0000075D
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
			AndroidJNI.SetStaticBooleanFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000256C File Offset: 0x0000076C
		public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val)
		{
			AndroidJNI.SetStaticSByteField(clazz, fieldID, (sbyte)val);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002579 File Offset: 0x00000779
		public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
		{
			AndroidJNI.SetStaticSByteFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002588 File Offset: 0x00000788
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
			AndroidJNI.SetStaticCharFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002597 File Offset: 0x00000797
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
			AndroidJNI.SetStaticShortFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000025A6 File Offset: 0x000007A6
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
			AndroidJNI.SetStaticIntFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000025B5 File Offset: 0x000007B5
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
			AndroidJNI.SetStaticLongFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000025C4 File Offset: 0x000007C4
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
			AndroidJNI.SetStaticFloatFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000025D3 File Offset: 0x000007D3
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
			AndroidJNI.SetStaticDoubleFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007F84 File Offset: 0x00006184
		public static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array)
		{
			return AndroidJNI.ToObjectArray(array, IntPtr.Zero);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007FA4 File Offset: 0x000061A4
		public static Il2CppStructArray<IntPtr> FromObjectArray(IntPtr array)
		{
			IntPtr intPtr = AndroidJNI.FromObjectArrayDelegateField(array);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000025E2 File Offset: 0x000007E2
		public static IntPtr NewBooleanArray(int size)
		{
			return AndroidJNI.NewBooleanArrayDelegateField(size);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00007FCC File Offset: 0x000061CC
		public static IntPtr NewByteArray(int size)
		{
			return AndroidJNI.NewSByteArray(size);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000025EF File Offset: 0x000007EF
		public static IntPtr NewSByteArray(int size)
		{
			return AndroidJNI.NewSByteArrayDelegateField(size);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000025FC File Offset: 0x000007FC
		public static IntPtr NewCharArray(int size)
		{
			return AndroidJNI.NewCharArrayDelegateField(size);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002609 File Offset: 0x00000809
		public static IntPtr NewShortArray(int size)
		{
			return AndroidJNI.NewShortArrayDelegateField(size);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002616 File Offset: 0x00000816
		public static IntPtr NewIntArray(int size)
		{
			return AndroidJNI.NewIntArrayDelegateField(size);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002623 File Offset: 0x00000823
		public static IntPtr NewLongArray(int size)
		{
			return AndroidJNI.NewLongArrayDelegateField(size);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002630 File Offset: 0x00000830
		public static IntPtr NewFloatArray(int size)
		{
			return AndroidJNI.NewFloatArrayDelegateField(size);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000263D File Offset: 0x0000083D
		public static IntPtr NewDoubleArray(int size)
		{
			return AndroidJNI.NewDoubleArrayDelegateField(size);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000264A File Offset: 0x0000084A
		public static bool GetBooleanArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetBooleanArrayElementDelegateField(array, index);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00007FE4 File Offset: 0x000061E4
		public static byte GetByteArrayElement(IntPtr array, int index)
		{
			return (byte)AndroidJNI.GetSByteArrayElement(array, index);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002658 File Offset: 0x00000858
		public static sbyte GetSByteArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetSByteArrayElementDelegateField(array, index);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002666 File Offset: 0x00000866
		public static char GetCharArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetCharArrayElementDelegateField(array, index);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002674 File Offset: 0x00000874
		public static short GetShortArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetShortArrayElementDelegateField(array, index);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002682 File Offset: 0x00000882
		public static int GetIntArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetIntArrayElementDelegateField(array, index);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002690 File Offset: 0x00000890
		public static long GetLongArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetLongArrayElementDelegateField(array, index);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000269E File Offset: 0x0000089E
		public static float GetFloatArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetFloatArrayElementDelegateField(array, index);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000026AC File Offset: 0x000008AC
		public static double GetDoubleArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetDoubleArrayElementDelegateField(array, index);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000026BA File Offset: 0x000008BA
		public static void SetBooleanArrayElement(IntPtr array, int index, byte val)
		{
			AndroidJNI.SetBooleanArrayElement(array, index, val > 0);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000026C9 File Offset: 0x000008C9
		public static void SetBooleanArrayElement(IntPtr array, int index, bool val)
		{
			AndroidJNI.SetBooleanArrayElementDelegateField(array, index, val);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000026D8 File Offset: 0x000008D8
		public static void SetByteArrayElement(IntPtr array, int index, sbyte val)
		{
			AndroidJNI.SetSByteArrayElement(array, index, val);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000026E4 File Offset: 0x000008E4
		public static void SetSByteArrayElement(IntPtr array, int index, sbyte val)
		{
			AndroidJNI.SetSByteArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000026F3 File Offset: 0x000008F3
		public static void SetCharArrayElement(IntPtr array, int index, char val)
		{
			AndroidJNI.SetCharArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002702 File Offset: 0x00000902
		public static void SetShortArrayElement(IntPtr array, int index, short val)
		{
			AndroidJNI.SetShortArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002711 File Offset: 0x00000911
		public static void SetIntArrayElement(IntPtr array, int index, int val)
		{
			AndroidJNI.SetIntArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002720 File Offset: 0x00000920
		public static void SetLongArrayElement(IntPtr array, int index, long val)
		{
			AndroidJNI.SetLongArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000272F File Offset: 0x0000092F
		public static void SetFloatArrayElement(IntPtr array, int index, float val)
		{
			AndroidJNI.SetFloatArrayElementDelegateField(array, index, val);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000273E File Offset: 0x0000093E
		public static void SetDoubleArrayElement(IntPtr array, int index, double val)
		{
			AndroidJNI.SetDoubleArrayElementDelegateField(array, index, val);
		}

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_PushLocalFrame_Public_Static_Int32_Int32_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_PopLocalFrame_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_DeleteGlobalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticFieldID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_GetStringField_Public_Static_String_IntPtr_IntPtr_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_GetBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_GetSByteField_Public_Static_SByte_IntPtr_IntPtr_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_GetCharField_Public_Static_Char_IntPtr_IntPtr_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_GetShortField_Public_Static_Int16_IntPtr_IntPtr_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_GetIntField_Public_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_GetLongField_Public_Static_Int64_IntPtr_IntPtr_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatField_Public_Static_Single_IntPtr_IntPtr_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_GetDoubleField_Public_Static_Double_IntPtr_IntPtr_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticVoidMethod_Public_Static_Void_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticStringField_Public_Static_String_IntPtr_IntPtr_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticObjectField_Public_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticBooleanField_Public_Static_Boolean_IntPtr_IntPtr_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticSByteField_Public_Static_SByte_IntPtr_IntPtr_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticCharField_Public_Static_Char_IntPtr_IntPtr_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticShortField_Public_Static_Int16_IntPtr_IntPtr_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticIntField_Public_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticLongField_Public_Static_Int64_IntPtr_IntPtr_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticFloatField_Public_Static_Single_IntPtr_IntPtr_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticDoubleField_Public_Static_Double_IntPtr_IntPtr_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0;

		// Token: 0x040000D1 RID: 209
		private static readonly AndroidJNI.AttachCurrentThreadDelegate AttachCurrentThreadDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly AndroidJNI.DetachCurrentThreadDelegate DetachCurrentThreadDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly AndroidJNI.GetVersionDelegate GetVersionDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly AndroidJNI.FromReflectedFieldDelegate FromReflectedFieldDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly AndroidJNI.ToReflectedMethodDelegate ToReflectedMethodDelegateField;

		// Token: 0x040000D6 RID: 214
		private static readonly AndroidJNI.ToReflectedFieldDelegate ToReflectedFieldDelegateField;

		// Token: 0x040000D7 RID: 215
		private static readonly AndroidJNI.GetSuperclassDelegate GetSuperclassDelegateField;

		// Token: 0x040000D8 RID: 216
		private static readonly AndroidJNI.IsAssignableFromDelegate IsAssignableFromDelegateField;

		// Token: 0x040000D9 RID: 217
		private static readonly AndroidJNI.ThrowDelegate ThrowDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly AndroidJNI.ThrowNewDelegate ThrowNewDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly AndroidJNI.ExceptionDescribeDelegate ExceptionDescribeDelegateField;

		// Token: 0x040000DC RID: 220
		private static readonly AndroidJNI.FatalErrorDelegate FatalErrorDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly AndroidJNI.IsSameObjectDelegate IsSameObjectDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly AndroidJNI.EnsureLocalCapacityDelegate EnsureLocalCapacityDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly AndroidJNI.AllocObjectDelegate AllocObjectDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly AndroidJNI.IsInstanceOfDelegate IsInstanceOfDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly AndroidJNI.NewStringDelegate NewStringDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly AndroidJNI.NewStringUTFDelegate NewStringUTFDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly AndroidJNI.GetStringLengthDelegate GetStringLengthDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly AndroidJNI.GetStringUTFLengthDelegate GetStringUTFLengthDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly AndroidJNI.GetStringUTFCharsDelegate GetStringUTFCharsDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly AndroidJNI.CallVoidMethodDelegate CallVoidMethodDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly AndroidJNI.SetStringFieldDelegate SetStringFieldDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly AndroidJNI.SetObjectFieldDelegate SetObjectFieldDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly AndroidJNI.SetBooleanFieldDelegate SetBooleanFieldDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly AndroidJNI.SetSByteFieldDelegate SetSByteFieldDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly AndroidJNI.SetCharFieldDelegate SetCharFieldDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly AndroidJNI.SetShortFieldDelegate SetShortFieldDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly AndroidJNI.SetIntFieldDelegate SetIntFieldDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly AndroidJNI.SetLongFieldDelegate SetLongFieldDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly AndroidJNI.SetFloatFieldDelegate SetFloatFieldDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly AndroidJNI.SetDoubleFieldDelegate SetDoubleFieldDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly AndroidJNI.SetStaticStringFieldDelegate SetStaticStringFieldDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly AndroidJNI.SetStaticObjectFieldDelegate SetStaticObjectFieldDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly AndroidJNI.SetStaticBooleanFieldDelegate SetStaticBooleanFieldDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly AndroidJNI.SetStaticSByteFieldDelegate SetStaticSByteFieldDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly AndroidJNI.SetStaticCharFieldDelegate SetStaticCharFieldDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly AndroidJNI.SetStaticShortFieldDelegate SetStaticShortFieldDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly AndroidJNI.SetStaticIntFieldDelegate SetStaticIntFieldDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly AndroidJNI.SetStaticLongFieldDelegate SetStaticLongFieldDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly AndroidJNI.SetStaticFloatFieldDelegate SetStaticFloatFieldDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly AndroidJNI.SetStaticDoubleFieldDelegate SetStaticDoubleFieldDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly AndroidJNI.FromObjectArrayDelegate FromObjectArrayDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly AndroidJNI.NewBooleanArrayDelegate NewBooleanArrayDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly AndroidJNI.NewSByteArrayDelegate NewSByteArrayDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly AndroidJNI.NewCharArrayDelegate NewCharArrayDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly AndroidJNI.NewShortArrayDelegate NewShortArrayDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly AndroidJNI.NewIntArrayDelegate NewIntArrayDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly AndroidJNI.NewLongArrayDelegate NewLongArrayDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly AndroidJNI.NewFloatArrayDelegate NewFloatArrayDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly AndroidJNI.NewDoubleArrayDelegate NewDoubleArrayDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly AndroidJNI.GetBooleanArrayElementDelegate GetBooleanArrayElementDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly AndroidJNI.GetSByteArrayElementDelegate GetSByteArrayElementDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly AndroidJNI.GetCharArrayElementDelegate GetCharArrayElementDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly AndroidJNI.GetShortArrayElementDelegate GetShortArrayElementDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly AndroidJNI.GetIntArrayElementDelegate GetIntArrayElementDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly AndroidJNI.GetLongArrayElementDelegate GetLongArrayElementDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly AndroidJNI.GetFloatArrayElementDelegate GetFloatArrayElementDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly AndroidJNI.GetDoubleArrayElementDelegate GetDoubleArrayElementDelegateField;

		// Token: 0x0400010C RID: 268
		private static readonly AndroidJNI.SetBooleanArrayElementDelegate SetBooleanArrayElementDelegateField;

		// Token: 0x0400010D RID: 269
		private static readonly AndroidJNI.SetSByteArrayElementDelegate SetSByteArrayElementDelegateField;

		// Token: 0x0400010E RID: 270
		private static readonly AndroidJNI.SetCharArrayElementDelegate SetCharArrayElementDelegateField;

		// Token: 0x0400010F RID: 271
		private static readonly AndroidJNI.SetShortArrayElementDelegate SetShortArrayElementDelegateField;

		// Token: 0x04000110 RID: 272
		private static readonly AndroidJNI.SetIntArrayElementDelegate SetIntArrayElementDelegateField;

		// Token: 0x04000111 RID: 273
		private static readonly AndroidJNI.SetLongArrayElementDelegate SetLongArrayElementDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly AndroidJNI.SetFloatArrayElementDelegate SetFloatArrayElementDelegateField;

		// Token: 0x04000113 RID: 275
		private static readonly AndroidJNI.SetDoubleArrayElementDelegate SetDoubleArrayElementDelegateField;

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000215 RID: 533
		private delegate int AttachCurrentThreadDelegate();

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000217 RID: 535
		private delegate int DetachCurrentThreadDelegate();

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000219 RID: 537
		private delegate int GetVersionDelegate();

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600021B RID: 539
		private delegate IntPtr FromReflectedFieldDelegate(IntPtr refField);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600021D RID: 541
		private delegate IntPtr ToReflectedMethodDelegate(IntPtr clazz, IntPtr methodID, bool isStatic);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600021F RID: 543
		private delegate IntPtr ToReflectedFieldDelegate(IntPtr clazz, IntPtr fieldID, bool isStatic);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000221 RID: 545
		private delegate IntPtr GetSuperclassDelegate(IntPtr clazz);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000223 RID: 547
		private delegate bool IsAssignableFromDelegate(IntPtr clazz1, IntPtr clazz2);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000225 RID: 549
		private delegate int ThrowDelegate(IntPtr obj);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000227 RID: 551
		private delegate int ThrowNewDelegate(IntPtr clazz, IntPtr message);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000229 RID: 553
		private delegate void ExceptionDescribeDelegate();

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600022B RID: 555
		private delegate void FatalErrorDelegate(IntPtr message);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x0600022D RID: 557
		private delegate bool IsSameObjectDelegate(IntPtr obj1, IntPtr obj2);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600022F RID: 559
		private delegate int EnsureLocalCapacityDelegate(int capacity);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000231 RID: 561
		private delegate IntPtr AllocObjectDelegate(IntPtr clazz);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000233 RID: 563
		private delegate bool IsInstanceOfDelegate(IntPtr obj, IntPtr clazz);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000235 RID: 565
		private delegate IntPtr NewStringDelegate(IntPtr chars);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000237 RID: 567
		private delegate IntPtr NewStringUTFDelegate(IntPtr bytes);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000239 RID: 569
		private delegate int GetStringLengthDelegate(IntPtr str);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600023B RID: 571
		private delegate int GetStringUTFLengthDelegate(IntPtr str);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600023D RID: 573
		private delegate IntPtr GetStringUTFCharsDelegate(IntPtr str);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600023F RID: 575
		private delegate void CallVoidMethodDelegate(IntPtr obj, IntPtr methodID, IntPtr args);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000241 RID: 577
		private delegate void SetStringFieldDelegate(IntPtr obj, IntPtr fieldID, IntPtr val);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000243 RID: 579
		private delegate void SetObjectFieldDelegate(IntPtr obj, IntPtr fieldID, IntPtr val);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000245 RID: 581
		private delegate void SetBooleanFieldDelegate(IntPtr obj, IntPtr fieldID, bool val);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000247 RID: 583
		private delegate void SetSByteFieldDelegate(IntPtr obj, IntPtr fieldID, sbyte val);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000249 RID: 585
		private delegate void SetCharFieldDelegate(IntPtr obj, IntPtr fieldID, char val);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600024B RID: 587
		private delegate void SetShortFieldDelegate(IntPtr obj, IntPtr fieldID, short val);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600024D RID: 589
		private delegate void SetIntFieldDelegate(IntPtr obj, IntPtr fieldID, int val);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600024F RID: 591
		private delegate void SetLongFieldDelegate(IntPtr obj, IntPtr fieldID, long val);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000251 RID: 593
		private delegate void SetFloatFieldDelegate(IntPtr obj, IntPtr fieldID, float val);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000253 RID: 595
		private delegate void SetDoubleFieldDelegate(IntPtr obj, IntPtr fieldID, double val);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000255 RID: 597
		private delegate void SetStaticStringFieldDelegate(IntPtr clazz, IntPtr fieldID, IntPtr val);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000257 RID: 599
		private delegate void SetStaticObjectFieldDelegate(IntPtr clazz, IntPtr fieldID, IntPtr val);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000259 RID: 601
		private delegate void SetStaticBooleanFieldDelegate(IntPtr clazz, IntPtr fieldID, bool val);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600025B RID: 603
		private delegate void SetStaticSByteFieldDelegate(IntPtr clazz, IntPtr fieldID, sbyte val);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600025D RID: 605
		private delegate void SetStaticCharFieldDelegate(IntPtr clazz, IntPtr fieldID, char val);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x0600025F RID: 607
		private delegate void SetStaticShortFieldDelegate(IntPtr clazz, IntPtr fieldID, short val);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000261 RID: 609
		private delegate void SetStaticIntFieldDelegate(IntPtr clazz, IntPtr fieldID, int val);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000263 RID: 611
		private delegate void SetStaticLongFieldDelegate(IntPtr clazz, IntPtr fieldID, long val);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000265 RID: 613
		private delegate void SetStaticFloatFieldDelegate(IntPtr clazz, IntPtr fieldID, float val);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000267 RID: 615
		private delegate void SetStaticDoubleFieldDelegate(IntPtr clazz, IntPtr fieldID, double val);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000269 RID: 617
		private delegate IntPtr FromObjectArrayDelegate(IntPtr array);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600026B RID: 619
		private delegate IntPtr NewBooleanArrayDelegate(int size);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600026D RID: 621
		private delegate IntPtr NewSByteArrayDelegate(int size);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x0600026F RID: 623
		private delegate IntPtr NewCharArrayDelegate(int size);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000271 RID: 625
		private delegate IntPtr NewShortArrayDelegate(int size);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000273 RID: 627
		private delegate IntPtr NewIntArrayDelegate(int size);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000275 RID: 629
		private delegate IntPtr NewLongArrayDelegate(int size);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000277 RID: 631
		private delegate IntPtr NewFloatArrayDelegate(int size);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000279 RID: 633
		private delegate IntPtr NewDoubleArrayDelegate(int size);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600027B RID: 635
		private delegate bool GetBooleanArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600027D RID: 637
		private delegate sbyte GetSByteArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600027F RID: 639
		private delegate char GetCharArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000281 RID: 641
		private delegate short GetShortArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000283 RID: 643
		private delegate int GetIntArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000285 RID: 645
		private delegate long GetLongArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000287 RID: 647
		private delegate float GetFloatArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000289 RID: 649
		private delegate double GetDoubleArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600028B RID: 651
		private delegate void SetBooleanArrayElementDelegate(IntPtr array, int index, bool val);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600028D RID: 653
		private delegate void SetSByteArrayElementDelegate(IntPtr array, int index, sbyte val);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x0600028F RID: 655
		private delegate void SetCharArrayElementDelegate(IntPtr array, int index, char val);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000291 RID: 657
		private delegate void SetShortArrayElementDelegate(IntPtr array, int index, short val);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000293 RID: 659
		private delegate void SetIntArrayElementDelegate(IntPtr array, int index, int val);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000295 RID: 661
		private delegate void SetLongArrayElementDelegate(IntPtr array, int index, long val);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000297 RID: 663
		private delegate void SetFloatArrayElementDelegate(IntPtr array, int index, float val);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000299 RID: 665
		private delegate void SetDoubleArrayElementDelegate(IntPtr array, int index, double val);
	}
}
