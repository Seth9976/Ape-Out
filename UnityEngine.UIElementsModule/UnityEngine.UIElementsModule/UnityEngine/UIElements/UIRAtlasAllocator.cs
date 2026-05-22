using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010A RID: 266
	public class UIRAtlasAllocator
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00006216 File Offset: 0x00004416
		public int maxAtlasSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00006223 File Offset: 0x00004423
		public int maxImageWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00006230 File Offset: 0x00004430
		public int maxImageHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0000623D File Offset: 0x0000443D
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x0000624A File Offset: 0x0000444A
		public int virtualWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00006257 File Offset: 0x00004457
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00006264 File Offset: 0x00004464
		public int virtualHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00006271 File Offset: 0x00004471
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x0000627E File Offset: 0x0000447E
		public int physicalWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0000628B File Offset: 0x0000448B
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00006298 File Offset: 0x00004498
		public int physicalHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x000062A5 File Offset: 0x000044A5
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x000062B2 File Offset: 0x000044B2
		public bool disposed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000062BF File Offset: 0x000044BF
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000062D1 File Offset: 0x000044D1
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000C380 File Offset: 0x0000A580
		public static int GetLog2OfNextPower(int n)
		{
			float num = (float)Mathf.NextPowerOfTwo(n);
			float num2 = Mathf.Log(num, 2f);
			return Mathf.RoundToInt(num2);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000062DE File Offset: 0x000044DE
		public bool TryAllocate(int width, int height, out RectInt location)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000062EB File Offset: 0x000044EB
		public bool TryPartitionArea(UIRAtlasAllocator.AreaNode areaNode, int rowIndex, int rowHeight, int minWidth)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000062F8 File Offset: 0x000044F8
		public void BuildAreas()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001F6 RID: 502
		public class Row
		{
		}

		// Token: 0x020001F7 RID: 503
		public class AreaNode
		{
		}
	}
}
