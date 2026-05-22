using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000003 RID: 3
	public static class math : Object
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002160 File Offset: 0x00000360
		// Note: this type is marked as 'beforefieldinit'.
		static math()
		{
			Il2CppClassPointerStore<math>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "math");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<math>.NativeClassPtr);
			math.NativeMethodInfoPtr_min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663298);
			math.NativeMethodInfoPtr_min_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663299);
			math.NativeMethodInfoPtr_max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663300);
			math.NativeMethodInfoPtr_max_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663301);
			math.NativeMethodInfoPtr_countbits_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663302);
			math.NativeMethodInfoPtr_countbits_Public_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663303);
			math.NativeMethodInfoPtr_lzcnt_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663304);
			math.NativeMethodInfoPtr_lzcnt_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663305);
			math.NativeMethodInfoPtr_tzcnt_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663306);
			math.NativeMethodInfoPtr_tzcnt_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663307);
			math.NativeMethodInfoPtr_ceilpow2_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663308);
			math.NativeMethodInfoPtr_ceilpow2_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663309);
			math.NativeMethodInfoPtr_csum_Public_Static_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663310);
			math.NativeMethodInfoPtr_csum_Public_Static_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663311);
			math.NativeMethodInfoPtr_uint2_Public_Static_uint2_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663312);
			math.NativeMethodInfoPtr_hash_Public_Static_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663313);
			math.NativeMethodInfoPtr_uint4_Public_Static_uint4_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663314);
			math.NativeMethodInfoPtr_hash_Public_Static_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663315);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022F8 File Offset: 0x000004F8
		[CallerCount(0)]
		public unsafe static int min(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_min_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002344 File Offset: 0x00000544
		[CallerCount(0)]
		public unsafe static long min(long x, long y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_min_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002390 File Offset: 0x00000590
		[CallerCount(0)]
		public unsafe static int max(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_max_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023DC File Offset: 0x000005DC
		[CallerCount(0)]
		public unsafe static long max(long x, long y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_max_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002428 File Offset: 0x00000628
		[CallerCount(0)]
		public unsafe static int countbits(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_countbits_Public_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002468 File Offset: 0x00000668
		[CallerCount(0)]
		public unsafe static int countbits(long x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_countbits_Public_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024A8 File Offset: 0x000006A8
		[CallerCount(0)]
		public unsafe static int lzcnt(int x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_lzcnt_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000024E8 File Offset: 0x000006E8
		[CallerCount(0)]
		public unsafe static int lzcnt(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_lzcnt_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002528 File Offset: 0x00000728
		[CallerCount(0)]
		public unsafe static int tzcnt(int x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_tzcnt_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002568 File Offset: 0x00000768
		[CallerCount(0)]
		public unsafe static int tzcnt(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_tzcnt_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000025A8 File Offset: 0x000007A8
		[CallerCount(0)]
		public unsafe static int ceilpow2(int x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_ceilpow2_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000025E8 File Offset: 0x000007E8
		[CallerCount(0)]
		public unsafe static long ceilpow2(long x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_ceilpow2_Public_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002628 File Offset: 0x00000828
		[CallerCount(0)]
		public unsafe static uint csum(uint2 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_csum_Public_Static_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002668 File Offset: 0x00000868
		[CallerCount(0)]
		public unsafe static uint csum(uint4 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_csum_Public_Static_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000026A8 File Offset: 0x000008A8
		[CallerCount(0)]
		public unsafe static uint2 uint2(uint x, uint y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_uint2_Public_Static_uint2_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000026F4 File Offset: 0x000008F4
		[CallerCount(0)]
		public unsafe static uint hash(uint2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_hash_Public_Static_UInt32_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002734 File Offset: 0x00000934
		[CallerCount(0)]
		public unsafe static uint4 uint4(uint x, uint y, uint z, uint w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_uint4_Public_Static_uint4_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000279C File Offset: 0x0000099C
		[CallerCount(0)]
		public unsafe static uint hash(uint4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(math.NativeMethodInfoPtr_hash_Public_Static_UInt32_uint4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002092 File Offset: 0x00000292
		public math(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_min_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_min_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_max_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_max_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_countbits_Public_Static_Int32_UInt64_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_countbits_Public_Static_Int32_Int64_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_lzcnt_Public_Static_Int32_Int32_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_lzcnt_Public_Static_Int32_UInt32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_tzcnt_Public_Static_Int32_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_tzcnt_Public_Static_Int32_UInt32_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_ceilpow2_Public_Static_Int32_Int32_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_ceilpow2_Public_Static_Int64_Int64_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_csum_Public_Static_UInt32_uint2_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_csum_Public_Static_UInt32_uint4_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_uint2_Public_Static_uint2_UInt32_UInt32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_uint2_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_uint4_Public_Static_uint4_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_uint4_0;

		// Token: 0x02000006 RID: 6
		[StructLayout(2)]
		public struct LongDoubleUnion
		{
			// Token: 0x0600002A RID: 42 RVA: 0x00002D60 File Offset: 0x00000F60
			// Note: this type is marked as 'beforefieldinit'.
			static LongDoubleUnion()
			{
				Il2CppClassPointerStore<math.LongDoubleUnion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<math>.NativeClassPtr, "LongDoubleUnion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<math.LongDoubleUnion>.NativeClassPtr);
				math.LongDoubleUnion.NativeFieldInfoPtr_longValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<math.LongDoubleUnion>.NativeClassPtr, "longValue");
				math.LongDoubleUnion.NativeFieldInfoPtr_doubleValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<math.LongDoubleUnion>.NativeClassPtr, "doubleValue");
			}

			// Token: 0x0600002B RID: 43 RVA: 0x000020BF File Offset: 0x000002BF
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<math.LongDoubleUnion>.NativeClassPtr, ref this));
			}

			// Token: 0x0400002E RID: 46
			private static readonly IntPtr NativeFieldInfoPtr_longValue;

			// Token: 0x0400002F RID: 47
			private static readonly IntPtr NativeFieldInfoPtr_doubleValue;

			// Token: 0x04000030 RID: 48
			[FieldOffset(0)]
			public long longValue;

			// Token: 0x04000031 RID: 49
			[FieldOffset(0)]
			public double doubleValue;
		}
	}
}
