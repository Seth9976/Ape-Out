using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000109 RID: 265
	public static class ParseNumbers : Object
	{
		// Token: 0x060013CD RID: 5069 RVA: 0x0007FC50 File Offset: 0x0007DE50
		// Note: this type is marked as 'beforefieldinit'.
		static ParseNumbers()
		{
			Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParseNumbers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr);
			ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666783);
			ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666784);
			ParseNumbers.NativeMethodInfoPtr_StringToLong_Public_Static_Int64_String_Int32_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666785);
			ParseNumbers.NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666786);
			ParseNumbers.NativeMethodInfoPtr_EndianSwap_Private_Static_Void_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666787);
			ParseNumbers.NativeMethodInfoPtr_ConvertToBase2_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666788);
			ParseNumbers.NativeMethodInfoPtr_ConvertToBase8_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666789);
			ParseNumbers.NativeMethodInfoPtr_ConvertToBase16_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666790);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0007FD20 File Offset: 0x0007DF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174332, XrefRangeEnd = 174333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringToInt(string value, int fromBase, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0007FD80 File Offset: 0x0007DF80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 174351, RefRangeEnd = 174355, XrefRangeStart = 174333, XrefRangeEnd = 174351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringToInt(string value, int fromBase, int flags, int* parsePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_ptr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0007FDEC File Offset: 0x0007DFEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174375, RefRangeEnd = 174376, XrefRangeStart = 174355, XrefRangeEnd = 174375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long StringToLong(string value, int fromBase, int flags, int* parsePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToLong_Public_Static_Int64_String_Int32_Int32_ptr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0007FE58 File Offset: 0x0007E058
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 174420, RefRangeEnd = 174426, XrefRangeStart = 174376, XrefRangeEnd = 174420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(int value, int toBase, int width, char paddingChar, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0007FEC8 File Offset: 0x0007E0C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174430, RefRangeEnd = 174433, XrefRangeStart = 174426, XrefRangeEnd = 174430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndianSwap(ref Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_EndianSwap_Private_Static_Void_byref_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0007FF14 File Offset: 0x0007E114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174433, XrefRangeEnd = 174448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder ConvertToBase2(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ConvertToBase2_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0007FF58 File Offset: 0x0007E158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174469, RefRangeEnd = 174470, XrefRangeStart = 174448, XrefRangeEnd = 174469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder ConvertToBase8(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ConvertToBase8_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0007FF9C File Offset: 0x0007E19C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174484, RefRangeEnd = 174485, XrefRangeStart = 174470, XrefRangeEnd = 174484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder ConvertToBase16(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ConvertToBase16_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00006B24 File Offset: 0x00004D24
		public ParseNumbers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_ptr_Int32_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_StringToLong_Public_Static_Int64_String_Int32_Int32_ptr_Int32_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_EndianSwap_Private_Static_Void_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBase2_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBase8_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBase16_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0;
	}
}
