using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Mathematics;

namespace Unity.Collections
{
	// Token: 0x02000029 RID: 41
	public static class xxHash3 : Object
	{
		// Token: 0x06000137 RID: 311 RVA: 0x0000A6C4 File Offset: 0x000088C4
		// Note: this type is marked as 'beforefieldinit'.
		static xxHash3()
		{
			Il2CppClassPointerStore<xxHash3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "xxHash3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<xxHash3>.NativeClassPtr);
			xxHash3.NativeFieldInfoPtr_STRIPE_LEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "STRIPE_LEN");
			xxHash3.NativeFieldInfoPtr_ACC_NB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "ACC_NB");
			xxHash3.NativeFieldInfoPtr_SECRET_CONSUME_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "SECRET_CONSUME_RATE");
			xxHash3.NativeFieldInfoPtr_SECRET_KEY_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "SECRET_KEY_SIZE");
			xxHash3.NativeFieldInfoPtr_SECRET_KEY_MIN_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "SECRET_KEY_MIN_SIZE");
			xxHash3.NativeFieldInfoPtr_SECRET_LASTACC_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "SECRET_LASTACC_START");
			xxHash3.NativeFieldInfoPtr_NB_ROUNDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "NB_ROUNDS");
			xxHash3.NativeFieldInfoPtr_BLOCK_LEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "BLOCK_LEN");
			xxHash3.NativeFieldInfoPtr_PRIME32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "PRIME32_1");
			xxHash3.NativeFieldInfoPtr_PRIME32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "PRIME32_2");
			xxHash3.NativeFieldInfoPtr_PRIME32_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "PRIME32_3");
			xxHash3.NativeFieldInfoPtr_PRIME32_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "PRIME32_5");
			xxHash3.NativeFieldInfoPtr_PRIME64_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "PRIME64_1");
			xxHash3.NativeFieldInfoPtr_PRIME64_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "PRIME64_2");
			xxHash3.NativeFieldInfoPtr_PRIME64_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "PRIME64_3");
			xxHash3.NativeFieldInfoPtr_PRIME64_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "PRIME64_4");
			xxHash3.NativeFieldInfoPtr_PRIME64_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "PRIME64_5");
			xxHash3.NativeFieldInfoPtr_MIDSIZE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "MIDSIZE_MAX");
			xxHash3.NativeFieldInfoPtr_MIDSIZE_STARTOFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "MIDSIZE_STARTOFFSET");
			xxHash3.NativeFieldInfoPtr_MIDSIZE_LASTOFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "MIDSIZE_LASTOFFSET");
			xxHash3.NativeFieldInfoPtr_SECRET_MERGEACCS_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "SECRET_MERGEACCS_START");
			xxHash3.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "_initialized");
			xxHash3.NativeFieldInfoPtr__bfp_Hash64Long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "_bfp_Hash64Long");
			xxHash3.NativeFieldInfoPtr__bfp_Hash128Long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "_bfp_Hash128Long");
			xxHash3.NativeMethodInfoPtr_Avx2HashLongInternalLoop_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663536);
			xxHash3.NativeMethodInfoPtr_Avx2ScrambleAcc_Internal_Static_Void_ptr_UInt64_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663537);
			xxHash3.NativeMethodInfoPtr_Avx2Accumulate_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663538);
			xxHash3.NativeMethodInfoPtr_Avx2Accumulate512_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663539);
			xxHash3.NativeMethodInfoPtr_Hash64_Public_Static_uint2_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663540);
			xxHash3.NativeMethodInfoPtr_Hash64_Public_Static_uint2_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663541);
			xxHash3.NativeMethodInfoPtr_Hash64_Public_Static_uint2_ptr_Void_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663542);
			xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663543);
			xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663544);
			xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663545);
			xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663546);
			xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_ptr_Void_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663547);
			xxHash3.NativeMethodInfoPtr_CheckMono_Private_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663548);
			xxHash3.NativeMethodInfoPtr_IsMono_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663549);
			xxHash3.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663550);
			xxHash3.NativeMethodInfoPtr__mono_to_burst_Hash64Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663551);
			xxHash3.NativeMethodInfoPtr__forward_mono_Hash64Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663552);
			xxHash3.NativeMethodInfoPtr__mono_to_burst_Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663553);
			xxHash3.NativeMethodInfoPtr__forward_mono_Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663554);
			xxHash3.NativeMethodInfoPtr_Hash64Long_Private_Static_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663555);
			xxHash3.NativeMethodInfoPtr_Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663556);
			xxHash3.NativeMethodInfoPtr_Hash64Internal_Internal_Static_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663557);
			xxHash3.NativeMethodInfoPtr_Hash128Internal_Internal_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663558);
			xxHash3.NativeMethodInfoPtr_Hash64Len1To3_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663559);
			xxHash3.NativeMethodInfoPtr_Hash64Len4To8_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663560);
			xxHash3.NativeMethodInfoPtr_Hash64Len9To16_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663561);
			xxHash3.NativeMethodInfoPtr_Hash64Len0To16_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663562);
			xxHash3.NativeMethodInfoPtr_Hash64Len17To128_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663563);
			xxHash3.NativeMethodInfoPtr_Hash64Len129To240_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663564);
			xxHash3.NativeMethodInfoPtr__Hash64Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663565);
			xxHash3.NativeMethodInfoPtr_Hash128Len1To3_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663566);
			xxHash3.NativeMethodInfoPtr_Hash128Len4To8_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663567);
			xxHash3.NativeMethodInfoPtr_Hash128Len9To16_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663568);
			xxHash3.NativeMethodInfoPtr_Hash128Len0To16_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663569);
			xxHash3.NativeMethodInfoPtr_Hash128Len17To128_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663570);
			xxHash3.NativeMethodInfoPtr_Hash128Len129To240_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663571);
			xxHash3.NativeMethodInfoPtr__Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663572);
			xxHash3.NativeMethodInfoPtr_ToUint2_Internal_Static_uint2_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663573);
			xxHash3.NativeMethodInfoPtr_ToUint4_Internal_Static_uint4_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663574);
			xxHash3.NativeMethodInfoPtr_EncodeSecretKey_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663575);
			xxHash3.NativeMethodInfoPtr_Read64LE_Private_Static_UInt64_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663576);
			xxHash3.NativeMethodInfoPtr_Read32LE_Private_Static_UInt32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663577);
			xxHash3.NativeMethodInfoPtr_Write64LE_Private_Static_Void_ptr_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663578);
			xxHash3.NativeMethodInfoPtr_Read32LE_Private_Static_Void_ptr_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663579);
			xxHash3.NativeMethodInfoPtr_Mul32To64_Private_Static_UInt64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663580);
			xxHash3.NativeMethodInfoPtr_Swap64_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663581);
			xxHash3.NativeMethodInfoPtr_Swap32_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663582);
			xxHash3.NativeMethodInfoPtr_RotL32_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663583);
			xxHash3.NativeMethodInfoPtr_RotL64_Private_Static_UInt64_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663584);
			xxHash3.NativeMethodInfoPtr_XorShift64_Private_Static_UInt64_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663585);
			xxHash3.NativeMethodInfoPtr_Mul128Fold64_Private_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663586);
			xxHash3.NativeMethodInfoPtr_Mix16_Private_Static_UInt64_ptr_Byte_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663587);
			xxHash3.NativeMethodInfoPtr_Mix32_Private_Static_ulong2_ulong2_ptr_Byte_ptr_Byte_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663588);
			xxHash3.NativeMethodInfoPtr_Avalanche_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663589);
			xxHash3.NativeMethodInfoPtr_AvalancheH64_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663590);
			xxHash3.NativeMethodInfoPtr_rrmxmx_Private_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663591);
			xxHash3.NativeMethodInfoPtr_Mix2Acc_Private_Static_UInt64_UInt64_UInt64_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663592);
			xxHash3.NativeMethodInfoPtr_MergeAcc_Internal_Static_UInt64_ptr_UInt64_ptr_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663593);
			xxHash3.NativeMethodInfoPtr_DefaultHashLongInternalLoop_Private_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663594);
			xxHash3.NativeMethodInfoPtr_DefaultAccumulate_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663595);
			xxHash3.NativeMethodInfoPtr_DefaultAccumulate512_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663596);
			xxHash3.NativeMethodInfoPtr_DefaultScrambleAcc_Internal_Static_Void_ptr_UInt64_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663597);
			xxHash3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663599);
			xxHash3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, 100663600);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000ADD4 File Offset: 0x00008FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440833, XrefRangeEnd = 440834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = input;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHash64;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Avx2HashLongInternalLoop_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000AE4C File Offset: 0x0000904C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33858, RefRangeEnd = 33864, XrefRangeStart = 33858, XrefRangeEnd = 33864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Avx2ScrambleAcc(ulong* acc, byte* secret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Avx2ScrambleAcc_Internal_Static_Void_ptr_UInt64_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000AE8C File Offset: 0x0000908C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440834, XrefRangeEnd = 440835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = input;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nbStripes;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHash64;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Avx2Accumulate_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000AF00 File Offset: 0x00009100
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33858, RefRangeEnd = 33864, XrefRangeStart = 33858, XrefRangeEnd = 33864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = input;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Avx2Accumulate512_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000AF58 File Offset: 0x00009158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440835, XrefRangeEnd = 440844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint2 Hash64(void* input, long length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64_Public_Static_uint2_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000AFA4 File Offset: 0x000091A4
		[CallerCount(0)]
		public unsafe static uint2 Hash64<T>([In] ref T input) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(input);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(xxHash3.MethodInfoStoreGeneric_Hash64_Public_Static_uint2_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				input = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000B000 File Offset: 0x00009200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440844, XrefRangeEnd = 440853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint2 Hash64(void* input, long length, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64_Public_Static_uint2_ptr_Void_Int64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000B058 File Offset: 0x00009258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440853, XrefRangeEnd = 440862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint4 Hash128(void* input, long length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000B0A4 File Offset: 0x000092A4
		[CallerCount(0)]
		public unsafe static uint4 Hash128<T>([In] ref T input) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(input);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(xxHash3.MethodInfoStoreGeneric_Hash128_Public_Static_uint4_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				input = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000B100 File Offset: 0x00009300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440862, XrefRangeEnd = 440871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint4 Hash128(void* input, void* destination, long length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000B158 File Offset: 0x00009358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440871, XrefRangeEnd = 440880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint4 Hash128(void* input, long length, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_Int64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000B1B0 File Offset: 0x000093B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440880, XrefRangeEnd = 440889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint4 Hash128(void* input, void* destination, long length, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_ptr_Void_Int64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000B218 File Offset: 0x00009418
		[CallerCount(0)]
		public unsafe static void CheckMono(ref bool isMono)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &isMono;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_CheckMono_Private_Static_Void_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000B24C File Offset: 0x0000944C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440889, XrefRangeEnd = 440892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMono()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_IsMono_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000B27C File Offset: 0x0000947C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440892, XrefRangeEnd = 440925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000B2A4 File Offset: 0x000094A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440925, XrefRangeEnd = 440945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _mono_to_burst_Hash64Long(byte* input, byte* dest, long length, byte* secret, out ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr__mono_to_burst_Hash64Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000B30C File Offset: 0x0000950C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440945, XrefRangeEnd = 440950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _forward_mono_Hash64Long(byte* input, byte* dest, long length, byte* secret, out ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr__forward_mono_Hash64Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000B374 File Offset: 0x00009574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440950, XrefRangeEnd = 440970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _mono_to_burst_Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr__mono_to_burst_Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000B3DC File Offset: 0x000095DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440970, XrefRangeEnd = 440975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _forward_mono_Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr__forward_mono_Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000B444 File Offset: 0x00009644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440990, RefRangeEnd = 440991, XrefRangeStart = 440975, XrefRangeEnd = 440990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Hash64Long(byte* input, byte* dest, long length, byte* secret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64Long_Private_Static_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441006, RefRangeEnd = 441008, XrefRangeStart = 440991, XrefRangeEnd = 441006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000B510 File Offset: 0x00009710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441013, RefRangeEnd = 441015, XrefRangeStart = 441008, XrefRangeEnd = 441013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Hash64Internal(byte* input, byte* dest, long length, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64Internal_Internal_Static_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000B584 File Offset: 0x00009784
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 441038, RefRangeEnd = 441042, XrefRangeStart = 441015, XrefRangeEnd = 441038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash128Internal(byte* input, byte* dest, long length, byte* secret, ulong seed, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128Internal_Internal_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000B5FC File Offset: 0x000097FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441042, XrefRangeEnd = 441045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Hash64Len1To3(byte* input, long len, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64Len1To3_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000B664 File Offset: 0x00009864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441045, XrefRangeEnd = 441052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Hash64Len4To8(byte* input, long length, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64Len4To8_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000B6CC File Offset: 0x000098CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441052, XrefRangeEnd = 441056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Hash64Len9To16(byte* input, long length, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64Len9To16_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000B734 File Offset: 0x00009934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441056, XrefRangeEnd = 441084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Hash64Len0To16(byte* input, long length, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64Len0To16_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000B79C File Offset: 0x0000999C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441084, XrefRangeEnd = 441104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Hash64Len17To128(byte* input, long length, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64Len17To128_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000B804 File Offset: 0x00009A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441104, XrefRangeEnd = 441118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Hash64Len129To240(byte* input, long length, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash64Len129To240_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000B86C File Offset: 0x00009A6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 441125, RefRangeEnd = 441128, XrefRangeStart = 441118, XrefRangeEnd = 441125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Hash64Long(byte* input, byte* dest, long length, byte* secret, out ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr__Hash64Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000B8D4 File Offset: 0x00009AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441128, XrefRangeEnd = 441131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash128Len1To3(byte* input, long length, byte* secret, ulong seed, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128Len1To3_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000B940 File Offset: 0x00009B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441138, RefRangeEnd = 441139, XrefRangeStart = 441131, XrefRangeEnd = 441138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash128Len4To8(byte* input, long len, byte* secret, ulong seed, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128Len4To8_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000B9AC File Offset: 0x00009BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441144, RefRangeEnd = 441145, XrefRangeStart = 441139, XrefRangeEnd = 441144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash128Len9To16(byte* input, long len, byte* secret, ulong seed, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128Len9To16_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000BA18 File Offset: 0x00009C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441160, RefRangeEnd = 441161, XrefRangeStart = 441145, XrefRangeEnd = 441160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash128Len0To16(byte* input, long length, byte* secret, ulong seed, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128Len0To16_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000BA84 File Offset: 0x00009C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441191, RefRangeEnd = 441192, XrefRangeStart = 441161, XrefRangeEnd = 441191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash128Len17To128(byte* input, long length, byte* secret, ulong seed, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128Len17To128_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441208, RefRangeEnd = 441209, XrefRangeStart = 441192, XrefRangeEnd = 441208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash128Len129To240(byte* input, long length, byte* secret, ulong seed, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Hash128Len129To240_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000BB5C File Offset: 0x00009D5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 441218, RefRangeEnd = 441221, XrefRangeStart = 441209, XrefRangeEnd = 441218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr__Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		[CallerCount(0)]
		public unsafe static uint2 ToUint2(ulong u)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref u;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_ToUint2_Internal_Static_uint2_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000BC04 File Offset: 0x00009E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441221, RefRangeEnd = 441222, XrefRangeStart = 441221, XrefRangeEnd = 441221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint4 ToUint4(ulong ul0, ulong ul1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ul0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ul1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_ToUint4_Internal_Static_uint4_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000BC50 File Offset: 0x00009E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441225, RefRangeEnd = 441226, XrefRangeStart = 441222, XrefRangeEnd = 441225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EncodeSecretKey(byte* dst, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_EncodeSecretKey_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000BC9C File Offset: 0x00009E9C
		[CallerCount(0)]
		public unsafe static ulong Read64LE(void* addr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = addr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Read64LE_Private_Static_UInt64_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000BCD8 File Offset: 0x00009ED8
		[CallerCount(0)]
		public unsafe static uint Read32LE(void* addr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = addr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Read32LE_Private_Static_UInt32_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000BD14 File Offset: 0x00009F14
		[CallerCount(0)]
		public unsafe static void Write64LE(void* addr, ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = addr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Write64LE_Private_Static_Void_ptr_Void_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000BD54 File Offset: 0x00009F54
		[CallerCount(0)]
		public unsafe static void Read32LE(void* addr, uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = addr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Read32LE_Private_Static_Void_ptr_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000BD94 File Offset: 0x00009F94
		[CallerCount(0)]
		public unsafe static ulong Mul32To64(uint x, uint y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Mul32To64_Private_Static_UInt64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		[CallerCount(0)]
		public unsafe static ulong Swap64(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Swap64_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000BE20 File Offset: 0x0000A020
		[CallerCount(0)]
		public unsafe static uint Swap32(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Swap32_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000BE60 File Offset: 0x0000A060
		[CallerCount(0)]
		public unsafe static uint RotL32(uint x, int r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_RotL32_Private_Static_UInt32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		[CallerCount(0)]
		public unsafe static ulong RotL64(ulong x, int r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_RotL64_Private_Static_UInt64_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[CallerCount(0)]
		public unsafe static ulong XorShift64(ulong v64, int shift)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v64;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_XorShift64_Private_Static_UInt64_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000BF44 File Offset: 0x0000A144
		[CallerCount(0)]
		public unsafe static ulong Mul128Fold64(ulong lhs, ulong rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Mul128Fold64_Private_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000BF90 File Offset: 0x0000A190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441226, XrefRangeEnd = 441229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Mix16(byte* input, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Mix16_Private_Static_UInt64_ptr_Byte_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441229, XrefRangeEnd = 441234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static xxHash3.ulong2 Mix32(xxHash3.ulong2 acc, byte* input_1, byte* input_2, byte* secret, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = input_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = input_2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Mix32_Private_Static_ulong2_ulong2_ptr_Byte_ptr_Byte_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000C05C File Offset: 0x0000A25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441234, XrefRangeEnd = 441237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Avalanche(ulong h64)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h64;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Avalanche_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000C09C File Offset: 0x0000A29C
		[CallerCount(0)]
		public unsafe static ulong AvalancheH64(ulong h64)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h64;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_AvalancheH64_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000C0DC File Offset: 0x0000A2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441237, XrefRangeEnd = 441240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong rrmxmx(ulong h64, ulong length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h64;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_rrmxmx_Private_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000C128 File Offset: 0x0000A328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441240, XrefRangeEnd = 441243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref acc0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acc1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Mix2Acc_Private_Static_UInt64_UInt64_UInt64_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000C180 File Offset: 0x0000A380
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 441251, RefRangeEnd = 441254, XrefRangeStart = 441243, XrefRangeEnd = 441251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong MergeAcc(ulong* acc, byte* secret, ulong start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_MergeAcc_Internal_Static_UInt64_ptr_UInt64_ptr_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000C1D8 File Offset: 0x0000A3D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441264, RefRangeEnd = 441266, XrefRangeStart = 441254, XrefRangeEnd = 441264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = input;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHash64;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_DefaultHashLongInternalLoop_Private_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000C250 File Offset: 0x0000A450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441270, RefRangeEnd = 441272, XrefRangeStart = 441266, XrefRangeEnd = 441270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = input;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nbStripes;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHash64;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_DefaultAccumulate_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441279, RefRangeEnd = 441281, XrefRangeStart = 441272, XrefRangeEnd = 441279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = input;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHash64;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_DefaultAccumulate512_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000C32C File Offset: 0x0000A52C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441284, RefRangeEnd = 441285, XrefRangeStart = 441281, XrefRangeEnd = 441284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DefaultScrambleAcc(ulong* acc, byte* secret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = acc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_DefaultScrambleAcc_Internal_Static_Void_ptr_UInt64_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000C36C File Offset: 0x0000A56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441285, XrefRangeEnd = 441289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_PDM_0(byte* input, byte* dest, long length, byte* secret, out ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441289, XrefRangeEnd = 441301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_PDM_0(byte* input, byte* dest, long length, byte* secret, out uint4 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000273B File Offset: 0x0000093B
		public xxHash3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000C43C File Offset: 0x0000A63C
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002744 File Offset: 0x00000944
		public unsafe static int STRIPE_LEN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_STRIPE_LEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_STRIPE_LEN, (void*)(&value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000C458 File Offset: 0x0000A658
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002752 File Offset: 0x00000952
		public unsafe static int ACC_NB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_ACC_NB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_ACC_NB, (void*)(&value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000C474 File Offset: 0x0000A674
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002760 File Offset: 0x00000960
		public unsafe static int SECRET_CONSUME_RATE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_SECRET_CONSUME_RATE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_SECRET_CONSUME_RATE, (void*)(&value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000C490 File Offset: 0x0000A690
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000276E File Offset: 0x0000096E
		public unsafe static int SECRET_KEY_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_SECRET_KEY_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_SECRET_KEY_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000277C File Offset: 0x0000097C
		public unsafe static int SECRET_KEY_MIN_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_SECRET_KEY_MIN_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_SECRET_KEY_MIN_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0000278A File Offset: 0x0000098A
		public unsafe static int SECRET_LASTACC_START
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_SECRET_LASTACC_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_SECRET_LASTACC_START, (void*)(&value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002798 File Offset: 0x00000998
		public unsafe static int NB_ROUNDS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_NB_ROUNDS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_NB_ROUNDS, (void*)(&value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000C500 File Offset: 0x0000A700
		// (set) Token: 0x06000188 RID: 392 RVA: 0x000027A6 File Offset: 0x000009A6
		public unsafe static int BLOCK_LEN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_BLOCK_LEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_BLOCK_LEN, (void*)(&value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000C51C File Offset: 0x0000A71C
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000027B4 File Offset: 0x000009B4
		public unsafe static uint PRIME32_1
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_PRIME32_1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_PRIME32_1, (void*)(&value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000C538 File Offset: 0x0000A738
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000027C2 File Offset: 0x000009C2
		public unsafe static uint PRIME32_2
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_PRIME32_2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_PRIME32_2, (void*)(&value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000C554 File Offset: 0x0000A754
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000027D0 File Offset: 0x000009D0
		public unsafe static uint PRIME32_3
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_PRIME32_3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_PRIME32_3, (void*)(&value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000C570 File Offset: 0x0000A770
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000027DE File Offset: 0x000009DE
		public unsafe static uint PRIME32_5
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_PRIME32_5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_PRIME32_5, (void*)(&value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000C58C File Offset: 0x0000A78C
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000027EC File Offset: 0x000009EC
		public unsafe static ulong PRIME64_1
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_PRIME64_1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_PRIME64_1, (void*)(&value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000027FA File Offset: 0x000009FA
		public unsafe static ulong PRIME64_2
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_PRIME64_2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_PRIME64_2, (void*)(&value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002808 File Offset: 0x00000A08
		public unsafe static ulong PRIME64_3
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_PRIME64_3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_PRIME64_3, (void*)(&value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002816 File Offset: 0x00000A16
		public unsafe static ulong PRIME64_4
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_PRIME64_4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_PRIME64_4, (void*)(&value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002824 File Offset: 0x00000A24
		public unsafe static ulong PRIME64_5
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_PRIME64_5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_PRIME64_5, (void*)(&value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000C618 File Offset: 0x0000A818
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002832 File Offset: 0x00000A32
		public unsafe static int MIDSIZE_MAX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_MIDSIZE_MAX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_MIDSIZE_MAX, (void*)(&value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000C634 File Offset: 0x0000A834
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002840 File Offset: 0x00000A40
		public unsafe static int MIDSIZE_STARTOFFSET
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_MIDSIZE_STARTOFFSET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_MIDSIZE_STARTOFFSET, (void*)(&value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000C650 File Offset: 0x0000A850
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000284E File Offset: 0x00000A4E
		public unsafe static int MIDSIZE_LASTOFFSET
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_MIDSIZE_LASTOFFSET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_MIDSIZE_LASTOFFSET, (void*)(&value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000C66C File Offset: 0x0000A86C
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000285C File Offset: 0x00000A5C
		public unsafe static int SECRET_MERGEACCS_START
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr_SECRET_MERGEACCS_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr_SECRET_MERGEACCS_START, (void*)(&value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000C688 File Offset: 0x0000A888
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000286A File Offset: 0x00000A6A
		public unsafe static bool _initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr__initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr__initialized, (void*)(&value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002878 File Offset: 0x00000A78
		public unsafe static xxHash3._dlg_Hash64Long _bfp_Hash64Long
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr__bfp_Hash64Long, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<xxHash3._dlg_Hash64Long>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr__bfp_Hash64Long, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000288A File Offset: 0x00000A8A
		public unsafe static xxHash3._dlg_Hash128Long _bfp_Hash128Long
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(xxHash3.NativeFieldInfoPtr__bfp_Hash128Long, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<xxHash3._dlg_Hash128Long>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHash3.NativeFieldInfoPtr__bfp_Hash128Long, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_STRIPE_LEN;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_ACC_NB;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_SECRET_CONSUME_RATE;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_SECRET_KEY_SIZE;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_SECRET_KEY_MIN_SIZE;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr_SECRET_LASTACC_START;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_NB_ROUNDS;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_BLOCK_LEN;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_PRIME32_1;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_PRIME32_2;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_PRIME32_3;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_PRIME32_5;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_PRIME64_1;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_PRIME64_2;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_PRIME64_3;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_PRIME64_4;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_PRIME64_5;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_MIDSIZE_MAX;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_MIDSIZE_STARTOFFSET;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_MIDSIZE_LASTOFFSET;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_SECRET_MERGEACCS_START;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr__initialized;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr__bfp_Hash64Long;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr__bfp_Hash128Long;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_Avx2HashLongInternalLoop_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_Int32_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_Avx2ScrambleAcc_Internal_Static_Void_ptr_UInt64_ptr_Byte_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_Avx2Accumulate_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_Int64_Int32_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_Avx2Accumulate512_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_Hash64_Public_Static_uint2_ptr_Void_Int64_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_Hash64_Public_Static_uint2_byref_T_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_Hash64_Public_Static_uint2_ptr_Void_Int64_UInt64_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_Int64_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_Hash128_Public_Static_uint4_byref_T_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_ptr_Void_Int64_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_Int64_UInt64_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_Hash128_Public_Static_uint4_ptr_Void_ptr_Void_Int64_UInt64_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_CheckMono_Private_Static_Void_byref_Boolean_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_IsMono_Private_Static_Boolean_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr__mono_to_burst_Hash64Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr__forward_mono_Hash64Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr__mono_to_burst_Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr__forward_mono_Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_Hash64Long_Private_Static_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_Hash64Internal_Internal_Static_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_UInt64_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_Hash128Internal_Internal_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_Hash64Len1To3_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_Hash64Len4To8_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_Hash64Len9To16_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_Hash64Len0To16_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_Hash64Len17To128_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_Hash64Len129To240_Private_Static_UInt64_ptr_Byte_Int64_ptr_Byte_UInt64_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr__Hash64Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_Hash128Len1To3_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_Hash128Len4To8_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_Hash128Len9To16_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_Hash128Len0To16_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_Hash128Len17To128_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_Hash128Len129To240_Private_Static_Void_ptr_Byte_Int64_ptr_Byte_UInt64_byref_uint4_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr__Hash128Long_Private_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_ToUint2_Internal_Static_uint2_UInt64_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_ToUint4_Internal_Static_uint4_UInt64_UInt64_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_EncodeSecretKey_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt64_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_Read64LE_Private_Static_UInt64_ptr_Void_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_Read32LE_Private_Static_UInt32_ptr_Void_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_Write64LE_Private_Static_Void_ptr_Void_UInt64_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_Read32LE_Private_Static_Void_ptr_Void_UInt32_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_Mul32To64_Private_Static_UInt64_UInt32_UInt32_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_Swap64_Private_Static_UInt64_UInt64_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_Swap32_Private_Static_UInt32_UInt32_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_RotL32_Private_Static_UInt32_UInt32_Int32_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_RotL64_Private_Static_UInt64_UInt64_Int32_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_XorShift64_Private_Static_UInt64_UInt64_Int32_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_Mul128Fold64_Private_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_Mix16_Private_Static_UInt64_ptr_Byte_ptr_Byte_UInt64_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_Mix32_Private_Static_ulong2_ulong2_ptr_Byte_ptr_Byte_ptr_Byte_UInt64_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_Avalanche_Private_Static_UInt64_UInt64_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_AvalancheH64_Private_Static_UInt64_UInt64_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_rrmxmx_Private_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_Mix2Acc_Private_Static_UInt64_UInt64_UInt64_ptr_Byte_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_MergeAcc_Internal_Static_UInt64_ptr_UInt64_ptr_Byte_UInt64_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_DefaultHashLongInternalLoop_Private_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_Int64_ptr_Byte_Int32_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_DefaultAccumulate_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_Int64_Int32_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_DefaultAccumulate512_Internal_Static_Void_ptr_UInt64_ptr_Byte_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_DefaultScrambleAcc_Internal_Static_Void_ptr_UInt64_ptr_Byte_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_PDM_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_PDM_0;

		// Token: 0x02000051 RID: 81
		[StructLayout(2)]
		public struct ulong2
		{
			// Token: 0x060002E6 RID: 742 RVA: 0x0001127C File Offset: 0x0000F47C
			// Note: this type is marked as 'beforefieldinit'.
			static ulong2()
			{
				Il2CppClassPointerStore<xxHash3.ulong2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "ulong2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<xxHash3.ulong2>.NativeClassPtr);
				xxHash3.ulong2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3.ulong2>.NativeClassPtr, "x");
				xxHash3.ulong2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3.ulong2>.NativeClassPtr, "y");
				xxHash3.ulong2.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ulong2>.NativeClassPtr, 100663601);
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x000112E4 File Offset: 0x0000F4E4
			[CallerCount(0)]
			public unsafe ulong2(ulong x, ulong y)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ulong2.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x000034BE File Offset: 0x000016BE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<xxHash3.ulong2>.NativeClassPtr, ref this));
			}

			// Token: 0x04000533 RID: 1331
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04000534 RID: 1332
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04000535 RID: 1333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

			// Token: 0x04000536 RID: 1334
			[FieldOffset(0)]
			public ulong x;

			// Token: 0x04000537 RID: 1335
			[FieldOffset(8)]
			public ulong y;
		}

		// Token: 0x02000052 RID: 82
		public sealed class _dlg_Hash64Long : MulticastDelegate
		{
			// Token: 0x060002E9 RID: 745 RVA: 0x00011324 File Offset: 0x0000F524
			// Note: this type is marked as 'beforefieldinit'.
			static _dlg_Hash64Long()
			{
				Il2CppClassPointerStore<xxHash3._dlg_Hash64Long>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "_dlg_Hash64Long");
				xxHash3._dlg_Hash64Long.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3._dlg_Hash64Long>.NativeClassPtr, 100663602);
				xxHash3._dlg_Hash64Long.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3._dlg_Hash64Long>.NativeClassPtr, 100663603);
				xxHash3._dlg_Hash64Long.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3._dlg_Hash64Long>.NativeClassPtr, 100663604);
				xxHash3._dlg_Hash64Long.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UInt64_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3._dlg_Hash64Long>.NativeClassPtr, 100663605);
			}

			// Token: 0x060002EA RID: 746 RVA: 0x00011398 File Offset: 0x0000F598
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _dlg_Hash64Long(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<xxHash3._dlg_Hash64Long>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3._dlg_Hash64Long.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EB RID: 747 RVA: 0x000113F4 File Offset: 0x0000F5F4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 440671, RefRangeEnd = 440675, XrefRangeStart = 440671, XrefRangeEnd = 440671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(byte* input, byte* dest, long length, byte* secret, out ulong result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3._dlg_Hash64Long.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0001146C File Offset: 0x0000F66C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440675, XrefRangeEnd = 440682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(byte* input, byte* dest, long length, byte* secret, out ulong result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3._dlg_Hash64Long.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060002ED RID: 749 RVA: 0x00011518 File Offset: 0x0000F718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(out ulong result, IAsyncResult __result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3._dlg_Hash64Long.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UInt64_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EE RID: 750 RVA: 0x000034D0 File Offset: 0x000016D0
			public _dlg_Hash64Long(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000538 RID: 1336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000539 RID: 1337
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0;

			// Token: 0x0400053A RID: 1338
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_AsyncCallback_Object_0;

			// Token: 0x0400053B RID: 1339
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UInt64_IAsyncResult_0;
		}

		// Token: 0x02000053 RID: 83
		public sealed class _dlg_Hash128Long : MulticastDelegate
		{
			// Token: 0x060002EF RID: 751 RVA: 0x00011568 File Offset: 0x0000F768
			// Note: this type is marked as 'beforefieldinit'.
			static _dlg_Hash128Long()
			{
				Il2CppClassPointerStore<xxHash3._dlg_Hash128Long>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "_dlg_Hash128Long");
				xxHash3._dlg_Hash128Long.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3._dlg_Hash128Long>.NativeClassPtr, 100663606);
				xxHash3._dlg_Hash128Long.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3._dlg_Hash128Long>.NativeClassPtr, 100663607);
				xxHash3._dlg_Hash128Long.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3._dlg_Hash128Long>.NativeClassPtr, 100663608);
				xxHash3._dlg_Hash128Long.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_uint4_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3._dlg_Hash128Long>.NativeClassPtr, 100663609);
			}

			// Token: 0x060002F0 RID: 752 RVA: 0x000115DC File Offset: 0x0000F7DC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _dlg_Hash128Long(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<xxHash3._dlg_Hash128Long>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3._dlg_Hash128Long.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x00011638 File Offset: 0x0000F838
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 440671, RefRangeEnd = 440675, XrefRangeStart = 440671, XrefRangeEnd = 440675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3._dlg_Hash128Long.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x000116B0 File Offset: 0x0000F8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440682, XrefRangeEnd = 440689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(byte* input, byte* dest, long length, byte* secret, out uint4 result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3._dlg_Hash128Long.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x0001175C File Offset: 0x0000F95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(out uint4 result, IAsyncResult __result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3._dlg_Hash128Long.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_uint4_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F4 RID: 756 RVA: 0x000034D9 File Offset: 0x000016D9
			public _dlg_Hash128Long(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400053C RID: 1340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400053D RID: 1341
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0;

			// Token: 0x0400053E RID: 1342
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_AsyncCallback_Object_0;

			// Token: 0x0400053F RID: 1343
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_uint4_IAsyncResult_0;
		}

		// Token: 0x02000054 RID: 84
		[ObfuscatedName("Unity.Collections.xxHash3+_mono_to_burst_Hash64Long_000006D2$PostfixBurstDelegate")]
		public sealed class MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0 : MulticastDelegate
		{
			// Token: 0x060002F5 RID: 757 RVA: 0x000117AC File Offset: 0x0000F9AC
			// Note: this type is marked as 'beforefieldinit'.
			static MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0()
			{
				Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "_mono_to_burst_Hash64Long_000006D2$PostfixBurstDelegate");
				xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0>.NativeClassPtr, 100663610);
				xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0>.NativeClassPtr, 100663611);
				xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0>.NativeClassPtr, 100663612);
				xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0>.NativeClassPtr, 100663613);
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x00011820 File Offset: 0x0000FA20
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0(Object A_1, IntPtr A_2)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x0001187C File Offset: 0x0000FA7C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 440671, RefRangeEnd = 440675, XrefRangeStart = 440671, XrefRangeEnd = 440675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(byte* input, byte* dest, long length, byte* secret, out ulong result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x000118F4 File Offset: 0x0000FAF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440689, XrefRangeEnd = 440696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(byte* input, byte* dest, long length, byte* secret, out ulong result, AsyncCallback A_6, Object A_7)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_7);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x000119A0 File Offset: 0x0000FBA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002FA RID: 762 RVA: 0x000034E2 File Offset: 0x000016E2
			public MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000540 RID: 1344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000541 RID: 1345
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0;

			// Token: 0x04000542 RID: 1346
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_AsyncCallback_Object_0;

			// Token: 0x04000543 RID: 1347
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000055 RID: 85
		[ObfuscatedName("Unity.Collections.xxHash3+_mono_to_burst_Hash64Long_000006D2$BurstDirectCall")]
		public static class ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0 : Object
		{
			// Token: 0x060002FB RID: 763 RVA: 0x000119E4 File Offset: 0x0000FBE4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0()
			{
				Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "_mono_to_burst_Hash64Long_000006D2$BurstDirectCall");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0>.NativeClassPtr);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0>.NativeClassPtr, "Pointer");
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0>.NativeClassPtr, 100663614);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0>.NativeClassPtr, 100663615);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0>.NativeClassPtr, 100663616);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0>.NativeClassPtr, 100663617);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0>.NativeClassPtr, 100663619);
			}

			// Token: 0x060002FC RID: 764 RVA: 0x00011A88 File Offset: 0x0000FC88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440696, XrefRangeEnd = 440712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_0;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002FD RID: 765 RVA: 0x00011ABC File Offset: 0x0000FCBC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 440732, RefRangeEnd = 440735, XrefRangeStart = 440712, XrefRangeEnd = 440732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IntPtr GetFunctionPointer()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002FE RID: 766 RVA: 0x00011AEC File Offset: 0x0000FCEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440735, XrefRangeEnd = 440740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Constructor()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002FF RID: 767 RVA: 0x00011B14 File Offset: 0x0000FD14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440740, XrefRangeEnd = 440744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000300 RID: 768 RVA: 0x00011B3C File Offset: 0x0000FD3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440744, XrefRangeEnd = 440761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Invoke(byte* input, byte* dest, long length, byte* secret, out ulong result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000301 RID: 769 RVA: 0x000034EB File Offset: 0x000016EB
			public ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000302 RID: 770 RVA: 0x00011BA4 File Offset: 0x0000FDA4
			// (set) Token: 0x06000303 RID: 771 RVA: 0x000034F4 File Offset: 0x000016F4
			public unsafe static IntPtr Pointer
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeFieldInfoPtr_Pointer, (void*)(&intPtr));
					return intPtr;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin0.NativeFieldInfoPtr_Pointer, (void*)(&value));
				}
			}

			// Token: 0x04000544 RID: 1348
			private static readonly IntPtr NativeFieldInfoPtr_Pointer;

			// Token: 0x04000545 RID: 1349
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

			// Token: 0x04000546 RID: 1350
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

			// Token: 0x04000547 RID: 1351
			private static readonly IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;

			// Token: 0x04000548 RID: 1352
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

			// Token: 0x04000549 RID: 1353
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_UInt64_0;
		}

		// Token: 0x02000056 RID: 86
		[ObfuscatedName("Unity.Collections.xxHash3+_mono_to_burst_Hash128Long_000006D4$PostfixBurstDelegate")]
		public sealed class MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1 : MulticastDelegate
		{
			// Token: 0x06000304 RID: 772 RVA: 0x00011BC0 File Offset: 0x0000FDC0
			// Note: this type is marked as 'beforefieldinit'.
			static MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1()
			{
				Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "_mono_to_burst_Hash128Long_000006D4$PostfixBurstDelegate");
				xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1>.NativeClassPtr, 100663620);
				xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1>.NativeClassPtr, 100663621);
				xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1>.NativeClassPtr, 100663622);
				xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1>.NativeClassPtr, 100663623);
			}

			// Token: 0x06000305 RID: 773 RVA: 0x00011C34 File Offset: 0x0000FE34
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1(Object A_1, IntPtr A_2)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000306 RID: 774 RVA: 0x00011C90 File Offset: 0x0000FE90
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 440671, RefRangeEnd = 440675, XrefRangeStart = 440671, XrefRangeEnd = 440675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000307 RID: 775 RVA: 0x00011D08 File Offset: 0x0000FF08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440761, XrefRangeEnd = 440768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(byte* input, byte* dest, long length, byte* secret, out uint4 result, AsyncCallback A_6, Object A_7)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_6);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_7);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000308 RID: 776 RVA: 0x00011DB4 File Offset: 0x0000FFB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000309 RID: 777 RVA: 0x00003502 File Offset: 0x00001702
			public MulticastDelegateNPublicSealedVoObInObA_VoinA_Inde1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400054A RID: 1354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400054B RID: 1355
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0;

			// Token: 0x0400054C RID: 1356
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_AsyncCallback_Object_0;

			// Token: 0x0400054D RID: 1357
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000057 RID: 87
		[ObfuscatedName("Unity.Collections.xxHash3+_mono_to_burst_Hash128Long_000006D4$BurstDirectCall")]
		public static class ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1 : Object
		{
			// Token: 0x0600030A RID: 778 RVA: 0x00011DF8 File Offset: 0x0000FFF8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1()
			{
				Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<xxHash3>.NativeClassPtr, "_mono_to_burst_Hash128Long_000006D4$BurstDirectCall");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1>.NativeClassPtr);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1>.NativeClassPtr, "Pointer");
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1>.NativeClassPtr, 100663624);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1>.NativeClassPtr, 100663625);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1>.NativeClassPtr, 100663626);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1>.NativeClassPtr, 100663627);
				xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1>.NativeClassPtr, 100663629);
			}

			// Token: 0x0600030B RID: 779 RVA: 0x00011E9C File Offset: 0x0001009C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440768, XrefRangeEnd = 440784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_0;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600030C RID: 780 RVA: 0x00011ED0 File Offset: 0x000100D0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 440804, RefRangeEnd = 440807, XrefRangeStart = 440784, XrefRangeEnd = 440804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IntPtr GetFunctionPointer()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600030D RID: 781 RVA: 0x00011F00 File Offset: 0x00010100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440807, XrefRangeEnd = 440812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Constructor()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600030E RID: 782 RVA: 0x00011F28 File Offset: 0x00010128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440812, XrefRangeEnd = 440816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600030F RID: 783 RVA: 0x00011F50 File Offset: 0x00010150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440816, XrefRangeEnd = 440833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = secret;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000310 RID: 784 RVA: 0x0000350B File Offset: 0x0000170B
			public ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000311 RID: 785 RVA: 0x00011FB8 File Offset: 0x000101B8
			// (set) Token: 0x06000312 RID: 786 RVA: 0x00003514 File Offset: 0x00001714
			public unsafe static IntPtr Pointer
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeFieldInfoPtr_Pointer, (void*)(&intPtr));
					return intPtr;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(xxHash3.ObjectNPrivateAbstractSealedInPoGeVoA_ObCoGeInin1.NativeFieldInfoPtr_Pointer, (void*)(&value));
				}
			}

			// Token: 0x0400054E RID: 1358
			private static readonly IntPtr NativeFieldInfoPtr_Pointer;

			// Token: 0x0400054F RID: 1359
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

			// Token: 0x04000550 RID: 1360
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

			// Token: 0x04000551 RID: 1361
			private static readonly IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;

			// Token: 0x04000552 RID: 1362
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

			// Token: 0x04000553 RID: 1363
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Byte_ptr_Byte_Int64_ptr_Byte_byref_uint4_0;
		}

		// Token: 0x02000058 RID: 88
		private sealed class MethodInfoStoreGeneric_Hash64_Public_Static_uint2_byref_T_0<T>
		{
			// Token: 0x04000554 RID: 1364
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(xxHash3.NativeMethodInfoPtr_Hash64_Public_Static_uint2_byref_T_0, Il2CppClassPointerStore<xxHash3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000059 RID: 89
		private sealed class MethodInfoStoreGeneric_Hash128_Public_Static_uint4_byref_T_0<T>
		{
			// Token: 0x04000555 RID: 1365
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(xxHash3.NativeMethodInfoPtr_Hash128_Public_Static_uint4_byref_T_0, Il2CppClassPointerStore<xxHash3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
