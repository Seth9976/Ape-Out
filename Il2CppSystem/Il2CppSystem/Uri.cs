using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public class Uri : Object
	{
		// Token: 0x06000280 RID: 640 RVA: 0x0001A054 File Offset: 0x00018254
		// Note: this type is marked as 'beforefieldinit'.
		static Uri()
		{
			Il2CppClassPointerStore<Uri>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "Uri");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri>.NativeClassPtr);
			Uri.NativeFieldInfoPtr_UriSchemeFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeFile");
			Uri.NativeFieldInfoPtr_UriSchemeFtp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeFtp");
			Uri.NativeFieldInfoPtr_UriSchemeGopher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeGopher");
			Uri.NativeFieldInfoPtr_UriSchemeHttp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeHttp");
			Uri.NativeFieldInfoPtr_UriSchemeHttps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeHttps");
			Uri.NativeFieldInfoPtr_UriSchemeWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeWs");
			Uri.NativeFieldInfoPtr_UriSchemeWss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeWss");
			Uri.NativeFieldInfoPtr_UriSchemeMailto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeMailto");
			Uri.NativeFieldInfoPtr_UriSchemeNews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNews");
			Uri.NativeFieldInfoPtr_UriSchemeNntp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNntp");
			Uri.NativeFieldInfoPtr_UriSchemeNetTcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNetTcp");
			Uri.NativeFieldInfoPtr_UriSchemeNetPipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNetPipe");
			Uri.NativeFieldInfoPtr_SchemeDelimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "SchemeDelimiter");
			Uri.NativeFieldInfoPtr_m_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_String");
			Uri.NativeFieldInfoPtr_m_originalUnicodeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_originalUnicodeString");
			Uri.NativeFieldInfoPtr_m_Syntax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Syntax");
			Uri.NativeFieldInfoPtr_m_DnsSafeHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_DnsSafeHost");
			Uri.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Flags");
			Uri.NativeFieldInfoPtr_m_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Info");
			Uri.NativeFieldInfoPtr_m_iriParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_iriParsing");
			Uri.NativeFieldInfoPtr_s_ConfigInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_ConfigInitialized");
			Uri.NativeFieldInfoPtr_s_ConfigInitializing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_ConfigInitializing");
			Uri.NativeFieldInfoPtr_s_IdnScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_IdnScope");
			Uri.NativeFieldInfoPtr_s_IriParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_IriParsing");
			Uri.NativeFieldInfoPtr_useDotNetRelativeOrAbsolute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "useDotNetRelativeOrAbsolute");
			Uri.NativeFieldInfoPtr_IsWindowsFileSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "IsWindowsFileSystem");
			Uri.NativeFieldInfoPtr_s_initLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_initLock");
			Uri.NativeFieldInfoPtr_HexLowerChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "HexLowerChars");
			Uri.NativeFieldInfoPtr__WSchars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "_WSchars");
			Uri.NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663776);
			Uri.NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663777);
			Uri.NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663778);
			Uri.NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663779);
			Uri.NativeMethodInfoPtr_get_HostType_Private_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663780);
			Uri.NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663781);
			Uri.NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663782);
			Uri.NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663783);
			Uri.NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663784);
			Uri.NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663785);
			Uri.NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663786);
			Uri.NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663787);
			Uri.NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663788);
			Uri.NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663789);
			Uri.NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663790);
			Uri.NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663791);
			Uri.NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663792);
			Uri.NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663793);
			Uri.NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663794);
			Uri.NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663795);
			Uri.NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663796);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663797);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663798);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663799);
			Uri.NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663800);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663801);
			Uri.NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663802);
			Uri.NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663803);
			Uri.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663804);
			Uri.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663805);
			Uri.NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663806);
			Uri.NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663807);
			Uri.NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663808);
			Uri.NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663809);
			Uri.NativeMethodInfoPtr_get_LocalPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663810);
			Uri.NativeMethodInfoPtr_get_Authority_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663811);
			Uri.NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663812);
			Uri.NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663813);
			Uri.NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663814);
			Uri.NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663815);
			Uri.NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663816);
			Uri.NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663817);
			Uri.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663818);
			Uri.NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663819);
			Uri.NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663820);
			Uri.NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663821);
			Uri.NativeMethodInfoPtr_GetLocalPath_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663822);
			Uri.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663823);
			Uri.NativeMethodInfoPtr_get_Query_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663824);
			Uri.NativeMethodInfoPtr_get_Fragment_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663825);
			Uri.NativeMethodInfoPtr_get_Scheme_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663826);
			Uri.NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663827);
			Uri.NativeMethodInfoPtr_get_OriginalString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663828);
			Uri.NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663829);
			Uri.NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663830);
			Uri.NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663831);
			Uri.NativeMethodInfoPtr_get_UserInfo_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663832);
			Uri.NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663833);
			Uri.NativeMethodInfoPtr_CheckSchemeName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663834);
			Uri.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663835);
			Uri.NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663836);
			Uri.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663837);
			Uri.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663838);
			Uri.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663839);
			Uri.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663840);
			Uri.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663841);
			Uri.NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663842);
			Uri.NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663843);
			Uri.NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663844);
			Uri.NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663845);
			Uri.NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663846);
			Uri.NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663847);
			Uri.NativeMethodInfoPtr_CreateHostString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663848);
			Uri.NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663849);
			Uri.NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663850);
			Uri.NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663851);
			Uri.NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663852);
			Uri.NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663853);
			Uri.NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663854);
			Uri.NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663855);
			Uri.NativeMethodInfoPtr_ParseRemaining_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663856);
			Uri.NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663857);
			Uri.NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663858);
			Uri.NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663859);
			Uri.NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663860);
			Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663861);
			Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663862);
			Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663863);
			Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663864);
			Uri.NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663865);
			Uri.NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663866);
			Uri.NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663867);
			Uri.NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663868);
			Uri.NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663869);
			Uri.NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663870);
			Uri.NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663871);
			Uri.NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663872);
			Uri.NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663873);
			Uri.NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663874);
			Uri.NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663875);
			Uri.NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663876);
			Uri.NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663877);
			Uri.NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663878);
			Uri.NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663879);
			Uri.NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663880);
			Uri.NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663881);
			Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663882);
			Uri.NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663883);
			Uri.NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663884);
			Uri.NativeMethodInfoPtr_EscapeUriString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663885);
			Uri.NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663886);
			Uri.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663887);
			Uri.NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663888);
			Uri.NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663889);
			Uri.NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663890);
			Uri.NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663891);
			Uri.NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663892);
			Uri.NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663893);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0001AC00 File Offset: 0x00018E00
		public unsafe bool IsImplicitFile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001AC3C File Offset: 0x00018E3C
		public unsafe bool IsUncOrDosPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0001AC78 File Offset: 0x00018E78
		public unsafe bool IsDosPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0001ACB4 File Offset: 0x00018EB4
		public unsafe bool IsUncPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		public unsafe Uri.Flags HostType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_HostType_Private_get_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0001AD2C File Offset: 0x00018F2C
		public unsafe UriParser Syntax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0001AD6C File Offset: 0x00018F6C
		public unsafe bool IsNotAbsoluteUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001ADA8 File Offset: 0x00018FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367247, XrefRangeEnd = 367251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IriParsingStatic(UriParser syntax)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0001ADEC File Offset: 0x00018FEC
		public unsafe bool AllowIdn
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 367255, RefRangeEnd = 367268, XrefRangeStart = 367251, XrefRangeEnd = 367255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001AE28 File Offset: 0x00019028
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 367272, RefRangeEnd = 367276, XrefRangeStart = 367268, XrefRangeEnd = 367272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AllowIdnStatic(UriParser syntax, Uri.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001AE84 File Offset: 0x00019084
		[CallerCount(0)]
		public unsafe bool IsIntranet(string schemeHost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(schemeHost);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0001AED4 File Offset: 0x000190D4
		public unsafe bool UserDrivenParsing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0001AF10 File Offset: 0x00019110
		[CallerCount(0)]
		public unsafe void SetUserDrivenParsing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0001AF44 File Offset: 0x00019144
		public unsafe ushort SecuredPathIndex
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 367276, RefRangeEnd = 367278, XrefRangeStart = 367276, XrefRangeEnd = 367276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001AF80 File Offset: 0x00019180
		[CallerCount(0)]
		public unsafe bool NotAny(Uri.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001AFCC File Offset: 0x000191CC
		[CallerCount(0)]
		public unsafe bool InFact(Uri.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001B018 File Offset: 0x00019218
		[CallerCount(0)]
		public unsafe static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001B064 File Offset: 0x00019264
		[CallerCount(0)]
		public unsafe static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001B0B0 File Offset: 0x000192B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367278, XrefRangeEnd = 367279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri.UriInfo EnsureUriInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri.UriInfo>(intPtr3) : null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001B0F0 File Offset: 0x000192F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367279, XrefRangeEnd = 367280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureParseRemaining()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001B124 File Offset: 0x00019324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367280, XrefRangeEnd = 367282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureHostString(bool allowDnsOptimization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowDnsOptimization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001B164 File Offset: 0x00019364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367282, XrefRangeEnd = 367283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(string uriString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001B1B0 File Offset: 0x000193B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367283, XrefRangeEnd = 367284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(string uriString, UriKind uriKind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0001B20C File Offset: 0x0001940C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367285, RefRangeEnd = 367286, XrefRangeStart = 367284, XrefRangeEnd = 367285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(Uri baseUri, string relativeUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001B26C File Offset: 0x0001946C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 367295, RefRangeEnd = 367299, XrefRangeStart = 367286, XrefRangeEnd = 367295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUri(Uri baseUri, string relativeUri, bool dontEscape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001B2D0 File Offset: 0x000194D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367310, RefRangeEnd = 367311, XrefRangeStart = 367299, XrefRangeEnd = 367310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(Uri baseUri, Uri relativeUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001B330 File Offset: 0x00019530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367311, XrefRangeEnd = 367323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(result);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			result = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001B3B4 File Offset: 0x000195B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 367335, RefRangeEnd = 367338, XrefRangeStart = 367323, XrefRangeEnd = 367335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UriFormatException GetException(ParsingError err)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref err;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriFormatException>(intPtr3) : null;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001B3F4 File Offset: 0x000195F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367338, XrefRangeEnd = 367345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001B458 File Offset: 0x00019658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367345, XrefRangeEnd = 367346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001B4B4 File Offset: 0x000196B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367366, RefRangeEnd = 367367, XrefRangeStart = 367346, XrefRangeEnd = 367366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0001B510 File Offset: 0x00019710
		public unsafe string AbsolutePath
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 367373, RefRangeEnd = 367378, XrefRangeStart = 367367, XrefRangeEnd = 367373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0001B548 File Offset: 0x00019748
		public unsafe string PrivateAbsolutePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367378, XrefRangeEnd = 367383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0001B580 File Offset: 0x00019780
		public unsafe string AbsoluteUri
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 367389, RefRangeEnd = 367398, XrefRangeStart = 367383, XrefRangeEnd = 367389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0001B5B8 File Offset: 0x000197B8
		public unsafe string LocalPath
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 367406, RefRangeEnd = 367414, XrefRangeStart = 367398, XrefRangeEnd = 367406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_LocalPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0001B5F0 File Offset: 0x000197F0
		public unsafe string Authority
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 367422, RefRangeEnd = 367429, XrefRangeStart = 367414, XrefRangeEnd = 367422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Authority_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0001B628 File Offset: 0x00019828
		public unsafe UriHostNameType HostNameType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 367433, RefRangeEnd = 367436, XrefRangeStart = 367429, XrefRangeEnd = 367433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0001B664 File Offset: 0x00019864
		public unsafe bool IsDefaultPort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367436, XrefRangeEnd = 367438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001B6A0 File Offset: 0x000198A0
		public unsafe bool IsFile
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 367442, RefRangeEnd = 367444, XrefRangeStart = 367438, XrefRangeEnd = 367442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0001B6DC File Offset: 0x000198DC
		public unsafe bool IsLoopback
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 367446, RefRangeEnd = 367449, XrefRangeStart = 367444, XrefRangeEnd = 367446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0001B718 File Offset: 0x00019918
		public unsafe string PathAndQuery
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 367451, RefRangeEnd = 367457, XrefRangeStart = 367449, XrefRangeEnd = 367451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0001B750 File Offset: 0x00019950
		public unsafe bool IsUnc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0001B78C File Offset: 0x0001998C
		public unsafe string Host
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 367465, RefRangeEnd = 367481, XrefRangeStart = 367457, XrefRangeEnd = 367465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0001B7C4 File Offset: 0x000199C4
		[CallerCount(0)]
		public unsafe static bool StaticIsFile(UriParser syntax)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0001B808 File Offset: 0x00019A08
		public unsafe static Object InitializeLock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367481, XrefRangeEnd = 367494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0001B83C File Offset: 0x00019A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367527, RefRangeEnd = 367528, XrefRangeStart = 367494, XrefRangeEnd = 367527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeUriConfig()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0001B864 File Offset: 0x00019A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367550, RefRangeEnd = 367551, XrefRangeStart = 367528, XrefRangeEnd = 367550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetLocalPath_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0001B89C File Offset: 0x00019A9C
		public unsafe int Port
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 367555, RefRangeEnd = 367562, XrefRangeStart = 367551, XrefRangeEnd = 367555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0001B8D8 File Offset: 0x00019AD8
		public unsafe string Query
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367562, XrefRangeEnd = 367568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Query_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0001B910 File Offset: 0x00019B10
		public unsafe string Fragment
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 367574, RefRangeEnd = 367576, XrefRangeStart = 367568, XrefRangeEnd = 367574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Fragment_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0001B948 File Offset: 0x00019B48
		public unsafe string Scheme
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 367576, RefRangeEnd = 367597, XrefRangeStart = 367576, XrefRangeEnd = 367576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Scheme_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0001B980 File Offset: 0x00019B80
		public unsafe bool OriginalStringSwitched
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367597, XrefRangeEnd = 367598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0001B9BC File Offset: 0x00019BBC
		public unsafe string OriginalString
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 367599, RefRangeEnd = 367613, XrefRangeStart = 367598, XrefRangeEnd = 367599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_OriginalString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0001B9F4 File Offset: 0x00019BF4
		public unsafe string DnsSafeHost
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367613, XrefRangeEnd = 367618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0001BA2C File Offset: 0x00019C2C
		public unsafe bool IsAbsoluteUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0001BA68 File Offset: 0x00019C68
		public unsafe bool UserEscaped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0001BAA4 File Offset: 0x00019CA4
		public unsafe string UserInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367618, XrefRangeEnd = 367626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_UserInfo_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0001BADC File Offset: 0x00019CDC
		[CallerCount(0)]
		public unsafe static bool IsGenDelim(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0001BB1C File Offset: 0x00019D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367638, RefRangeEnd = 367639, XrefRangeStart = 367626, XrefRangeEnd = 367638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckSchemeName(string schemeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(schemeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckSchemeName_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001BB60 File Offset: 0x00019D60
		[CallerCount(0)]
		public unsafe static bool IsHexDigit(char character)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367639, RefRangeEnd = 367640, XrefRangeStart = 367639, XrefRangeEnd = 367639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FromHex(char digit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0001BBE0 File Offset: 0x00019DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367640, XrefRangeEnd = 367650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Uri.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0001BC28 File Offset: 0x00019E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367650, XrefRangeEnd = 367655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Uri.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0001BC6C File Offset: 0x00019E6C
		[CallerCount(0)]
		public unsafe static bool operator ==(Uri uri1, Uri uri2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		[CallerCount(0)]
		public unsafe static bool operator !=(Uri uri1, Uri uri2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0001BD14 File Offset: 0x00019F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367655, XrefRangeEnd = 367678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Uri.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0001BD6C File Offset: 0x00019F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367678, XrefRangeEnd = 367684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalEscapeString(string rawString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rawString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0001BDA8 File Offset: 0x00019FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367688, RefRangeEnd = 367689, XrefRangeStart = 367684, XrefRangeEnd = 367688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0001BE20 File Offset: 0x0001A020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367689, XrefRangeEnd = 367694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriFormatException ParseMinimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriFormatException>(intPtr3) : null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0001BE60 File Offset: 0x0001A060
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 367706, RefRangeEnd = 367708, XrefRangeStart = 367694, XrefRangeEnd = 367706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParsingError PrivateParseMinimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0001BE9C File Offset: 0x0001A09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367708, XrefRangeEnd = 367713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrivateParseMinimalIri(string newHost, ushort idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0001BEEC File Offset: 0x0001A0EC
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 367738, RefRangeEnd = 367763, XrefRangeStart = 367713, XrefRangeEnd = 367738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUriInfo(Uri.Flags cF)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cF;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0001BF2C File Offset: 0x0001A12C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 367785, RefRangeEnd = 367794, XrefRangeStart = 367763, XrefRangeEnd = 367785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateHostString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateHostString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0001BF60 File Offset: 0x0001A160
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 367801, RefRangeEnd = 367803, XrefRangeStart = 367794, XrefRangeEnd = 367801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0001BFEC File Offset: 0x0001A1EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367815, RefRangeEnd = 367816, XrefRangeStart = 367803, XrefRangeEnd = 367815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetHostViaCustomSyntax()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0001C020 File Offset: 0x0001A220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367816, XrefRangeEnd = 367817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetParts(UriComponents uriParts, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0001C074 File Offset: 0x0001A274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367817, XrefRangeEnd = 367821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEscapedParts(UriComponents uriParts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367825, RefRangeEnd = 367826, XrefRangeStart = 367821, XrefRangeEnd = 367825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0001C10C File Offset: 0x0001A30C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 367905, RefRangeEnd = 367907, XrefRangeStart = 367826, XrefRangeEnd = 367905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonCanonical;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001C16C File Offset: 0x0001A36C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 367911, RefRangeEnd = 367913, XrefRangeStart = 367907, XrefRangeEnd = 367911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUriPartsFromUserString(UriComponents uriParts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0001C1B0 File Offset: 0x0001A3B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 367977, RefRangeEnd = 367980, XrefRangeStart = 367913, XrefRangeEnd = 367977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseRemaining()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseRemaining_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001C1E4 File Offset: 0x0001A3E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 367988, RefRangeEnd = 367990, XrefRangeStart = 367980, XrefRangeEnd = 367988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = uriString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001C278 File Offset: 0x0001A478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367990, XrefRangeEnd = 367995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = lptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChars;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0001C2EC File Offset: 0x0001A4EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368001, RefRangeEnd = 368002, XrefRangeStart = 367995, XrefRangeEnd = 368001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0001C360 File Offset: 0x0001A560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368127, RefRangeEnd = 368128, XrefRangeStart = 368002, XrefRangeEnd = 368127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newHost = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0001C418 File Offset: 0x0001A618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368168, RefRangeEnd = 368169, XrefRangeStart = 368128, XrefRangeEnd = 368168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startInput;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iriParsing;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUnicode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userInfoString);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &justNormalized;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newHost = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0001C514 File Offset: 0x0001A714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368169, XrefRangeEnd = 368191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startInput;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iriParsing;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUnicode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newHost = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0001C5DC File Offset: 0x0001A7DC
		[CallerCount(0)]
		public unsafe void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001C648 File Offset: 0x0001A848
		[CallerCount(0)]
		public unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 368211, RefRangeEnd = 368216, XrefRangeStart = 368191, XrefRangeEnd = 368211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001C724 File Offset: 0x0001A924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368256, RefRangeEnd = 368257, XrefRangeStart = 368216, XrefRangeEnd = 368256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<char> GetCanonicalPath(Il2CppStructArray<char> dest, ref int pos, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0001C790 File Offset: 0x0001A990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368266, RefRangeEnd = 368267, XrefRangeStart = 368257, XrefRangeEnd = 368266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0001C808 File Offset: 0x0001AA08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368286, RefRangeEnd = 368287, XrefRangeStart = 368267, XrefRangeEnd = 368286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> Compress(Il2CppStructArray<char> dest, ushort start, ref int destLength, UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0001C87C File Offset: 0x0001AA7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368292, RefRangeEnd = 368293, XrefRangeStart = 368287, XrefRangeEnd = 368292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CalculateCaseInsensitiveHashCode(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368293, XrefRangeEnd = 368315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(basePart);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativePart);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0001C91C File Offset: 0x0001AB1C
		public unsafe bool HasAuthority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001C958 File Offset: 0x0001AB58
		[CallerCount(0)]
		public unsafe static bool IsLWS(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001C998 File Offset: 0x0001AB98
		[CallerCount(0)]
		public unsafe static bool IsAsciiLetter(char character)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0001C9D8 File Offset: 0x0001ABD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368318, RefRangeEnd = 368321, XrefRangeStart = 368315, XrefRangeEnd = 368318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAsciiLetterOrDigit(char character)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001CA18 File Offset: 0x0001AC18
		[CallerCount(0)]
		public unsafe static bool IsBidiControlCharacter(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001CA58 File Offset: 0x0001AC58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368331, RefRangeEnd = 368334, XrefRangeStart = 368321, XrefRangeEnd = 368331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripBidiControlCharacter(char* strToClean, int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = strToClean;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0001CAAC File Offset: 0x0001ACAC
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 368341, RefRangeEnd = 368361, XrefRangeStart = 368334, XrefRangeEnd = 368341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateThis(string uri, bool dontEscape, UriKind uriKind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001CB0C File Offset: 0x0001AD0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368375, RefRangeEnd = 368377, XrefRangeStart = 368361, XrefRangeEnd = 368375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref err;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			e = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001CB7C File Offset: 0x0001AD7C
		[CallerCount(0)]
		public unsafe bool CheckForConfigLoad(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001CBCC File Offset: 0x0001ADCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368377, XrefRangeEnd = 368388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForUnicode(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001CC1C File Offset: 0x0001AE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368388, XrefRangeEnd = 368407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForEscapedUnreserved(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001CC6C File Offset: 0x0001AE6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368413, RefRangeEnd = 368416, XrefRangeStart = 368407, XrefRangeEnd = 368413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate(string uriString, UriKind uriKind, out Uri result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 368416, RefRangeEnd = 368432, XrefRangeStart = 368416, XrefRangeEnd = 368416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetComponents(UriComponents components, UriFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref components;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001CD34 File Offset: 0x0001AF34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368446, RefRangeEnd = 368448, XrefRangeStart = 368432, XrefRangeEnd = 368446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeDataString(string stringToUnescape)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToUnescape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001CD70 File Offset: 0x0001AF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368448, XrefRangeEnd = 368454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeUriString(string stringToEscape)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToEscape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EscapeUriString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001CDAC File Offset: 0x0001AFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368460, RefRangeEnd = 368461, XrefRangeStart = 368454, XrefRangeEnd = 368460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeDataString(string stringToEscape)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToEscape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001CDE8 File Offset: 0x0001AFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368461, XrefRangeEnd = 368462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EscapeUnescapeIri(string input, int start, int end, UriComponents component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref component;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001CE5C File Offset: 0x0001B05C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368462, RefRangeEnd = 368463, XrefRangeStart = 368462, XrefRangeEnd = 368462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(Uri.Flags flags, UriParser uriParser, string uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uriParser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001CEC8 File Offset: 0x0001B0C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368480, RefRangeEnd = 368482, XrefRangeStart = 368463, XrefRangeEnd = 368480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			e = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0001CF54 File Offset: 0x0001B154
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368509, RefRangeEnd = 368512, XrefRangeStart = 368482, XrefRangeEnd = 368509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeUri);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newUriString);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &userEscaped;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			newUriString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			e = ((intPtr5 == 0) ? null : new UriFormatException(intPtr5));
			IntPtr intPtr6 = intPtr3;
			return (intPtr6 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr6) : null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001D000 File Offset: 0x0001B200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368512, XrefRangeEnd = 368526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRelativeSerializationString(UriFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001D044 File Offset: 0x0001B244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368533, RefRangeEnd = 368535, XrefRangeStart = 368526, XrefRangeEnd = 368533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriComponents;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001D098 File Offset: 0x0001B298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368538, RefRangeEnd = 368539, XrefRangeStart = 368535, XrefRangeEnd = 368538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateThisFromUri(Uri otherUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002F97 File Offset: 0x00001197
		public Uri(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0001D0DC File Offset: 0x0001B2DC
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00002FA0 File Offset: 0x000011A0
		public unsafe static string UriSchemeFile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeFile, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeFile, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0001D0FC File Offset: 0x0001B2FC
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00002FB2 File Offset: 0x000011B2
		public unsafe static string UriSchemeFtp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeFtp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeFtp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0001D11C File Offset: 0x0001B31C
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00002FC4 File Offset: 0x000011C4
		public unsafe static string UriSchemeGopher
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeGopher, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeGopher, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0001D13C File Offset: 0x0001B33C
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00002FD6 File Offset: 0x000011D6
		public unsafe static string UriSchemeHttp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeHttp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeHttp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0001D15C File Offset: 0x0001B35C
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00002FE8 File Offset: 0x000011E8
		public unsafe static string UriSchemeHttps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeHttps, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeHttps, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0001D17C File Offset: 0x0001B37C
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00002FFA File Offset: 0x000011FA
		public unsafe static string UriSchemeWs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeWs, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeWs, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0001D19C File Offset: 0x0001B39C
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0000300C File Offset: 0x0000120C
		public unsafe static string UriSchemeWss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeWss, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeWss, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0001D1BC File Offset: 0x0001B3BC
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0000301E File Offset: 0x0000121E
		public unsafe static string UriSchemeMailto
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeMailto, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeMailto, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0001D1DC File Offset: 0x0001B3DC
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00003030 File Offset: 0x00001230
		public unsafe static string UriSchemeNews
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNews, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNews, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0001D1FC File Offset: 0x0001B3FC
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00003042 File Offset: 0x00001242
		public unsafe static string UriSchemeNntp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNntp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNntp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0001D21C File Offset: 0x0001B41C
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003054 File Offset: 0x00001254
		public unsafe static string UriSchemeNetTcp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNetTcp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNetTcp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0001D23C File Offset: 0x0001B43C
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003066 File Offset: 0x00001266
		public unsafe static string UriSchemeNetPipe
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNetPipe, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNetPipe, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0001D25C File Offset: 0x0001B45C
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00003078 File Offset: 0x00001278
		public unsafe static string SchemeDelimiter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_SchemeDelimiter, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_SchemeDelimiter, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0001D27C File Offset: 0x0001B47C
		// (set) Token: 0x06000313 RID: 787 RVA: 0x0000308A File Offset: 0x0000128A
		public unsafe string m_String
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_String);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_String), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000030A9 File Offset: 0x000012A9
		public unsafe string m_originalUnicodeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_originalUnicodeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_originalUnicodeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0001D2CC File Offset: 0x0001B4CC
		// (set) Token: 0x06000317 RID: 791 RVA: 0x000030C8 File Offset: 0x000012C8
		public unsafe UriParser m_Syntax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Syntax);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Syntax), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0001D2FC File Offset: 0x0001B4FC
		// (set) Token: 0x06000319 RID: 793 RVA: 0x000030E7 File Offset: 0x000012E7
		public unsafe string m_DnsSafeHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_DnsSafeHost);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_DnsSafeHost), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001D324 File Offset: 0x0001B524
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00003106 File Offset: 0x00001306
		public unsafe Uri.Flags m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0001D34C File Offset: 0x0001B54C
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00003121 File Offset: 0x00001321
		public unsafe Uri.UriInfo m_Info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri.UriInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001D37C File Offset: 0x0001B57C
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00003140 File Offset: 0x00001340
		public unsafe bool m_iriParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_iriParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_iriParsing)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001D3A4 File Offset: 0x0001B5A4
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0000315B File Offset: 0x0000135B
		public unsafe static bool s_ConfigInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_ConfigInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_ConfigInitialized, (void*)(&value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001D3C0 File Offset: 0x0001B5C0
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00003169 File Offset: 0x00001369
		public unsafe static bool s_ConfigInitializing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_ConfigInitializing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_ConfigInitializing, (void*)(&value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0001D3DC File Offset: 0x0001B5DC
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00003177 File Offset: 0x00001377
		public unsafe static UriIdnScope s_IdnScope
		{
			get
			{
				UriIdnScope uriIdnScope;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_IdnScope, (void*)(&uriIdnScope));
				return uriIdnScope;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_IdnScope, (void*)(&value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0001D3F8 File Offset: 0x0001B5F8
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003185 File Offset: 0x00001385
		public unsafe static bool s_IriParsing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_IriParsing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_IriParsing, (void*)(&value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0001D414 File Offset: 0x0001B614
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00003193 File Offset: 0x00001393
		public unsafe static bool useDotNetRelativeOrAbsolute
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_useDotNetRelativeOrAbsolute, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_useDotNetRelativeOrAbsolute, (void*)(&value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001D430 File Offset: 0x0001B630
		// (set) Token: 0x0600032B RID: 811 RVA: 0x000031A1 File Offset: 0x000013A1
		public unsafe static bool IsWindowsFileSystem
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_IsWindowsFileSystem, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_IsWindowsFileSystem, (void*)(&value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001D44C File Offset: 0x0001B64C
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000031AF File Offset: 0x000013AF
		public unsafe static Object s_initLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_initLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_initLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0001D474 File Offset: 0x0001B674
		// (set) Token: 0x0600032F RID: 815 RVA: 0x000031C1 File Offset: 0x000013C1
		public unsafe static Il2CppStructArray<char> HexLowerChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_HexLowerChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_HexLowerChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0001D49C File Offset: 0x0001B69C
		// (set) Token: 0x06000331 RID: 817 RVA: 0x000031D3 File Offset: 0x000013D3
		public unsafe static Il2CppStructArray<char> _WSchars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr__WSchars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr__WSchars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeFile;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeFtp;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeGopher;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeHttp;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeHttps;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeWs;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeWss;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeMailto;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNews;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNntp;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNetTcp;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNetPipe;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_SchemeDelimiter;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_m_String;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_m_originalUnicodeString;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_m_Syntax;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_m_DnsSafeHost;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_m_Info;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_m_iriParsing;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_s_ConfigInitialized;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_s_ConfigInitializing;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_s_IdnScope;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_s_IriParsing;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_useDotNetRelativeOrAbsolute;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_IsWindowsFileSystem;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_s_initLock;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_HexLowerChars;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr__WSchars;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_get_HostType_Private_get_Flags_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPath_Public_get_String_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_get_Authority_Public_get_String_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPath_Private_String_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_get_Query_Public_get_String_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_get_Fragment_Public_get_String_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_Scheme_Public_get_String_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalString_Public_get_String_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_get_UserInfo_Public_get_String_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_CheckSchemeName_Public_Static_Boolean_String_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_CreateHostString_Private_Void_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_ParseRemaining_Private_Void_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_EscapeUriString_Public_Static_String_String_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0;

		// Token: 0x020001B0 RID: 432
		[OriginalName("System.dll", "", "Flags")]
		[Flags]
		public enum Flags : ulong
		{
			// Token: 0x04001374 RID: 4980
			Zero = 0UL,
			// Token: 0x04001375 RID: 4981
			SchemeNotCanonical = 1UL,
			// Token: 0x04001376 RID: 4982
			UserNotCanonical = 2UL,
			// Token: 0x04001377 RID: 4983
			HostNotCanonical = 4UL,
			// Token: 0x04001378 RID: 4984
			PortNotCanonical = 8UL,
			// Token: 0x04001379 RID: 4985
			PathNotCanonical = 16UL,
			// Token: 0x0400137A RID: 4986
			QueryNotCanonical = 32UL,
			// Token: 0x0400137B RID: 4987
			FragmentNotCanonical = 64UL,
			// Token: 0x0400137C RID: 4988
			CannotDisplayCanonical = 127UL,
			// Token: 0x0400137D RID: 4989
			E_UserNotCanonical = 128UL,
			// Token: 0x0400137E RID: 4990
			E_HostNotCanonical = 256UL,
			// Token: 0x0400137F RID: 4991
			E_PortNotCanonical = 512UL,
			// Token: 0x04001380 RID: 4992
			E_PathNotCanonical = 1024UL,
			// Token: 0x04001381 RID: 4993
			E_QueryNotCanonical = 2048UL,
			// Token: 0x04001382 RID: 4994
			E_FragmentNotCanonical = 4096UL,
			// Token: 0x04001383 RID: 4995
			E_CannotDisplayCanonical = 8064UL,
			// Token: 0x04001384 RID: 4996
			ShouldBeCompressed = 8192UL,
			// Token: 0x04001385 RID: 4997
			FirstSlashAbsent = 16384UL,
			// Token: 0x04001386 RID: 4998
			BackslashInPath = 32768UL,
			// Token: 0x04001387 RID: 4999
			IndexMask = 65535UL,
			// Token: 0x04001388 RID: 5000
			HostTypeMask = 458752UL,
			// Token: 0x04001389 RID: 5001
			HostNotParsed = 0UL,
			// Token: 0x0400138A RID: 5002
			IPv6HostType = 65536UL,
			// Token: 0x0400138B RID: 5003
			IPv4HostType = 131072UL,
			// Token: 0x0400138C RID: 5004
			DnsHostType = 196608UL,
			// Token: 0x0400138D RID: 5005
			UncHostType = 262144UL,
			// Token: 0x0400138E RID: 5006
			BasicHostType = 327680UL,
			// Token: 0x0400138F RID: 5007
			UnusedHostType = 393216UL,
			// Token: 0x04001390 RID: 5008
			UnknownHostType = 458752UL,
			// Token: 0x04001391 RID: 5009
			UserEscaped = 524288UL,
			// Token: 0x04001392 RID: 5010
			AuthorityFound = 1048576UL,
			// Token: 0x04001393 RID: 5011
			HasUserInfo = 2097152UL,
			// Token: 0x04001394 RID: 5012
			LoopbackHost = 4194304UL,
			// Token: 0x04001395 RID: 5013
			NotDefaultPort = 8388608UL,
			// Token: 0x04001396 RID: 5014
			UserDrivenParsing = 16777216UL,
			// Token: 0x04001397 RID: 5015
			CanonicalDnsHost = 33554432UL,
			// Token: 0x04001398 RID: 5016
			ErrorOrParsingRecursion = 67108864UL,
			// Token: 0x04001399 RID: 5017
			DosPath = 134217728UL,
			// Token: 0x0400139A RID: 5018
			UncPath = 268435456UL,
			// Token: 0x0400139B RID: 5019
			ImplicitFile = 536870912UL,
			// Token: 0x0400139C RID: 5020
			MinimalUriInfoSet = 1073741824UL,
			// Token: 0x0400139D RID: 5021
			AllUriInfoSet = 2147483648UL,
			// Token: 0x0400139E RID: 5022
			IdnHost = 4294967296UL,
			// Token: 0x0400139F RID: 5023
			HasUnicode = 8589934592UL,
			// Token: 0x040013A0 RID: 5024
			HostUnicodeNormalized = 17179869184UL,
			// Token: 0x040013A1 RID: 5025
			RestUnicodeNormalized = 34359738368UL,
			// Token: 0x040013A2 RID: 5026
			UnicodeHost = 68719476736UL,
			// Token: 0x040013A3 RID: 5027
			IntranetUri = 137438953472UL,
			// Token: 0x040013A4 RID: 5028
			UseOrigUncdStrOffset = 274877906944UL,
			// Token: 0x040013A5 RID: 5029
			UserIriCanonical = 549755813888UL,
			// Token: 0x040013A6 RID: 5030
			PathIriCanonical = 1099511627776UL,
			// Token: 0x040013A7 RID: 5031
			QueryIriCanonical = 2199023255552UL,
			// Token: 0x040013A8 RID: 5032
			FragmentIriCanonical = 4398046511104UL,
			// Token: 0x040013A9 RID: 5033
			IriCanonical = 8246337208320UL,
			// Token: 0x040013AA RID: 5034
			CompressedSlashes = 17592186044416UL
		}

		// Token: 0x020001B1 RID: 433
		public class UriInfo : Object
		{
			// Token: 0x060018D8 RID: 6360 RVA: 0x0006B838 File Offset: 0x00069A38
			// Note: this type is marked as 'beforefieldinit'.
			static UriInfo()
			{
				Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr);
				Uri.UriInfo.NativeFieldInfoPtr_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "Host");
				Uri.UriInfo.NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "ScopeId");
				Uri.UriInfo.NativeFieldInfoPtr_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "String");
				Uri.UriInfo.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "Offset");
				Uri.UriInfo.NativeFieldInfoPtr_DnsSafeHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "DnsSafeHost");
				Uri.UriInfo.NativeFieldInfoPtr_MoreInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "MoreInfo");
				Uri.UriInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, 100663895);
			}

			// Token: 0x060018D9 RID: 6361 RVA: 0x0006B8F0 File Offset: 0x00069AF0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UriInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.UriInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018DA RID: 6362 RVA: 0x0000CC8C File Offset: 0x0000AE8C
			public UriInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007F7 RID: 2039
			// (get) Token: 0x060018DB RID: 6363 RVA: 0x0006B92C File Offset: 0x00069B2C
			// (set) Token: 0x060018DC RID: 6364 RVA: 0x0000CC95 File Offset: 0x0000AE95
			public unsafe string Host
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Host);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Host), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007F8 RID: 2040
			// (get) Token: 0x060018DD RID: 6365 RVA: 0x0006B954 File Offset: 0x00069B54
			// (set) Token: 0x060018DE RID: 6366 RVA: 0x0000CCB4 File Offset: 0x0000AEB4
			public unsafe string ScopeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_ScopeId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_ScopeId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007F9 RID: 2041
			// (get) Token: 0x060018DF RID: 6367 RVA: 0x0006B97C File Offset: 0x00069B7C
			// (set) Token: 0x060018E0 RID: 6368 RVA: 0x0000CCD3 File Offset: 0x0000AED3
			public unsafe string String
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_String);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_String), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007FA RID: 2042
			// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0006B9A4 File Offset: 0x00069BA4
			// (set) Token: 0x060018E2 RID: 6370 RVA: 0x0000CCF2 File Offset: 0x0000AEF2
			public unsafe Uri.Offset Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x170007FB RID: 2043
			// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0006B9CC File Offset: 0x00069BCC
			// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0000CD0D File Offset: 0x0000AF0D
			public unsafe string DnsSafeHost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_DnsSafeHost);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_DnsSafeHost), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007FC RID: 2044
			// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0006B9F4 File Offset: 0x00069BF4
			// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0000CD2C File Offset: 0x0000AF2C
			public unsafe Uri.MoreInfo MoreInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_MoreInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri.MoreInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_MoreInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013AB RID: 5035
			private static readonly IntPtr NativeFieldInfoPtr_Host;

			// Token: 0x040013AC RID: 5036
			private static readonly IntPtr NativeFieldInfoPtr_ScopeId;

			// Token: 0x040013AD RID: 5037
			private static readonly IntPtr NativeFieldInfoPtr_String;

			// Token: 0x040013AE RID: 5038
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x040013AF RID: 5039
			private static readonly IntPtr NativeFieldInfoPtr_DnsSafeHost;

			// Token: 0x040013B0 RID: 5040
			private static readonly IntPtr NativeFieldInfoPtr_MoreInfo;

			// Token: 0x040013B1 RID: 5041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001B2 RID: 434
		[StructLayout(2)]
		public struct Offset
		{
			// Token: 0x060018E7 RID: 6375 RVA: 0x0006BA24 File Offset: 0x00069C24
			// Note: this type is marked as 'beforefieldinit'.
			static Offset()
			{
				Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "Offset");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr);
				Uri.Offset.NativeFieldInfoPtr_Scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Scheme");
				Uri.Offset.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "User");
				Uri.Offset.NativeFieldInfoPtr_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Host");
				Uri.Offset.NativeFieldInfoPtr_PortValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "PortValue");
				Uri.Offset.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Path");
				Uri.Offset.NativeFieldInfoPtr_Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Query");
				Uri.Offset.NativeFieldInfoPtr_Fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Fragment");
				Uri.Offset.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "End");
			}

			// Token: 0x060018E8 RID: 6376 RVA: 0x0000CD4B File Offset: 0x0000AF4B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, ref this));
			}

			// Token: 0x040013B2 RID: 5042
			private static readonly IntPtr NativeFieldInfoPtr_Scheme;

			// Token: 0x040013B3 RID: 5043
			private static readonly IntPtr NativeFieldInfoPtr_User;

			// Token: 0x040013B4 RID: 5044
			private static readonly IntPtr NativeFieldInfoPtr_Host;

			// Token: 0x040013B5 RID: 5045
			private static readonly IntPtr NativeFieldInfoPtr_PortValue;

			// Token: 0x040013B6 RID: 5046
			private static readonly IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x040013B7 RID: 5047
			private static readonly IntPtr NativeFieldInfoPtr_Query;

			// Token: 0x040013B8 RID: 5048
			private static readonly IntPtr NativeFieldInfoPtr_Fragment;

			// Token: 0x040013B9 RID: 5049
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x040013BA RID: 5050
			[FieldOffset(0)]
			public ushort Scheme;

			// Token: 0x040013BB RID: 5051
			[FieldOffset(2)]
			public ushort User;

			// Token: 0x040013BC RID: 5052
			[FieldOffset(4)]
			public ushort Host;

			// Token: 0x040013BD RID: 5053
			[FieldOffset(6)]
			public ushort PortValue;

			// Token: 0x040013BE RID: 5054
			[FieldOffset(8)]
			public ushort Path;

			// Token: 0x040013BF RID: 5055
			[FieldOffset(10)]
			public ushort Query;

			// Token: 0x040013C0 RID: 5056
			[FieldOffset(12)]
			public ushort Fragment;

			// Token: 0x040013C1 RID: 5057
			[FieldOffset(14)]
			public ushort End;
		}

		// Token: 0x020001B3 RID: 435
		public class MoreInfo : Object
		{
			// Token: 0x060018E9 RID: 6377 RVA: 0x0006BAF0 File Offset: 0x00069CF0
			// Note: this type is marked as 'beforefieldinit'.
			static MoreInfo()
			{
				Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "MoreInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr);
				Uri.MoreInfo.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Path");
				Uri.MoreInfo.NativeFieldInfoPtr_Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Query");
				Uri.MoreInfo.NativeFieldInfoPtr_Fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Fragment");
				Uri.MoreInfo.NativeFieldInfoPtr_AbsoluteUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "AbsoluteUri");
				Uri.MoreInfo.NativeFieldInfoPtr_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Hash");
				Uri.MoreInfo.NativeFieldInfoPtr_RemoteUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "RemoteUrl");
				Uri.MoreInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, 100663896);
			}

			// Token: 0x060018EA RID: 6378 RVA: 0x0006BBA8 File Offset: 0x00069DA8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MoreInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.MoreInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018EB RID: 6379 RVA: 0x0000CD5D File Offset: 0x0000AF5D
			public MoreInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007FD RID: 2045
			// (get) Token: 0x060018EC RID: 6380 RVA: 0x0006BBE4 File Offset: 0x00069DE4
			// (set) Token: 0x060018ED RID: 6381 RVA: 0x0000CD66 File Offset: 0x0000AF66
			public unsafe string Path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007FE RID: 2046
			// (get) Token: 0x060018EE RID: 6382 RVA: 0x0006BC0C File Offset: 0x00069E0C
			// (set) Token: 0x060018EF RID: 6383 RVA: 0x0000CD85 File Offset: 0x0000AF85
			public unsafe string Query
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Query);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Query), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007FF RID: 2047
			// (get) Token: 0x060018F0 RID: 6384 RVA: 0x0006BC34 File Offset: 0x00069E34
			// (set) Token: 0x060018F1 RID: 6385 RVA: 0x0000CDA4 File Offset: 0x0000AFA4
			public unsafe string Fragment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Fragment);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Fragment), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000800 RID: 2048
			// (get) Token: 0x060018F2 RID: 6386 RVA: 0x0006BC5C File Offset: 0x00069E5C
			// (set) Token: 0x060018F3 RID: 6387 RVA: 0x0000CDC3 File Offset: 0x0000AFC3
			public unsafe string AbsoluteUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_AbsoluteUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_AbsoluteUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000801 RID: 2049
			// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0006BC84 File Offset: 0x00069E84
			// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0000CDE2 File Offset: 0x0000AFE2
			public unsafe int Hash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Hash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Hash)) = value;
				}
			}

			// Token: 0x17000802 RID: 2050
			// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0006BCAC File Offset: 0x00069EAC
			// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0000CDFD File Offset: 0x0000AFFD
			public unsafe string RemoteUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_RemoteUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_RemoteUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040013C2 RID: 5058
			private static readonly IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x040013C3 RID: 5059
			private static readonly IntPtr NativeFieldInfoPtr_Query;

			// Token: 0x040013C4 RID: 5060
			private static readonly IntPtr NativeFieldInfoPtr_Fragment;

			// Token: 0x040013C5 RID: 5061
			private static readonly IntPtr NativeFieldInfoPtr_AbsoluteUri;

			// Token: 0x040013C6 RID: 5062
			private static readonly IntPtr NativeFieldInfoPtr_Hash;

			// Token: 0x040013C7 RID: 5063
			private static readonly IntPtr NativeFieldInfoPtr_RemoteUrl;

			// Token: 0x040013C8 RID: 5064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001B4 RID: 436
		[OriginalName("System.dll", "", "Check")]
		[Flags]
		public enum Check
		{
			// Token: 0x040013CA RID: 5066
			None = 0,
			// Token: 0x040013CB RID: 5067
			EscapedCanonical = 1,
			// Token: 0x040013CC RID: 5068
			DisplayCanonical = 2,
			// Token: 0x040013CD RID: 5069
			DotSlashAttn = 4,
			// Token: 0x040013CE RID: 5070
			DotSlashEscaped = 128,
			// Token: 0x040013CF RID: 5071
			BackslashInPath = 16,
			// Token: 0x040013D0 RID: 5072
			ReservedFound = 32,
			// Token: 0x040013D1 RID: 5073
			NotIriCanonical = 64,
			// Token: 0x040013D2 RID: 5074
			FoundNonAscii = 8
		}
	}
}
