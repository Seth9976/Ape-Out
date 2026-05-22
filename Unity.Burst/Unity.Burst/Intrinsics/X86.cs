using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics
{
	// Token: 0x02000014 RID: 20
	public static class X86 : Object
	{
		// Token: 0x0600006D RID: 109 RVA: 0x000023BD File Offset: 0x000005BD
		// Note: this type is marked as 'beforefieldinit'.
		static X86()
		{
			Il2CppClassPointerStore<X86>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "X86");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X86>.NativeClassPtr);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000023E2 File Offset: 0x000005E2
		public X86(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x02000020 RID: 32
		public static class Avx : Object
		{
			// Token: 0x0600009C RID: 156 RVA: 0x00005344 File Offset: 0x00003544
			// Note: this type is marked as 'beforefieldinit'.
			static Avx()
			{
				Il2CppClassPointerStore<X86.Avx>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X86>.NativeClassPtr, "Avx");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X86.Avx>.NativeClassPtr);
				X86.Avx.NativeMethodInfoPtr_mm256_load_ps_Public_Static_v256_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx>.NativeClassPtr, 100663358);
				X86.Avx.NativeMethodInfoPtr_mm256_store_ps_Public_Static_Void_ptr_Void_v256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx>.NativeClassPtr, 100663359);
				X86.Avx.NativeMethodInfoPtr_mm256_loadu_si256_Public_Static_v256_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx>.NativeClassPtr, 100663360);
				X86.Avx.NativeMethodInfoPtr_mm256_storeu_si256_Public_Static_Void_ptr_Void_v256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx>.NativeClassPtr, 100663361);
				X86.Avx.NativeMethodInfoPtr_mm256_set1_epi32_Public_Static_v256_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx>.NativeClassPtr, 100663362);
			}

			// Token: 0x0600009D RID: 157 RVA: 0x000053D4 File Offset: 0x000035D4
			[CallerCount(0)]
			public unsafe static v256 mm256_load_ps(void* ptr)
			{
				checked
				{
					IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr2 = ptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx.NativeMethodInfoPtr_mm256_load_ps_Public_Static_v256_ptr_Void_0, 0, (void**)ptr2, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00005410 File Offset: 0x00003610
			[CallerCount(0)]
			public unsafe static void mm256_store_ps(void* ptr, v256 val)
			{
				IntPtr* ptr2;
				checked
				{
					ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr2 = ptr;
				}
				ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx.NativeMethodInfoPtr_mm256_store_ps_Public_Static_Void_ptr_Void_v256_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00005450 File Offset: 0x00003650
			[CallerCount(0)]
			public unsafe static v256 mm256_loadu_si256(void* ptr)
			{
				checked
				{
					IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr2 = ptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx.NativeMethodInfoPtr_mm256_loadu_si256_Public_Static_v256_ptr_Void_0, 0, (void**)ptr2, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x0000548C File Offset: 0x0000368C
			[CallerCount(0)]
			public unsafe static void mm256_storeu_si256(void* ptr, v256 v)
			{
				IntPtr* ptr2;
				checked
				{
					ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr2 = ptr;
				}
				ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx.NativeMethodInfoPtr_mm256_storeu_si256_Public_Static_Void_ptr_Void_v256_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x000054CC File Offset: 0x000036CC
			[CallerCount(0)]
			public unsafe static v256 mm256_set1_epi32(int a)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx.NativeMethodInfoPtr_mm256_set1_epi32_Public_Static_v256_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00002576 File Offset: 0x00000776
			public Avx(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeMethodInfoPtr_mm256_load_ps_Public_Static_v256_ptr_Void_0;

			// Token: 0x04000230 RID: 560
			private static readonly IntPtr NativeMethodInfoPtr_mm256_store_ps_Public_Static_Void_ptr_Void_v256_0;

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeMethodInfoPtr_mm256_loadu_si256_Public_Static_v256_ptr_Void_0;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeMethodInfoPtr_mm256_storeu_si256_Public_Static_Void_ptr_Void_v256_0;

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeMethodInfoPtr_mm256_set1_epi32_Public_Static_v256_Int32_0;
		}

		// Token: 0x02000021 RID: 33
		public static class Avx2 : Object
		{
			// Token: 0x060000A3 RID: 163 RVA: 0x0000550C File Offset: 0x0000370C
			// Note: this type is marked as 'beforefieldinit'.
			static Avx2()
			{
				Il2CppClassPointerStore<X86.Avx2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X86>.NativeClassPtr, "Avx2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X86.Avx2>.NativeClassPtr);
				X86.Avx2.NativeMethodInfoPtr_get_IsAvx2Supported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx2>.NativeClassPtr, 100663363);
				X86.Avx2.NativeMethodInfoPtr_mm256_xor_si256_Public_Static_v256_v256_v256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx2>.NativeClassPtr, 100663364);
				X86.Avx2.NativeMethodInfoPtr_mm256_add_epi64_Public_Static_v256_v256_v256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx2>.NativeClassPtr, 100663365);
				X86.Avx2.NativeMethodInfoPtr_mm256_mul_epu32_Public_Static_v256_v256_v256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx2>.NativeClassPtr, 100663366);
				X86.Avx2.NativeMethodInfoPtr_mm256_slli_epi64_Public_Static_v256_v256_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx2>.NativeClassPtr, 100663367);
				X86.Avx2.NativeMethodInfoPtr_mm256_srli_epi64_Public_Static_v256_v256_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx2>.NativeClassPtr, 100663368);
				X86.Avx2.NativeMethodInfoPtr_mm256_shuffle_epi32_Public_Static_v256_v256_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Avx2>.NativeClassPtr, 100663369);
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x000055C4 File Offset: 0x000037C4
			public unsafe static bool IsAvx2Supported
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx2.NativeMethodInfoPtr_get_IsAvx2Supported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x000055F4 File Offset: 0x000037F4
			[CallerCount(0)]
			public unsafe static v256 mm256_xor_si256(v256 a, v256 b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx2.NativeMethodInfoPtr_mm256_xor_si256_Public_Static_v256_v256_v256_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x00005640 File Offset: 0x00003840
			[CallerCount(0)]
			public unsafe static v256 mm256_add_epi64(v256 a, v256 b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx2.NativeMethodInfoPtr_mm256_add_epi64_Public_Static_v256_v256_v256_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x0000568C File Offset: 0x0000388C
			[CallerCount(0)]
			public unsafe static v256 mm256_mul_epu32(v256 a, v256 b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx2.NativeMethodInfoPtr_mm256_mul_epu32_Public_Static_v256_v256_v256_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x000056D8 File Offset: 0x000038D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439720, XrefRangeEnd = 439729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static v256 mm256_slli_epi64(v256 a, int imm8)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imm8;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx2.NativeMethodInfoPtr_mm256_slli_epi64_Public_Static_v256_v256_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00005724 File Offset: 0x00003924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439729, XrefRangeEnd = 439738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static v256 mm256_srli_epi64(v256 a, int imm8)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imm8;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx2.NativeMethodInfoPtr_mm256_srli_epi64_Public_Static_v256_v256_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00005770 File Offset: 0x00003970
			[CallerCount(0)]
			public unsafe static v256 mm256_shuffle_epi32(v256 a, int imm8)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imm8;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Avx2.NativeMethodInfoPtr_mm256_shuffle_epi32_Public_Static_v256_v256_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000AB RID: 171 RVA: 0x0000257F File Offset: 0x0000077F
			public Avx2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeMethodInfoPtr_get_IsAvx2Supported_Public_Static_get_Boolean_0;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeMethodInfoPtr_mm256_xor_si256_Public_Static_v256_v256_v256_0;

			// Token: 0x04000236 RID: 566
			private static readonly IntPtr NativeMethodInfoPtr_mm256_add_epi64_Public_Static_v256_v256_v256_0;

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeMethodInfoPtr_mm256_mul_epu32_Public_Static_v256_v256_v256_0;

			// Token: 0x04000238 RID: 568
			private static readonly IntPtr NativeMethodInfoPtr_mm256_slli_epi64_Public_Static_v256_v256_Int32_0;

			// Token: 0x04000239 RID: 569
			private static readonly IntPtr NativeMethodInfoPtr_mm256_srli_epi64_Public_Static_v256_v256_Int32_0;

			// Token: 0x0400023A RID: 570
			private static readonly IntPtr NativeMethodInfoPtr_mm256_shuffle_epi32_Public_Static_v256_v256_Int32_0;
		}

		// Token: 0x02000022 RID: 34
		public static class Sse : Object
		{
			// Token: 0x060000AC RID: 172 RVA: 0x00002588 File Offset: 0x00000788
			// Note: this type is marked as 'beforefieldinit'.
			static Sse()
			{
				Il2CppClassPointerStore<X86.Sse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X86>.NativeClassPtr, "Sse");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X86.Sse>.NativeClassPtr);
				X86.Sse.NativeMethodInfoPtr_SHUFFLE_Public_Static_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Sse>.NativeClassPtr, 100663370);
			}

			// Token: 0x060000AD RID: 173 RVA: 0x000057BC File Offset: 0x000039BC
			[CallerCount(0)]
			public unsafe static int SHUFFLE(int d, int c, int b, int a)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Sse.NativeMethodInfoPtr_SHUFFLE_Public_Static_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000AE RID: 174 RVA: 0x000025BC File Offset: 0x000007BC
			public Sse(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400023B RID: 571
			private static readonly IntPtr NativeMethodInfoPtr_SHUFFLE_Public_Static_Int32_Int32_Int32_Int32_Int32_0;
		}

		// Token: 0x02000023 RID: 35
		public static class Sse2 : Object
		{
			// Token: 0x060000AF RID: 175 RVA: 0x00005824 File Offset: 0x00003A24
			// Note: this type is marked as 'beforefieldinit'.
			static Sse2()
			{
				Il2CppClassPointerStore<X86.Sse2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X86>.NativeClassPtr, "Sse2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X86.Sse2>.NativeClassPtr);
				X86.Sse2.NativeMethodInfoPtr_add_epi64_Public_Static_v128_v128_v128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Sse2>.NativeClassPtr, 100663371);
				X86.Sse2.NativeMethodInfoPtr_mul_epu32_Public_Static_v128_v128_v128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Sse2>.NativeClassPtr, 100663372);
				X86.Sse2.NativeMethodInfoPtr_slli_epi64_Public_Static_v128_v128_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Sse2>.NativeClassPtr, 100663373);
				X86.Sse2.NativeMethodInfoPtr_srli_epi64_Public_Static_v128_v128_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Sse2>.NativeClassPtr, 100663374);
				X86.Sse2.NativeMethodInfoPtr_xor_si128_Public_Static_v128_v128_v128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Sse2>.NativeClassPtr, 100663375);
				X86.Sse2.NativeMethodInfoPtr_shuffle_epi32_Public_Static_v128_v128_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X86.Sse2>.NativeClassPtr, 100663376);
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x000058C8 File Offset: 0x00003AC8
			[CallerCount(0)]
			public unsafe static v128 add_epi64(v128 a, v128 b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Sse2.NativeMethodInfoPtr_add_epi64_Public_Static_v128_v128_v128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x00005914 File Offset: 0x00003B14
			[CallerCount(0)]
			public unsafe static v128 mul_epu32(v128 a, v128 b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Sse2.NativeMethodInfoPtr_mul_epu32_Public_Static_v128_v128_v128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00005960 File Offset: 0x00003B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439738, XrefRangeEnd = 439742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static v128 slli_epi64(v128 a, int imm8)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imm8;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Sse2.NativeMethodInfoPtr_slli_epi64_Public_Static_v128_v128_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x000059AC File Offset: 0x00003BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439742, XrefRangeEnd = 439745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static v128 srli_epi64(v128 a, int imm8)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imm8;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Sse2.NativeMethodInfoPtr_srli_epi64_Public_Static_v128_v128_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000059F8 File Offset: 0x00003BF8
			[CallerCount(0)]
			public unsafe static v128 xor_si128(v128 a, v128 b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Sse2.NativeMethodInfoPtr_xor_si128_Public_Static_v128_v128_v128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x00005A44 File Offset: 0x00003C44
			[CallerCount(0)]
			public unsafe static v128 shuffle_epi32(v128 a, int imm8)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imm8;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X86.Sse2.NativeMethodInfoPtr_shuffle_epi32_Public_Static_v128_v128_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x000025C5 File Offset: 0x000007C5
			public Sse2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400023C RID: 572
			private static readonly IntPtr NativeMethodInfoPtr_add_epi64_Public_Static_v128_v128_v128_0;

			// Token: 0x0400023D RID: 573
			private static readonly IntPtr NativeMethodInfoPtr_mul_epu32_Public_Static_v128_v128_v128_0;

			// Token: 0x0400023E RID: 574
			private static readonly IntPtr NativeMethodInfoPtr_slli_epi64_Public_Static_v128_v128_Int32_0;

			// Token: 0x0400023F RID: 575
			private static readonly IntPtr NativeMethodInfoPtr_srli_epi64_Public_Static_v128_v128_Int32_0;

			// Token: 0x04000240 RID: 576
			private static readonly IntPtr NativeMethodInfoPtr_xor_si128_Public_Static_v128_v128_v128_0;

			// Token: 0x04000241 RID: 577
			private static readonly IntPtr NativeMethodInfoPtr_shuffle_epi32_Public_Static_v128_v128_Int32_0;
		}
	}
}
