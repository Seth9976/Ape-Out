using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000026 RID: 38
	public sealed class TargetJoint2D : Joint2D
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000DB30 File Offset: 0x0000BD30
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00003CFD File Offset: 0x00001EFD
		public Vector2 anchor
		{
			get
			{
				Vector2 vector;
				this.get_anchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchor_Injected(ref value);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000DB48 File Offset: 0x0000BD48
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003D07 File Offset: 0x00001F07
		public Vector2 target
		{
			get
			{
				Vector2 vector;
				this.get_target_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_target_Injected(ref value);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00003D11 File Offset: 0x00001F11
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003D23 File Offset: 0x00001F23
		public bool autoConfigureTarget
		{
			get
			{
				return TargetJoint2D.get_autoConfigureTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_autoConfigureTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00003D36 File Offset: 0x00001F36
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00003D48 File Offset: 0x00001F48
		public float maxForce
		{
			get
			{
				return TargetJoint2D.get_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00003D5B File Offset: 0x00001F5B
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00003D6D File Offset: 0x00001F6D
		public float dampingRatio
		{
			get
			{
				return TargetJoint2D.get_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00003D80 File Offset: 0x00001F80
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00003D92 File Offset: 0x00001F92
		public float frequency
		{
			get
			{
				return TargetJoint2D.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00003DA5 File Offset: 0x00001FA5
		public void get_anchor_Injected(out Vector2 ret)
		{
			TargetJoint2D.get_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00003DB8 File Offset: 0x00001FB8
		public void set_anchor_Injected(ref Vector2 value)
		{
			TargetJoint2D.set_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00003DCB File Offset: 0x00001FCB
		public void get_target_Injected(out Vector2 ret)
		{
			TargetJoint2D.get_target_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00003DDE File Offset: 0x00001FDE
		public void set_target_Injected(ref Vector2 value)
		{
			TargetJoint2D.set_target_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000257 RID: 599
		private static readonly TargetJoint2D.get_autoConfigureTargetDelegate get_autoConfigureTargetDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_autoConfigureTargetDelegate>("UnityEngine.TargetJoint2D::get_autoConfigureTarget");

		// Token: 0x04000258 RID: 600
		private static readonly TargetJoint2D.set_autoConfigureTargetDelegate set_autoConfigureTargetDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_autoConfigureTargetDelegate>("UnityEngine.TargetJoint2D::set_autoConfigureTarget");

		// Token: 0x04000259 RID: 601
		private static readonly TargetJoint2D.get_maxForceDelegate get_maxForceDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_maxForceDelegate>("UnityEngine.TargetJoint2D::get_maxForce");

		// Token: 0x0400025A RID: 602
		private static readonly TargetJoint2D.set_maxForceDelegate set_maxForceDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_maxForceDelegate>("UnityEngine.TargetJoint2D::set_maxForce");

		// Token: 0x0400025B RID: 603
		private static readonly TargetJoint2D.get_dampingRatioDelegate get_dampingRatioDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_dampingRatioDelegate>("UnityEngine.TargetJoint2D::get_dampingRatio");

		// Token: 0x0400025C RID: 604
		private static readonly TargetJoint2D.set_dampingRatioDelegate set_dampingRatioDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_dampingRatioDelegate>("UnityEngine.TargetJoint2D::set_dampingRatio");

		// Token: 0x0400025D RID: 605
		private static readonly TargetJoint2D.get_frequencyDelegate get_frequencyDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_frequencyDelegate>("UnityEngine.TargetJoint2D::get_frequency");

		// Token: 0x0400025E RID: 606
		private static readonly TargetJoint2D.set_frequencyDelegate set_frequencyDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_frequencyDelegate>("UnityEngine.TargetJoint2D::set_frequency");

		// Token: 0x0400025F RID: 607
		private static readonly TargetJoint2D.get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_anchor_InjectedDelegate>("UnityEngine.TargetJoint2D::get_anchor_Injected");

		// Token: 0x04000260 RID: 608
		private static readonly TargetJoint2D.set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_anchor_InjectedDelegate>("UnityEngine.TargetJoint2D::set_anchor_Injected");

		// Token: 0x04000261 RID: 609
		private static readonly TargetJoint2D.get_target_InjectedDelegate get_target_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_target_InjectedDelegate>("UnityEngine.TargetJoint2D::get_target_Injected");

		// Token: 0x04000262 RID: 610
		private static readonly TargetJoint2D.set_target_InjectedDelegate set_target_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_target_InjectedDelegate>("UnityEngine.TargetJoint2D::set_target_Injected");

		// Token: 0x02000177 RID: 375
		// (Invoke) Token: 0x060006C4 RID: 1732
		private delegate bool get_autoConfigureTargetDelegate(IntPtr @this);

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x060006C6 RID: 1734
		private delegate void set_autoConfigureTargetDelegate(IntPtr @this, bool value);

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x060006C8 RID: 1736
		private delegate float get_maxForceDelegate(IntPtr @this);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x060006CA RID: 1738
		private delegate void set_maxForceDelegate(IntPtr @this, float value);

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x060006CC RID: 1740
		private delegate float get_dampingRatioDelegate(IntPtr @this);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x060006CE RID: 1742
		private delegate void set_dampingRatioDelegate(IntPtr @this, float value);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x060006D0 RID: 1744
		private delegate float get_frequencyDelegate(IntPtr @this);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x060006D2 RID: 1746
		private delegate void set_frequencyDelegate(IntPtr @this, float value);

		// Token: 0x0200017F RID: 383
		// (Invoke) Token: 0x060006D4 RID: 1748
		private delegate void get_anchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000180 RID: 384
		// (Invoke) Token: 0x060006D6 RID: 1750
		private delegate void set_anchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000181 RID: 385
		// (Invoke) Token: 0x060006D8 RID: 1752
		private delegate void get_target_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x060006DA RID: 1754
		private delegate void set_target_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
