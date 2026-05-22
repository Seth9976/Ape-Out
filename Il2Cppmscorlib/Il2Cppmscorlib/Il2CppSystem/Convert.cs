using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000093 RID: 147
	public static class Convert : Object
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x0004A908 File Offset: 0x00048B08
		// Note: this type is marked as 'beforefieldinit'.
		static Convert()
		{
			Il2CppClassPointerStore<Convert>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Convert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Convert>.NativeClassPtr);
			Convert.NativeFieldInfoPtr_ConvertTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "ConvertTypes");
			Convert.NativeFieldInfoPtr_EnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "EnumType");
			Convert.NativeFieldInfoPtr_base64Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "base64Table");
			Convert.NativeFieldInfoPtr_DBNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "DBNull");
			Convert.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664704);
			Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664705);
			Convert.NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664706);
			Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664707);
			Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664708);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664709);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664710);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664711);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664712);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664713);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664714);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664715);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664716);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664717);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664718);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664719);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664720);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664721);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664722);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664723);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664724);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664725);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664726);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664727);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664728);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664729);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664730);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664731);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664732);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664733);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664734);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664735);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664736);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664737);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664738);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664739);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664740);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664741);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664742);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664743);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664744);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664745);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664746);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664747);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664748);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664749);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664750);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664751);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664752);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664753);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664754);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664755);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664756);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664757);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664758);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664759);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664760);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664761);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664762);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664763);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664764);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664765);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664766);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664767);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664768);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664769);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664770);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664771);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664772);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664773);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664774);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664775);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664776);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664777);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664778);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664779);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664780);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664781);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664782);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664783);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664784);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664785);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664786);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664787);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664788);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664789);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664790);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664791);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664792);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664793);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664794);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664795);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664796);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664797);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664798);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664799);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664800);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664801);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664802);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664803);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664804);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664805);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664806);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664807);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664808);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664809);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664810);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664811);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664812);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664813);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664814);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664815);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664816);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664817);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664818);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664819);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664820);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664821);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664822);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664823);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664824);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664825);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664826);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664827);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664828);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664829);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664830);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664831);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664832);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664833);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664834);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664835);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664836);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664837);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664838);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664839);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664840);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664841);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664842);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664843);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664844);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664845);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664846);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664847);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664848);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664849);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664850);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664851);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664852);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664853);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664854);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664855);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664856);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664857);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664858);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664859);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664860);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664861);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664862);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664863);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664864);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664865);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664866);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664867);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664868);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664869);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664870);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664871);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664872);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664873);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664874);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664875);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664876);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664877);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664878);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664879);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664880);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664881);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664882);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664883);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664884);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664885);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664886);
			Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664887);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664888);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664889);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664890);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664891);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664892);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664893);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664894);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664895);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664896);
			Convert.NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664897);
			Convert.NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Base64FormattingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664898);
			Convert.NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664899);
			Convert.NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664900);
			Convert.NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664901);
			Convert.NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664902);
			Convert.NativeMethodInfoPtr_FromBase64_Decode_Private_Static_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664903);
			Convert.NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664904);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0004B93C File Offset: 0x00049B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150221, XrefRangeEnd = 150224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode GetTypeCode(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0004B980 File Offset: 0x00049B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150247, RefRangeEnd = 150248, XrefRangeStart = 150224, XrefRangeEnd = 150247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType(Object value, TypeCode typeCode, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0004B9E4 File Offset: 0x00049BE4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 150403, RefRangeEnd = 150420, XrefRangeStart = 150248, XrefRangeEnd = 150403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0004BA4C File Offset: 0x00049C4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 150427, RefRangeEnd = 150431, XrefRangeStart = 150420, XrefRangeEnd = 150427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType(Object value, Type conversionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversionType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0004BAA4 File Offset: 0x00049CA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150560, RefRangeEnd = 150563, XrefRangeStart = 150431, XrefRangeEnd = 150560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType(Object value, Type conversionType, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversionType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0004BB0C File Offset: 0x00049D0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150564, RefRangeEnd = 150567, XrefRangeStart = 150563, XrefRangeEnd = 150564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0004BB60 File Offset: 0x00049D60
		[CallerCount(0)]
		public unsafe static bool ToBoolean(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0004BBA0 File Offset: 0x00049DA0
		[CallerCount(0)]
		public unsafe static bool ToBoolean(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0004BBE0 File Offset: 0x00049DE0
		[CallerCount(0)]
		public unsafe static bool ToBoolean(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0004BC20 File Offset: 0x00049E20
		[CallerCount(0)]
		public unsafe static bool ToBoolean(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0004BC60 File Offset: 0x00049E60
		[CallerCount(0)]
		public unsafe static bool ToBoolean(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0004BCA0 File Offset: 0x00049EA0
		[CallerCount(0)]
		public unsafe static bool ToBoolean(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0004BCE0 File Offset: 0x00049EE0
		[CallerCount(0)]
		public unsafe static bool ToBoolean(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0004BD20 File Offset: 0x00049F20
		[CallerCount(0)]
		public unsafe static bool ToBoolean(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0004BD60 File Offset: 0x00049F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150567, XrefRangeEnd = 150571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0004BDB4 File Offset: 0x00049FB4
		[CallerCount(0)]
		public unsafe static bool ToBoolean(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0004BDF4 File Offset: 0x00049FF4
		[CallerCount(0)]
		public unsafe static bool ToBoolean(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0004BE34 File Offset: 0x0004A034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150571, XrefRangeEnd = 150579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0004BE74 File Offset: 0x0004A074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150580, RefRangeEnd = 150582, XrefRangeStart = 150579, XrefRangeEnd = 150580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0004BEC8 File Offset: 0x0004A0C8
		[CallerCount(0)]
		public unsafe static char ToChar(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0004BF08 File Offset: 0x0004A108
		[CallerCount(0)]
		public unsafe static char ToChar(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0004BF48 File Offset: 0x0004A148
		[CallerCount(0)]
		public unsafe static char ToChar(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0004BF88 File Offset: 0x0004A188
		[CallerCount(0)]
		public unsafe static char ToChar(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0004BFC8 File Offset: 0x0004A1C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150582, RefRangeEnd = 150584, XrefRangeStart = 150582, XrefRangeEnd = 150582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0004C008 File Offset: 0x0004A208
		[CallerCount(0)]
		public unsafe static char ToChar(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0004C048 File Offset: 0x0004A248
		[CallerCount(0)]
		public unsafe static char ToChar(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0004C088 File Offset: 0x0004A288
		[CallerCount(0)]
		public unsafe static char ToChar(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0004C0C8 File Offset: 0x0004A2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150584, XrefRangeEnd = 150587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0004C10C File Offset: 0x0004A30C
		[CallerCount(0)]
		public unsafe static char ToChar(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0004C160 File Offset: 0x0004A360
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150588, RefRangeEnd = 150590, XrefRangeStart = 150587, XrefRangeEnd = 150588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0004C1B4 File Offset: 0x0004A3B4
		[CallerCount(0)]
		public unsafe static sbyte ToSByte(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0004C1F4 File Offset: 0x0004A3F4
		[CallerCount(0)]
		public unsafe static sbyte ToSByte(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0004C234 File Offset: 0x0004A434
		[CallerCount(0)]
		public unsafe static sbyte ToSByte(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0004C274 File Offset: 0x0004A474
		[CallerCount(0)]
		public unsafe static sbyte ToSByte(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0004C2B4 File Offset: 0x0004A4B4
		[CallerCount(0)]
		public unsafe static sbyte ToSByte(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0004C2F4 File Offset: 0x0004A4F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 150590, RefRangeEnd = 150595, XrefRangeStart = 150590, XrefRangeEnd = 150590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0004C334 File Offset: 0x0004A534
		[CallerCount(0)]
		public unsafe static sbyte ToSByte(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0004C374 File Offset: 0x0004A574
		[CallerCount(0)]
		public unsafe static sbyte ToSByte(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0004C3B4 File Offset: 0x0004A5B4
		[CallerCount(0)]
		public unsafe static sbyte ToSByte(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0004C3F4 File Offset: 0x0004A5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150595, XrefRangeEnd = 150604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0004C434 File Offset: 0x0004A634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150604, XrefRangeEnd = 150609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0004C474 File Offset: 0x0004A674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150609, XrefRangeEnd = 150618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0004C4B4 File Offset: 0x0004A6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150618, XrefRangeEnd = 150620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0004C508 File Offset: 0x0004A708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150621, RefRangeEnd = 150623, XrefRangeStart = 150620, XrefRangeEnd = 150621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0004C55C File Offset: 0x0004A75C
		[CallerCount(0)]
		public unsafe static byte ToByte(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0004C59C File Offset: 0x0004A79C
		[CallerCount(0)]
		public unsafe static byte ToByte(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0004C5DC File Offset: 0x0004A7DC
		[CallerCount(0)]
		public unsafe static byte ToByte(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0004C61C File Offset: 0x0004A81C
		[CallerCount(0)]
		public unsafe static byte ToByte(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0004C65C File Offset: 0x0004A85C
		[CallerCount(0)]
		public unsafe static byte ToByte(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0004C69C File Offset: 0x0004A89C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 150623, RefRangeEnd = 150631, XrefRangeStart = 150623, XrefRangeEnd = 150623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0004C6DC File Offset: 0x0004A8DC
		[CallerCount(0)]
		public unsafe static byte ToByte(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0004C71C File Offset: 0x0004A91C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150631, RefRangeEnd = 150634, XrefRangeStart = 150631, XrefRangeEnd = 150631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0004C75C File Offset: 0x0004A95C
		[CallerCount(0)]
		public unsafe static byte ToByte(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0004C79C File Offset: 0x0004A99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150634, XrefRangeEnd = 150643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0004C7DC File Offset: 0x0004A9DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150648, RefRangeEnd = 150650, XrefRangeStart = 150643, XrefRangeEnd = 150648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0004C81C File Offset: 0x0004AA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150650, XrefRangeEnd = 150659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0004C85C File Offset: 0x0004AA5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150666, RefRangeEnd = 150668, XrefRangeStart = 150659, XrefRangeEnd = 150666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0004C8A0 File Offset: 0x0004AAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150668, XrefRangeEnd = 150670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0004C8F4 File Offset: 0x0004AAF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150671, RefRangeEnd = 150673, XrefRangeStart = 150670, XrefRangeEnd = 150671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0004C948 File Offset: 0x0004AB48
		[CallerCount(0)]
		public unsafe static short ToInt16(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0004C988 File Offset: 0x0004AB88
		[CallerCount(0)]
		public unsafe static short ToInt16(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0004C9C8 File Offset: 0x0004ABC8
		[CallerCount(0)]
		public unsafe static short ToInt16(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0004CA08 File Offset: 0x0004AC08
		[CallerCount(0)]
		public unsafe static short ToInt16(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0004CA48 File Offset: 0x0004AC48
		[CallerCount(0)]
		public unsafe static short ToInt16(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0004CA88 File Offset: 0x0004AC88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 150673, RefRangeEnd = 150678, XrefRangeStart = 150673, XrefRangeEnd = 150673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0004CAC8 File Offset: 0x0004ACC8
		[CallerCount(0)]
		public unsafe static short ToInt16(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0004CB08 File Offset: 0x0004AD08
		[CallerCount(0)]
		public unsafe static short ToInt16(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0004CB48 File Offset: 0x0004AD48
		[CallerCount(0)]
		public unsafe static short ToInt16(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0004CB88 File Offset: 0x0004AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150678, XrefRangeEnd = 150687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150687, XrefRangeEnd = 150692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0004CC08 File Offset: 0x0004AE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150692, XrefRangeEnd = 150701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0004CC48 File Offset: 0x0004AE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150701, XrefRangeEnd = 150703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0004CC9C File Offset: 0x0004AE9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150704, RefRangeEnd = 150706, XrefRangeStart = 150703, XrefRangeEnd = 150704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0004CCF0 File Offset: 0x0004AEF0
		[CallerCount(0)]
		public unsafe static ushort ToUInt16(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0004CD30 File Offset: 0x0004AF30
		[CallerCount(0)]
		public unsafe static ushort ToUInt16(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0004CD70 File Offset: 0x0004AF70
		[CallerCount(0)]
		public unsafe static ushort ToUInt16(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
		[CallerCount(0)]
		public unsafe static ushort ToUInt16(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0004CDF0 File Offset: 0x0004AFF0
		[CallerCount(0)]
		public unsafe static ushort ToUInt16(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0004CE30 File Offset: 0x0004B030
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 150706, RefRangeEnd = 150711, XrefRangeStart = 150706, XrefRangeEnd = 150706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0004CE70 File Offset: 0x0004B070
		[CallerCount(0)]
		public unsafe static ushort ToUInt16(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0004CEB0 File Offset: 0x0004B0B0
		[CallerCount(0)]
		public unsafe static ushort ToUInt16(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
		[CallerCount(0)]
		public unsafe static ushort ToUInt16(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0004CF30 File Offset: 0x0004B130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150711, XrefRangeEnd = 150720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0004CF70 File Offset: 0x0004B170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150720, XrefRangeEnd = 150725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0004CFB0 File Offset: 0x0004B1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150725, XrefRangeEnd = 150734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0004CFF0 File Offset: 0x0004B1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150734, XrefRangeEnd = 150736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0004D044 File Offset: 0x0004B244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150737, RefRangeEnd = 150739, XrefRangeStart = 150736, XrefRangeEnd = 150737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0004D088 File Offset: 0x0004B288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150740, RefRangeEnd = 150743, XrefRangeStart = 150739, XrefRangeEnd = 150740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0004D0DC File Offset: 0x0004B2DC
		[CallerCount(0)]
		public unsafe static int ToInt32(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0004D11C File Offset: 0x0004B31C
		[CallerCount(0)]
		public unsafe static int ToInt32(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0004D15C File Offset: 0x0004B35C
		[CallerCount(0)]
		public unsafe static int ToInt32(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0004D19C File Offset: 0x0004B39C
		[CallerCount(0)]
		public unsafe static int ToInt32(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0004D1DC File Offset: 0x0004B3DC
		[CallerCount(0)]
		public unsafe static int ToInt32(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0004D21C File Offset: 0x0004B41C
		[CallerCount(0)]
		public unsafe static int ToInt32(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0004D25C File Offset: 0x0004B45C
		[CallerCount(0)]
		public unsafe static int ToInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0004D29C File Offset: 0x0004B49C
		[CallerCount(0)]
		public unsafe static int ToInt32(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0004D2DC File Offset: 0x0004B4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150743, XrefRangeEnd = 150747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0004D31C File Offset: 0x0004B51C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 150747, RefRangeEnd = 150767, XrefRangeStart = 150747, XrefRangeEnd = 150747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0004D35C File Offset: 0x0004B55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150767, XrefRangeEnd = 150772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0004D39C File Offset: 0x0004B59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150772, XrefRangeEnd = 150774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0004D3F0 File Offset: 0x0004B5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150774, XrefRangeEnd = 150775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0004D434 File Offset: 0x0004B634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150776, RefRangeEnd = 150778, XrefRangeStart = 150775, XrefRangeEnd = 150776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0004D488 File Offset: 0x0004B688
		[CallerCount(0)]
		public unsafe static uint ToUInt32(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0004D4C8 File Offset: 0x0004B6C8
		[CallerCount(0)]
		public unsafe static uint ToUInt32(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0004D508 File Offset: 0x0004B708
		[CallerCount(0)]
		public unsafe static uint ToUInt32(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0004D548 File Offset: 0x0004B748
		[CallerCount(0)]
		public unsafe static uint ToUInt32(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0004D588 File Offset: 0x0004B788
		[CallerCount(0)]
		public unsafe static uint ToUInt32(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0004D5C8 File Offset: 0x0004B7C8
		[CallerCount(0)]
		public unsafe static uint ToUInt32(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0004D608 File Offset: 0x0004B808
		[CallerCount(0)]
		public unsafe static uint ToUInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0004D648 File Offset: 0x0004B848
		[CallerCount(0)]
		public unsafe static uint ToUInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0004D688 File Offset: 0x0004B888
		[CallerCount(0)]
		public unsafe static uint ToUInt32(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0004D6C8 File Offset: 0x0004B8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150778, XrefRangeEnd = 150782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0004D708 File Offset: 0x0004B908
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150782, RefRangeEnd = 150785, XrefRangeStart = 150782, XrefRangeEnd = 150782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0004D748 File Offset: 0x0004B948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150785, XrefRangeEnd = 150794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0004D788 File Offset: 0x0004B988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150794, XrefRangeEnd = 150796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0004D7DC File Offset: 0x0004B9DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 150797, RefRangeEnd = 150802, XrefRangeStart = 150796, XrefRangeEnd = 150797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0004D830 File Offset: 0x0004BA30
		[CallerCount(0)]
		public unsafe static long ToInt64(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0004D870 File Offset: 0x0004BA70
		[CallerCount(0)]
		public unsafe static long ToInt64(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0004D8B0 File Offset: 0x0004BAB0
		[CallerCount(0)]
		public unsafe static long ToInt64(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0004D8F0 File Offset: 0x0004BAF0
		[CallerCount(0)]
		public unsafe static long ToInt64(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0004D930 File Offset: 0x0004BB30
		[CallerCount(0)]
		public unsafe static long ToInt64(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0004D970 File Offset: 0x0004BB70
		[CallerCount(0)]
		public unsafe static long ToInt64(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0004D9B0 File Offset: 0x0004BBB0
		[CallerCount(0)]
		public unsafe static long ToInt64(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0004D9F0 File Offset: 0x0004BBF0
		[CallerCount(0)]
		public unsafe static long ToInt64(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0004DA30 File Offset: 0x0004BC30
		[CallerCount(0)]
		public unsafe static long ToInt64(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0004DA70 File Offset: 0x0004BC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150802, XrefRangeEnd = 150806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0004DAB0 File Offset: 0x0004BCB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150811, RefRangeEnd = 150814, XrefRangeStart = 150806, XrefRangeEnd = 150811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0004DAF0 File Offset: 0x0004BCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150814, XrefRangeEnd = 150823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0004DB30 File Offset: 0x0004BD30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150830, RefRangeEnd = 150831, XrefRangeStart = 150823, XrefRangeEnd = 150830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0004DB74 File Offset: 0x0004BD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150831, XrefRangeEnd = 150833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0004DBC8 File Offset: 0x0004BDC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 150834, RefRangeEnd = 150838, XrefRangeStart = 150833, XrefRangeEnd = 150834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0004DC1C File Offset: 0x0004BE1C
		[CallerCount(0)]
		public unsafe static ulong ToUInt64(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0004DC5C File Offset: 0x0004BE5C
		[CallerCount(0)]
		public unsafe static ulong ToUInt64(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0004DC9C File Offset: 0x0004BE9C
		[CallerCount(0)]
		public unsafe static ulong ToUInt64(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0004DCDC File Offset: 0x0004BEDC
		[CallerCount(0)]
		public unsafe static ulong ToUInt64(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0004DD1C File Offset: 0x0004BF1C
		[CallerCount(0)]
		public unsafe static ulong ToUInt64(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0004DD5C File Offset: 0x0004BF5C
		[CallerCount(0)]
		public unsafe static ulong ToUInt64(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0004DD9C File Offset: 0x0004BF9C
		[CallerCount(0)]
		public unsafe static ulong ToUInt64(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0004DDDC File Offset: 0x0004BFDC
		[CallerCount(0)]
		public unsafe static ulong ToUInt64(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0004DE1C File Offset: 0x0004C01C
		[CallerCount(0)]
		public unsafe static ulong ToUInt64(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0004DE5C File Offset: 0x0004C05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150838, XrefRangeEnd = 150842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0004DE9C File Offset: 0x0004C09C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150847, RefRangeEnd = 150850, XrefRangeStart = 150842, XrefRangeEnd = 150847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0004DEDC File Offset: 0x0004C0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150850, XrefRangeEnd = 150859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0004DF1C File Offset: 0x0004C11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150859, XrefRangeEnd = 150861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0004DF70 File Offset: 0x0004C170
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150862, RefRangeEnd = 150865, XrefRangeStart = 150861, XrefRangeEnd = 150862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0004DFC4 File Offset: 0x0004C1C4
		[CallerCount(0)]
		public unsafe static float ToSingle(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0004E004 File Offset: 0x0004C204
		[CallerCount(0)]
		public unsafe static float ToSingle(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0004E044 File Offset: 0x0004C244
		[CallerCount(0)]
		public unsafe static float ToSingle(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0004E084 File Offset: 0x0004C284
		[CallerCount(0)]
		public unsafe static float ToSingle(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0004E0C4 File Offset: 0x0004C2C4
		[CallerCount(0)]
		public unsafe static float ToSingle(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0004E104 File Offset: 0x0004C304
		[CallerCount(0)]
		public unsafe static float ToSingle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0004E144 File Offset: 0x0004C344
		[CallerCount(0)]
		public unsafe static float ToSingle(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0004E184 File Offset: 0x0004C384
		[CallerCount(0)]
		public unsafe static float ToSingle(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0004E1C4 File Offset: 0x0004C3C4
		[CallerCount(0)]
		public unsafe static float ToSingle(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0004E204 File Offset: 0x0004C404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150865, XrefRangeEnd = 150873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0004E244 File Offset: 0x0004C444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150873, XrefRangeEnd = 150875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0004E298 File Offset: 0x0004C498
		[CallerCount(0)]
		public unsafe static float ToSingle(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0004E2D8 File Offset: 0x0004C4D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150876, RefRangeEnd = 150878, XrefRangeStart = 150875, XrefRangeEnd = 150876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0004E32C File Offset: 0x0004C52C
		[CallerCount(0)]
		public unsafe static double ToDouble(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0004E36C File Offset: 0x0004C56C
		[CallerCount(0)]
		public unsafe static double ToDouble(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0004E3AC File Offset: 0x0004C5AC
		[CallerCount(0)]
		public unsafe static double ToDouble(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0004E3EC File Offset: 0x0004C5EC
		[CallerCount(0)]
		public unsafe static double ToDouble(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0004E42C File Offset: 0x0004C62C
		[CallerCount(0)]
		public unsafe static double ToDouble(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0004E46C File Offset: 0x0004C66C
		[CallerCount(0)]
		public unsafe static double ToDouble(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0004E4AC File Offset: 0x0004C6AC
		[CallerCount(0)]
		public unsafe static double ToDouble(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0004E4EC File Offset: 0x0004C6EC
		[CallerCount(0)]
		public unsafe static double ToDouble(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0004E52C File Offset: 0x0004C72C
		[CallerCount(0)]
		public unsafe static double ToDouble(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0004E56C File Offset: 0x0004C76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150878, XrefRangeEnd = 150886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0004E5AC File Offset: 0x0004C7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150886, XrefRangeEnd = 150890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0004E600 File Offset: 0x0004C800
		[CallerCount(0)]
		public unsafe static double ToDouble(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0004E640 File Offset: 0x0004C840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150895, RefRangeEnd = 150896, XrefRangeStart = 150890, XrefRangeEnd = 150895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0004E694 File Offset: 0x0004C894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150896, XrefRangeEnd = 150899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0004E6D4 File Offset: 0x0004C8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150899, XrefRangeEnd = 150902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0004E714 File Offset: 0x0004C914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150902, XrefRangeEnd = 150905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0004E754 File Offset: 0x0004C954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150905, XrefRangeEnd = 150908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0004E794 File Offset: 0x0004C994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150908, XrefRangeEnd = 150911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0004E7D4 File Offset: 0x0004C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150911, XrefRangeEnd = 150914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0004E814 File Offset: 0x0004CA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150914, XrefRangeEnd = 150917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0004E854 File Offset: 0x0004CA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150917, XrefRangeEnd = 150920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0004E894 File Offset: 0x0004CA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150920, XrefRangeEnd = 150924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0004E8D4 File Offset: 0x0004CAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150924, XrefRangeEnd = 150928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0004E914 File Offset: 0x0004CB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150928, XrefRangeEnd = 150937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0004E968 File Offset: 0x0004CB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150937, XrefRangeEnd = 150940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0004E9A8 File Offset: 0x0004CBA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150955, RefRangeEnd = 150956, XrefRangeStart = 150940, XrefRangeEnd = 150955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0004E9FC File Offset: 0x0004CBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150956, XrefRangeEnd = 150964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0004EA4C File Offset: 0x0004CC4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150968, RefRangeEnd = 150969, XrefRangeStart = 150964, XrefRangeEnd = 150968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(char value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0004EA98 File Offset: 0x0004CC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150969, XrefRangeEnd = 150971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0004EAE4 File Offset: 0x0004CCE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 150972, RefRangeEnd = 150978, XrefRangeStart = 150971, XrefRangeEnd = 150972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0004EB34 File Offset: 0x0004CD34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150979, RefRangeEnd = 150980, XrefRangeStart = 150978, XrefRangeEnd = 150979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0004EB84 File Offset: 0x0004CD84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150981, RefRangeEnd = 150982, XrefRangeStart = 150980, XrefRangeEnd = 150981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value, int toBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0004EBCC File Offset: 0x0004CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150982, XrefRangeEnd = 150986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0004EC08 File Offset: 0x0004CE08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150990, RefRangeEnd = 150993, XrefRangeStart = 150986, XrefRangeEnd = 150990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray, int offset, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0004EC60 File Offset: 0x0004CE60
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 151003, RefRangeEnd = 151038, XrefRangeStart = 150993, XrefRangeEnd = 151003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray, int offset, int length, Base64FormattingOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0004ECC8 File Offset: 0x0004CEC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151042, RefRangeEnd = 151043, XrefRangeStart = 151038, XrefRangeEnd = 151042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToBase64CharArray(Il2CppStructArray<byte> inArray, int offsetIn, int length, Il2CppStructArray<char> outArray, int offsetOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArray);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0004ED48 File Offset: 0x0004CF48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151051, RefRangeEnd = 151052, XrefRangeStart = 151043, XrefRangeEnd = 151051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToBase64CharArray(Il2CppStructArray<byte> inArray, int offsetIn, int length, Il2CppStructArray<char> outArray, int offsetOut, Base64FormattingOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArray);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetOut;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Base64FormattingOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0004EDD4 File Offset: 0x0004CFD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151058, RefRangeEnd = 151060, XrefRangeStart = 151052, XrefRangeEnd = 151058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = outChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = inData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertLineBreaks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0004EE48 File Offset: 0x0004D048
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151060, RefRangeEnd = 151062, XrefRangeStart = 151060, XrefRangeEnd = 151060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertLineBreaks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0004EE94 File Offset: 0x0004D094
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 151072, RefRangeEnd = 151085, XrefRangeStart = 151062, XrefRangeEnd = 151072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBase64String(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0004EED8 File Offset: 0x0004D0D8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 151097, RefRangeEnd = 151115, XrefRangeStart = 151085, XrefRangeEnd = 151097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBase64CharPtr(char* inputPtr, int inputLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = inputPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0004EF28 File Offset: 0x0004D128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151121, RefRangeEnd = 151122, XrefRangeStart = 151115, XrefRangeEnd = 151121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = startInputPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = startDestPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64_Decode_Private_Static_Int32_ptr_Char_Int32_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0004EF90 File Offset: 0x0004D190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151122, XrefRangeEnd = 151124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = inputPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00004988 File Offset: 0x00002B88
		public Convert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0004EFDC File Offset: 0x0004D1DC
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x00004991 File Offset: 0x00002B91
		public unsafe static Il2CppReferenceArray<RuntimeType> ConvertTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_ConvertTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_ConvertTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0004F004 File Offset: 0x0004D204
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x000049A3 File Offset: 0x00002BA3
		public unsafe static RuntimeType EnumType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_EnumType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_EnumType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0004F02C File Offset: 0x0004D22C
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x000049B5 File Offset: 0x00002BB5
		public unsafe static Il2CppStructArray<char> base64Table
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_base64Table, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_base64Table, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0004F054 File Offset: 0x0004D254
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x000049C7 File Offset: 0x00002BC7
		public unsafe static Object DBNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_DBNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_DBNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_ConvertTypes;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_EnumType;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_base64Table;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_DBNull;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_Int32_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Base64FormattingOptions_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64_Decode_Private_Static_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0;
	}
}
