using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000313 RID: 787
	public static class Utils : Object
	{
		// Token: 0x0600340E RID: 13326 RVA: 0x00102140 File Offset: 0x00100340
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeFieldInfoPtr__rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "_rng");
			Utils.NativeMethodInfoPtr_get_StaticRandomNumberGenerator_Internal_Static_get_RNGCryptoServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671448);
			Utils.NativeMethodInfoPtr_GenerateRandom_Internal_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671449);
			Utils.NativeMethodInfoPtr_HasAlgorithm_Internal_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671450);
			Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671451);
			Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671452);
			Utils.NativeMethodInfoPtr_ConvertByteArrayToInt_Internal_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671453);
			Utils.NativeMethodInfoPtr_ConvertIntToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671454);
			Utils.NativeMethodInfoPtr_FixupKeyParity_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671455);
			Utils.NativeMethodInfoPtr_DWORDFromLittleEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671456);
			Utils.NativeMethodInfoPtr_DWORDToLittleEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671457);
			Utils.NativeMethodInfoPtr_DWORDFromBigEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671458);
			Utils.NativeMethodInfoPtr_DWORDToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671459);
			Utils.NativeMethodInfoPtr_QuadWordFromBigEndian_Internal_Static_Void_ptr_UInt64_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671460);
			Utils.NativeMethodInfoPtr_QuadWordToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671461);
			Utils.NativeMethodInfoPtr__ProduceLegacyHmacValues_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671462);
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x001022B0 File Offset: 0x001004B0
		public unsafe static RNGCryptoServiceProvider StaticRandomNumberGenerator
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 212038, RefRangeEnd = 212053, XrefRangeStart = 212026, XrefRangeEnd = 212038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_get_StaticRandomNumberGenerator_Internal_Static_get_RNGCryptoServiceProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RNGCryptoServiceProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x001022E4 File Offset: 0x001004E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 212057, RefRangeEnd = 212065, XrefRangeStart = 212053, XrefRangeEnd = 212057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GenerateRandom(int keySize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GenerateRandom_Internal_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x00102324 File Offset: 0x00100524
		[CallerCount(0)]
		public unsafe static bool HasAlgorithm(int dwCalg, int dwKeySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwCalg;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwKeySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_HasAlgorithm_Internal_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00102370 File Offset: 0x00100570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212065, XrefRangeEnd = 212067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DiscardWhiteSpaces(string inputBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x001023AC File Offset: 0x001005AC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 212095, RefRangeEnd = 212112, XrefRangeStart = 212067, XrefRangeEnd = 212095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x00102404 File Offset: 0x00100604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212112, XrefRangeEnd = 212113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertByteArrayToInt(Il2CppStructArray<byte> input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ConvertByteArrayToInt_Internal_Static_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x00102448 File Offset: 0x00100648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212113, XrefRangeEnd = 212121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ConvertIntToByteArray(int dwInput)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwInput;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ConvertIntToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x00102488 File Offset: 0x00100688
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212125, RefRangeEnd = 212128, XrefRangeStart = 212121, XrefRangeEnd = 212125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FixupKeyParity(Il2CppStructArray<byte> key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_FixupKeyParity_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x001024CC File Offset: 0x001006CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212128, RefRangeEnd = 212129, XrefRangeStart = 212128, XrefRangeEnd = 212128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DWORDFromLittleEndian(uint* x, int digits, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDFromLittleEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00102518 File Offset: 0x00100718
		[CallerCount(0)]
		public unsafe static void DWORDToLittleEndian(Il2CppStructArray<byte> block, Il2CppStructArray<uint> x, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDToLittleEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00102570 File Offset: 0x00100770
		[CallerCount(0)]
		public unsafe static void DWORDFromBigEndian(uint* x, int digits, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDFromBigEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x001025BC File Offset: 0x001007BC
		[CallerCount(0)]
		public unsafe static void DWORDToBigEndian(Il2CppStructArray<byte> block, Il2CppStructArray<uint> x, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00102614 File Offset: 0x00100814
		[CallerCount(0)]
		public unsafe static void QuadWordFromBigEndian(ulong* x, int digits, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_QuadWordFromBigEndian_Internal_Static_Void_ptr_UInt64_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00102660 File Offset: 0x00100860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212129, RefRangeEnd = 212131, XrefRangeStart = 212129, XrefRangeEnd = 212129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuadWordToBigEndian(Il2CppStructArray<byte> block, Il2CppStructArray<ulong> x, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_QuadWordToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x001026B8 File Offset: 0x001008B8
		[CallerCount(0)]
		public unsafe static bool _ProduceLegacyHmacValues()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr__ProduceLegacyHmacValues_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000125C3 File Offset: 0x000107C3
		public Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x0600341F RID: 13343 RVA: 0x001026E8 File Offset: 0x001008E8
		// (set) Token: 0x06003420 RID: 13344 RVA: 0x000125CC File Offset: 0x000107CC
		public unsafe static RNGCryptoServiceProvider _rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr__rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RNGCryptoServiceProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr__rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C40 RID: 11328
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x04002C41 RID: 11329
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticRandomNumberGenerator_Internal_Static_get_RNGCryptoServiceProvider_0;

		// Token: 0x04002C42 RID: 11330
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Internal_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002C43 RID: 11331
		private static readonly IntPtr NativeMethodInfoPtr_HasAlgorithm_Internal_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002C44 RID: 11332
		private static readonly IntPtr NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_0;

		// Token: 0x04002C45 RID: 11333
		private static readonly IntPtr NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_Int32_Int32_0;

		// Token: 0x04002C46 RID: 11334
		private static readonly IntPtr NativeMethodInfoPtr_ConvertByteArrayToInt_Internal_Static_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C47 RID: 11335
		private static readonly IntPtr NativeMethodInfoPtr_ConvertIntToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002C48 RID: 11336
		private static readonly IntPtr NativeMethodInfoPtr_FixupKeyParity_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C49 RID: 11337
		private static readonly IntPtr NativeMethodInfoPtr_DWORDFromLittleEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0;

		// Token: 0x04002C4A RID: 11338
		private static readonly IntPtr NativeMethodInfoPtr_DWORDToLittleEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04002C4B RID: 11339
		private static readonly IntPtr NativeMethodInfoPtr_DWORDFromBigEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0;

		// Token: 0x04002C4C RID: 11340
		private static readonly IntPtr NativeMethodInfoPtr_DWORDToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04002C4D RID: 11341
		private static readonly IntPtr NativeMethodInfoPtr_QuadWordFromBigEndian_Internal_Static_Void_ptr_UInt64_Int32_ptr_Byte_0;

		// Token: 0x04002C4E RID: 11342
		private static readonly IntPtr NativeMethodInfoPtr_QuadWordToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_Int32_0;

		// Token: 0x04002C4F RID: 11343
		private static readonly IntPtr NativeMethodInfoPtr__ProduceLegacyHmacValues_Internal_Static_Boolean_0;
	}
}
