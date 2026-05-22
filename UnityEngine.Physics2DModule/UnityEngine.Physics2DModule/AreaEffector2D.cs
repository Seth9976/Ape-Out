using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002A RID: 42
	public class AreaEffector2D : Effector2D
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00003F4D File Offset: 0x0000214D
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00003F5F File Offset: 0x0000215F
		public float forceAngle
		{
			get
			{
				return AreaEffector2D.get_forceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00003F72 File Offset: 0x00002172
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00003F84 File Offset: 0x00002184
		public bool useGlobalAngle
		{
			get
			{
				return AreaEffector2D.get_useGlobalAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_useGlobalAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00003F97 File Offset: 0x00002197
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00003FA9 File Offset: 0x000021A9
		public float forceMagnitude
		{
			get
			{
				return AreaEffector2D.get_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00003FBC File Offset: 0x000021BC
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003FCE File Offset: 0x000021CE
		public float forceVariation
		{
			get
			{
				return AreaEffector2D.get_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00003FE1 File Offset: 0x000021E1
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003FF3 File Offset: 0x000021F3
		public float drag
		{
			get
			{
				return AreaEffector2D.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00004006 File Offset: 0x00002206
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00004018 File Offset: 0x00002218
		public float angularDrag
		{
			get
			{
				return AreaEffector2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000402B File Offset: 0x0000222B
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0000403D File Offset: 0x0000223D
		public EffectorSelection2D forceTarget
		{
			get
			{
				return AreaEffector2D.get_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000276 RID: 630
		private static readonly AreaEffector2D.get_forceAngleDelegate get_forceAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceAngleDelegate>("UnityEngine.AreaEffector2D::get_forceAngle");

		// Token: 0x04000277 RID: 631
		private static readonly AreaEffector2D.set_forceAngleDelegate set_forceAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceAngleDelegate>("UnityEngine.AreaEffector2D::set_forceAngle");

		// Token: 0x04000278 RID: 632
		private static readonly AreaEffector2D.get_useGlobalAngleDelegate get_useGlobalAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_useGlobalAngleDelegate>("UnityEngine.AreaEffector2D::get_useGlobalAngle");

		// Token: 0x04000279 RID: 633
		private static readonly AreaEffector2D.set_useGlobalAngleDelegate set_useGlobalAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_useGlobalAngleDelegate>("UnityEngine.AreaEffector2D::set_useGlobalAngle");

		// Token: 0x0400027A RID: 634
		private static readonly AreaEffector2D.get_forceMagnitudeDelegate get_forceMagnitudeDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceMagnitudeDelegate>("UnityEngine.AreaEffector2D::get_forceMagnitude");

		// Token: 0x0400027B RID: 635
		private static readonly AreaEffector2D.set_forceMagnitudeDelegate set_forceMagnitudeDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceMagnitudeDelegate>("UnityEngine.AreaEffector2D::set_forceMagnitude");

		// Token: 0x0400027C RID: 636
		private static readonly AreaEffector2D.get_forceVariationDelegate get_forceVariationDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceVariationDelegate>("UnityEngine.AreaEffector2D::get_forceVariation");

		// Token: 0x0400027D RID: 637
		private static readonly AreaEffector2D.set_forceVariationDelegate set_forceVariationDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceVariationDelegate>("UnityEngine.AreaEffector2D::set_forceVariation");

		// Token: 0x0400027E RID: 638
		private static readonly AreaEffector2D.get_dragDelegate get_dragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_dragDelegate>("UnityEngine.AreaEffector2D::get_drag");

		// Token: 0x0400027F RID: 639
		private static readonly AreaEffector2D.set_dragDelegate set_dragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_dragDelegate>("UnityEngine.AreaEffector2D::set_drag");

		// Token: 0x04000280 RID: 640
		private static readonly AreaEffector2D.get_angularDragDelegate get_angularDragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_angularDragDelegate>("UnityEngine.AreaEffector2D::get_angularDrag");

		// Token: 0x04000281 RID: 641
		private static readonly AreaEffector2D.set_angularDragDelegate set_angularDragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_angularDragDelegate>("UnityEngine.AreaEffector2D::set_angularDrag");

		// Token: 0x04000282 RID: 642
		private static readonly AreaEffector2D.get_forceTargetDelegate get_forceTargetDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceTargetDelegate>("UnityEngine.AreaEffector2D::get_forceTarget");

		// Token: 0x04000283 RID: 643
		private static readonly AreaEffector2D.set_forceTargetDelegate set_forceTargetDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceTargetDelegate>("UnityEngine.AreaEffector2D::set_forceTarget");

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x06000702 RID: 1794
		private delegate float get_forceAngleDelegate(IntPtr @this);

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x06000704 RID: 1796
		private delegate void set_forceAngleDelegate(IntPtr @this, float value);

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x06000706 RID: 1798
		private delegate bool get_useGlobalAngleDelegate(IntPtr @this);

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x06000708 RID: 1800
		private delegate void set_useGlobalAngleDelegate(IntPtr @this, bool value);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x0600070A RID: 1802
		private delegate float get_forceMagnitudeDelegate(IntPtr @this);

		// Token: 0x0200019B RID: 411
		// (Invoke) Token: 0x0600070C RID: 1804
		private delegate void set_forceMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x0200019C RID: 412
		// (Invoke) Token: 0x0600070E RID: 1806
		private delegate float get_forceVariationDelegate(IntPtr @this);

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x06000710 RID: 1808
		private delegate void set_forceVariationDelegate(IntPtr @this, float value);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x06000712 RID: 1810
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000714 RID: 1812
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x06000716 RID: 1814
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x06000718 RID: 1816
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x0600071A RID: 1818
		private delegate EffectorSelection2D get_forceTargetDelegate(IntPtr @this);

		// Token: 0x020001A3 RID: 419
		// (Invoke) Token: 0x0600071C RID: 1820
		private delegate void set_forceTargetDelegate(IntPtr @this, EffectorSelection2D value);
	}
}
