using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000062 RID: 98
	public sealed class RegexParser : Object
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x000296B0 File Offset: 0x000278B0
		// Note: this type is marked as 'beforefieldinit'.
		static RegexParser()
		{
			Il2CppClassPointerStore<RegexParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexParser>.NativeClassPtr);
			RegexParser.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_stack");
			RegexParser.NativeFieldInfoPtr__group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_group");
			RegexParser.NativeFieldInfoPtr__alternation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_alternation");
			RegexParser.NativeFieldInfoPtr__concatenation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_concatenation");
			RegexParser.NativeFieldInfoPtr__unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_unit");
			RegexParser.NativeFieldInfoPtr__pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_pattern");
			RegexParser.NativeFieldInfoPtr__currentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_currentPos");
			RegexParser.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_culture");
			RegexParser.NativeFieldInfoPtr__autocap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_autocap");
			RegexParser.NativeFieldInfoPtr__capcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capcount");
			RegexParser.NativeFieldInfoPtr__captop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_captop");
			RegexParser.NativeFieldInfoPtr__capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capsize");
			RegexParser.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_caps");
			RegexParser.NativeFieldInfoPtr__capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capnames");
			RegexParser.NativeFieldInfoPtr__capnumlist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capnumlist");
			RegexParser.NativeFieldInfoPtr__capnamelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capnamelist");
			RegexParser.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_options");
			RegexParser.NativeFieldInfoPtr__optionsStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_optionsStack");
			RegexParser.NativeFieldInfoPtr__ignoreNextParen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_ignoreNextParen");
			RegexParser.NativeFieldInfoPtr__category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_category");
			RegexParser.NativeMethodInfoPtr_Parse_Internal_Static_RegexTree_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664271);
			RegexParser.NativeMethodInfoPtr_ParseReplacement_Internal_Static_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664272);
			RegexParser.NativeMethodInfoPtr_Escape_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664273);
			RegexParser.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664274);
			RegexParser.NativeMethodInfoPtr_SetPattern_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664275);
			RegexParser.NativeMethodInfoPtr_Reset_Internal_Void_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664276);
			RegexParser.NativeMethodInfoPtr_ScanRegex_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664277);
			RegexParser.NativeMethodInfoPtr_ScanReplacement_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664278);
			RegexParser.NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664279);
			RegexParser.NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664280);
			RegexParser.NativeMethodInfoPtr_ScanGroupOpen_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664281);
			RegexParser.NativeMethodInfoPtr_ScanBlank_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664282);
			RegexParser.NativeMethodInfoPtr_ScanBackslash_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664283);
			RegexParser.NativeMethodInfoPtr_ScanBasicBackslash_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664284);
			RegexParser.NativeMethodInfoPtr_ScanDollar_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664285);
			RegexParser.NativeMethodInfoPtr_ScanCapname_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664286);
			RegexParser.NativeMethodInfoPtr_ScanOctal_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664287);
			RegexParser.NativeMethodInfoPtr_ScanDecimal_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664288);
			RegexParser.NativeMethodInfoPtr_ScanHex_Internal_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664289);
			RegexParser.NativeMethodInfoPtr_HexDigit_Internal_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664290);
			RegexParser.NativeMethodInfoPtr_ScanControl_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664291);
			RegexParser.NativeMethodInfoPtr_IsOnlyTopOption_Internal_Boolean_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664292);
			RegexParser.NativeMethodInfoPtr_ScanOptions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664293);
			RegexParser.NativeMethodInfoPtr_ScanCharEscape_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664294);
			RegexParser.NativeMethodInfoPtr_ParseProperty_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664295);
			RegexParser.NativeMethodInfoPtr_TypeFromCode_Internal_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664296);
			RegexParser.NativeMethodInfoPtr_OptionFromCode_Internal_Static_RegexOptions_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664297);
			RegexParser.NativeMethodInfoPtr_CountCaptures_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664298);
			RegexParser.NativeMethodInfoPtr_NoteCaptureSlot_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664299);
			RegexParser.NativeMethodInfoPtr_NoteCaptureName_Internal_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664300);
			RegexParser.NativeMethodInfoPtr_NoteCaptures_Internal_Void_Hashtable_Int32_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664301);
			RegexParser.NativeMethodInfoPtr_AssignNameSlots_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664302);
			RegexParser.NativeMethodInfoPtr_CaptureSlotFromName_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664303);
			RegexParser.NativeMethodInfoPtr_IsCaptureSlot_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664304);
			RegexParser.NativeMethodInfoPtr_IsCaptureName_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664305);
			RegexParser.NativeMethodInfoPtr_UseOptionN_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664306);
			RegexParser.NativeMethodInfoPtr_UseOptionI_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664307);
			RegexParser.NativeMethodInfoPtr_UseOptionM_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664308);
			RegexParser.NativeMethodInfoPtr_UseOptionS_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664309);
			RegexParser.NativeMethodInfoPtr_UseOptionX_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664310);
			RegexParser.NativeMethodInfoPtr_UseOptionE_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664311);
			RegexParser.NativeMethodInfoPtr_IsSpecial_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664312);
			RegexParser.NativeMethodInfoPtr_IsStopperX_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664313);
			RegexParser.NativeMethodInfoPtr_IsQuantifier_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664314);
			RegexParser.NativeMethodInfoPtr_IsTrueQuantifier_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664315);
			RegexParser.NativeMethodInfoPtr_IsSpace_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664316);
			RegexParser.NativeMethodInfoPtr_IsMetachar_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664317);
			RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664318);
			RegexParser.NativeMethodInfoPtr_PushGroup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664319);
			RegexParser.NativeMethodInfoPtr_PopGroup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664320);
			RegexParser.NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664321);
			RegexParser.NativeMethodInfoPtr_StartGroup_Internal_Void_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664322);
			RegexParser.NativeMethodInfoPtr_AddAlternate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664323);
			RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664324);
			RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664325);
			RegexParser.NativeMethodInfoPtr_Unit_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664326);
			RegexParser.NativeMethodInfoPtr_AddUnitOne_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664327);
			RegexParser.NativeMethodInfoPtr_AddUnitNotone_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664328);
			RegexParser.NativeMethodInfoPtr_AddUnitSet_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664329);
			RegexParser.NativeMethodInfoPtr_AddUnitNode_Internal_Void_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664330);
			RegexParser.NativeMethodInfoPtr_AddUnitType_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664331);
			RegexParser.NativeMethodInfoPtr_AddGroup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664332);
			RegexParser.NativeMethodInfoPtr_PushOptions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664333);
			RegexParser.NativeMethodInfoPtr_PopOptions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664334);
			RegexParser.NativeMethodInfoPtr_EmptyOptionsStack_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664335);
			RegexParser.NativeMethodInfoPtr_PopKeepOptions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664336);
			RegexParser.NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664337);
			RegexParser.NativeMethodInfoPtr_Textpos_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664338);
			RegexParser.NativeMethodInfoPtr_Textto_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664339);
			RegexParser.NativeMethodInfoPtr_MoveRightGetChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664340);
			RegexParser.NativeMethodInfoPtr_MoveRight_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664341);
			RegexParser.NativeMethodInfoPtr_MoveRight_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664342);
			RegexParser.NativeMethodInfoPtr_MoveLeft_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664343);
			RegexParser.NativeMethodInfoPtr_CharAt_Internal_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664344);
			RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664345);
			RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664346);
			RegexParser.NativeMethodInfoPtr_CharsRight_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664347);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00029E74 File Offset: 0x00028074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371323, XrefRangeEnd = 371350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexTree Parse(string re, RegexOptions op)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(re);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Parse_Internal_Static_RegexTree_String_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexTree>(intPtr3) : null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00029EC8 File Offset: 0x000280C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371368, RefRangeEnd = 371369, XrefRangeStart = 371350, XrefRangeEnd = 371368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rep);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ParseReplacement_Internal_Static_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexReplacement>(intPtr3) : null;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00029F4C File Offset: 0x0002814C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371391, RefRangeEnd = 371392, XrefRangeStart = 371369, XrefRangeEnd = 371391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Escape(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Escape_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00029F88 File Offset: 0x00028188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371402, RefRangeEnd = 371404, XrefRangeStart = 371392, XrefRangeEnd = 371402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexParser(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00029FD4 File Offset: 0x000281D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371406, RefRangeEnd = 371408, XrefRangeStart = 371404, XrefRangeEnd = 371406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPattern(string Re)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Re);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_SetPattern_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0002A018 File Offset: 0x00028218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371408, XrefRangeEnd = 371412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(RegexOptions topopts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topopts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Reset_Internal_Void_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0002A058 File Offset: 0x00028258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371494, RefRangeEnd = 371495, XrefRangeStart = 371412, XrefRangeEnd = 371494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanRegex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanRegex_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0002A098 File Offset: 0x00028298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371502, RefRangeEnd = 371503, XrefRangeStart = 371495, XrefRangeEnd = 371502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanReplacement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanReplacement_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0002A0D8 File Offset: 0x000282D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371503, XrefRangeEnd = 371504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass ScanCharClass(bool caseInsensitive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caseInsensitive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0002A124 File Offset: 0x00028324
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 371550, RefRangeEnd = 371556, XrefRangeStart = 371504, XrefRangeEnd = 371550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caseInsensitive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scanOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0002A180 File Offset: 0x00028380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371571, RefRangeEnd = 371572, XrefRangeStart = 371556, XrefRangeEnd = 371571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanGroupOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanGroupOpen_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0002A1C0 File Offset: 0x000283C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 371587, RefRangeEnd = 371593, XrefRangeStart = 371572, XrefRangeEnd = 371587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanBlank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanBlank_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0002A1F4 File Offset: 0x000283F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371616, RefRangeEnd = 371617, XrefRangeStart = 371593, XrefRangeEnd = 371616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanBackslash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanBackslash_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0002A234 File Offset: 0x00028434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371617, XrefRangeEnd = 371628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanBasicBackslash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanBasicBackslash_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0002A274 File Offset: 0x00028474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371639, RefRangeEnd = 371640, XrefRangeStart = 371628, XrefRangeEnd = 371639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanDollar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanDollar_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002A2B4 File Offset: 0x000284B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371647, RefRangeEnd = 371650, XrefRangeStart = 371640, XrefRangeEnd = 371647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ScanCapname()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCapname_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0002A2EC File Offset: 0x000284EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371650, XrefRangeEnd = 371651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanOctal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanOctal_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0002A328 File Offset: 0x00028528
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 371653, RefRangeEnd = 371657, XrefRangeStart = 371651, XrefRangeEnd = 371653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ScanDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanDecimal_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0002A364 File Offset: 0x00028564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371657, XrefRangeEnd = 371661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanHex(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanHex_Internal_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002A3B0 File Offset: 0x000285B0
		[CallerCount(0)]
		public unsafe static int HexDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_HexDigit_Internal_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002A3F0 File Offset: 0x000285F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371661, XrefRangeEnd = 371662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanControl_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0002A42C File Offset: 0x0002862C
		[CallerCount(0)]
		public unsafe bool IsOnlyTopOption(RegexOptions option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref option;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsOnlyTopOption_Internal_Boolean_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0002A478 File Offset: 0x00028678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371671, RefRangeEnd = 371672, XrefRangeStart = 371662, XrefRangeEnd = 371671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanOptions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0002A4AC File Offset: 0x000286AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371675, RefRangeEnd = 371676, XrefRangeStart = 371672, XrefRangeEnd = 371675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanCharEscape()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCharEscape_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0002A4E8 File Offset: 0x000286E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371684, RefRangeEnd = 371686, XrefRangeStart = 371676, XrefRangeEnd = 371684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ParseProperty_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0002A520 File Offset: 0x00028720
		[CallerCount(0)]
		public unsafe int TypeFromCode(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_TypeFromCode_Internal_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0002A56C File Offset: 0x0002876C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371686, RefRangeEnd = 371687, XrefRangeStart = 371686, XrefRangeEnd = 371686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexOptions OptionFromCode(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_OptionFromCode_Internal_Static_RegexOptions_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0002A5AC File Offset: 0x000287AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371725, RefRangeEnd = 371726, XrefRangeStart = 371687, XrefRangeEnd = 371725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CountCaptures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CountCaptures_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0002A5E0 File Offset: 0x000287E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371733, RefRangeEnd = 371736, XrefRangeStart = 371726, XrefRangeEnd = 371733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoteCaptureSlot(int i, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_NoteCaptureSlot_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0002A62C File Offset: 0x0002882C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371752, RefRangeEnd = 371753, XrefRangeStart = 371736, XrefRangeEnd = 371752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoteCaptureName(string name, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_NoteCaptureName_Internal_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0002A67C File Offset: 0x0002887C
		[CallerCount(0)]
		public unsafe void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(caps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_NoteCaptures_Internal_Void_Hashtable_Int32_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0002A6E0 File Offset: 0x000288E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371818, RefRangeEnd = 371819, XrefRangeStart = 371753, XrefRangeEnd = 371818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignNameSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AssignNameSlots_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0002A714 File Offset: 0x00028914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371821, RefRangeEnd = 371822, XrefRangeStart = 371819, XrefRangeEnd = 371821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CaptureSlotFromName(string capname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CaptureSlotFromName_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0002A764 File Offset: 0x00028964
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 371823, RefRangeEnd = 371828, XrefRangeStart = 371822, XrefRangeEnd = 371823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCaptureSlot(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsCaptureSlot_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0002A7B0 File Offset: 0x000289B0
		[CallerCount(0)]
		public unsafe bool IsCaptureName(string capname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsCaptureName_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0002A800 File Offset: 0x00028A00
		[CallerCount(0)]
		public unsafe bool UseOptionN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionN_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0002A83C File Offset: 0x00028A3C
		[CallerCount(0)]
		public unsafe bool UseOptionI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionI_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0002A878 File Offset: 0x00028A78
		[CallerCount(0)]
		public unsafe bool UseOptionM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionM_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0002A8B4 File Offset: 0x00028AB4
		[CallerCount(0)]
		public unsafe bool UseOptionS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionS_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0002A8F0 File Offset: 0x00028AF0
		[CallerCount(0)]
		public unsafe bool UseOptionX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionX_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0002A92C File Offset: 0x00028B2C
		[CallerCount(0)]
		public unsafe bool UseOptionE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionE_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0002A968 File Offset: 0x00028B68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371829, RefRangeEnd = 371831, XrefRangeStart = 371828, XrefRangeEnd = 371829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSpecial(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsSpecial_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0002A9A8 File Offset: 0x00028BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371832, RefRangeEnd = 371833, XrefRangeStart = 371831, XrefRangeEnd = 371832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsStopperX(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsStopperX_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0002A9E8 File Offset: 0x00028BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371834, RefRangeEnd = 371835, XrefRangeStart = 371833, XrefRangeEnd = 371834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsQuantifier(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsQuantifier_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0002AA28 File Offset: 0x00028C28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371839, RefRangeEnd = 371842, XrefRangeStart = 371835, XrefRangeEnd = 371839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTrueQuantifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsTrueQuantifier_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0002AA64 File Offset: 0x00028C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371842, XrefRangeEnd = 371843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSpace(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsSpace_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0002AAA4 File Offset: 0x00028CA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371844, RefRangeEnd = 371846, XrefRangeStart = 371843, XrefRangeEnd = 371844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMetachar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsMetachar_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0002AAE4 File Offset: 0x00028CE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371866, RefRangeEnd = 371868, XrefRangeStart = 371846, XrefRangeEnd = 371866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConcatenate(int pos, int cch, bool isReplacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isReplacement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0002AB40 File Offset: 0x00028D40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371868, RefRangeEnd = 371869, XrefRangeStart = 371868, XrefRangeEnd = 371868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PushGroup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0002AB74 File Offset: 0x00028D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371872, RefRangeEnd = 371873, XrefRangeStart = 371869, XrefRangeEnd = 371872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PopGroup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0002ABA8 File Offset: 0x00028DA8
		[CallerCount(0)]
		public unsafe bool EmptyStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0002ABE4 File Offset: 0x00028DE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371878, RefRangeEnd = 371880, XrefRangeStart = 371873, XrefRangeEnd = 371878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGroup(RegexNode openGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(openGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_StartGroup_Internal_Void_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0002AC28 File Offset: 0x00028E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371887, RefRangeEnd = 371888, XrefRangeStart = 371880, XrefRangeEnd = 371887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAlternate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddAlternate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0002AC5C File Offset: 0x00028E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371889, RefRangeEnd = 371891, XrefRangeStart = 371888, XrefRangeEnd = 371889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConcatenate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0002AC90 File Offset: 0x00028E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371900, RefRangeEnd = 371901, XrefRangeStart = 371891, XrefRangeEnd = 371900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConcatenate(bool lazy, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lazy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0002ACEC File Offset: 0x00028EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode Unit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Unit_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0002AD2C File Offset: 0x00028F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371907, RefRangeEnd = 371908, XrefRangeStart = 371901, XrefRangeEnd = 371907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitOne(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitOne_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0002AD6C File Offset: 0x00028F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371914, RefRangeEnd = 371915, XrefRangeStart = 371908, XrefRangeEnd = 371914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitNotone(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitNotone_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0002ADAC File Offset: 0x00028FAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371918, RefRangeEnd = 371920, XrefRangeStart = 371915, XrefRangeEnd = 371918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitSet(string cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitSet_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0002ADF0 File Offset: 0x00028FF0
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitNode(RegexNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitNode_Internal_Void_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0002AE34 File Offset: 0x00029034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371923, RefRangeEnd = 371925, XrefRangeStart = 371920, XrefRangeEnd = 371923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitType(int type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitType_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0002AE74 File Offset: 0x00029074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371928, RefRangeEnd = 371930, XrefRangeStart = 371925, XrefRangeEnd = 371928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddGroup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0002AEA8 File Offset: 0x000290A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371934, RefRangeEnd = 371936, XrefRangeStart = 371930, XrefRangeEnd = 371934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PushOptions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0002AEDC File Offset: 0x000290DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371943, RefRangeEnd = 371945, XrefRangeStart = 371936, XrefRangeEnd = 371943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PopOptions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0002AF10 File Offset: 0x00029110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371946, RefRangeEnd = 371947, XrefRangeStart = 371945, XrefRangeEnd = 371946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EmptyOptionsStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_EmptyOptionsStack_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0002AF4C File Offset: 0x0002914C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371952, RefRangeEnd = 371954, XrefRangeStart = 371947, XrefRangeEnd = 371952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopKeepOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PopKeepOptions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0002AF80 File Offset: 0x00029180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371954, XrefRangeEnd = 371968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException MakeException(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0002AFD0 File Offset: 0x000291D0
		[CallerCount(0)]
		public unsafe int Textpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Textpos_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0002B00C File Offset: 0x0002920C
		[CallerCount(0)]
		public unsafe void Textto(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Textto_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0002B04C File Offset: 0x0002924C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 371968, RefRangeEnd = 371983, XrefRangeStart = 371968, XrefRangeEnd = 371968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char MoveRightGetChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveRightGetChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0002B088 File Offset: 0x00029288
		[CallerCount(0)]
		public unsafe void MoveRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveRight_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0002B0BC File Offset: 0x000292BC
		[CallerCount(0)]
		public unsafe void MoveRight(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveRight_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0002B0FC File Offset: 0x000292FC
		[CallerCount(0)]
		public unsafe void MoveLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveLeft_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0002B130 File Offset: 0x00029330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371983, RefRangeEnd = 371986, XrefRangeStart = 371983, XrefRangeEnd = 371983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char CharAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CharAt_Internal_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0002B17C File Offset: 0x0002937C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 371986, RefRangeEnd = 372018, XrefRangeStart = 371986, XrefRangeEnd = 371986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char RightChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0002B1B8 File Offset: 0x000293B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372018, RefRangeEnd = 372021, XrefRangeStart = 372018, XrefRangeEnd = 372018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char RightChar(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0002B204 File Offset: 0x00029404
		[CallerCount(0)]
		public unsafe int CharsRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CharsRight_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000477E File Offset: 0x0000297E
		public RegexParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0002B240 File Offset: 0x00029440
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00004787 File Offset: 0x00002987
		public unsafe RegexNode _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0002B270 File Offset: 0x00029470
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x000047A6 File Offset: 0x000029A6
		public unsafe RegexNode _group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0002B2A0 File Offset: 0x000294A0
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x000047C5 File Offset: 0x000029C5
		public unsafe RegexNode _alternation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__alternation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__alternation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0002B2D0 File Offset: 0x000294D0
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x000047E4 File Offset: 0x000029E4
		public unsafe RegexNode _concatenation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__concatenation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__concatenation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0002B300 File Offset: 0x00029500
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00004803 File Offset: 0x00002A03
		public unsafe RegexNode _unit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__unit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__unit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0002B330 File Offset: 0x00029530
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00004822 File Offset: 0x00002A22
		public unsafe string _pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0002B358 File Offset: 0x00029558
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00004841 File Offset: 0x00002A41
		public unsafe int _currentPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__currentPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__currentPos)) = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0002B380 File Offset: 0x00029580
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x0000485C File Offset: 0x00002A5C
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0002B3B0 File Offset: 0x000295B0
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x0000487B File Offset: 0x00002A7B
		public unsafe int _autocap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__autocap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__autocap)) = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0002B3D8 File Offset: 0x000295D8
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00004896 File Offset: 0x00002A96
		public unsafe int _capcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capcount)) = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0002B400 File Offset: 0x00029600
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x000048B1 File Offset: 0x00002AB1
		public unsafe int _captop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__captop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__captop)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0002B428 File Offset: 0x00029628
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x000048CC File Offset: 0x00002ACC
		public unsafe int _capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capsize)) = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x0002B450 File Offset: 0x00029650
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x000048E7 File Offset: 0x00002AE7
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0002B480 File Offset: 0x00029680
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00004906 File Offset: 0x00002B06
		public unsafe Hashtable _capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0002B4B0 File Offset: 0x000296B0
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00004925 File Offset: 0x00002B25
		public unsafe Il2CppStructArray<int> _capnumlist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnumlist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnumlist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0002B4E0 File Offset: 0x000296E0
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00004944 File Offset: 0x00002B44
		public unsafe List<string> _capnamelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnamelist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnamelist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0002B510 File Offset: 0x00029710
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00004963 File Offset: 0x00002B63
		public unsafe RegexOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__options)) = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0002B538 File Offset: 0x00029738
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x0000497E File Offset: 0x00002B7E
		public unsafe List<RegexOptions> _optionsStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__optionsStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__optionsStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0002B568 File Offset: 0x00029768
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x0000499D File Offset: 0x00002B9D
		public unsafe bool _ignoreNextParen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__ignoreNextParen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__ignoreNextParen)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0002B590 File Offset: 0x00029790
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x000049B8 File Offset: 0x00002BB8
		public unsafe static Il2CppStructArray<byte> _category
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexParser.NativeFieldInfoPtr__category, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexParser.NativeFieldInfoPtr__category, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr__group;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr__alternation;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr__concatenation;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr__unit;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr__pattern;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr__currentPos;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr__autocap;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr__capcount;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr__captop;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr__capsize;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr__capnames;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr__capnumlist;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr__capnamelist;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr__optionsStack;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr__ignoreNextParen;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr__category;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_RegexTree_String_RegexOptions_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_ParseReplacement_Internal_Static_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_Escape_Internal_Static_String_String_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_SetPattern_Internal_Void_String_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_RegexOptions_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_ScanRegex_Internal_RegexNode_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_ScanReplacement_Internal_RegexNode_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_Boolean_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_ScanGroupOpen_Internal_RegexNode_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_ScanBlank_Internal_Void_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_ScanBackslash_Internal_RegexNode_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_ScanBasicBackslash_Internal_RegexNode_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_ScanDollar_Internal_RegexNode_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_ScanCapname_Internal_String_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_ScanOctal_Internal_Char_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_ScanDecimal_Internal_Int32_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_ScanHex_Internal_Char_Int32_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_HexDigit_Internal_Static_Int32_Char_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_ScanControl_Internal_Char_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyTopOption_Internal_Boolean_RegexOptions_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_ScanOptions_Internal_Void_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_ScanCharEscape_Internal_Char_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_ParseProperty_Internal_String_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_TypeFromCode_Internal_Int32_Char_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_OptionFromCode_Internal_Static_RegexOptions_Char_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_CountCaptures_Internal_Void_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_NoteCaptureSlot_Internal_Void_Int32_Int32_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_NoteCaptureName_Internal_Void_String_Int32_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_NoteCaptures_Internal_Void_Hashtable_Int32_Hashtable_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_AssignNameSlots_Internal_Void_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_CaptureSlotFromName_Internal_Int32_String_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_IsCaptureSlot_Internal_Boolean_Int32_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_IsCaptureName_Internal_Boolean_String_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionN_Internal_Boolean_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionI_Internal_Boolean_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionM_Internal_Boolean_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionS_Internal_Boolean_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionX_Internal_Boolean_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionE_Internal_Boolean_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecial_Internal_Static_Boolean_Char_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_IsStopperX_Internal_Static_Boolean_Char_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_IsQuantifier_Internal_Static_Boolean_Char_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_IsTrueQuantifier_Internal_Boolean_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_IsSpace_Internal_Static_Boolean_Char_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_IsMetachar_Internal_Static_Boolean_Char_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_AddConcatenate_Internal_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_PushGroup_Internal_Void_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_PopGroup_Internal_Void_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_StartGroup_Internal_Void_RegexNode_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_AddAlternate_Internal_Void_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_AddConcatenate_Internal_Void_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_AddConcatenate_Internal_Void_Boolean_Int32_Int32_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_Unit_Internal_RegexNode_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitOne_Internal_Void_Char_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitNotone_Internal_Void_Char_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitSet_Internal_Void_String_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitNode_Internal_Void_RegexNode_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitType_Internal_Void_Int32_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_AddGroup_Internal_Void_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_PushOptions_Internal_Void_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_PopOptions_Internal_Void_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_EmptyOptionsStack_Internal_Boolean_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_PopKeepOptions_Internal_Void_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_Textpos_Internal_Int32_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_Textto_Internal_Void_Int32_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_MoveRightGetChar_Internal_Char_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Internal_Void_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Internal_Void_Int32_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Internal_Void_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_CharAt_Internal_Char_Int32_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_RightChar_Internal_Char_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_RightChar_Internal_Char_Int32_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_CharsRight_Internal_Int32_0;
	}
}
