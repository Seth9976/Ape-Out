using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	public sealed class RelativeJoint2D : Joint2D
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00003B12 File Offset: 0x00001D12
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003B24 File Offset: 0x00001D24
		public float maxForce
		{
			get
			{
				return RelativeJoint2D.get_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00003B37 File Offset: 0x00001D37
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003B49 File Offset: 0x00001D49
		public float maxTorque
		{
			get
			{
				return RelativeJoint2D.get_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00003B5C File Offset: 0x00001D5C
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00003B6E File Offset: 0x00001D6E
		public float correctionScale
		{
			get
			{
				return RelativeJoint2D.get_correctionScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_correctionScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00003B81 File Offset: 0x00001D81
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00003B93 File Offset: 0x00001D93
		public bool autoConfigureOffset
		{
			get
			{
				return RelativeJoint2D.get_autoConfigureOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_autoConfigureOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000D96C File Offset: 0x0000BB6C
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00003BA6 File Offset: 0x00001DA6
		public Vector2 linearOffset
		{
			get
			{
				Vector2 vector;
				this.get_linearOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_linearOffset_Injected(ref value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00003BB0 File Offset: 0x00001DB0
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00003BC2 File Offset: 0x00001DC2
		public float angularOffset
		{
			get
			{
				return RelativeJoint2D.get_angularOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_angularOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000D984 File Offset: 0x0000BB84
		public Vector2 target
		{
			get
			{
				Vector2 vector;
				this.get_target_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003BD5 File Offset: 0x00001DD5
		public void get_linearOffset_Injected(out Vector2 ret)
		{
			RelativeJoint2D.get_linearOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00003BE8 File Offset: 0x00001DE8
		public void set_linearOffset_Injected(ref Vector2 value)
		{
			RelativeJoint2D.set_linearOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003BFB File Offset: 0x00001DFB
		public void get_target_Injected(out Vector2 ret)
		{
			RelativeJoint2D.get_target_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0400023D RID: 573
		private static readonly RelativeJoint2D.get_maxForceDelegate get_maxForceDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_maxForceDelegate>("UnityEngine.RelativeJoint2D::get_maxForce");

		// Token: 0x0400023E RID: 574
		private static readonly RelativeJoint2D.set_maxForceDelegate set_maxForceDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_maxForceDelegate>("UnityEngine.RelativeJoint2D::set_maxForce");

		// Token: 0x0400023F RID: 575
		private static readonly RelativeJoint2D.get_maxTorqueDelegate get_maxTorqueDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_maxTorqueDelegate>("UnityEngine.RelativeJoint2D::get_maxTorque");

		// Token: 0x04000240 RID: 576
		private static readonly RelativeJoint2D.set_maxTorqueDelegate set_maxTorqueDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_maxTorqueDelegate>("UnityEngine.RelativeJoint2D::set_maxTorque");

		// Token: 0x04000241 RID: 577
		private static readonly RelativeJoint2D.get_correctionScaleDelegate get_correctionScaleDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_correctionScaleDelegate>("UnityEngine.RelativeJoint2D::get_correctionScale");

		// Token: 0x04000242 RID: 578
		private static readonly RelativeJoint2D.set_correctionScaleDelegate set_correctionScaleDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_correctionScaleDelegate>("UnityEngine.RelativeJoint2D::set_correctionScale");

		// Token: 0x04000243 RID: 579
		private static readonly RelativeJoint2D.get_autoConfigureOffsetDelegate get_autoConfigureOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_autoConfigureOffsetDelegate>("UnityEngine.RelativeJoint2D::get_autoConfigureOffset");

		// Token: 0x04000244 RID: 580
		private static readonly RelativeJoint2D.set_autoConfigureOffsetDelegate set_autoConfigureOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_autoConfigureOffsetDelegate>("UnityEngine.RelativeJoint2D::set_autoConfigureOffset");

		// Token: 0x04000245 RID: 581
		private static readonly RelativeJoint2D.get_angularOffsetDelegate get_angularOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_angularOffsetDelegate>("UnityEngine.RelativeJoint2D::get_angularOffset");

		// Token: 0x04000246 RID: 582
		private static readonly RelativeJoint2D.set_angularOffsetDelegate set_angularOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_angularOffsetDelegate>("UnityEngine.RelativeJoint2D::set_angularOffset");

		// Token: 0x04000247 RID: 583
		private static readonly RelativeJoint2D.get_linearOffset_InjectedDelegate get_linearOffset_InjectedDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_linearOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_linearOffset_Injected");

		// Token: 0x04000248 RID: 584
		private static readonly RelativeJoint2D.set_linearOffset_InjectedDelegate set_linearOffset_InjectedDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_linearOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::set_linearOffset_Injected");

		// Token: 0x04000249 RID: 585
		private static readonly RelativeJoint2D.get_target_InjectedDelegate get_target_InjectedDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_target_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_target_Injected");

		// Token: 0x0200015D RID: 349
		// (Invoke) Token: 0x06000690 RID: 1680
		private delegate float get_maxForceDelegate(IntPtr @this);

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x06000692 RID: 1682
		private delegate void set_maxForceDelegate(IntPtr @this, float value);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x06000694 RID: 1684
		private delegate float get_maxTorqueDelegate(IntPtr @this);

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x06000696 RID: 1686
		private delegate void set_maxTorqueDelegate(IntPtr @this, float value);

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x06000698 RID: 1688
		private delegate float get_correctionScaleDelegate(IntPtr @this);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x0600069A RID: 1690
		private delegate void set_correctionScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x0600069C RID: 1692
		private delegate bool get_autoConfigureOffsetDelegate(IntPtr @this);

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x0600069E RID: 1694
		private delegate void set_autoConfigureOffsetDelegate(IntPtr @this, bool value);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x060006A0 RID: 1696
		private delegate float get_angularOffsetDelegate(IntPtr @this);

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x060006A2 RID: 1698
		private delegate void set_angularOffsetDelegate(IntPtr @this, float value);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x060006A4 RID: 1700
		private delegate void get_linearOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x060006A6 RID: 1702
		private delegate void set_linearOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x060006A8 RID: 1704
		private delegate void get_target_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
