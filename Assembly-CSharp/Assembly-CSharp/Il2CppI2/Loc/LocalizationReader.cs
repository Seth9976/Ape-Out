using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200023F RID: 575
	public class LocalizationReader : global::Il2CppSystem.Object
	{
		// Token: 0x0600441A RID: 17434 RVA: 0x000FD360 File Offset: 0x000FB560
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizationReader()
		{
			Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizationReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr);
			LocalizationReader.NativeMethodInfoPtr_ReadTextAsset_Public_Static_Dictionary_2_String_String_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670035);
			LocalizationReader.NativeMethodInfoPtr_TextAsset_ReadLine_Public_Static_Boolean_String_byref_String_byref_String_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670036);
			LocalizationReader.NativeMethodInfoPtr_ReadCSVfile_Public_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670037);
			LocalizationReader.NativeMethodInfoPtr_ReadCSV_Public_Static_List_1_Il2CppStringArray_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670038);
			LocalizationReader.NativeMethodInfoPtr_ParseCSVline_Private_Static_Il2CppStringArray_String_byref_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670039);
			LocalizationReader.NativeMethodInfoPtr_AddCSVtoken_Private_Static_Void_byref_List_1_String_byref_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670040);
			LocalizationReader.NativeMethodInfoPtr_ReadI2CSV_Public_Static_List_1_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670041);
			LocalizationReader.NativeMethodInfoPtr_ValidateFullTerm_Public_Static_Void_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670042);
			LocalizationReader.NativeMethodInfoPtr_EncodeString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670043);
			LocalizationReader.NativeMethodInfoPtr_DecodeString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670044);
			LocalizationReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr, 100670045);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x000FD46C File Offset: 0x000FB66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110471, XrefRangeEnd = 110506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_ReadTextAsset_Public_Static_Dictionary_2_String_String_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x000FD4B0 File Offset: 0x000FB6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110554, RefRangeEnd = 110555, XrefRangeStart = 110506, XrefRangeEnd = 110554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = 0;
			ptr6 = &intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_TextAsset_ReadLine_Public_Static_Boolean_String_byref_String_byref_String_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			key = IL2CPP.Il2CppStringToManaged(intPtr);
			value = IL2CPP.Il2CppStringToManaged(intPtr2);
			category = IL2CPP.Il2CppStringToManaged(intPtr3);
			comment = IL2CPP.Il2CppStringToManaged(intPtr4);
			termType = IL2CPP.Il2CppStringToManaged(intPtr5);
			return *IL2CPP.il2cpp_object_unbox(intPtr6);
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x000FD57C File Offset: 0x000FB77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110555, XrefRangeEnd = 110578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadCSVfile(string Path, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_ReadCSVfile_Public_Static_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x000FD5CC File Offset: 0x000FB7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110578, XrefRangeEnd = 110589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Il2CppStringArray> ReadCSV(string Text, char Separator = ',')
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Separator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_ReadCSV_Public_Static_List_1_Il2CppStringArray_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Il2CppStringArray>>(intPtr3) : null;
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x000FD620 File Offset: 0x000FB820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110612, RefRangeEnd = 110614, XrefRangeStart = 110589, XrefRangeEnd = 110612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ParseCSVline(string Line, ref int iStart, char Separator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Line);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &iStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Separator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_ParseCSVline_Private_Static_Il2CppStringArray_String_byref_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x000FD680 File Offset: 0x000FB880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110641, RefRangeEnd = 110643, XrefRangeStart = 110614, XrefRangeEnd = 110641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(list);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(Line);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &iWordStart;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_AddCSVtoken_Private_Static_Void_byref_List_1_String_byref_String_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			list = ((intPtr5 == 0) ? null : new List<string>(intPtr5));
			Line = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x000FD708 File Offset: 0x000FB908
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110670, RefRangeEnd = 110672, XrefRangeStart = 110643, XrefRangeEnd = 110670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Il2CppStringArray> ReadI2CSV(string Text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_ReadI2CSV_Public_Static_List_1_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Il2CppStringArray>>(intPtr3) : null;
			}
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x000FD74C File Offset: 0x000FB94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110672, XrefRangeEnd = 110677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateFullTerm(ref string Term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(Term);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_ValidateFullTerm_Public_Static_Void_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				Term = IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x000FD790 File Offset: 0x000FB990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110677, XrefRangeEnd = 110697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_EncodeString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x000FD7CC File Offset: 0x000FB9CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110705, RefRangeEnd = 110707, XrefRangeStart = 110697, XrefRangeEnd = 110705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr_DecodeString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x000FD808 File Offset: 0x000FBA08
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizationReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x0002935F File Offset: 0x0002755F
		public LocalizationReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeMethodInfoPtr_ReadTextAsset_Public_Static_Dictionary_2_String_String_TextAsset_0;

		// Token: 0x04002A05 RID: 10757
		private static readonly IntPtr NativeMethodInfoPtr_TextAsset_ReadLine_Public_Static_Boolean_String_byref_String_byref_String_byref_String_byref_String_byref_String_0;

		// Token: 0x04002A06 RID: 10758
		private static readonly IntPtr NativeMethodInfoPtr_ReadCSVfile_Public_Static_String_String_Encoding_0;

		// Token: 0x04002A07 RID: 10759
		private static readonly IntPtr NativeMethodInfoPtr_ReadCSV_Public_Static_List_1_Il2CppStringArray_String_Char_0;

		// Token: 0x04002A08 RID: 10760
		private static readonly IntPtr NativeMethodInfoPtr_ParseCSVline_Private_Static_Il2CppStringArray_String_byref_Int32_Char_0;

		// Token: 0x04002A09 RID: 10761
		private static readonly IntPtr NativeMethodInfoPtr_AddCSVtoken_Private_Static_Void_byref_List_1_String_byref_String_Int32_byref_Int32_0;

		// Token: 0x04002A0A RID: 10762
		private static readonly IntPtr NativeMethodInfoPtr_ReadI2CSV_Public_Static_List_1_Il2CppStringArray_String_0;

		// Token: 0x04002A0B RID: 10763
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFullTerm_Public_Static_Void_byref_String_0;

		// Token: 0x04002A0C RID: 10764
		private static readonly IntPtr NativeMethodInfoPtr_EncodeString_Public_Static_String_String_0;

		// Token: 0x04002A0D RID: 10765
		private static readonly IntPtr NativeMethodInfoPtr_DecodeString_Public_Static_String_String_0;

		// Token: 0x04002A0E RID: 10766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
