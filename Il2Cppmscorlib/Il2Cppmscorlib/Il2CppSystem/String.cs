using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000E9 RID: 233
	[DefaultMember("Item")]
	[Serializable]
	public sealed class String : Object
	{
		// Token: 0x06000FF3 RID: 4083 RVA: 0x0006CDCC File Offset: 0x0006AFCC
		// Note: this type is marked as 'beforefieldinit'.
		static String()
		{
			Il2CppClassPointerStore<string>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "String");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<string>.NativeClassPtr);
			String.NativeFieldInfoPtr_m_stringLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "m_stringLength");
			String.NativeFieldInfoPtr_m_firstChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "m_firstChar");
			String.NativeFieldInfoPtr_TrimHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "TrimHead");
			String.NativeFieldInfoPtr_TrimTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "TrimTail");
			String.NativeFieldInfoPtr_TrimBoth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "TrimBoth");
			String.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "Empty");
			String.NativeFieldInfoPtr_charPtrAlignConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "charPtrAlignConst");
			String.NativeFieldInfoPtr_alignConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "alignConst");
			String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666029);
			String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666030);
			String.NativeMethodInfoPtr_CompareOrdinalIgnoreCaseHelper_Private_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666031);
			String.NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666032);
			String.NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666033);
			String.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666034);
			String.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666035);
			String.NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666036);
			String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666037);
			String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666038);
			String.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666039);
			String.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666040);
			String.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666041);
			String.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666042);
			String.NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666043);
			String.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666044);
			String.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666045);
			String.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666046);
			String.NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666047);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666048);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666049);
			String.NativeMethodInfoPtr_SplitInternal_Internal_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666050);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666051);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666052);
			String.NativeMethodInfoPtr_InternalSplitKeepEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666053);
			String.NativeMethodInfoPtr_InternalSplitOmitEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666054);
			String.NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStructArray_1_Char_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666055);
			String.NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666056);
			String.NativeMethodInfoPtr_Substring_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666057);
			String.NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666058);
			String.NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666059);
			String.NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666060);
			String.NativeMethodInfoPtr_TrimStart_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666061);
			String.NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666062);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666063);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666064);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666065);
			String.NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666066);
			String.NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666067);
			String.NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666068);
			String.NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666069);
			String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666070);
			String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666071);
			String.NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666072);
			String.NativeMethodInfoPtr_CtorCharArray_Private_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666073);
			String.NativeMethodInfoPtr_CtorCharArrayStartLength_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666074);
			String.NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666075);
			String.NativeMethodInfoPtr_CtorCharPtr_Private_String_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666076);
			String.NativeMethodInfoPtr_CtorCharPtrStartLength_Private_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666077);
			String.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666078);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666079);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666080);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666081);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666082);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666083);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666084);
			String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666085);
			String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666086);
			String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666087);
			String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666088);
			String.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666089);
			String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666090);
			String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666091);
			String.NativeMethodInfoPtr_EndsWith_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666092);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666093);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666094);
			String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666095);
			String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666096);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666097);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666098);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666099);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666100);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666101);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666102);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666103);
			String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666104);
			String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666105);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666106);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666107);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666108);
			String.NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666109);
			String.NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666110);
			String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666111);
			String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666112);
			String.NativeMethodInfoPtr_ToLower_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666113);
			String.NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666114);
			String.NativeMethodInfoPtr_ToLowerInvariant_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666115);
			String.NativeMethodInfoPtr_ToUpper_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666116);
			String.NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666117);
			String.NativeMethodInfoPtr_ToUpperInvariant_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666118);
			String.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666119);
			String.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666120);
			String.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666121);
			String.NativeMethodInfoPtr_IsBOMWhitespace_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666122);
			String.NativeMethodInfoPtr_Trim_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666123);
			String.NativeMethodInfoPtr_TrimHelper_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666124);
			String.NativeMethodInfoPtr_TrimHelper_Private_String_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666125);
			String.NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666126);
			String.NativeMethodInfoPtr_Insert_Public_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666127);
			String.NativeMethodInfoPtr_Replace_Public_String_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666128);
			String.NativeMethodInfoPtr_Replace_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666129);
			String.NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666130);
			String.NativeMethodInfoPtr_Remove_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666131);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666132);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666133);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666134);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666135);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666136);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666137);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666138);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666139);
			String.NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666140);
			String.NativeMethodInfoPtr_Copy_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666141);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666142);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666143);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666144);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666145);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666146);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666147);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666148);
			String.NativeMethodInfoPtr_ConcatArray_Private_Static_String_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666149);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666150);
			String.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666151);
			String.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666152);
			String.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666153);
			String.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666154);
			String.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666155);
			String.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666156);
			String.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666157);
			String.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666158);
			String.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666159);
			String.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666160);
			String.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666161);
			String.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666162);
			String.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666163);
			String.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666164);
			String.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666165);
			String.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666166);
			String.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666167);
			String.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666168);
			String.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666169);
			String.NativeMethodInfoPtr_CompareOrdinalUnchecked_Internal_Static_Int32_String_Int32_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666170);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666171);
			String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666172);
			String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666173);
			String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666174);
			String.NativeMethodInfoPtr_IndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666175);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666176);
			String.NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666177);
			String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666178);
			String.NativeMethodInfoPtr_LastIndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666179);
			String.NativeMethodInfoPtr_nativeCompareOrdinalEx_Internal_Static_Int32_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666180);
			String.NativeMethodInfoPtr_ReplaceInternal_Private_String_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666181);
			String.NativeMethodInfoPtr_ReplaceInternal_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666182);
			String.NativeMethodInfoPtr_ReplaceUnchecked_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666183);
			String.NativeMethodInfoPtr_ReplaceFallback_Private_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666184);
			String.NativeMethodInfoPtr_PadHelper_Private_String_Int32_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666185);
			String.NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666186);
			String.NativeMethodInfoPtr_IsAscii_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666187);
			String.NativeMethodInfoPtr_CharCopy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666188);
			String.NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666189);
			String.NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666190);
			String.NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666191);
			String.NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666192);
			String.NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666193);
			String.NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666194);
			String.NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666195);
			String.NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666196);
			String.NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666197);
			String.NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666198);
			String.NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666199);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666200);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666201);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666202);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666203);
			String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666204);
			String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666205);
			String.NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666206);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666207);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0006DC98 File Offset: 0x0006BE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162986, XrefRangeEnd = 162987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(string separator, [Optional] Il2CppStringArray value)
		{
			if (value == null)
			{
				value = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0006DCF4 File Offset: 0x0006BEF4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 162993, RefRangeEnd = 163001, XrefRangeStart = 162987, XrefRangeEnd = 162993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(string separator, Il2CppStringArray value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0006DD60 File Offset: 0x0006BF60
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 163004, RefRangeEnd = 163109, XrefRangeStart = 163001, XrefRangeEnd = 163004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalIgnoreCaseHelper(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinalIgnoreCaseHelper_Private_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0006DDB4 File Offset: 0x0006BFB4
		[CallerCount(0)]
		public unsafe static bool EqualsHelper(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0006DE08 File Offset: 0x0006C008
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 163112, RefRangeEnd = 163160, XrefRangeStart = 163109, XrefRangeEnd = 163112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalHelper(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0006DE5C File Offset: 0x0006C05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163160, XrefRangeEnd = 163162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0006DEAC File Offset: 0x0006C0AC
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 163162, RefRangeEnd = 163218, XrefRangeStart = 163162, XrefRangeEnd = 163162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0006DEFC File Offset: 0x0006C0FC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 163223, RefRangeEnd = 163236, XrefRangeStart = 163218, XrefRangeEnd = 163223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0006DF58 File Offset: 0x0006C158
		[CallerCount(278)]
		[CachedScanResults(RefRangeStart = 163236, RefRangeEnd = 163514, XrefRangeStart = 163236, XrefRangeEnd = 163236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equals(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0006DFAC File Offset: 0x0006C1AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 163519, RefRangeEnd = 163522, XrefRangeStart = 163514, XrefRangeEnd = 163519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equals(string a, string b, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0006E010 File Offset: 0x0006C210
		[CallerCount(278)]
		[CachedScanResults(RefRangeStart = 163236, RefRangeEnd = 163514, XrefRangeStart = 163236, XrefRangeEnd = 163514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0006E064 File Offset: 0x0006C264
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 163522, RefRangeEnd = 163537, XrefRangeStart = 163522, XrefRangeEnd = 163522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0006E0B8 File Offset: 0x0006C2B8
		public unsafe char Chars
		{
			[CallerCount(405)]
			[CachedScanResults(RefRangeStart = 163537, RefRangeEnd = 163942, XrefRangeStart = 163537, XrefRangeEnd = 163537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0006E104 File Offset: 0x0006C304
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 163944, RefRangeEnd = 163960, XrefRangeStart = 163942, XrefRangeEnd = 163944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(int sourceIndex, Il2CppStructArray<char> destination, int destinationIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0006E170 File Offset: 0x0006C370
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 163965, RefRangeEnd = 164010, XrefRangeStart = 163960, XrefRangeEnd = 163965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<char> ToCharArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0006E1B0 File Offset: 0x0006C3B0
		[CallerCount(0)]
		public unsafe static bool IsNullOrEmpty(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0006E1F4 File Offset: 0x0006C3F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164016, RefRangeEnd = 164018, XrefRangeStart = 164010, XrefRangeEnd = 164016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrWhiteSpace(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0006E238 File Offset: 0x0006C438
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0006E274 File Offset: 0x0006C474
		[CallerCount(0)]
		public unsafe int GetLegacyNonRandomizedHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0006E2B0 File Offset: 0x0006C4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164018, XrefRangeEnd = 164019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split([Optional] Il2CppStructArray<char> separator)
		{
			if (separator == null)
			{
				separator = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0006E310 File Offset: 0x0006C510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164019, XrefRangeEnd = 164020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStructArray<char> separator, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0006E370 File Offset: 0x0006C570
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 164026, RefRangeEnd = 164078, XrefRangeStart = 164020, XrefRangeEnd = 164026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray SplitInternal(Il2CppStructArray<char> separator, int count, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_SplitInternal_Internal_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0006E3DC File Offset: 0x0006C5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164078, XrefRangeEnd = 164079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStringArray separator, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0006E43C File Offset: 0x0006C63C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 164087, RefRangeEnd = 164095, XrefRangeStart = 164079, XrefRangeEnd = 164087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStringArray separator, int count, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0006E4A8 File Offset: 0x0006C6A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164108, RefRangeEnd = 164110, XrefRangeStart = 164095, XrefRangeEnd = 164108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray InternalSplitKeepEmptyEntries(Il2CppStructArray<int> sepList, Il2CppStructArray<int> lengthList, int numReplaces, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sepList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numReplaces;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_InternalSplitKeepEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0006E528 File Offset: 0x0006C728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164110, XrefRangeEnd = 164127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray InternalSplitOmitEmptyEntries(Il2CppStructArray<int> sepList, Il2CppStructArray<int> lengthList, int numReplaces, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sepList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numReplaces;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_InternalSplitOmitEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0006E5A8 File Offset: 0x0006C7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164130, RefRangeEnd = 164131, XrefRangeStart = 164127, XrefRangeEnd = 164130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MakeSeparatorList(Il2CppStructArray<char> separator, ref Il2CppStructArray<int> sepList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sepList);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStructArray_1_Char_byref_Il2CppStructArray_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sepList = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0006E620 File Offset: 0x0006C820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164134, RefRangeEnd = 164135, XrefRangeStart = 164131, XrefRangeEnd = 164134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MakeSeparatorList(Il2CppStringArray separators, ref Il2CppStructArray<int> sepList, ref Il2CppStructArray<int> lengthList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separators);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sepList);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(lengthList);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sepList = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			lengthList = ((intPtr6 == 0) ? null : new Il2CppStructArray<int>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0006E6C0 File Offset: 0x0006C8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164135, XrefRangeEnd = 164136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Substring(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Substring_Public_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0006E704 File Offset: 0x0006C904
		[CallerCount(331)]
		[CachedScanResults(RefRangeStart = 164137, RefRangeEnd = 164468, XrefRangeStart = 164136, XrefRangeEnd = 164137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Substring(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0006E758 File Offset: 0x0006C958
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 164470, RefRangeEnd = 164479, XrefRangeStart = 164468, XrefRangeEnd = 164470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalSubString(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0006E7AC File Offset: 0x0006C9AC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 164485, RefRangeEnd = 164501, XrefRangeStart = 164479, XrefRangeEnd = 164485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Trim([Optional] Il2CppStructArray<char> trimChars)
		{
			if (trimChars == null)
			{
				trimChars = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0006E804 File Offset: 0x0006CA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164501, XrefRangeEnd = 164506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimStart([Optional] Il2CppStructArray<char> trimChars)
		{
			if (trimChars == null)
			{
				trimChars = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimStart_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0006E85C File Offset: 0x0006CA5C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 164509, RefRangeEnd = 164516, XrefRangeStart = 164506, XrefRangeEnd = 164509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimEnd([Optional] Il2CppStructArray<char> trimChars)
		{
			if (trimChars == null)
			{
				trimChars = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0006E8B4 File Offset: 0x0006CAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164516, XrefRangeEnd = 164517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(char* value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0006E8FC File Offset: 0x0006CAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(char* value, int startIndex, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0006E960 File Offset: 0x0006CB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164517, XrefRangeEnd = 164518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(sbyte* value, int startIndex, int length, Encoding enc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0006E9D8 File Offset: 0x0006CBD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 164520, RefRangeEnd = 164526, XrefRangeStart = 164518, XrefRangeEnd = 164520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0006EA30 File Offset: 0x0006CC30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 164540, RefRangeEnd = 164547, XrefRangeStart = 164526, XrefRangeEnd = 164540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Normalize(NormalizationForm normalizationForm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref normalizationForm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0006EA74 File Offset: 0x0006CC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164547, XrefRangeEnd = 164548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FastAllocateString(int length)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0006EAAC File Offset: 0x0006CCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164548, XrefRangeEnd = 164555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillStringChecked(string dest, int destPos, string src)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(src);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0006EB04 File Offset: 0x0006CD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(Il2CppStructArray<char> value, int startIndex, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0006EB6C File Offset: 0x0006CD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(Il2CppStructArray<char> value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0006EBB8 File Offset: 0x0006CDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164555, XrefRangeEnd = 164556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dmem;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = smem;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0006EC04 File Offset: 0x0006CE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164556, XrefRangeEnd = 164560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CtorCharArray(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CtorCharArray_Private_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0006EC4C File Offset: 0x0006CE4C
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 164562, RefRangeEnd = 164621, XrefRangeStart = 164560, XrefRangeEnd = 164562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CtorCharArrayStartLength(Il2CppStructArray<char> value, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CtorCharArrayStartLength_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0006ECB0 File Offset: 0x0006CEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164621, XrefRangeEnd = 164622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int wcslen(char* ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0006ECEC File Offset: 0x0006CEEC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 164628, RefRangeEnd = 164643, XrefRangeStart = 164622, XrefRangeEnd = 164628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CtorCharPtr(char* ptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CtorCharPtr_Private_String_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0006ED30 File Offset: 0x0006CF30
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 164646, RefRangeEnd = 164675, XrefRangeStart = 164643, XrefRangeEnd = 164646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CtorCharPtrStartLength(char* ptr, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CtorCharPtrStartLength_Private_String_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0006ED90 File Offset: 0x0006CF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(char c, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0006EDE8 File Offset: 0x0006CFE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164684, RefRangeEnd = 164686, XrefRangeStart = 164675, XrefRangeEnd = 164684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0006EE4C File Offset: 0x0006D04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164691, RefRangeEnd = 164692, XrefRangeStart = 164686, XrefRangeEnd = 164691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0006EEB0 File Offset: 0x0006D0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164692, XrefRangeEnd = 164700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0006EF24 File Offset: 0x0006D124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164700, XrefRangeEnd = 164705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0006EFA4 File Offset: 0x0006D1A4
		[CallerCount(0)]
		public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0006F044 File Offset: 0x0006D244
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 164724, RefRangeEnd = 164736, XrefRangeStart = 164705, XrefRangeEnd = 164724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0006F0D0 File Offset: 0x0006D2D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164744, RefRangeEnd = 164745, XrefRangeStart = 164736, XrefRangeEnd = 164744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0006F120 File Offset: 0x0006D320
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 164750, RefRangeEnd = 164754, XrefRangeStart = 164745, XrefRangeEnd = 164750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(string strB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strB);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0006F170 File Offset: 0x0006D370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164754, XrefRangeEnd = 164755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0006F1C4 File Offset: 0x0006D3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164755, XrefRangeEnd = 164756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0006F244 File Offset: 0x0006D444
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 164761, RefRangeEnd = 164785, XrefRangeStart = 164756, XrefRangeEnd = 164761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0006F294 File Offset: 0x0006D494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164785, XrefRangeEnd = 164786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0006F2E4 File Offset: 0x0006D4E4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 164792, RefRangeEnd = 164807, XrefRangeStart = 164786, XrefRangeEnd = 164792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0006F340 File Offset: 0x0006D540
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 164807, RefRangeEnd = 164811, XrefRangeStart = 164807, XrefRangeEnd = 164807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EndsWith_Internal_Boolean_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0006F38C File Offset: 0x0006D58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164811, XrefRangeEnd = 164812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0006F3D8 File Offset: 0x0006D5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164812, XrefRangeEnd = 164813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0006F430 File Offset: 0x0006D630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164813, XrefRangeEnd = 164814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0006F480 File Offset: 0x0006D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164814, XrefRangeEnd = 164815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0006F4DC File Offset: 0x0006D6DC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 164821, RefRangeEnd = 164843, XrefRangeStart = 164815, XrefRangeEnd = 164821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0006F52C File Offset: 0x0006D72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164843, XrefRangeEnd = 164844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0006F588 File Offset: 0x0006D788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164844, XrefRangeEnd = 164845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0006F5E4 File Offset: 0x0006D7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164845, XrefRangeEnd = 164846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0006F650 File Offset: 0x0006D850
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 164869, RefRangeEnd = 164884, XrefRangeStart = 164846, XrefRangeEnd = 164869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0006F6C8 File Offset: 0x0006D8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164884, XrefRangeEnd = 164885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0006F714 File Offset: 0x0006D914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164885, XrefRangeEnd = 164886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0006F76C File Offset: 0x0006D96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164886, XrefRangeEnd = 164887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0006F7BC File Offset: 0x0006D9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164887, XrefRangeEnd = 164888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0006F818 File Offset: 0x0006DA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164888, XrefRangeEnd = 164889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0006F868 File Offset: 0x0006DA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164889, XrefRangeEnd = 164890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0006F8C4 File Offset: 0x0006DAC4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 164891, RefRangeEnd = 164899, XrefRangeStart = 164890, XrefRangeEnd = 164891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0006F93C File Offset: 0x0006DB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164899, XrefRangeEnd = 164900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PadLeft(int totalWidth, char paddingChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0006F990 File Offset: 0x0006DB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164900, XrefRangeEnd = 164901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PadRight(int totalWidth, char paddingChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0006F9E4 File Offset: 0x0006DBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164901, XrefRangeEnd = 164908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0006FA34 File Offset: 0x0006DC34
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 164914, RefRangeEnd = 164941, XrefRangeStart = 164908, XrefRangeEnd = 164914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0006FA90 File Offset: 0x0006DC90
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 164953, RefRangeEnd = 164978, XrefRangeStart = 164941, XrefRangeEnd = 164953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLower()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToLower_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0006FAC8 File Offset: 0x0006DCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164978, XrefRangeEnd = 164985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLower(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0006FB10 File Offset: 0x0006DD10
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 165000, RefRangeEnd = 165015, XrefRangeStart = 164985, XrefRangeEnd = 165000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLowerInvariant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToLowerInvariant_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0006FB48 File Offset: 0x0006DD48
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 165027, RefRangeEnd = 165045, XrefRangeStart = 165015, XrefRangeEnd = 165027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToUpper_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0006FB80 File Offset: 0x0006DD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165045, XrefRangeEnd = 165052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpper(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0006FBC8 File Offset: 0x0006DDC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 165067, RefRangeEnd = 165075, XrefRangeStart = 165052, XrefRangeEnd = 165067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpperInvariant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToUpperInvariant_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0006FC00 File Offset: 0x0006DE00
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0006FC38 File Offset: 0x0006DE38
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0006FC80 File Offset: 0x0006DE80
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0006FCC0 File Offset: 0x0006DEC0
		[CallerCount(0)]
		public unsafe static bool IsBOMWhitespace(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsBOMWhitespace_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0006FD00 File Offset: 0x0006DF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165075, XrefRangeEnd = 165076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Trim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Trim_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0006FD38 File Offset: 0x0006DF38
		[CallerCount(112)]
		[CachedScanResults(RefRangeStart = 165091, RefRangeEnd = 165203, XrefRangeStart = 165076, XrefRangeEnd = 165091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimHelper(int trimType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trimType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimHelper_Private_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0006FD7C File Offset: 0x0006DF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165203, XrefRangeEnd = 165209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimHelper(Il2CppStructArray<char> trimChars, int trimType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trimType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimHelper_Private_String_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0006FDD4 File Offset: 0x0006DFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165209, XrefRangeEnd = 165212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateTrimmedString(int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0006FE28 File Offset: 0x0006E028
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 165217, RefRangeEnd = 165220, XrefRangeStart = 165212, XrefRangeEnd = 165217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Insert(int startIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Insert_Public_String_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0006FE80 File Offset: 0x0006E080
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 165225, RefRangeEnd = 165251, XrefRangeStart = 165220, XrefRangeEnd = 165225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(char oldChar, char newChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Replace_Public_String_Char_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0006FED4 File Offset: 0x0006E0D4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 165254, RefRangeEnd = 165279, XrefRangeStart = 165251, XrefRangeEnd = 165254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Replace_Public_String_String_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0006FF30 File Offset: 0x0006E130
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 165283, RefRangeEnd = 165301, XrefRangeStart = 165279, XrefRangeEnd = 165283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Remove(int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0006FF84 File Offset: 0x0006E184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165318, RefRangeEnd = 165319, XrefRangeStart = 165301, XrefRangeEnd = 165318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Remove(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Remove_Public_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0006FFC8 File Offset: 0x0006E1C8
		[CallerCount(86)]
		[CachedScanResults(RefRangeStart = 165323, RefRangeEnd = 165409, XrefRangeStart = 165319, XrefRangeEnd = 165323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00070018 File Offset: 0x0006E218
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 165413, RefRangeEnd = 165460, XrefRangeStart = 165409, XrefRangeEnd = 165413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00070078 File Offset: 0x0006E278
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 165464, RefRangeEnd = 165485, XrefRangeStart = 165460, XrefRangeEnd = 165464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000700EC File Offset: 0x0006E2EC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 165489, RefRangeEnd = 165520, XrefRangeStart = 165485, XrefRangeEnd = 165489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00070148 File Offset: 0x0006E348
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 165524, RefRangeEnd = 165550, XrefRangeStart = 165520, XrefRangeEnd = 165524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, Object arg0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x000701A8 File Offset: 0x0006E3A8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 165554, RefRangeEnd = 165562, XrefRangeStart = 165550, XrefRangeEnd = 165554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0007021C File Offset: 0x0006E41C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 165566, RefRangeEnd = 165570, XrefRangeStart = 165562, XrefRangeEnd = 165566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x000702A4 File Offset: 0x0006E4A4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 165574, RefRangeEnd = 165589, XrefRangeStart = 165570, XrefRangeEnd = 165574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00070314 File Offset: 0x0006E514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165589, XrefRangeEnd = 165592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0007037C File Offset: 0x0006E57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165592, XrefRangeEnd = 165594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Copy(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Copy_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x000703B8 File Offset: 0x0006E5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165594, XrefRangeEnd = 165596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(Object arg0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x000703F4 File Offset: 0x0006E5F4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 165600, RefRangeEnd = 165610, XrefRangeStart = 165596, XrefRangeEnd = 165600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00070444 File Offset: 0x0006E644
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 165614, RefRangeEnd = 165620, XrefRangeStart = 165610, XrefRangeEnd = 165614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000704A4 File Offset: 0x0006E6A4
		[CallerCount(159)]
		[CachedScanResults(RefRangeStart = 165655, RefRangeEnd = 165814, XrefRangeStart = 165620, XrefRangeEnd = 165655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x000704F0 File Offset: 0x0006E6F0
		[CallerCount(749)]
		[CachedScanResults(RefRangeStart = 165818, RefRangeEnd = 166567, XrefRangeStart = 165814, XrefRangeEnd = 165818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(string str0, string str1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00070540 File Offset: 0x0006E740
		[CallerCount(452)]
		[CachedScanResults(RefRangeStart = 166569, RefRangeEnd = 167021, XrefRangeStart = 166567, XrefRangeEnd = 166569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(string str0, string str1, string str2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x000705A0 File Offset: 0x0006E7A0
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 167029, RefRangeEnd = 167129, XrefRangeStart = 167021, XrefRangeEnd = 167029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(string str0, string str1, string str2, string str3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00070614 File Offset: 0x0006E814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167132, RefRangeEnd = 167134, XrefRangeStart = 167129, XrefRangeEnd = 167132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConcatArray(Il2CppStringArray values, int totalLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ConcatArray_Private_Static_String_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00070660 File Offset: 0x0006E860
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 167161, RefRangeEnd = 167223, XrefRangeStart = 167134, XrefRangeEnd = 167161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat([Optional] Il2CppStringArray values)
		{
			if (values == null)
			{
				values = new Il2CppStringArray(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000706AC File Offset: 0x0006E8AC
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000706E8 File Offset: 0x0006E8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167223, XrefRangeEnd = 167230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00070738 File Offset: 0x0006E938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167230, XrefRangeEnd = 167233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00070788 File Offset: 0x0006E988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167233, XrefRangeEnd = 167238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x000707D8 File Offset: 0x0006E9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167238, XrefRangeEnd = 167243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00070828 File Offset: 0x0006EA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167243, XrefRangeEnd = 167248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00070878 File Offset: 0x0006EA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167248, XrefRangeEnd = 167253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000708C8 File Offset: 0x0006EAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167253, XrefRangeEnd = 167258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00070918 File Offset: 0x0006EB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167258, XrefRangeEnd = 167263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00070968 File Offset: 0x0006EB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167263, XrefRangeEnd = 167268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000709B8 File Offset: 0x0006EBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167268, XrefRangeEnd = 167273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00070A08 File Offset: 0x0006EC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167273, XrefRangeEnd = 167278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00070A58 File Offset: 0x0006EC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167278, XrefRangeEnd = 167285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00070AA8 File Offset: 0x0006ECA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167285, XrefRangeEnd = 167297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00070AF8 File Offset: 0x0006ECF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167297, XrefRangeEnd = 167301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00070B48 File Offset: 0x0006ED48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167301, XrefRangeEnd = 167305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00070BAC File Offset: 0x0006EDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167305, XrefRangeEnd = 167308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<char> System_Collections_Generic_IEnumerable_System_Char__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<char>>(intPtr3) : null;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00070BEC File Offset: 0x0006EDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167308, XrefRangeEnd = 167311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00070C2C File Offset: 0x0006EE2C
		public unsafe int Length
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00070C68 File Offset: 0x0006EE68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167315, RefRangeEnd = 167316, XrefRangeStart = 167311, XrefRangeEnd = 167315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lenA;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lenB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinalUnchecked_Internal_Static_Int32_String_Int32_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00070CF4 File Offset: 0x0006EEF4
		[CallerCount(115)]
		[CachedScanResults(RefRangeStart = 167318, RefRangeEnd = 167433, XrefRangeStart = 167316, XrefRangeEnd = 167318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00070D5C File Offset: 0x0006EF5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167433, RefRangeEnd = 167436, XrefRangeStart = 167433, XrefRangeEnd = 167433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfUnchecked(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00070DC4 File Offset: 0x0006EFC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167437, RefRangeEnd = 167439, XrefRangeStart = 167436, XrefRangeEnd = 167437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfUnchecked(string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00070E30 File Offset: 0x0006F030
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 167441, RefRangeEnd = 167499, XrefRangeStart = 167439, XrefRangeEnd = 167441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00070E9C File Offset: 0x0006F09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167499, XrefRangeEnd = 167501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAnyUnchecked(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00070F08 File Offset: 0x0006F108
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 167502, RefRangeEnd = 167535, XrefRangeStart = 167501, XrefRangeEnd = 167502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00070F70 File Offset: 0x0006F170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167535, RefRangeEnd = 167536, XrefRangeStart = 167535, XrefRangeEnd = 167535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfUnchecked(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00070FD8 File Offset: 0x0006F1D8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 167537, RefRangeEnd = 167554, XrefRangeStart = 167536, XrefRangeEnd = 167537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00071044 File Offset: 0x0006F244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167554, XrefRangeEnd = 167555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAnyUnchecked(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x000710B0 File Offset: 0x0006F2B0
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 167556, RefRangeEnd = 167593, XrefRangeStart = 167555, XrefRangeEnd = 167556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_nativeCompareOrdinalEx_Internal_Static_Int32_String_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00071130 File Offset: 0x0006F330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167593, XrefRangeEnd = 167599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReplaceInternal(char oldChar, char newChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ReplaceInternal_Private_String_Char_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00071184 File Offset: 0x0006F384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167599, XrefRangeEnd = 167602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReplaceInternal(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ReplaceInternal_Internal_String_String_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000711E0 File Offset: 0x0006F3E0
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 167604, RefRangeEnd = 167637, XrefRangeStart = 167602, XrefRangeEnd = 167604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReplaceUnchecked(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ReplaceUnchecked_Private_String_String_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0007123C File Offset: 0x0006F43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167637, XrefRangeEnd = 167652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReplaceFallback(string oldValue, string newValue, int testedCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref testedCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ReplaceFallback_Private_String_String_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x000712A4 File Offset: 0x0006F4A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 167660, RefRangeEnd = 167664, XrefRangeStart = 167652, XrefRangeEnd = 167660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PadHelper(int totalWidth, char paddingChar, bool isRightPadded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRightPadded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_PadHelper_Private_String_Int32_Char_Boolean_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00071304 File Offset: 0x0006F504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167664, RefRangeEnd = 167665, XrefRangeStart = 167664, XrefRangeEnd = 167664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWithOrdinalUnchecked(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00071354 File Offset: 0x0006F554
		[CallerCount(0)]
		public unsafe bool IsAscii()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsAscii_Internal_Boolean_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00071390 File Offset: 0x0006F590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167665, XrefRangeEnd = 167667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CharCopy(char* dest, char* src, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CharCopy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000713DC File Offset: 0x0006F5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167667, XrefRangeEnd = 167668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void memset(byte* dest, int val, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0007142C File Offset: 0x0006F62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167668, XrefRangeEnd = 167669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void memcpy(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00071478 File Offset: 0x0006F678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167669, XrefRangeEnd = 167671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void bzero(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x000714B8 File Offset: 0x0006F6B8
		[CallerCount(0)]
		public unsafe static void bzero_aligned_1(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x000714F8 File Offset: 0x0006F6F8
		[CallerCount(0)]
		public unsafe static void bzero_aligned_2(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00071538 File Offset: 0x0006F738
		[CallerCount(0)]
		public unsafe static void bzero_aligned_4(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00071578 File Offset: 0x0006F778
		[CallerCount(0)]
		public unsafe static void bzero_aligned_8(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x000715B8 File Offset: 0x0006F7B8
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00071604 File Offset: 0x0006F804
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00071650 File Offset: 0x0006F850
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0007169C File Offset: 0x0006F89C
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000716E8 File Offset: 0x0006F8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167671, XrefRangeEnd = 167673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(sbyte* value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0007172C File Offset: 0x0006F92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167673, XrefRangeEnd = 167674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(sbyte* value, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0007178C File Offset: 0x0006F98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167674, XrefRangeEnd = 167675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(char* value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x000717D0 File Offset: 0x0006F9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167675, XrefRangeEnd = 167676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(char* value, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00071830 File Offset: 0x0006FA30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167677, RefRangeEnd = 167678, XrefRangeStart = 167676, XrefRangeEnd = 167677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(Il2CppStructArray<char> val, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00071894 File Offset: 0x0006FA94
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 167681, RefRangeEnd = 167701, XrefRangeStart = 167678, XrefRangeEnd = 167681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(Il2CppStructArray<char> val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x000718DC File Offset: 0x0006FADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167703, RefRangeEnd = 167705, XrefRangeStart = 167701, XrefRangeEnd = 167703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(char c, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00071930 File Offset: 0x0006FB30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167712, RefRangeEnd = 167715, XrefRangeStart = 167705, XrefRangeEnd = 167712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00005F58 File Offset: 0x00004158
		public static string Join(string separator, params string[] value)
		{
			return String.Join(separator, new Il2CppStringArray(value));
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00005F66 File Offset: 0x00004166
		public Il2CppStringArray Split(params char[] separator)
		{
			return this.Split(new Il2CppStructArray<char>(separator));
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00005F74 File Offset: 0x00004174
		public string Trim(params char[] trimChars)
		{
			return this.Trim(new Il2CppStructArray<char>(trimChars));
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00005F82 File Offset: 0x00004182
		public string TrimStart(params char[] trimChars)
		{
			return this.TrimStart(new Il2CppStructArray<char>(trimChars));
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00005F90 File Offset: 0x00004190
		public string TrimEnd(params char[] trimChars)
		{
			return this.TrimEnd(new Il2CppStructArray<char>(trimChars));
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00005F9E File Offset: 0x0000419E
		public static string Format(string format, params Object[] args)
		{
			return String.Format(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00005FAC File Offset: 0x000041AC
		public static string Format(IFormatProvider provider, string format, params Object[] args)
		{
			return String.Format(provider, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00005FBB File Offset: 0x000041BB
		public static string Concat(params Object[] args)
		{
			return String.Concat(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00005FC8 File Offset: 0x000041C8
		public static string Concat(params string[] values)
		{
			return String.Concat(new Il2CppStringArray(values));
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00005FD5 File Offset: 0x000041D5
		public String(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x000719A4 File Offset: 0x0006FBA4
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x00005FDE File Offset: 0x000041DE
		public unsafe int m_stringLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr_m_stringLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr_m_stringLength)) = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x000719CC File Offset: 0x0006FBCC
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x00005FF9 File Offset: 0x000041F9
		public unsafe char m_firstChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr_m_firstChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr_m_firstChar)) = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x000719F4 File Offset: 0x0006FBF4
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00006014 File Offset: 0x00004214
		public unsafe static int TrimHead
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_TrimHead, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_TrimHead, (void*)(&value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00071A10 File Offset: 0x0006FC10
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00006022 File Offset: 0x00004222
		public unsafe static int TrimTail
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_TrimTail, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_TrimTail, (void*)(&value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00071A2C File Offset: 0x0006FC2C
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x00006030 File Offset: 0x00004230
		public unsafe static int TrimBoth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_TrimBoth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_TrimBoth, (void*)(&value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00071A48 File Offset: 0x0006FC48
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0000603E File Offset: 0x0000423E
		public unsafe static string Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_Empty, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x00071A68 File Offset: 0x0006FC68
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x00006050 File Offset: 0x00004250
		public unsafe static int charPtrAlignConst
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_charPtrAlignConst, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_charPtrAlignConst, (void*)(&value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00071A84 File Offset: 0x0006FC84
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x0000605E File Offset: 0x0000425E
		public unsafe static int alignConst
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_alignConst, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_alignConst, (void*)(&value));
			}
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0000606C File Offset: 0x0000426C
		public new static implicit operator String(string A_0)
		{
			if (A_0 == null)
			{
				return A_0;
			}
			return new String(IL2CPP.ManagedStringToIl2Cpp(A_0));
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0000607E File Offset: 0x0000427E
		public static implicit operator string(String A_0)
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			if (intPtr == 0)
			{
				return null;
			}
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeFieldInfoPtr_m_stringLength;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeFieldInfoPtr_m_firstChar;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeFieldInfoPtr_TrimHead;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeFieldInfoPtr_TrimTail;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr_TrimBoth;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_charPtrAlignConst;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr_alignConst;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalIgnoreCaseHelper_Private_Static_Int32_String_String_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_SplitInternal_Internal_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_StringSplitOptions_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_Int32_StringSplitOptions_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_InternalSplitKeepEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_InternalSplitOmitEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStructArray_1_Char_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_Substring_Public_String_Int32_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_TrimStart_Public_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_CtorCharArray_Private_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_CtorCharArrayStartLength_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_CtorCharPtr_Private_String_ptr_Char_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_CtorCharPtrStartLength_Private_String_ptr_Char_Int32_Int32_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Internal_Boolean_Char_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_String_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerInvariant_Public_String_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_String_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInvariant_Public_String_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_IsBOMWhitespace_Private_Static_Boolean_Char_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_String_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_TrimHelper_Private_String_Int32_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_TrimHelper_Private_String_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_String_Int32_String_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_Char_Char_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_String_Int32_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_String_String_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Object_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_ConcatArray_Private_Static_String_Il2CppStringArray_Int32_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalUnchecked_Internal_Static_Int32_String_Int32_Int32_String_Int32_Int32_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_nativeCompareOrdinalEx_Internal_Static_Int32_String_Int32_String_Int32_Int32_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceInternal_Private_String_Char_Char_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceInternal_Internal_String_String_String_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceUnchecked_Private_String_String_String_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceFallback_Private_String_String_String_Int32_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_PadHelper_Private_String_Int32_Char_Boolean_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_IsAscii_Internal_Boolean_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_CharCopy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0;
	}
}
