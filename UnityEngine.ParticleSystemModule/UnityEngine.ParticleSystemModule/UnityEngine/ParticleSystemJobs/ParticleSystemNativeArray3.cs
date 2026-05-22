using System;
using Unity.Collections;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x02000039 RID: 57
	public struct ParticleSystemNativeArray3
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004E34 File Offset: 0x00003034
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000029C5 File Offset: 0x00000BC5
		public Vector3 Item
		{
			get
			{
				return new Vector3(this.x[index], this.y[index], this.z[index]);
			}
			set
			{
				this.x[index] = value.x;
				this.y[index] = value.y;
				this.z[index] = value.z;
			}
		}

		// Token: 0x0400018B RID: 395
		public NativeArray<float> x;

		// Token: 0x0400018C RID: 396
		public NativeArray<float> y;

		// Token: 0x0400018D RID: 397
		public NativeArray<float> z;
	}
}
