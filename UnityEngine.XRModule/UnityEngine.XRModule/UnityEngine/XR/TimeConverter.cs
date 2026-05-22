using System;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x0200001F RID: 31
	public static class TimeConverter
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000593C File Offset: 0x00003B3C
		public static DateTime now
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002D2A File Offset: 0x00000F2A
		public static long LocalDateTimeToUnixTimeMilliseconds(DateTime date)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002D37 File Offset: 0x00000F37
		public static DateTime UnixTimeMillisecondsToLocalDateTime(long unixTimeInMilliseconds)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
