using System;
using Unity.Collections;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x0200003A RID: 58
	public struct ParticleSystemNativeArray4
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00004E70 File Offset: 0x00003070
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00004EB8 File Offset: 0x000030B8
		public Vector4 Item
		{
			get
			{
				return new Vector4(this.x[index], this.y[index], this.z[index], this.w[index]);
			}
			set
			{
				this.x[index] = value.x;
				this.y[index] = value.y;
				this.z[index] = value.z;
				this.w[index] = value.w;
			}
		}

		// Token: 0x0400018E RID: 398
		public NativeArray<float> x;

		// Token: 0x0400018F RID: 399
		public NativeArray<float> y;

		// Token: 0x04000190 RID: 400
		public NativeArray<float> z;

		// Token: 0x04000191 RID: 401
		public NativeArray<float> w;
	}
}
