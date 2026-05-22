using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppI2.Loc
{
	// Token: 0x02000268 RID: 616
	public class RTLFixerTool : Object
	{
		// Token: 0x0600465E RID: 18014 RVA: 0x00106864 File Offset: 0x00104A64
		// Note: this type is marked as 'beforefieldinit'.
		static RTLFixerTool()
		{
			Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "RTLFixerTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr);
			RTLFixerTool.NativeFieldInfoPtr_showTashkeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, "showTashkeel");
			RTLFixerTool.NativeFieldInfoPtr_useHinduNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, "useHinduNumbers");
			RTLFixerTool.NativeMethodInfoPtr_RemoveTashkeel_Internal_Static_String_String_byref_List_1_TashkeelLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, 100670412);
			RTLFixerTool.NativeMethodInfoPtr_ReturnTashkeel_Internal_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_List_1_TashkeelLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, 100670413);
			RTLFixerTool.NativeMethodInfoPtr_FixLine_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, 100670414);
			RTLFixerTool.NativeMethodInfoPtr_IsIgnoredCharacter_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, 100670415);
			RTLFixerTool.NativeMethodInfoPtr_IsLeadingLetter_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, 100670416);
			RTLFixerTool.NativeMethodInfoPtr_IsFinishingLetter_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, 100670417);
			RTLFixerTool.NativeMethodInfoPtr_IsMiddleLetter_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, 100670418);
			RTLFixerTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr, 100670419);
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x0010695C File Offset: 0x00104B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114955, RefRangeEnd = 114956, XrefRangeStart = 114890, XrefRangeEnd = 114955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RTLFixerTool.NativeMethodInfoPtr_RemoveTashkeel_Internal_Static_String_String_byref_List_1_TashkeelLocation_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			tashkeelLocation = ((intPtr4 == 0) ? null : new List<TashkeelLocation>(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x001069BC File Offset: 0x00104BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114969, RefRangeEnd = 114970, XrefRangeStart = 114956, XrefRangeEnd = 114969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> ReturnTashkeel(Il2CppStructArray<char> letters, List<TashkeelLocation> tashkeelLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(letters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tashkeelLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixerTool.NativeMethodInfoPtr_ReturnTashkeel_Internal_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_List_1_TashkeelLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00106A14 File Offset: 0x00104C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114970, XrefRangeEnd = 115133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FixLine(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixerTool.NativeMethodInfoPtr_FixLine_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x00106A50 File Offset: 0x00104C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115144, RefRangeEnd = 115145, XrefRangeStart = 115133, XrefRangeEnd = 115144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIgnoredCharacter(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixerTool.NativeMethodInfoPtr_IsIgnoredCharacter_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x00106A90 File Offset: 0x00104C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115166, RefRangeEnd = 115167, XrefRangeStart = 115145, XrefRangeEnd = 115166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLeadingLetter(Il2CppStructArray<char> letters, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(letters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixerTool.NativeMethodInfoPtr_IsLeadingLetter_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x00106AE0 File Offset: 0x00104CE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115173, RefRangeEnd = 115174, XrefRangeStart = 115167, XrefRangeEnd = 115173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFinishingLetter(Il2CppStructArray<char> letters, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(letters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixerTool.NativeMethodInfoPtr_IsFinishingLetter_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x00106B30 File Offset: 0x00104D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115196, RefRangeEnd = 115197, XrefRangeStart = 115174, XrefRangeEnd = 115196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMiddleLetter(Il2CppStructArray<char> letters, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(letters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixerTool.NativeMethodInfoPtr_IsMiddleLetter_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00106B80 File Offset: 0x00104D80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTLFixerTool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTLFixerTool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTLFixerTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00029E1A File Offset: 0x0002801A
		public RTLFixerTool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06004668 RID: 18024 RVA: 0x00106BBC File Offset: 0x00104DBC
		// (set) Token: 0x06004669 RID: 18025 RVA: 0x00029E23 File Offset: 0x00028023
		public unsafe static bool showTashkeel
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RTLFixerTool.NativeFieldInfoPtr_showTashkeel, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTLFixerTool.NativeFieldInfoPtr_showTashkeel, (void*)(&value));
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x0600466A RID: 18026 RVA: 0x00106BD8 File Offset: 0x00104DD8
		// (set) Token: 0x0600466B RID: 18027 RVA: 0x00029E31 File Offset: 0x00028031
		public unsafe static bool useHinduNumbers
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RTLFixerTool.NativeFieldInfoPtr_useHinduNumbers, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTLFixerTool.NativeFieldInfoPtr_useHinduNumbers, (void*)(&value));
			}
		}

		// Token: 0x04002C02 RID: 11266
		private static readonly IntPtr NativeFieldInfoPtr_showTashkeel;

		// Token: 0x04002C03 RID: 11267
		private static readonly IntPtr NativeFieldInfoPtr_useHinduNumbers;

		// Token: 0x04002C04 RID: 11268
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTashkeel_Internal_Static_String_String_byref_List_1_TashkeelLocation_0;

		// Token: 0x04002C05 RID: 11269
		private static readonly IntPtr NativeMethodInfoPtr_ReturnTashkeel_Internal_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_List_1_TashkeelLocation_0;

		// Token: 0x04002C06 RID: 11270
		private static readonly IntPtr NativeMethodInfoPtr_FixLine_Internal_Static_String_String_0;

		// Token: 0x04002C07 RID: 11271
		private static readonly IntPtr NativeMethodInfoPtr_IsIgnoredCharacter_Internal_Static_Boolean_Char_0;

		// Token: 0x04002C08 RID: 11272
		private static readonly IntPtr NativeMethodInfoPtr_IsLeadingLetter_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04002C09 RID: 11273
		private static readonly IntPtr NativeMethodInfoPtr_IsFinishingLetter_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04002C0A RID: 11274
		private static readonly IntPtr NativeMethodInfoPtr_IsMiddleLetter_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04002C0B RID: 11275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
