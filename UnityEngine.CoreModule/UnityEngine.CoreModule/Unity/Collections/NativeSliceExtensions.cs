using System;

namespace Unity.Collections
{
	// Token: 0x020001D1 RID: 465
	public static class NativeSliceExtensions
	{
		// Token: 0x06001FFF RID: 8191 RVA: 0x000740B8 File Offset: 0x000722B8
		public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray) where T : struct
		{
			return new NativeSlice<T>(thisArray);
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x000740D0 File Offset: 0x000722D0
		public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray, int start) where T : struct
		{
			return new NativeSlice<T>(thisArray, start);
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x000740EC File Offset: 0x000722EC
		public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray, int start, int length) where T : struct
		{
			return new NativeSlice<T>(thisArray, start, length);
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00074108 File Offset: 0x00072308
		public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice) where T : struct
		{
			return thisSlice;
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x0007411C File Offset: 0x0007231C
		public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice, int start) where T : struct
		{
			return new NativeSlice<T>(thisSlice, start);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00074138 File Offset: 0x00072338
		public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice, int start, int length) where T : struct
		{
			return new NativeSlice<T>(thisSlice, start, length);
		}
	}
}
