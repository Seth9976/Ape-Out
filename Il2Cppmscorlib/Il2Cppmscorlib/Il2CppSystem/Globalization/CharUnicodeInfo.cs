using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022A RID: 554
	public static class CharUnicodeInfo : Object
	{
		// Token: 0x06002423 RID: 9251 RVA: 0x000C74A8 File Offset: 0x000C56A8
		// Note: this type is marked as 'beforefieldinit'.
		static CharUnicodeInfo()
		{
			Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CharUnicodeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr);
			CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoryLevel1Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pCategoryLevel1Index");
			CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoriesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pCategoriesValue");
			CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericLevel1Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pNumericLevel1Index");
			CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pNumericValues");
			CharUnicodeInfo.NativeFieldInfoPtr_s_pDigitValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "s_pDigitValues");
			CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669433);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669434);
			CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669435);
			CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669436);
			CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669437);
			CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669438);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669439);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669440);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669441);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100669442);
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x000C7604 File Offset: 0x000C5804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193901, XrefRangeEnd = 193904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalConvertToUtf32(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x000C7654 File Offset: 0x000C5854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193904, XrefRangeEnd = 193908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalConvertToUtf32(string s, int index, out int charLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x000C76B4 File Offset: 0x000C58B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193908, XrefRangeEnd = 193914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhiteSpace(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x000C7704 File Offset: 0x000C5904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193914, XrefRangeEnd = 193922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhiteSpace(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x000C7744 File Offset: 0x000C5944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193922, XrefRangeEnd = 193926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x000C7784 File Offset: 0x000C5984
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 193942, RefRangeEnd = 193946, XrefRangeStart = 193926, XrefRangeEnd = 193942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x000C77D4 File Offset: 0x000C59D4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 193955, RefRangeEnd = 193971, XrefRangeStart = 193946, XrefRangeEnd = 193955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory InternalGetUnicodeCategory(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x000C7814 File Offset: 0x000C5A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193971, XrefRangeEnd = 193976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte InternalGetCategoryValue(int ch, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x000C7860 File Offset: 0x000C5A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193997, RefRangeEnd = 193999, XrefRangeStart = 193976, XrefRangeEnd = 193997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x000C78B0 File Offset: 0x000C5AB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194055, RefRangeEnd = 194057, XrefRangeStart = 193999, XrefRangeEnd = 194055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0000C018 File Offset: 0x0000A218
		public CharUnicodeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x000C7910 File Offset: 0x000C5B10
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x0000C021 File Offset: 0x0000A221
		public unsafe static Il2CppStructArray<ushort> s_pCategoryLevel1Index
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoryLevel1Index, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoryLevel1Index, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x000C7938 File Offset: 0x000C5B38
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x0000C033 File Offset: 0x0000A233
		public unsafe static Il2CppStructArray<byte> s_pCategoriesValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoriesValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pCategoriesValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x000C7960 File Offset: 0x000C5B60
		// (set) Token: 0x06002434 RID: 9268 RVA: 0x0000C045 File Offset: 0x0000A245
		public unsafe static Il2CppStructArray<ushort> s_pNumericLevel1Index
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericLevel1Index, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericLevel1Index, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x000C7988 File Offset: 0x000C5B88
		// (set) Token: 0x06002436 RID: 9270 RVA: 0x0000C057 File Offset: 0x0000A257
		public unsafe static Il2CppStructArray<byte> s_pNumericValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pNumericValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x000C79B0 File Offset: 0x000C5BB0
		// (set) Token: 0x06002438 RID: 9272 RVA: 0x0000C069 File Offset: 0x0000A269
		public unsafe static Il2CppStructArray<ushort> s_pDigitValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pDigitValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharUnicodeInfo.NativeFieldInfoPtr_s_pDigitValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeFieldInfoPtr_s_pCategoryLevel1Index;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeFieldInfoPtr_s_pCategoriesValue;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeFieldInfoPtr_s_pNumericLevel1Index;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeFieldInfoPtr_s_pNumericValues;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeFieldInfoPtr_s_pDigitValues;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_byref_Int32_0;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_String_Int32_0;

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_Int32_0;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_byref_Int32_0;

		// Token: 0x020005E0 RID: 1504
		public static class Debug : Object
		{
			// Token: 0x060053C7 RID: 21447 RVA: 0x0001F863 File Offset: 0x0001DA63
			// Note: this type is marked as 'beforefieldinit'.
			static Debug()
			{
				Il2CppClassPointerStore<CharUnicodeInfo.Debug>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, "Debug");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharUnicodeInfo.Debug>.NativeClassPtr);
				CharUnicodeInfo.Debug.NativeMethodInfoPtr_Assert_Internal_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo.Debug>.NativeClassPtr, 100669444);
			}

			// Token: 0x060053C8 RID: 21448 RVA: 0x001796A8 File Offset: 0x001778A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Assert(bool condition, string message)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref condition;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.Debug.NativeMethodInfoPtr_Assert_Internal_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053C9 RID: 21449 RVA: 0x0001F897 File Offset: 0x0001DA97
			public Debug(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040043C3 RID: 17347
			private static readonly IntPtr NativeMethodInfoPtr_Assert_Internal_Static_Void_Boolean_String_0;
		}
	}
}
