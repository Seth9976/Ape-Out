using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000027 RID: 39
	public sealed class FixedJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00003DF1 File Offset: 0x00001FF1
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003E03 File Offset: 0x00002003
		public float dampingRatio
		{
			get
			{
				return FixedJoint2D.get_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FixedJoint2D.set_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00003E16 File Offset: 0x00002016
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003E28 File Offset: 0x00002028
		public float frequency
		{
			get
			{
				return FixedJoint2D.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FixedJoint2D.set_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00003E3B File Offset: 0x0000203B
		public float referenceAngle
		{
			get
			{
				return FixedJoint2D.get_referenceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000263 RID: 611
		private static readonly FixedJoint2D.get_dampingRatioDelegate get_dampingRatioDelegateField = IL2CPP.ResolveICall<FixedJoint2D.get_dampingRatioDelegate>("UnityEngine.FixedJoint2D::get_dampingRatio");

		// Token: 0x04000264 RID: 612
		private static readonly FixedJoint2D.set_dampingRatioDelegate set_dampingRatioDelegateField = IL2CPP.ResolveICall<FixedJoint2D.set_dampingRatioDelegate>("UnityEngine.FixedJoint2D::set_dampingRatio");

		// Token: 0x04000265 RID: 613
		private static readonly FixedJoint2D.get_frequencyDelegate get_frequencyDelegateField = IL2CPP.ResolveICall<FixedJoint2D.get_frequencyDelegate>("UnityEngine.FixedJoint2D::get_frequency");

		// Token: 0x04000266 RID: 614
		private static readonly FixedJoint2D.set_frequencyDelegate set_frequencyDelegateField = IL2CPP.ResolveICall<FixedJoint2D.set_frequencyDelegate>("UnityEngine.FixedJoint2D::set_frequency");

		// Token: 0x04000267 RID: 615
		private static readonly FixedJoint2D.get_referenceAngleDelegate get_referenceAngleDelegateField = IL2CPP.ResolveICall<FixedJoint2D.get_referenceAngleDelegate>("UnityEngine.FixedJoint2D::get_referenceAngle");

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x060006DC RID: 1756
		private delegate float get_dampingRatioDelegate(IntPtr @this);

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x060006DE RID: 1758
		private delegate void set_dampingRatioDelegate(IntPtr @this, float value);

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x060006E0 RID: 1760
		private delegate float get_frequencyDelegate(IntPtr @this);

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x060006E2 RID: 1762
		private delegate void set_frequencyDelegate(IntPtr @this, float value);

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x060006E4 RID: 1764
		private delegate float get_referenceAngleDelegate(IntPtr @this);
	}
}
