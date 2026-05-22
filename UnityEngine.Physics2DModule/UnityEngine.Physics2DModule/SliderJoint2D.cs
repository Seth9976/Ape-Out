using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000025 RID: 37
	public sealed class SliderJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00003C0E File Offset: 0x00001E0E
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003C20 File Offset: 0x00001E20
		public bool autoConfigureAngle
		{
			get
			{
				return SliderJoint2D.get_autoConfigureAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_autoConfigureAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00003C33 File Offset: 0x00001E33
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00003C45 File Offset: 0x00001E45
		public float angle
		{
			get
			{
				return SliderJoint2D.get_angleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_angleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00003C58 File Offset: 0x00001E58
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00003C6A File Offset: 0x00001E6A
		public bool useMotor
		{
			get
			{
				return SliderJoint2D.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00003C7D File Offset: 0x00001E7D
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00003C8F File Offset: 0x00001E8F
		public bool useLimits
		{
			get
			{
				return SliderJoint2D.get_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00003CA2 File Offset: 0x00001EA2
		public JointLimitState2D limitState
		{
			get
			{
				return SliderJoint2D.get_limitStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public float referenceAngle
		{
			get
			{
				return SliderJoint2D.get_referenceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00003CC6 File Offset: 0x00001EC6
		public float jointTranslation
		{
			get
			{
				return SliderJoint2D.get_jointTranslationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public float jointSpeed
		{
			get
			{
				return SliderJoint2D.get_jointSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00003CEA File Offset: 0x00001EEA
		public float GetMotorForce(float timeStep)
		{
			return SliderJoint2D.GetMotorForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x0400024A RID: 586
		private static readonly SliderJoint2D.get_autoConfigureAngleDelegate get_autoConfigureAngleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_autoConfigureAngleDelegate>("UnityEngine.SliderJoint2D::get_autoConfigureAngle");

		// Token: 0x0400024B RID: 587
		private static readonly SliderJoint2D.set_autoConfigureAngleDelegate set_autoConfigureAngleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_autoConfigureAngleDelegate>("UnityEngine.SliderJoint2D::set_autoConfigureAngle");

		// Token: 0x0400024C RID: 588
		private static readonly SliderJoint2D.get_angleDelegate get_angleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_angleDelegate>("UnityEngine.SliderJoint2D::get_angle");

		// Token: 0x0400024D RID: 589
		private static readonly SliderJoint2D.set_angleDelegate set_angleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_angleDelegate>("UnityEngine.SliderJoint2D::set_angle");

		// Token: 0x0400024E RID: 590
		private static readonly SliderJoint2D.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_useMotorDelegate>("UnityEngine.SliderJoint2D::get_useMotor");

		// Token: 0x0400024F RID: 591
		private static readonly SliderJoint2D.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_useMotorDelegate>("UnityEngine.SliderJoint2D::set_useMotor");

		// Token: 0x04000250 RID: 592
		private static readonly SliderJoint2D.get_useLimitsDelegate get_useLimitsDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_useLimitsDelegate>("UnityEngine.SliderJoint2D::get_useLimits");

		// Token: 0x04000251 RID: 593
		private static readonly SliderJoint2D.set_useLimitsDelegate set_useLimitsDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_useLimitsDelegate>("UnityEngine.SliderJoint2D::set_useLimits");

		// Token: 0x04000252 RID: 594
		private static readonly SliderJoint2D.get_limitStateDelegate get_limitStateDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_limitStateDelegate>("UnityEngine.SliderJoint2D::get_limitState");

		// Token: 0x04000253 RID: 595
		private static readonly SliderJoint2D.get_referenceAngleDelegate get_referenceAngleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_referenceAngleDelegate>("UnityEngine.SliderJoint2D::get_referenceAngle");

		// Token: 0x04000254 RID: 596
		private static readonly SliderJoint2D.get_jointTranslationDelegate get_jointTranslationDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_jointTranslationDelegate>("UnityEngine.SliderJoint2D::get_jointTranslation");

		// Token: 0x04000255 RID: 597
		private static readonly SliderJoint2D.get_jointSpeedDelegate get_jointSpeedDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_jointSpeedDelegate>("UnityEngine.SliderJoint2D::get_jointSpeed");

		// Token: 0x04000256 RID: 598
		private static readonly SliderJoint2D.GetMotorForceDelegate GetMotorForceDelegateField = IL2CPP.ResolveICall<SliderJoint2D.GetMotorForceDelegate>("UnityEngine.SliderJoint2D::GetMotorForce");

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x060006AA RID: 1706
		private delegate bool get_autoConfigureAngleDelegate(IntPtr @this);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x060006AC RID: 1708
		private delegate void set_autoConfigureAngleDelegate(IntPtr @this, bool value);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x060006AE RID: 1710
		private delegate float get_angleDelegate(IntPtr @this);

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x060006B0 RID: 1712
		private delegate void set_angleDelegate(IntPtr @this, float value);

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x060006B2 RID: 1714
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x060006B4 RID: 1716
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x060006B6 RID: 1718
		private delegate bool get_useLimitsDelegate(IntPtr @this);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x060006B8 RID: 1720
		private delegate void set_useLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x060006BA RID: 1722
		private delegate JointLimitState2D get_limitStateDelegate(IntPtr @this);

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x060006BC RID: 1724
		private delegate float get_referenceAngleDelegate(IntPtr @this);

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x060006BE RID: 1726
		private delegate float get_jointTranslationDelegate(IntPtr @this);

		// Token: 0x02000175 RID: 373
		// (Invoke) Token: 0x060006C0 RID: 1728
		private delegate float get_jointSpeedDelegate(IntPtr @this);

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x060006C2 RID: 1730
		private delegate float GetMotorForceDelegate(IntPtr @this, float timeStep);
	}
}
