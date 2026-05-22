using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002D RID: 45
	public class PlatformEffector2D : Effector2D
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0000427B File Offset: 0x0000247B
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0000428D File Offset: 0x0000248D
		public bool useOneWay
		{
			get
			{
				return PlatformEffector2D.get_useOneWayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useOneWayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x000042A0 File Offset: 0x000024A0
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x000042B2 File Offset: 0x000024B2
		public bool useOneWayGrouping
		{
			get
			{
				return PlatformEffector2D.get_useOneWayGroupingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useOneWayGroupingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x000042C5 File Offset: 0x000024C5
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x000042D7 File Offset: 0x000024D7
		public bool useSideFriction
		{
			get
			{
				return PlatformEffector2D.get_useSideFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useSideFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x000042EA File Offset: 0x000024EA
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x000042FC File Offset: 0x000024FC
		public bool useSideBounce
		{
			get
			{
				return PlatformEffector2D.get_useSideBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useSideBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0000430F File Offset: 0x0000250F
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00004321 File Offset: 0x00002521
		public float surfaceArc
		{
			get
			{
				return PlatformEffector2D.get_surfaceArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_surfaceArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00004334 File Offset: 0x00002534
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00004346 File Offset: 0x00002546
		public float sideArc
		{
			get
			{
				return PlatformEffector2D.get_sideArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_sideArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00004359 File Offset: 0x00002559
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0000436B File Offset: 0x0000256B
		public float rotationalOffset
		{
			get
			{
				return PlatformEffector2D.get_rotationalOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_rotationalOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040002A2 RID: 674
		private static readonly PlatformEffector2D.get_useOneWayDelegate get_useOneWayDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useOneWayDelegate>("UnityEngine.PlatformEffector2D::get_useOneWay");

		// Token: 0x040002A3 RID: 675
		private static readonly PlatformEffector2D.set_useOneWayDelegate set_useOneWayDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useOneWayDelegate>("UnityEngine.PlatformEffector2D::set_useOneWay");

		// Token: 0x040002A4 RID: 676
		private static readonly PlatformEffector2D.get_useOneWayGroupingDelegate get_useOneWayGroupingDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useOneWayGroupingDelegate>("UnityEngine.PlatformEffector2D::get_useOneWayGrouping");

		// Token: 0x040002A5 RID: 677
		private static readonly PlatformEffector2D.set_useOneWayGroupingDelegate set_useOneWayGroupingDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useOneWayGroupingDelegate>("UnityEngine.PlatformEffector2D::set_useOneWayGrouping");

		// Token: 0x040002A6 RID: 678
		private static readonly PlatformEffector2D.get_useSideFrictionDelegate get_useSideFrictionDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useSideFrictionDelegate>("UnityEngine.PlatformEffector2D::get_useSideFriction");

		// Token: 0x040002A7 RID: 679
		private static readonly PlatformEffector2D.set_useSideFrictionDelegate set_useSideFrictionDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useSideFrictionDelegate>("UnityEngine.PlatformEffector2D::set_useSideFriction");

		// Token: 0x040002A8 RID: 680
		private static readonly PlatformEffector2D.get_useSideBounceDelegate get_useSideBounceDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useSideBounceDelegate>("UnityEngine.PlatformEffector2D::get_useSideBounce");

		// Token: 0x040002A9 RID: 681
		private static readonly PlatformEffector2D.set_useSideBounceDelegate set_useSideBounceDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useSideBounceDelegate>("UnityEngine.PlatformEffector2D::set_useSideBounce");

		// Token: 0x040002AA RID: 682
		private static readonly PlatformEffector2D.get_surfaceArcDelegate get_surfaceArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_surfaceArcDelegate>("UnityEngine.PlatformEffector2D::get_surfaceArc");

		// Token: 0x040002AB RID: 683
		private static readonly PlatformEffector2D.set_surfaceArcDelegate set_surfaceArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_surfaceArcDelegate>("UnityEngine.PlatformEffector2D::set_surfaceArc");

		// Token: 0x040002AC RID: 684
		private static readonly PlatformEffector2D.get_sideArcDelegate get_sideArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_sideArcDelegate>("UnityEngine.PlatformEffector2D::get_sideArc");

		// Token: 0x040002AD RID: 685
		private static readonly PlatformEffector2D.set_sideArcDelegate set_sideArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_sideArcDelegate>("UnityEngine.PlatformEffector2D::set_sideArc");

		// Token: 0x040002AE RID: 686
		private static readonly PlatformEffector2D.get_rotationalOffsetDelegate get_rotationalOffsetDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_rotationalOffsetDelegate>("UnityEngine.PlatformEffector2D::get_rotationalOffset");

		// Token: 0x040002AF RID: 687
		private static readonly PlatformEffector2D.set_rotationalOffsetDelegate set_rotationalOffsetDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_rotationalOffsetDelegate>("UnityEngine.PlatformEffector2D::set_rotationalOffset");

		// Token: 0x020001C2 RID: 450
		// (Invoke) Token: 0x0600075A RID: 1882
		private delegate bool get_useOneWayDelegate(IntPtr @this);

		// Token: 0x020001C3 RID: 451
		// (Invoke) Token: 0x0600075C RID: 1884
		private delegate void set_useOneWayDelegate(IntPtr @this, bool value);

		// Token: 0x020001C4 RID: 452
		// (Invoke) Token: 0x0600075E RID: 1886
		private delegate bool get_useOneWayGroupingDelegate(IntPtr @this);

		// Token: 0x020001C5 RID: 453
		// (Invoke) Token: 0x06000760 RID: 1888
		private delegate void set_useOneWayGroupingDelegate(IntPtr @this, bool value);

		// Token: 0x020001C6 RID: 454
		// (Invoke) Token: 0x06000762 RID: 1890
		private delegate bool get_useSideFrictionDelegate(IntPtr @this);

		// Token: 0x020001C7 RID: 455
		// (Invoke) Token: 0x06000764 RID: 1892
		private delegate void set_useSideFrictionDelegate(IntPtr @this, bool value);

		// Token: 0x020001C8 RID: 456
		// (Invoke) Token: 0x06000766 RID: 1894
		private delegate bool get_useSideBounceDelegate(IntPtr @this);

		// Token: 0x020001C9 RID: 457
		// (Invoke) Token: 0x06000768 RID: 1896
		private delegate void set_useSideBounceDelegate(IntPtr @this, bool value);

		// Token: 0x020001CA RID: 458
		// (Invoke) Token: 0x0600076A RID: 1898
		private delegate float get_surfaceArcDelegate(IntPtr @this);

		// Token: 0x020001CB RID: 459
		// (Invoke) Token: 0x0600076C RID: 1900
		private delegate void set_surfaceArcDelegate(IntPtr @this, float value);

		// Token: 0x020001CC RID: 460
		// (Invoke) Token: 0x0600076E RID: 1902
		private delegate float get_sideArcDelegate(IntPtr @this);

		// Token: 0x020001CD RID: 461
		// (Invoke) Token: 0x06000770 RID: 1904
		private delegate void set_sideArcDelegate(IntPtr @this, float value);

		// Token: 0x020001CE RID: 462
		// (Invoke) Token: 0x06000772 RID: 1906
		private delegate float get_rotationalOffsetDelegate(IntPtr @this);

		// Token: 0x020001CF RID: 463
		// (Invoke) Token: 0x06000774 RID: 1908
		private delegate void set_rotationalOffsetDelegate(IntPtr @this, float value);
	}
}
