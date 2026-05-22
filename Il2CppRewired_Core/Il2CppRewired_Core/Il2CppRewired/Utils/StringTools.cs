using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using UnityEngine;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001F7 RID: 503
	public static class StringTools : global::Il2CppSystem.Object
	{
		// Token: 0x06003373 RID: 13171 RVA: 0x00101138 File Offset: 0x000FF338
		// Note: this type is marked as 'beforefieldinit'.
		static StringTools()
		{
			Il2CppClassPointerStore<StringTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "StringTools");
			StringTools.NativeFieldInfoPtr_qSHKjFghbLYbkiadfFSwWtAKJWh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringTools>.NativeClassPtr, "qSHKjFghbLYbkiadfFSwWtAKJWh");
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676261);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676262);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676263);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676264);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676265);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676266);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676267);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676268);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676269);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676270);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676271);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676272);
			StringTools.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676273);
			StringTools.NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676274);
			StringTools.NativeMethodInfoPtr_DecodeNewlines_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676275);
			StringTools.NativeMethodInfoPtr_EncodeNewlines_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676276);
			StringTools.NativeMethodInfoPtr_ArrayToText_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676277);
			StringTools.NativeMethodInfoPtr_TextToArray_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676278);
			StringTools.NativeMethodInfoPtr_StringToString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676279);
			StringTools.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676280);
			StringTools.NativeMethodInfoPtr_StringToFloat_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676281);
			StringTools.NativeMethodInfoPtr_StringToBoolean_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676282);
			StringTools.NativeMethodInfoPtr_StringToKeyCode_Public_Static_KeyCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676283);
			StringTools.NativeMethodInfoPtr_StringToEnum_Public_Static_Enum_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676284);
			StringTools.NativeMethodInfoPtr_ToStringWithCount_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676285);
			StringTools.NativeMethodInfoPtr_StringToCharArray_Public_Static_Il2CppStructArray_1_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676286);
			StringTools.NativeMethodInfoPtr_CharArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676287);
			StringTools.NativeMethodInfoPtr_CSVEncode_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676288);
			StringTools.NativeMethodInfoPtr_CSVDecode_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676289);
			StringTools.NativeMethodInfoPtr_CSVToArray_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676290);
			StringTools.NativeMethodInfoPtr_TryParseEnum_Public_Static_Boolean_String_byref_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676291);
			StringTools.NativeMethodInfoPtr_TimeToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676292);
			StringTools.NativeMethodInfoPtr_TimeToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676293);
			StringTools.NativeMethodInfoPtr_CleanUpFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676295);
			StringTools.NativeMethodInfoPtr_StripTrailingNumbers_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676296);
			StringTools.NativeMethodInfoPtr_StripTrailingNumbers_Public_Static_String_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676297);
			StringTools.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_Int32_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676298);
			StringTools.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_Int32_Il2CppStringArray_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676299);
			StringTools.NativeMethodInfoPtr_IterateName_Public_Static_String_String_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676300);
			StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676301);
			StringTools.NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676302);
			StringTools.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676303);
			StringTools.NativeMethodInfoPtr_GetString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676304);
			StringTools.NativeMethodInfoPtr_ByteShiftEncode_Public_Static_String_String_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676305);
			StringTools.NativeMethodInfoPtr_GetNullTerminatedUnicodeString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676306);
			StringTools.NativeMethodInfoPtr_SanitizeDeviceString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676307);
			StringTools.NativeMethodInfoPtr_ReplaceChar_Public_Static_String_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676308);
			StringTools.NativeMethodInfoPtr_AddSpacesToSentence_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676309);
			StringTools.NativeMethodInfoPtr_WriteVar_Public_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676310);
			StringTools.NativeMethodInfoPtr_WriteVar_Public_Static_String_String_Object_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676311);
			StringTools.NativeMethodInfoPtr_WriteVar_Public_Static_Void_StringBuilder_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676312);
			StringTools.NativeMethodInfoPtr_WriteVar_Public_Static_Void_StringBuilder_String_Object_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676313);
			StringTools.NativeMethodInfoPtr_Trim_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676314);
			StringTools.NativeMethodInfoPtr_VariableNameToDisplayName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676315);
			StringTools.NativeMethodInfoPtr_CountChars_Public_Static_Int32_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTools>.NativeClassPtr, 100676316);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x001015C0 File Offset: 0x000FF7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340034, XrefRangeEnd = 340046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<int> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x001015FC File Offset: 0x000FF7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340046, XrefRangeEnd = 340058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<float> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00101638 File Offset: 0x000FF838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340058, XrefRangeEnd = 340065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStringArray inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00101674 File Offset: 0x000FF874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340065, XrefRangeEnd = 340077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<bool> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x001016B0 File Offset: 0x000FF8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340077, XrefRangeEnd = 340089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<byte> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x001016EC File Offset: 0x000FF8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340089, XrefRangeEnd = 340103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<byte> inArray, string stringOptions, int maxItemsPerLine = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringOptions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxItemsPerLine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00101748 File Offset: 0x000FF948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340103, XrefRangeEnd = 340115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Il2CppStructArray<Vector3> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00101784 File Offset: 0x000FF984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340115, XrefRangeEnd = 340126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(List<global::Il2CppSystem.Object> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_List_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x001017C0 File Offset: 0x000FF9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340126, XrefRangeEnd = 340137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Vector2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x001017F8 File Offset: 0x000FF9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340137, XrefRangeEnd = 340174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Vector3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x00101830 File Offset: 0x000FFA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340174, XrefRangeEnd = 340181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString<T>(Il2CppArrayBase<T> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.MethodInfoStoreGeneric_ToString_Public_Static_String_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x0010186C File Offset: 0x000FFA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340181, XrefRangeEnd = 340188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString<T>(List<T> inList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.MethodInfoStoreGeneric_ToString_Public_Static_String_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x001018A8 File Offset: 0x000FFAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340188, XrefRangeEnd = 340192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Split(string str, string delimiter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(delimiter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x00101900 File Offset: 0x000FFB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340192, XrefRangeEnd = 340203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray SplitAndTrim(string str, string delimiter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(delimiter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00101958 File Offset: 0x000FFB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340203, XrefRangeEnd = 340210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeNewlines(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_DecodeNewlines_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00101994 File Offset: 0x000FFB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340210, XrefRangeEnd = 340217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeNewlines(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_EncodeNewlines_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x001019D0 File Offset: 0x000FFBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340217, XrefRangeEnd = 340224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ArrayToText(Il2CppStringArray sA)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sA);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ArrayToText_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00101A0C File Offset: 0x000FFC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340224, XrefRangeEnd = 340230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray TextToArray(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_TextToArray_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00101A50 File Offset: 0x000FFC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340230, XrefRangeEnd = 340232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StringToString(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_StringToString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00101A8C File Offset: 0x000FFC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340232, XrefRangeEnd = 340234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringToInt(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x00101AD0 File Offset: 0x000FFCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340234, XrefRangeEnd = 340244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float StringToFloat(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_StringToFloat_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x00101B14 File Offset: 0x000FFD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340244, XrefRangeEnd = 340248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToBoolean(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_StringToBoolean_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x00101B58 File Offset: 0x000FFD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340248, XrefRangeEnd = 340264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyCode StringToKeyCode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_StringToKeyCode_Public_Static_KeyCode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x00101B9C File Offset: 0x000FFD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340264, XrefRangeEnd = 340273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Enum StringToEnum(string str, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_StringToEnum_Public_Static_Enum_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enum>(intPtr3) : null;
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x00101BF4 File Offset: 0x000FFDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340273, XrefRangeEnd = 340289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToStringWithCount(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToStringWithCount_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x00101C30 File Offset: 0x000FFE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340289, XrefRangeEnd = 340290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> StringToCharArray(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_StringToCharArray_Public_Static_Il2CppStructArray_1_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x00101C74 File Offset: 0x000FFE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340290, XrefRangeEnd = 340291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CharArrayToString(Il2CppStructArray<char> c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_CharArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x00101CB0 File Offset: 0x000FFEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340291, XrefRangeEnd = 340306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CSVEncode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_CSVEncode_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00101CEC File Offset: 0x000FFEEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340324, RefRangeEnd = 340325, XrefRangeStart = 340306, XrefRangeEnd = 340324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CSVDecode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_CSVDecode_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x00101D28 File Offset: 0x000FFF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340325, XrefRangeEnd = 340367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray CSVToArray(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_CSVToArray_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x00101D6C File Offset: 0x000FFF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340367, XrefRangeEnd = 340380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseEnum<TEnum>(string value, out TEnum enumeration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TEnum).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref enumeration;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StringTools.MethodInfoStoreGeneric_TryParseEnum_Public_Static_Boolean_String_byref_TEnum_0<TEnum>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TEnum).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				enumeration = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TEnum>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00101DFC File Offset: 0x000FFFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340380, XrefRangeEnd = 340384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeToString(int seconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_TimeToString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00101E34 File Offset: 0x00100034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340423, RefRangeEnd = 340424, XrefRangeStart = 340384, XrefRangeEnd = 340423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeToString(float seconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_TimeToString_Public_Static_String_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00101E6C File Offset: 0x0010006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340424, XrefRangeEnd = 340441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CleanUpFileName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_CleanUpFileName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00101EA8 File Offset: 0x001000A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340441, XrefRangeEnd = 340445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripTrailingNumbers(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_StripTrailingNumbers_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00101EE4 File Offset: 0x001000E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340456, RefRangeEnd = 340459, XrefRangeStart = 340445, XrefRangeEnd = 340456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripTrailingNumbers(string name, out int number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_StripTrailingNumbers_Public_Static_String_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00101F30 File Offset: 0x00100130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340459, XrefRangeEnd = 340463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyName(string name, int indexInNameList, Il2CppStringArray names, bool cleanUpIllegalFileChars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexInNameList;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cleanUpIllegalFileChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_Int32_Il2CppStringArray_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00101F9C File Offset: 0x0010019C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340489, RefRangeEnd = 340490, XrefRangeStart = 340463, XrefRangeEnd = 340489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyName(string name, int indexInNameList, Il2CppStringArray names, bool cleanUpIllegalFileChars, bool allowBlank)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexInNameList;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cleanUpIllegalFileChars;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowBlank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_Int32_Il2CppStringArray_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00102014 File Offset: 0x00100214
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 340512, RefRangeEnd = 340540, XrefRangeStart = 340490, XrefRangeEnd = 340512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IterateName(string name, int indexInNameList = -1, Il2CppStringArray names = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexInNameList;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_IterateName_Public_Static_String_String_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00102070 File Offset: 0x00100270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340540, XrefRangeEnd = 340572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x001020A8 File Offset: 0x001002A8
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 340579, RefRangeEnd = 340624, XrefRangeStart = 340572, XrefRangeEnd = 340579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid ToGuid(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x001020EC File Offset: 0x001002EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340624, XrefRangeEnd = 340629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00102130 File Offset: 0x00100330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340629, XrefRangeEnd = 340635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_GetString_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x0010216C File Offset: 0x0010036C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340635, XrefRangeEnd = 340649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ByteShiftEncode(string source, short shift)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ByteShiftEncode_Public_Static_String_String_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x001021B8 File Offset: 0x001003B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340652, RefRangeEnd = 340653, XrefRangeStart = 340649, XrefRangeEnd = 340652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNullTerminatedUnicodeString(Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_GetNullTerminatedUnicodeString_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x001021F4 File Offset: 0x001003F4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 340664, RefRangeEnd = 340680, XrefRangeStart = 340653, XrefRangeEnd = 340664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SanitizeDeviceString(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_SanitizeDeviceString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00102230 File Offset: 0x00100430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340680, XrefRangeEnd = 340682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReplaceChar(string @string, int index, char replacement)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(@string);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replacement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_ReplaceChar_Public_Static_String_String_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00102288 File Offset: 0x00100488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340713, RefRangeEnd = 340715, XrefRangeStart = 340682, XrefRangeEnd = 340713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AddSpacesToSentence(string text, bool preserveAcronyms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveAcronyms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_AddSpacesToSentence_Public_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x001022D4 File Offset: 0x001004D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 340719, RefRangeEnd = 340730, XrefRangeStart = 340715, XrefRangeEnd = 340719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string WriteVar(string name, global::Il2CppSystem.Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_WriteVar_Public_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00102324 File Offset: 0x00100524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340773, RefRangeEnd = 340774, XrefRangeStart = 340730, XrefRangeEnd = 340773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string WriteVar(string name, global::Il2CppSystem.Object value, char delimiter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delimiter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_WriteVar_Public_Static_String_String_Object_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00102380 File Offset: 0x00100580
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 340793, RefRangeEnd = 340816, XrefRangeStart = 340774, XrefRangeEnd = 340793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteVar(StringBuilder sb, string name, global::Il2CppSystem.Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_WriteVar_Public_Static_Void_StringBuilder_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x001023DC File Offset: 0x001005DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340816, XrefRangeEnd = 340832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteVar(StringBuilder sb, string name, global::Il2CppSystem.Object value, char delimiter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delimiter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_WriteVar_Public_Static_Void_StringBuilder_String_Object_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00102444 File Offset: 0x00100644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340832, XrefRangeEnd = 340833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Trim(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_Trim_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00102480 File Offset: 0x00100680
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340896, RefRangeEnd = 340899, XrefRangeStart = 340833, XrefRangeEnd = 340896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VariableNameToDisplayName(string fieldName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_VariableNameToDisplayName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x001024BC File Offset: 0x001006BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340899, XrefRangeEnd = 340900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountChars(string text, char character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref character;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTools.NativeMethodInfoPtr_CountChars_Public_Static_Int32_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x00011E49 File Offset: 0x00010049
		public StringTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x0010250C File Offset: 0x0010070C
		// (set) Token: 0x060033AD RID: 13229 RVA: 0x00011E52 File Offset: 0x00010052
		public unsafe static string qSHKjFghbLYbkiadfFSwWtAKJWh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringTools.NativeFieldInfoPtr_qSHKjFghbLYbkiadfFSwWtAKJWh, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringTools.NativeFieldInfoPtr_qSHKjFghbLYbkiadfFSwWtAKJWh, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002BE2 RID: 11234
		private static readonly IntPtr NativeFieldInfoPtr_qSHKjFghbLYbkiadfFSwWtAKJWh;

		// Token: 0x04002BE3 RID: 11235
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002BE4 RID: 11236
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Single_0;

		// Token: 0x04002BE5 RID: 11237
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x04002BE6 RID: 11238
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04002BE7 RID: 11239
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BE8 RID: 11240
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_String_Int32_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04002BEA RID: 11242
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_List_1_Object_0;

		// Token: 0x04002BEB RID: 11243
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Vector2_0;

		// Token: 0x04002BEC RID: 11244
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Vector3_0;

		// Token: 0x04002BED RID: 11245
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppArrayBase_1_T_0;

		// Token: 0x04002BEE RID: 11246
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_List_1_T_0;

		// Token: 0x04002BEF RID: 11247
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0;

		// Token: 0x04002BF0 RID: 11248
		private static readonly IntPtr NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_0;

		// Token: 0x04002BF1 RID: 11249
		private static readonly IntPtr NativeMethodInfoPtr_DecodeNewlines_Public_Static_String_String_0;

		// Token: 0x04002BF2 RID: 11250
		private static readonly IntPtr NativeMethodInfoPtr_EncodeNewlines_Public_Static_String_String_0;

		// Token: 0x04002BF3 RID: 11251
		private static readonly IntPtr NativeMethodInfoPtr_ArrayToText_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x04002BF4 RID: 11252
		private static readonly IntPtr NativeMethodInfoPtr_TextToArray_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04002BF5 RID: 11253
		private static readonly IntPtr NativeMethodInfoPtr_StringToString_Public_Static_String_String_0;

		// Token: 0x04002BF6 RID: 11254
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_0;

		// Token: 0x04002BF7 RID: 11255
		private static readonly IntPtr NativeMethodInfoPtr_StringToFloat_Public_Static_Single_String_0;

		// Token: 0x04002BF8 RID: 11256
		private static readonly IntPtr NativeMethodInfoPtr_StringToBoolean_Public_Static_Boolean_String_0;

		// Token: 0x04002BF9 RID: 11257
		private static readonly IntPtr NativeMethodInfoPtr_StringToKeyCode_Public_Static_KeyCode_String_0;

		// Token: 0x04002BFA RID: 11258
		private static readonly IntPtr NativeMethodInfoPtr_StringToEnum_Public_Static_Enum_String_Type_0;

		// Token: 0x04002BFB RID: 11259
		private static readonly IntPtr NativeMethodInfoPtr_ToStringWithCount_Public_Static_String_String_0;

		// Token: 0x04002BFC RID: 11260
		private static readonly IntPtr NativeMethodInfoPtr_StringToCharArray_Public_Static_Il2CppStructArray_1_Char_String_0;

		// Token: 0x04002BFD RID: 11261
		private static readonly IntPtr NativeMethodInfoPtr_CharArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04002BFE RID: 11262
		private static readonly IntPtr NativeMethodInfoPtr_CSVEncode_Public_Static_String_String_0;

		// Token: 0x04002BFF RID: 11263
		private static readonly IntPtr NativeMethodInfoPtr_CSVDecode_Public_Static_String_String_0;

		// Token: 0x04002C00 RID: 11264
		private static readonly IntPtr NativeMethodInfoPtr_CSVToArray_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04002C01 RID: 11265
		private static readonly IntPtr NativeMethodInfoPtr_TryParseEnum_Public_Static_Boolean_String_byref_TEnum_0;

		// Token: 0x04002C02 RID: 11266
		private static readonly IntPtr NativeMethodInfoPtr_TimeToString_Public_Static_String_Int32_0;

		// Token: 0x04002C03 RID: 11267
		private static readonly IntPtr NativeMethodInfoPtr_TimeToString_Public_Static_String_Single_0;

		// Token: 0x04002C04 RID: 11268
		private static readonly IntPtr NativeMethodInfoPtr_CleanUpFileName_Public_Static_String_String_0;

		// Token: 0x04002C05 RID: 11269
		private static readonly IntPtr NativeMethodInfoPtr_StripTrailingNumbers_Public_Static_String_String_0;

		// Token: 0x04002C06 RID: 11270
		private static readonly IntPtr NativeMethodInfoPtr_StripTrailingNumbers_Public_Static_String_String_byref_Int32_0;

		// Token: 0x04002C07 RID: 11271
		private static readonly IntPtr NativeMethodInfoPtr_VerifyName_Public_Static_String_String_Int32_Il2CppStringArray_Boolean_0;

		// Token: 0x04002C08 RID: 11272
		private static readonly IntPtr NativeMethodInfoPtr_VerifyName_Public_Static_String_String_Int32_Il2CppStringArray_Boolean_Boolean_0;

		// Token: 0x04002C09 RID: 11273
		private static readonly IntPtr NativeMethodInfoPtr_IterateName_Public_Static_String_String_Int32_Il2CppStringArray_0;

		// Token: 0x04002C0A RID: 11274
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Rect_0;

		// Token: 0x04002C0B RID: 11275
		private static readonly IntPtr NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0;

		// Token: 0x04002C0C RID: 11276
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04002C0D RID: 11277
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C0E RID: 11278
		private static readonly IntPtr NativeMethodInfoPtr_ByteShiftEncode_Public_Static_String_String_Int16_0;

		// Token: 0x04002C0F RID: 11279
		private static readonly IntPtr NativeMethodInfoPtr_GetNullTerminatedUnicodeString_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C10 RID: 11280
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeDeviceString_Public_Static_String_String_0;

		// Token: 0x04002C11 RID: 11281
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceChar_Public_Static_String_String_Int32_Char_0;

		// Token: 0x04002C12 RID: 11282
		private static readonly IntPtr NativeMethodInfoPtr_AddSpacesToSentence_Public_Static_String_String_Boolean_0;

		// Token: 0x04002C13 RID: 11283
		private static readonly IntPtr NativeMethodInfoPtr_WriteVar_Public_Static_String_String_Object_0;

		// Token: 0x04002C14 RID: 11284
		private static readonly IntPtr NativeMethodInfoPtr_WriteVar_Public_Static_String_String_Object_Char_0;

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeMethodInfoPtr_WriteVar_Public_Static_Void_StringBuilder_String_Object_0;

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeMethodInfoPtr_WriteVar_Public_Static_Void_StringBuilder_String_Object_Char_0;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_Static_String_String_0;

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeMethodInfoPtr_VariableNameToDisplayName_Public_Static_String_String_0;

		// Token: 0x04002C19 RID: 11289
		private static readonly IntPtr NativeMethodInfoPtr_CountChars_Public_Static_Int32_String_Char_0;

		// Token: 0x02000458 RID: 1112
		private sealed class MethodInfoStoreGeneric_ToString_Public_Static_String_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x040043A6 RID: 17318
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<StringTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000459 RID: 1113
		private sealed class MethodInfoStoreGeneric_ToString_Public_Static_String_List_1_T_0<T>
		{
			// Token: 0x040043A7 RID: 17319
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StringTools.NativeMethodInfoPtr_ToString_Public_Static_String_List_1_T_0, Il2CppClassPointerStore<StringTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200045A RID: 1114
		private sealed class MethodInfoStoreGeneric_TryParseEnum_Public_Static_Boolean_String_byref_TEnum_0<TEnum>
		{
			// Token: 0x040043A8 RID: 17320
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StringTools.NativeMethodInfoPtr_TryParseEnum_Public_Static_Boolean_String_byref_TEnum_0, Il2CppClassPointerStore<StringTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) }))));
		}
	}
}
