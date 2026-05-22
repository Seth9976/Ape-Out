using System;

namespace UnityEngine.Yoga
{
	// Token: 0x0200000C RID: 12
	public class YogaConfig
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00002B56 File Offset: 0x00000D56
		public override void Finalize()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00002B63 File Offset: 0x00000D63
		public IntPtr Handle
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002B70 File Offset: 0x00000D70
		public void SetExperimentalFeatureEnabled(YogaExperimentalFeature feature, bool enabled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002B7D File Offset: 0x00000D7D
		public bool IsExperimentalFeatureEnabled(YogaExperimentalFeature feature)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002B8A File Offset: 0x00000D8A
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002B97 File Offset: 0x00000D97
		public bool UseWebDefaults
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002BA4 File Offset: 0x00000DA4
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002BB1 File Offset: 0x00000DB1
		public float PointScaleFactor
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

		// Token: 0x06000132 RID: 306 RVA: 0x0000489C File Offset: 0x00002A9C
		public static int GetInstanceCount()
		{
			return Native.YGConfigGetInstanceCount();
		}
	}
}
