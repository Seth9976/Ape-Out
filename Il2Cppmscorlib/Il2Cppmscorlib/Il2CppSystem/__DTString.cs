using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000AC RID: 172
	public sealed class __DTString : ValueType
	{
		// Token: 0x06000C74 RID: 3188 RVA: 0x0005CA68 File Offset: 0x0005AC68
		// Note: this type is marked as 'beforefieldinit'.
		static __DTString()
		{
			Il2CppClassPointerStore<__DTString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__DTString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__DTString>.NativeClassPtr);
			__DTString.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "Value");
			__DTString.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "Index");
			__DTString.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "len");
			__DTString.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "m_current");
			__DTString.NativeFieldInfoPtr_m_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "m_info");
			__DTString.NativeFieldInfoPtr_m_checkDigitToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "m_checkDigitToken");
			__DTString.NativeFieldInfoPtr_WhiteSpaceChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "WhiteSpaceChecks");
			__DTString.NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665433);
			__DTString.NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665434);
			__DTString.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665435);
			__DTString.NativeMethodInfoPtr_GetNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665436);
			__DTString.NativeMethodInfoPtr_AtEnd_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665437);
			__DTString.NativeMethodInfoPtr_Advance_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665438);
			__DTString.NativeMethodInfoPtr_GetRegularToken_Internal_Void_byref_TokenType_byref_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665439);
			__DTString.NativeMethodInfoPtr_GetSeparatorToken_Internal_TokenType_DateTimeFormatInfo_byref_Int32_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665440);
			__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665441);
			__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665442);
			__DTString.NativeMethodInfoPtr_MatchSpecifiedWords_Internal_Boolean_String_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665443);
			__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665444);
			__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665445);
			__DTString.NativeMethodInfoPtr_MatchLongestWords_Internal_Int32_Il2CppStringArray_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665446);
			__DTString.NativeMethodInfoPtr_GetRepeatCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665447);
			__DTString.NativeMethodInfoPtr_GetNextDigit_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665448);
			__DTString.NativeMethodInfoPtr_GetChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665449);
			__DTString.NativeMethodInfoPtr_GetDigit_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665450);
			__DTString.NativeMethodInfoPtr_SkipWhiteSpaces_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665451);
			__DTString.NativeMethodInfoPtr_SkipWhiteSpaceCurrent_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665452);
			__DTString.NativeMethodInfoPtr_TrimTail_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665453);
			__DTString.NativeMethodInfoPtr_RemoveTrailingInQuoteSpaces_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665454);
			__DTString.NativeMethodInfoPtr_RemoveLeadingInQuoteSpaces_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665455);
			__DTString.NativeMethodInfoPtr_GetSubString_Internal_DTSubString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665456);
			__DTString.NativeMethodInfoPtr_ConsumeSubString_Internal_Void_DTSubString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665457);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0005CD18 File Offset: 0x0005AF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156924, XrefRangeEnd = 156925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __DTString(string str, DateTimeFormatInfo dtfi, bool checkDigitToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__DTString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkDigitToken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0005CD88 File Offset: 0x0005AF88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156927, RefRangeEnd = 156929, XrefRangeStart = 156925, XrefRangeEnd = 156927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __DTString(string str, DateTimeFormatInfo dtfi)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__DTString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0005CDEC File Offset: 0x0005AFEC
		public unsafe CompareInfo CompareInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0005CE30 File Offset: 0x0005B030
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 156929, RefRangeEnd = 156947, XrefRangeStart = 156929, XrefRangeEnd = 156929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetNext_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0005CE74 File Offset: 0x0005B074
		[CallerCount(0)]
		public unsafe bool AtEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_AtEnd_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0005CEB8 File Offset: 0x0005B0B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156947, RefRangeEnd = 156949, XrefRangeStart = 156947, XrefRangeEnd = 156947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Advance(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_Advance_Internal_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0005CF08 File Offset: 0x0005B108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156967, RefRangeEnd = 156968, XrefRangeStart = 156949, XrefRangeEnd = 156967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &tokenType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tokenValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetRegularToken_Internal_Void_byref_TokenType_byref_Int32_DateTimeFormatInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0005CF6C File Offset: 0x0005B16C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 156972, RefRangeEnd = 156977, XrefRangeStart = 156968, XrefRangeEnd = 156972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexBeforeSeparator;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charBeforeSeparator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetSeparatorToken_Internal_TokenType_DateTimeFormatInfo_byref_Int32_byref_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0005CFDC File Offset: 0x0005B1DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 156977, RefRangeEnd = 156985, XrefRangeStart = 156977, XrefRangeEnd = 156977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchSpecifiedWord(string target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0005D030 File Offset: 0x0005B230
		[CallerCount(0)]
		public unsafe bool MatchSpecifiedWord(string target, int endIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0005D090 File Offset: 0x0005B290
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 157006, RefRangeEnd = 157017, XrefRangeStart = 156985, XrefRangeEnd = 157006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkWordBoundary;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matchLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchSpecifiedWords_Internal_Boolean_String_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0005D100 File Offset: 0x0005B300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157017, RefRangeEnd = 157020, XrefRangeStart = 157017, XrefRangeEnd = 157017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Match(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0005D154 File Offset: 0x0005B354
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 157020, RefRangeEnd = 157036, XrefRangeStart = 157020, XrefRangeEnd = 157020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Match(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0005D1A4 File Offset: 0x0005B3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157036, XrefRangeEnd = 157038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchLongestWords(Il2CppStringArray words, ref int maxMatchStrLen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(words);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxMatchStrLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchLongestWords_Internal_Int32_Il2CppStringArray_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0005D204 File Offset: 0x0005B404
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 157038, RefRangeEnd = 157050, XrefRangeStart = 157038, XrefRangeEnd = 157038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRepeatCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetRepeatCount_Internal_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0005D248 File Offset: 0x0005B448
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157053, RefRangeEnd = 157056, XrefRangeStart = 157050, XrefRangeEnd = 157053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNextDigit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetNextDigit_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0005D28C File Offset: 0x0005B48C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 157056, RefRangeEnd = 157066, XrefRangeStart = 157056, XrefRangeEnd = 157056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char GetChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetChar_Internal_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0005D2D0 File Offset: 0x0005B4D0
		[CallerCount(0)]
		public unsafe int GetDigit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetDigit_Internal_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0005D314 File Offset: 0x0005B514
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 157070, RefRangeEnd = 157079, XrefRangeStart = 157066, XrefRangeEnd = 157070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhiteSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_SkipWhiteSpaces_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0005D34C File Offset: 0x0005B54C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157086, RefRangeEnd = 157087, XrefRangeStart = 157079, XrefRangeEnd = 157086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SkipWhiteSpaceCurrent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_SkipWhiteSpaceCurrent_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0005D390 File Offset: 0x0005B590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157087, XrefRangeEnd = 157092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimTail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_TrimTail_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0005D3C8 File Offset: 0x0005B5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157092, XrefRangeEnd = 157101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrailingInQuoteSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_RemoveTrailingInQuoteSpaces_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0005D400 File Offset: 0x0005B600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157101, XrefRangeEnd = 157106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLeadingInQuoteSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_RemoveLeadingInQuoteSpaces_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0005D438 File Offset: 0x0005B638
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157106, RefRangeEnd = 157110, XrefRangeStart = 157106, XrefRangeEnd = 157106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DTSubString GetSubString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetSubString_Internal_DTSubString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new DTSubString(intPtr);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0005D474 File Offset: 0x0005B674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157110, RefRangeEnd = 157112, XrefRangeStart = 157110, XrefRangeEnd = 157110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeSubString(DTSubString sub)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sub));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_ConsumeSubString_Internal_Void_DTSubString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x000051B3 File Offset: 0x000033B3
		public __DTString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000051BC File Offset: 0x000033BC
		public __DTString()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__DTString>.NativeClassPtr))
		{
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0005D4C0 File Offset: 0x0005B6C0
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x000051CE File Offset: 0x000033CE
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0005D4E8 File Offset: 0x0005B6E8
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x000051ED File Offset: 0x000033ED
		public unsafe int Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Index)) = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x0005D510 File Offset: 0x0005B710
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00005208 File Offset: 0x00003408
		public unsafe int len
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_len);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_len)) = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0005D538 File Offset: 0x0005B738
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00005223 File Offset: 0x00003423
		public unsafe char m_current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_current)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0005D560 File Offset: 0x0005B760
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x0000523E File Offset: 0x0000343E
		public unsafe CompareInfo m_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0005D590 File Offset: 0x0005B790
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x0000525D File Offset: 0x0000345D
		public unsafe bool m_checkDigitToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_checkDigitToken);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_checkDigitToken)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0005D5B8 File Offset: 0x0005B7B8
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x00005278 File Offset: 0x00003478
		public unsafe static Il2CppStructArray<char> WhiteSpaceChecks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__DTString.NativeFieldInfoPtr_WhiteSpaceChecks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__DTString.NativeFieldInfoPtr_WhiteSpaceChecks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeFieldInfoPtr_len;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeFieldInfoPtr_m_current;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeFieldInfoPtr_m_info;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeFieldInfoPtr_m_checkDigitToken;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeFieldInfoPtr_WhiteSpaceChecks;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_Boolean_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Internal_Boolean_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_AtEnd_Internal_Boolean_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Internal_Boolean_Int32_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_GetRegularToken_Internal_Void_byref_TokenType_byref_Int32_DateTimeFormatInfo_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_GetSeparatorToken_Internal_TokenType_DateTimeFormatInfo_byref_Int32_byref_Char_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_Int32_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_MatchSpecifiedWords_Internal_Boolean_String_Boolean_byref_Int32_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_Match_Internal_Boolean_String_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_Match_Internal_Boolean_Char_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_MatchLongestWords_Internal_Int32_Il2CppStringArray_byref_Int32_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_GetRepeatCount_Internal_Int32_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_GetNextDigit_Internal_Boolean_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_GetChar_Internal_Char_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_GetDigit_Internal_Int32_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpaces_Internal_Void_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpaceCurrent_Internal_Boolean_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_TrimTail_Internal_Void_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrailingInQuoteSpaces_Internal_Void_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLeadingInQuoteSpaces_Internal_Void_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_GetSubString_Internal_DTSubString_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeSubString_Internal_Void_DTSubString_0;
	}
}
