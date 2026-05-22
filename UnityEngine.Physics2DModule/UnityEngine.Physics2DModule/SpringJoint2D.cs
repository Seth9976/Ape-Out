using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000021 RID: 33
	public sealed class SpringJoint2D : AnchoredJoint2D
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00003951 File Offset: 0x00001B51
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00003963 File Offset: 0x00001B63
		public bool autoConfigureDistance
		{
			get
			{
				return SpringJoint2D.get_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00003976 File Offset: 0x00001B76
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00003988 File Offset: 0x00001B88
		public float distance
		{
			get
			{
				return SpringJoint2D.get_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000399B File Offset: 0x00001B9B
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000039AD File Offset: 0x00001BAD
		public float dampingRatio
		{
			get
			{
				return SpringJoint2D.get_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000039D2 File Offset: 0x00001BD2
		public float frequency
		{
			get
			{
				return SpringJoint2D.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000228 RID: 552
		private static readonly SpringJoint2D.get_autoConfigureDistanceDelegate get_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_autoConfigureDistanceDelegate>("UnityEngine.SpringJoint2D::get_autoConfigureDistance");

		// Token: 0x04000229 RID: 553
		private static readonly SpringJoint2D.set_autoConfigureDistanceDelegate set_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_autoConfigureDistanceDelegate>("UnityEngine.SpringJoint2D::set_autoConfigureDistance");

		// Token: 0x0400022A RID: 554
		private static readonly SpringJoint2D.get_distanceDelegate get_distanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_distanceDelegate>("UnityEngine.SpringJoint2D::get_distance");

		// Token: 0x0400022B RID: 555
		private static readonly SpringJoint2D.set_distanceDelegate set_distanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_distanceDelegate>("UnityEngine.SpringJoint2D::set_distance");

		// Token: 0x0400022C RID: 556
		private static readonly SpringJoint2D.get_dampingRatioDelegate get_dampingRatioDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_dampingRatioDelegate>("UnityEngine.SpringJoint2D::get_dampingRatio");

		// Token: 0x0400022D RID: 557
		private static readonly SpringJoint2D.set_dampingRatioDelegate set_dampingRatioDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_dampingRatioDelegate>("UnityEngine.SpringJoint2D::set_dampingRatio");

		// Token: 0x0400022E RID: 558
		private static readonly SpringJoint2D.get_frequencyDelegate get_frequencyDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_frequencyDelegate>("UnityEngine.SpringJoint2D::get_frequency");

		// Token: 0x0400022F RID: 559
		private static readonly SpringJoint2D.set_frequencyDelegate set_frequencyDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_frequencyDelegate>("UnityEngine.SpringJoint2D::set_frequency");

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x06000666 RID: 1638
		private delegate bool get_autoConfigureDistanceDelegate(IntPtr @this);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x06000668 RID: 1640
		private delegate void set_autoConfigureDistanceDelegate(IntPtr @this, bool value);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x0600066A RID: 1642
		private delegate float get_distanceDelegate(IntPtr @this);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x0600066C RID: 1644
		private delegate void set_distanceDelegate(IntPtr @this, float value);

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x0600066E RID: 1646
		private delegate float get_dampingRatioDelegate(IntPtr @this);

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x06000670 RID: 1648
		private delegate void set_dampingRatioDelegate(IntPtr @this, float value);

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x06000672 RID: 1650
		private delegate float get_frequencyDelegate(IntPtr @this);

		// Token: 0x0200014F RID: 335
		// (Invoke) Token: 0x06000674 RID: 1652
		private delegate void set_frequencyDelegate(IntPtr @this, float value);
	}
}
