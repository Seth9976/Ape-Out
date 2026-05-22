using System;

namespace UnityEngine
{
	// Token: 0x02000240 RID: 576
	public static class HashUnsafeUtilities
	{
		// Token: 0x06002196 RID: 8598 RVA: 0x00011D08 File Offset: 0x0000FF08
		public unsafe static void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2)
		{
			SpookyHash.Hash(data, dataSize, hash1, hash2);
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x0007642C File Offset: 0x0007462C
		public unsafe static void ComputeHash128(void* data, ulong dataSize, Hash128* hash)
		{
			ulong u64_ = hash->u64_0;
			ulong u64_2 = hash->u64_1;
			HashUnsafeUtilities.ComputeHash128(data, dataSize, &u64_, &u64_2);
			*hash = new Hash128(u64_, u64_2);
		}
	}
}
