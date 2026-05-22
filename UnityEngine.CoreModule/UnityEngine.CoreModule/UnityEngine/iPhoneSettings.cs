using System;

namespace UnityEngine
{
	// Token: 0x02000267 RID: 615
	public class iPhoneSettings
	{
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x00077894 File Offset: 0x00075A94
		public static bool verticalOrientation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x000778A8 File Offset: 0x00075AA8
		public static bool screenCanDarken
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x000120EF File Offset: 0x000102EF
		public static void StartLocationServiceUpdates(float desiredAccuracyInMeters, float updateDistanceInMeters)
		{
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000120F2 File Offset: 0x000102F2
		public static void StartLocationServiceUpdates(float desiredAccuracyInMeters)
		{
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000120F5 File Offset: 0x000102F5
		public static void StartLocationServiceUpdates()
		{
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000120F8 File Offset: 0x000102F8
		public static void StopLocationServiceUpdates()
		{
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x000778BC File Offset: 0x00075ABC
		public static bool locationServiceEnabledByUser
		{
			get
			{
				return false;
			}
		}
	}
}
