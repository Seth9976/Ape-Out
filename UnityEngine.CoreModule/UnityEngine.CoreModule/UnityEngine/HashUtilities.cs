using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x0200023F RID: 575
	public static class HashUtilities
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x00076318 File Offset: 0x00074518
		public unsafe static void AppendHash(ref Hash128 inHash, ref Hash128 outHash)
		{
			fixed (Hash128* ptr = &outHash)
			{
				Hash128* ptr2 = ptr;
				fixed (Hash128* ptr3 = &inHash)
				{
					Hash128* ptr4 = ptr3;
					HashUnsafeUtilities.ComputeHash128((void*)ptr4, (ulong)((long)sizeof(Hash128)), ptr2);
				}
			}
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x0007634C File Offset: 0x0007454C
		public unsafe static void QuantisedMatrixHash(ref Matrix4x4 value, ref Hash128 hash)
		{
			fixed (Hash128* ptr = &hash)
			{
				Hash128* ptr2 = ptr;
				int* ptr3 = stackalloc int[(UIntPtr)64];
				for (int i = 0; i < 16; i++)
				{
					ptr3[i] = (int)(value[i] * 1000f + 0.5f);
				}
				HashUnsafeUtilities.ComputeHash128((void*)ptr3, 64UL, ptr2);
			}
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x000763A8 File Offset: 0x000745A8
		public unsafe static void QuantisedVectorHash(ref Vector3 value, ref Hash128 hash)
		{
			fixed (Hash128* ptr = &hash)
			{
				Hash128* ptr2 = ptr;
				int* ptr3 = stackalloc int[(UIntPtr)12];
				for (int i = 0; i < 3; i++)
				{
					ptr3[i] = (int)(value[i] * 1000f + 0.5f);
				}
				HashUnsafeUtilities.ComputeHash128((void*)ptr3, 12UL, ptr2);
			}
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00076400 File Offset: 0x00074600
		public unsafe static void ComputeHash128<T>(ref T value, ref Hash128 hash) where T : struct
		{
			void* ptr = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref value);
			ulong num = (ulong)((long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
			Hash128* ptr2 = (Hash128*)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<Hash128>(ref hash);
			HashUnsafeUtilities.ComputeHash128(ptr, num, ptr2);
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00011CFB File Offset: 0x0000FEFB
		public static void ComputeHash128(Il2CppStructArray<byte> value, ref Hash128 hash)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
