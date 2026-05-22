using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002B RID: 43
	public class BuoyancyEffector2D : Effector2D
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00004050 File Offset: 0x00002250
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00004062 File Offset: 0x00002262
		public float surfaceLevel
		{
			get
			{
				return BuoyancyEffector2D.get_surfaceLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_surfaceLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00004075 File Offset: 0x00002275
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00004087 File Offset: 0x00002287
		public float density
		{
			get
			{
				return BuoyancyEffector2D.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000409A File Offset: 0x0000229A
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x000040AC File Offset: 0x000022AC
		public float linearDrag
		{
			get
			{
				return BuoyancyEffector2D.get_linearDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_linearDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000040BF File Offset: 0x000022BF
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x000040D1 File Offset: 0x000022D1
		public float angularDrag
		{
			get
			{
				return BuoyancyEffector2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x000040E4 File Offset: 0x000022E4
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x000040F6 File Offset: 0x000022F6
		public float flowAngle
		{
			get
			{
				return BuoyancyEffector2D.get_flowAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_flowAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00004109 File Offset: 0x00002309
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0000411B File Offset: 0x0000231B
		public float flowMagnitude
		{
			get
			{
				return BuoyancyEffector2D.get_flowMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_flowMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000412E File Offset: 0x0000232E
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x00004140 File Offset: 0x00002340
		public float flowVariation
		{
			get
			{
				return BuoyancyEffector2D.get_flowVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_flowVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000284 RID: 644
		private static readonly BuoyancyEffector2D.get_surfaceLevelDelegate get_surfaceLevelDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_surfaceLevelDelegate>("UnityEngine.BuoyancyEffector2D::get_surfaceLevel");

		// Token: 0x04000285 RID: 645
		private static readonly BuoyancyEffector2D.set_surfaceLevelDelegate set_surfaceLevelDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_surfaceLevelDelegate>("UnityEngine.BuoyancyEffector2D::set_surfaceLevel");

		// Token: 0x04000286 RID: 646
		private static readonly BuoyancyEffector2D.get_densityDelegate get_densityDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_densityDelegate>("UnityEngine.BuoyancyEffector2D::get_density");

		// Token: 0x04000287 RID: 647
		private static readonly BuoyancyEffector2D.set_densityDelegate set_densityDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_densityDelegate>("UnityEngine.BuoyancyEffector2D::set_density");

		// Token: 0x04000288 RID: 648
		private static readonly BuoyancyEffector2D.get_linearDragDelegate get_linearDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_linearDragDelegate>("UnityEngine.BuoyancyEffector2D::get_linearDrag");

		// Token: 0x04000289 RID: 649
		private static readonly BuoyancyEffector2D.set_linearDragDelegate set_linearDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_linearDragDelegate>("UnityEngine.BuoyancyEffector2D::set_linearDrag");

		// Token: 0x0400028A RID: 650
		private static readonly BuoyancyEffector2D.get_angularDragDelegate get_angularDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_angularDragDelegate>("UnityEngine.BuoyancyEffector2D::get_angularDrag");

		// Token: 0x0400028B RID: 651
		private static readonly BuoyancyEffector2D.set_angularDragDelegate set_angularDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_angularDragDelegate>("UnityEngine.BuoyancyEffector2D::set_angularDrag");

		// Token: 0x0400028C RID: 652
		private static readonly BuoyancyEffector2D.get_flowAngleDelegate get_flowAngleDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_flowAngleDelegate>("UnityEngine.BuoyancyEffector2D::get_flowAngle");

		// Token: 0x0400028D RID: 653
		private static readonly BuoyancyEffector2D.set_flowAngleDelegate set_flowAngleDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_flowAngleDelegate>("UnityEngine.BuoyancyEffector2D::set_flowAngle");

		// Token: 0x0400028E RID: 654
		private static readonly BuoyancyEffector2D.get_flowMagnitudeDelegate get_flowMagnitudeDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_flowMagnitudeDelegate>("UnityEngine.BuoyancyEffector2D::get_flowMagnitude");

		// Token: 0x0400028F RID: 655
		private static readonly BuoyancyEffector2D.set_flowMagnitudeDelegate set_flowMagnitudeDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_flowMagnitudeDelegate>("UnityEngine.BuoyancyEffector2D::set_flowMagnitude");

		// Token: 0x04000290 RID: 656
		private static readonly BuoyancyEffector2D.get_flowVariationDelegate get_flowVariationDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_flowVariationDelegate>("UnityEngine.BuoyancyEffector2D::get_flowVariation");

		// Token: 0x04000291 RID: 657
		private static readonly BuoyancyEffector2D.set_flowVariationDelegate set_flowVariationDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_flowVariationDelegate>("UnityEngine.BuoyancyEffector2D::set_flowVariation");

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x0600071E RID: 1822
		private delegate float get_surfaceLevelDelegate(IntPtr @this);

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x06000720 RID: 1824
		private delegate void set_surfaceLevelDelegate(IntPtr @this, float value);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x06000722 RID: 1826
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000724 RID: 1828
		private delegate void set_densityDelegate(IntPtr @this, float value);

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06000726 RID: 1830
		private delegate float get_linearDragDelegate(IntPtr @this);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x06000728 RID: 1832
		private delegate void set_linearDragDelegate(IntPtr @this, float value);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x0600072A RID: 1834
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020001AB RID: 427
		// (Invoke) Token: 0x0600072C RID: 1836
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020001AC RID: 428
		// (Invoke) Token: 0x0600072E RID: 1838
		private delegate float get_flowAngleDelegate(IntPtr @this);

		// Token: 0x020001AD RID: 429
		// (Invoke) Token: 0x06000730 RID: 1840
		private delegate void set_flowAngleDelegate(IntPtr @this, float value);

		// Token: 0x020001AE RID: 430
		// (Invoke) Token: 0x06000732 RID: 1842
		private delegate float get_flowMagnitudeDelegate(IntPtr @this);

		// Token: 0x020001AF RID: 431
		// (Invoke) Token: 0x06000734 RID: 1844
		private delegate void set_flowMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x020001B0 RID: 432
		// (Invoke) Token: 0x06000736 RID: 1846
		private delegate float get_flowVariationDelegate(IntPtr @this);

		// Token: 0x020001B1 RID: 433
		// (Invoke) Token: 0x06000738 RID: 1848
		private delegate void set_flowVariationDelegate(IntPtr @this, float value);
	}
}
