using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000242 RID: 578
	[Serializable]
	public sealed class NumberFormatInfo : Object
	{
		// Token: 0x06002721 RID: 10017 RVA: 0x000D20B4 File Offset: 0x000D02B4
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFormatInfo()
		{
			Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "NumberFormatInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr);
			NumberFormatInfo.NativeFieldInfoPtr_invariantInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "invariantInfo");
			NumberFormatInfo.NativeFieldInfoPtr_numberGroupSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberGroupSizes");
			NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyGroupSizes");
			NumberFormatInfo.NativeFieldInfoPtr_percentGroupSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentGroupSizes");
			NumberFormatInfo.NativeFieldInfoPtr_positiveSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "positiveSign");
			NumberFormatInfo.NativeFieldInfoPtr_negativeSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "negativeSign");
			NumberFormatInfo.NativeFieldInfoPtr_numberDecimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberDecimalSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_numberGroupSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberGroupSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyGroupSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyDecimalSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_currencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_ansiCurrencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "ansiCurrencySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_nanSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "nanSymbol");
			NumberFormatInfo.NativeFieldInfoPtr_positiveInfinitySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "positiveInfinitySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_negativeInfinitySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "negativeInfinitySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_percentDecimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentDecimalSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_percentGroupSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentGroupSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_percentSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentSymbol");
			NumberFormatInfo.NativeFieldInfoPtr_perMilleSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "perMilleSymbol");
			NumberFormatInfo.NativeFieldInfoPtr_nativeDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "nativeDigits");
			NumberFormatInfo.NativeFieldInfoPtr_m_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "m_dataItem");
			NumberFormatInfo.NativeFieldInfoPtr_numberDecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberDecimalDigits");
			NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyDecimalDigits");
			NumberFormatInfo.NativeFieldInfoPtr_currencyPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyPositivePattern");
			NumberFormatInfo.NativeFieldInfoPtr_currencyNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyNegativePattern");
			NumberFormatInfo.NativeFieldInfoPtr_numberNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberNegativePattern");
			NumberFormatInfo.NativeFieldInfoPtr_percentPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentPositivePattern");
			NumberFormatInfo.NativeFieldInfoPtr_percentNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentNegativePattern");
			NumberFormatInfo.NativeFieldInfoPtr_percentDecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentDecimalDigits");
			NumberFormatInfo.NativeFieldInfoPtr_digitSubstitution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "digitSubstitution");
			NumberFormatInfo.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "isReadOnly");
			NumberFormatInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "m_useUserOverride");
			NumberFormatInfo.NativeFieldInfoPtr_m_isInvariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "m_isInvariant");
			NumberFormatInfo.NativeFieldInfoPtr_validForParseAsNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "validForParseAsNumber");
			NumberFormatInfo.NativeFieldInfoPtr_validForParseAsCurrency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "validForParseAsCurrency");
			NumberFormatInfo.NativeFieldInfoPtr_InvalidNumberStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "InvalidNumberStyles");
			NumberFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669745);
			NumberFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669746);
			NumberFormatInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669747);
			NumberFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669748);
			NumberFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669749);
			NumberFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669750);
			NumberFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_NumberFormatInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669751);
			NumberFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669752);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalDigits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669753);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669754);
			NumberFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669755);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSizes_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669756);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSizes_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669757);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSizes_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669758);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669759);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669760);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669761);
			NumberFormatInfo.NativeMethodInfoPtr_get_NaNSymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669762);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyNegativePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669763);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberNegativePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669764);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentPositivePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669765);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentNegativePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669766);
			NumberFormatInfo.NativeMethodInfoPtr_get_NegativeInfinitySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669767);
			NumberFormatInfo.NativeMethodInfoPtr_get_NegativeSign_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669768);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalDigits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669769);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669770);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669771);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyPositivePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669772);
			NumberFormatInfo.NativeMethodInfoPtr_get_PositiveInfinitySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669773);
			NumberFormatInfo.NativeMethodInfoPtr_get_PositiveSign_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669774);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalDigits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669775);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669776);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669777);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentSymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669778);
			NumberFormatInfo.NativeMethodInfoPtr_get_PerMilleSymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669779);
			NumberFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669780);
			NumberFormatInfo.NativeMethodInfoPtr_ReadOnly_Public_Static_NumberFormatInfo_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669781);
			NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleInteger_Internal_Static_Void_NumberStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669782);
			NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleFloatingPoint_Internal_Static_Void_NumberStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669783);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000D26C0 File Offset: 0x000D08C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196435, XrefRangeEnd = 196436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000D26FC File Offset: 0x000D08FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196436, XrefRangeEnd = 196439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000D2744 File Offset: 0x000D0944
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000D278C File Offset: 0x000D098C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000D27D4 File Offset: 0x000D09D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 196524, RefRangeEnd = 196528, XrefRangeStart = 196439, XrefRangeEnd = 196524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatInfo(CultureData cultureData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000D2820 File Offset: 0x000D0A20
		public unsafe static NumberFormatInfo InvariantInfo
		{
			[CallerCount(116)]
			[CachedScanResults(RefRangeStart = 196538, RefRangeEnd = 196654, XrefRangeStart = 196528, XrefRangeEnd = 196538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000D2854 File Offset: 0x000D0A54
		[CallerCount(345)]
		[CachedScanResults(RefRangeStart = 196667, RefRangeEnd = 197012, XrefRangeStart = 196654, XrefRangeEnd = 196667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_NumberFormatInfo_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x000D2898 File Offset: 0x000D0A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197015, RefRangeEnd = 197017, XrefRangeStart = 197012, XrefRangeEnd = 197015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000D28D8 File Offset: 0x000D0AD8
		public unsafe int CurrencyDecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalDigits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x000D2914 File Offset: 0x000D0B14
		public unsafe string CurrencyDecimalSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x000D294C File Offset: 0x000D0B4C
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x000D2988 File Offset: 0x000D0B88
		public unsafe Il2CppStructArray<int> CurrencyGroupSizes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197017, XrefRangeEnd = 197020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSizes_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000D29C8 File Offset: 0x000D0BC8
		public unsafe Il2CppStructArray<int> NumberGroupSizes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 197023, RefRangeEnd = 197025, XrefRangeStart = 197020, XrefRangeEnd = 197023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSizes_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x000D2A08 File Offset: 0x000D0C08
		public unsafe Il2CppStructArray<int> PercentGroupSizes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197025, XrefRangeEnd = 197028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSizes_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x000D2A48 File Offset: 0x000D0C48
		public unsafe string CurrencyGroupSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002731 RID: 10033 RVA: 0x000D2A80 File Offset: 0x000D0C80
		public unsafe string CurrencySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000D2AB8 File Offset: 0x000D0CB8
		public unsafe static NumberFormatInfo CurrentInfo
		{
			[CallerCount(547)]
			[CachedScanResults(RefRangeStart = 197038, RefRangeEnd = 197585, XrefRangeStart = 197028, XrefRangeEnd = 197038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x000D2AEC File Offset: 0x000D0CEC
		public unsafe string NaNSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NaNSymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000D2B24 File Offset: 0x000D0D24
		public unsafe int CurrencyNegativePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyNegativePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x000D2B60 File Offset: 0x000D0D60
		public unsafe int NumberNegativePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberNegativePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x000D2B9C File Offset: 0x000D0D9C
		public unsafe int PercentPositivePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentPositivePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x000D2BD8 File Offset: 0x000D0DD8
		public unsafe int PercentNegativePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentNegativePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x000D2C14 File Offset: 0x000D0E14
		public unsafe string NegativeInfinitySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NegativeInfinitySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x000D2C4C File Offset: 0x000D0E4C
		public unsafe string NegativeSign
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NegativeSign_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x000D2C84 File Offset: 0x000D0E84
		public unsafe int NumberDecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalDigits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x000D2CC0 File Offset: 0x000D0EC0
		public unsafe string NumberDecimalSeparator
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x000D2CF8 File Offset: 0x000D0EF8
		public unsafe string NumberGroupSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x0600273D RID: 10045 RVA: 0x000D2D30 File Offset: 0x000D0F30
		public unsafe int CurrencyPositivePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyPositivePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x000D2D6C File Offset: 0x000D0F6C
		public unsafe string PositiveInfinitySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PositiveInfinitySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x000D2DA4 File Offset: 0x000D0FA4
		public unsafe string PositiveSign
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PositiveSign_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000D2DDC File Offset: 0x000D0FDC
		public unsafe int PercentDecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalDigits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x000D2E18 File Offset: 0x000D1018
		public unsafe string PercentDecimalSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x000D2E50 File Offset: 0x000D1050
		public unsafe string PercentGroupSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x000D2E88 File Offset: 0x000D1088
		public unsafe string PercentSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentSymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x000D2EC0 File Offset: 0x000D10C0
		public unsafe string PerMilleSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PerMilleSymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000D2EF8 File Offset: 0x000D10F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197585, XrefRangeEnd = 197591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000D2F48 File Offset: 0x000D1148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197591, XrefRangeEnd = 197594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_ReadOnly_Public_Static_NumberFormatInfo_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000D2F8C File Offset: 0x000D118C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 197594, RefRangeEnd = 197613, XrefRangeStart = 197594, XrefRangeEnd = 197594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateParseStyleInteger(NumberStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleInteger_Internal_Static_Void_NumberStyles_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000D2FC0 File Offset: 0x000D11C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 197613, RefRangeEnd = 197619, XrefRangeStart = 197613, XrefRangeEnd = 197613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleFloatingPoint_Internal_Static_Void_NumberStyles_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0000D39F File Offset: 0x0000B59F
		public NumberFormatInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x000D2FF4 File Offset: 0x000D11F4
		// (set) Token: 0x0600274B RID: 10059 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		public unsafe static NumberFormatInfo invariantInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatInfo.NativeFieldInfoPtr_invariantInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatInfo.NativeFieldInfoPtr_invariantInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000D301C File Offset: 0x000D121C
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x0000D3BA File Offset: 0x0000B5BA
		public unsafe Il2CppStructArray<int> numberGroupSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x000D304C File Offset: 0x000D124C
		// (set) Token: 0x0600274F RID: 10063 RVA: 0x0000D3D9 File Offset: 0x0000B5D9
		public unsafe Il2CppStructArray<int> currencyGroupSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x000D307C File Offset: 0x000D127C
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		public unsafe Il2CppStructArray<int> percentGroupSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000D30AC File Offset: 0x000D12AC
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x0000D417 File Offset: 0x0000B617
		public unsafe string positiveSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveSign);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveSign), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x000D30D4 File Offset: 0x000D12D4
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x0000D436 File Offset: 0x0000B636
		public unsafe string negativeSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeSign);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeSign), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x000D30FC File Offset: 0x000D12FC
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x0000D455 File Offset: 0x0000B655
		public unsafe string numberDecimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000D3124 File Offset: 0x000D1324
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x0000D474 File Offset: 0x0000B674
		public unsafe string numberGroupSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000D314C File Offset: 0x000D134C
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x0000D493 File Offset: 0x0000B693
		public unsafe string currencyGroupSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x000D3174 File Offset: 0x000D1374
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x0000D4B2 File Offset: 0x0000B6B2
		public unsafe string currencyDecimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000D319C File Offset: 0x000D139C
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x0000D4D1 File Offset: 0x0000B6D1
		public unsafe string currencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000D31C4 File Offset: 0x000D13C4
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		public unsafe string ansiCurrencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_ansiCurrencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_ansiCurrencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000D31EC File Offset: 0x000D13EC
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x0000D50F File Offset: 0x0000B70F
		public unsafe string nanSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nanSymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nanSymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000D3214 File Offset: 0x000D1414
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x0000D52E File Offset: 0x0000B72E
		public unsafe string positiveInfinitySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveInfinitySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveInfinitySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x000D323C File Offset: 0x000D143C
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x0000D54D File Offset: 0x0000B74D
		public unsafe string negativeInfinitySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeInfinitySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeInfinitySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x000D3264 File Offset: 0x000D1464
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x0000D56C File Offset: 0x0000B76C
		public unsafe string percentDecimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x000D328C File Offset: 0x000D148C
		// (set) Token: 0x0600276B RID: 10091 RVA: 0x0000D58B File Offset: 0x0000B78B
		public unsafe string percentGroupSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x000D32B4 File Offset: 0x000D14B4
		// (set) Token: 0x0600276D RID: 10093 RVA: 0x0000D5AA File Offset: 0x0000B7AA
		public unsafe string percentSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentSymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentSymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000D32DC File Offset: 0x000D14DC
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x0000D5C9 File Offset: 0x0000B7C9
		public unsafe string perMilleSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_perMilleSymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_perMilleSymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x000D3304 File Offset: 0x000D1504
		// (set) Token: 0x06002771 RID: 10097 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
		public unsafe Il2CppStringArray nativeDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nativeDigits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nativeDigits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x000D3334 File Offset: 0x000D1534
		// (set) Token: 0x06002773 RID: 10099 RVA: 0x0000D607 File Offset: 0x0000B807
		public unsafe int m_dataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_dataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_dataItem)) = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x000D335C File Offset: 0x000D155C
		// (set) Token: 0x06002775 RID: 10101 RVA: 0x0000D622 File Offset: 0x0000B822
		public unsafe int numberDecimalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalDigits)) = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x000D3384 File Offset: 0x000D1584
		// (set) Token: 0x06002777 RID: 10103 RVA: 0x0000D63D File Offset: 0x0000B83D
		public unsafe int currencyDecimalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalDigits)) = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000D33AC File Offset: 0x000D15AC
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x0000D658 File Offset: 0x0000B858
		public unsafe int currencyPositivePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyPositivePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyPositivePattern)) = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000D33D4 File Offset: 0x000D15D4
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x0000D673 File Offset: 0x0000B873
		public unsafe int currencyNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyNegativePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyNegativePattern)) = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x000D33FC File Offset: 0x000D15FC
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x0000D68E File Offset: 0x0000B88E
		public unsafe int numberNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberNegativePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberNegativePattern)) = value;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x000D3424 File Offset: 0x000D1624
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x0000D6A9 File Offset: 0x0000B8A9
		public unsafe int percentPositivePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentPositivePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentPositivePattern)) = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x000D344C File Offset: 0x000D164C
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		public unsafe int percentNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentNegativePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentNegativePattern)) = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x000D3474 File Offset: 0x000D1674
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x0000D6DF File Offset: 0x0000B8DF
		public unsafe int percentDecimalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalDigits)) = value;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x000D349C File Offset: 0x000D169C
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x0000D6FA File Offset: 0x0000B8FA
		public unsafe int digitSubstitution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_digitSubstitution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_digitSubstitution)) = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x000D34C4 File Offset: 0x000D16C4
		// (set) Token: 0x06002787 RID: 10119 RVA: 0x0000D715 File Offset: 0x0000B915
		public unsafe bool isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_isReadOnly)) = value;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x000D34EC File Offset: 0x000D16EC
		// (set) Token: 0x06002789 RID: 10121 RVA: 0x0000D730 File Offset: 0x0000B930
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x000D3514 File Offset: 0x000D1714
		// (set) Token: 0x0600278B RID: 10123 RVA: 0x0000D74B File Offset: 0x0000B94B
		public unsafe bool m_isInvariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_isInvariant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_isInvariant)) = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x000D353C File Offset: 0x000D173C
		// (set) Token: 0x0600278D RID: 10125 RVA: 0x0000D766 File Offset: 0x0000B966
		public unsafe bool validForParseAsNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsNumber)) = value;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x000D3564 File Offset: 0x000D1764
		// (set) Token: 0x0600278F RID: 10127 RVA: 0x0000D781 File Offset: 0x0000B981
		public unsafe bool validForParseAsCurrency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsCurrency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsCurrency)) = value;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x000D358C File Offset: 0x000D178C
		// (set) Token: 0x06002791 RID: 10129 RVA: 0x0000D79C File Offset: 0x0000B99C
		public unsafe static NumberStyles InvalidNumberStyles
		{
			get
			{
				NumberStyles numberStyles;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatInfo.NativeFieldInfoPtr_InvalidNumberStyles, (void*)(&numberStyles));
				return numberStyles;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatInfo.NativeFieldInfoPtr_InvalidNumberStyles, (void*)(&value));
			}
		}

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeFieldInfoPtr_invariantInfo;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeFieldInfoPtr_numberGroupSizes;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeFieldInfoPtr_currencyGroupSizes;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeFieldInfoPtr_percentGroupSizes;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeFieldInfoPtr_positiveSign;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeFieldInfoPtr_negativeSign;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeFieldInfoPtr_numberDecimalSeparator;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeFieldInfoPtr_numberGroupSeparator;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeFieldInfoPtr_currencyGroupSeparator;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeFieldInfoPtr_currencyDecimalSeparator;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeFieldInfoPtr_currencySymbol;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeFieldInfoPtr_ansiCurrencySymbol;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeFieldInfoPtr_nanSymbol;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinitySymbol;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinitySymbol;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeFieldInfoPtr_percentDecimalSeparator;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeFieldInfoPtr_percentGroupSeparator;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeFieldInfoPtr_percentSymbol;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeFieldInfoPtr_perMilleSymbol;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeFieldInfoPtr_nativeDigits;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeFieldInfoPtr_m_dataItem;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeFieldInfoPtr_numberDecimalDigits;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeFieldInfoPtr_currencyDecimalDigits;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeFieldInfoPtr_currencyPositivePattern;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeFieldInfoPtr_currencyNegativePattern;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeFieldInfoPtr_numberNegativePattern;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeFieldInfoPtr_percentPositivePattern;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeFieldInfoPtr_percentNegativePattern;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeFieldInfoPtr_percentDecimalDigits;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeFieldInfoPtr_digitSubstitution;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeFieldInfoPtr_m_isInvariant;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeFieldInfoPtr_validForParseAsNumber;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeFieldInfoPtr_validForParseAsCurrency;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeFieldInfoPtr_InvalidNumberStyles;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_NumberFormatInfo_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_NumberFormatInfo_IFormatProvider_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyDecimalDigits_Public_get_Int32_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyDecimalSeparator_Public_get_String_0;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyGroupSizes_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberGroupSizes_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentGroupSizes_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyGroupSeparator_Public_get_String_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_NumberFormatInfo_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_get_NaNSymbol_Public_get_String_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyNegativePattern_Public_get_Int32_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberNegativePattern_Public_get_Int32_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentPositivePattern_Public_get_Int32_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentNegativePattern_Public_get_Int32_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_get_NegativeInfinitySymbol_Public_get_String_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_get_NegativeSign_Public_get_String_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberDecimalDigits_Public_get_Int32_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberDecimalSeparator_Public_get_String_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberGroupSeparator_Public_get_String_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyPositivePattern_Public_get_Int32_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveInfinitySymbol_Public_get_String_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveSign_Public_get_String_0;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentDecimalDigits_Public_get_Int32_0;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentDecimalSeparator_Public_get_String_0;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentGroupSeparator_Public_get_String_0;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentSymbol_Public_get_String_0;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeMethodInfoPtr_get_PerMilleSymbol_Public_get_String_0;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_ReadOnly_Public_Static_NumberFormatInfo_NumberFormatInfo_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_ValidateParseStyleInteger_Internal_Static_Void_NumberStyles_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_ValidateParseStyleFloatingPoint_Internal_Static_Void_NumberStyles_0;
	}
}
