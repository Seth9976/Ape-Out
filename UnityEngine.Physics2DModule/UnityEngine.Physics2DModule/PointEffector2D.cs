using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002C RID: 44
	public class PointEffector2D : Effector2D
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00004153 File Offset: 0x00002353
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00004165 File Offset: 0x00002365
		public float forceMagnitude
		{
			get
			{
				return PointEffector2D.get_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00004178 File Offset: 0x00002378
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x0000418A File Offset: 0x0000238A
		public float forceVariation
		{
			get
			{
				return PointEffector2D.get_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0000419D File Offset: 0x0000239D
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x000041AF File Offset: 0x000023AF
		public float distanceScale
		{
			get
			{
				return PointEffector2D.get_distanceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_distanceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x000041C2 File Offset: 0x000023C2
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x000041D4 File Offset: 0x000023D4
		public float drag
		{
			get
			{
				return PointEffector2D.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x000041E7 File Offset: 0x000023E7
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x000041F9 File Offset: 0x000023F9
		public float angularDrag
		{
			get
			{
				return PointEffector2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0000420C File Offset: 0x0000240C
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0000421E File Offset: 0x0000241E
		public EffectorSelection2D forceSource
		{
			get
			{
				return PointEffector2D.get_forceSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00004231 File Offset: 0x00002431
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00004243 File Offset: 0x00002443
		public EffectorSelection2D forceTarget
		{
			get
			{
				return PointEffector2D.get_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00004256 File Offset: 0x00002456
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00004268 File Offset: 0x00002468
		public EffectorForceMode2D forceMode
		{
			get
			{
				return PointEffector2D.get_forceModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000292 RID: 658
		private static readonly PointEffector2D.get_forceMagnitudeDelegate get_forceMagnitudeDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceMagnitudeDelegate>("UnityEngine.PointEffector2D::get_forceMagnitude");

		// Token: 0x04000293 RID: 659
		private static readonly PointEffector2D.set_forceMagnitudeDelegate set_forceMagnitudeDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceMagnitudeDelegate>("UnityEngine.PointEffector2D::set_forceMagnitude");

		// Token: 0x04000294 RID: 660
		private static readonly PointEffector2D.get_forceVariationDelegate get_forceVariationDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceVariationDelegate>("UnityEngine.PointEffector2D::get_forceVariation");

		// Token: 0x04000295 RID: 661
		private static readonly PointEffector2D.set_forceVariationDelegate set_forceVariationDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceVariationDelegate>("UnityEngine.PointEffector2D::set_forceVariation");

		// Token: 0x04000296 RID: 662
		private static readonly PointEffector2D.get_distanceScaleDelegate get_distanceScaleDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_distanceScaleDelegate>("UnityEngine.PointEffector2D::get_distanceScale");

		// Token: 0x04000297 RID: 663
		private static readonly PointEffector2D.set_distanceScaleDelegate set_distanceScaleDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_distanceScaleDelegate>("UnityEngine.PointEffector2D::set_distanceScale");

		// Token: 0x04000298 RID: 664
		private static readonly PointEffector2D.get_dragDelegate get_dragDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_dragDelegate>("UnityEngine.PointEffector2D::get_drag");

		// Token: 0x04000299 RID: 665
		private static readonly PointEffector2D.set_dragDelegate set_dragDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_dragDelegate>("UnityEngine.PointEffector2D::set_drag");

		// Token: 0x0400029A RID: 666
		private static readonly PointEffector2D.get_angularDragDelegate get_angularDragDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_angularDragDelegate>("UnityEngine.PointEffector2D::get_angularDrag");

		// Token: 0x0400029B RID: 667
		private static readonly PointEffector2D.set_angularDragDelegate set_angularDragDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_angularDragDelegate>("UnityEngine.PointEffector2D::set_angularDrag");

		// Token: 0x0400029C RID: 668
		private static readonly PointEffector2D.get_forceSourceDelegate get_forceSourceDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceSourceDelegate>("UnityEngine.PointEffector2D::get_forceSource");

		// Token: 0x0400029D RID: 669
		private static readonly PointEffector2D.set_forceSourceDelegate set_forceSourceDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceSourceDelegate>("UnityEngine.PointEffector2D::set_forceSource");

		// Token: 0x0400029E RID: 670
		private static readonly PointEffector2D.get_forceTargetDelegate get_forceTargetDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceTargetDelegate>("UnityEngine.PointEffector2D::get_forceTarget");

		// Token: 0x0400029F RID: 671
		private static readonly PointEffector2D.set_forceTargetDelegate set_forceTargetDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceTargetDelegate>("UnityEngine.PointEffector2D::set_forceTarget");

		// Token: 0x040002A0 RID: 672
		private static readonly PointEffector2D.get_forceModeDelegate get_forceModeDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceModeDelegate>("UnityEngine.PointEffector2D::get_forceMode");

		// Token: 0x040002A1 RID: 673
		private static readonly PointEffector2D.set_forceModeDelegate set_forceModeDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceModeDelegate>("UnityEngine.PointEffector2D::set_forceMode");

		// Token: 0x020001B2 RID: 434
		// (Invoke) Token: 0x0600073A RID: 1850
		private delegate float get_forceMagnitudeDelegate(IntPtr @this);

		// Token: 0x020001B3 RID: 435
		// (Invoke) Token: 0x0600073C RID: 1852
		private delegate void set_forceMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x020001B4 RID: 436
		// (Invoke) Token: 0x0600073E RID: 1854
		private delegate float get_forceVariationDelegate(IntPtr @this);

		// Token: 0x020001B5 RID: 437
		// (Invoke) Token: 0x06000740 RID: 1856
		private delegate void set_forceVariationDelegate(IntPtr @this, float value);

		// Token: 0x020001B6 RID: 438
		// (Invoke) Token: 0x06000742 RID: 1858
		private delegate float get_distanceScaleDelegate(IntPtr @this);

		// Token: 0x020001B7 RID: 439
		// (Invoke) Token: 0x06000744 RID: 1860
		private delegate void set_distanceScaleDelegate(IntPtr @this, float value);

		// Token: 0x020001B8 RID: 440
		// (Invoke) Token: 0x06000746 RID: 1862
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x020001B9 RID: 441
		// (Invoke) Token: 0x06000748 RID: 1864
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x020001BA RID: 442
		// (Invoke) Token: 0x0600074A RID: 1866
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020001BB RID: 443
		// (Invoke) Token: 0x0600074C RID: 1868
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020001BC RID: 444
		// (Invoke) Token: 0x0600074E RID: 1870
		private delegate EffectorSelection2D get_forceSourceDelegate(IntPtr @this);

		// Token: 0x020001BD RID: 445
		// (Invoke) Token: 0x06000750 RID: 1872
		private delegate void set_forceSourceDelegate(IntPtr @this, EffectorSelection2D value);

		// Token: 0x020001BE RID: 446
		// (Invoke) Token: 0x06000752 RID: 1874
		private delegate EffectorSelection2D get_forceTargetDelegate(IntPtr @this);

		// Token: 0x020001BF RID: 447
		// (Invoke) Token: 0x06000754 RID: 1876
		private delegate void set_forceTargetDelegate(IntPtr @this, EffectorSelection2D value);

		// Token: 0x020001C0 RID: 448
		// (Invoke) Token: 0x06000756 RID: 1878
		private delegate EffectorForceMode2D get_forceModeDelegate(IntPtr @this);

		// Token: 0x020001C1 RID: 449
		// (Invoke) Token: 0x06000758 RID: 1880
		private delegate void set_forceModeDelegate(IntPtr @this, EffectorForceMode2D value);
	}
}
