using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000169 RID: 361
	public class BestFitAllocator
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x000079F7 File Offset: 0x00005BF7
		public uint totalSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00007A04 File Offset: 0x00005C04
		public uint highWatermark
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00007A11 File Offset: 0x00005C11
		public BestFitAllocator.Block CoalesceBlockWithPrevious(BestFitAllocator.Block block)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00007A1E File Offset: 0x00005C1E
		public BestFitAllocator.Block BestFitFindAvailableBlock(uint size)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00007A2B File Offset: 0x00005C2B
		public void SplitBlock(BestFitAllocator.Block block, uint size)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000216 RID: 534
		public class Block : PoolItem
		{
		}
	}
}
