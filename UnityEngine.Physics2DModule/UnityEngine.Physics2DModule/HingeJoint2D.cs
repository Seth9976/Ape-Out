using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	public sealed class HingeJoint2D : AnchoredJoint2D
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00003A6D File Offset: 0x00001C6D
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00003A7F File Offset: 0x00001C7F
		public bool useMotor
		{
			get
			{
				return HingeJoint2D.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint2D.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00003A92 File Offset: 0x00001C92
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00003AA4 File Offset: 0x00001CA4
		public bool useLimits
		{
			get
			{
				return HingeJoint2D.get_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint2D.set_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00003AB7 File Offset: 0x00001CB7
		public JointLimitState2D limitState
		{
			get
			{
				return HingeJoint2D.get_limitStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00003AC9 File Offset: 0x00001CC9
		public float referenceAngle
		{
			get
			{
				return HingeJoint2D.get_referenceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00003ADB File Offset: 0x00001CDB
		public float jointAngle
		{
			get
			{
				return HingeJoint2D.get_jointAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00003AED File Offset: 0x00001CED
		public float jointSpeed
		{
			get
			{
				return HingeJoint2D.get_jointSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003AFF File Offset: 0x00001CFF
		public float GetMotorTorque(float timeStep)
		{
			return HingeJoint2D.GetMotorTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x04000234 RID: 564
		private static readonly HingeJoint2D.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_useMotorDelegate>("UnityEngine.HingeJoint2D::get_useMotor");

		// Token: 0x04000235 RID: 565
		private static readonly HingeJoint2D.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint2D.set_useMotorDelegate>("UnityEngine.HingeJoint2D::set_useMotor");

		// Token: 0x04000236 RID: 566
		private static readonly HingeJoint2D.get_useLimitsDelegate get_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_useLimitsDelegate>("UnityEngine.HingeJoint2D::get_useLimits");

		// Token: 0x04000237 RID: 567
		private static readonly HingeJoint2D.set_useLimitsDelegate set_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint2D.set_useLimitsDelegate>("UnityEngine.HingeJoint2D::set_useLimits");

		// Token: 0x04000238 RID: 568
		private static readonly HingeJoint2D.get_limitStateDelegate get_limitStateDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_limitStateDelegate>("UnityEngine.HingeJoint2D::get_limitState");

		// Token: 0x04000239 RID: 569
		private static readonly HingeJoint2D.get_referenceAngleDelegate get_referenceAngleDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_referenceAngleDelegate>("UnityEngine.HingeJoint2D::get_referenceAngle");

		// Token: 0x0400023A RID: 570
		private static readonly HingeJoint2D.get_jointAngleDelegate get_jointAngleDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_jointAngleDelegate>("UnityEngine.HingeJoint2D::get_jointAngle");

		// Token: 0x0400023B RID: 571
		private static readonly HingeJoint2D.get_jointSpeedDelegate get_jointSpeedDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_jointSpeedDelegate>("UnityEngine.HingeJoint2D::get_jointSpeed");

		// Token: 0x0400023C RID: 572
		private static readonly HingeJoint2D.GetMotorTorqueDelegate GetMotorTorqueDelegateField = IL2CPP.ResolveICall<HingeJoint2D.GetMotorTorqueDelegate>("UnityEngine.HingeJoint2D::GetMotorTorque");

		// Token: 0x02000154 RID: 340
		// (Invoke) Token: 0x0600067E RID: 1662
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x06000680 RID: 1664
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x06000682 RID: 1666
		private delegate bool get_useLimitsDelegate(IntPtr @this);

		// Token: 0x02000157 RID: 343
		// (Invoke) Token: 0x06000684 RID: 1668
		private delegate void set_useLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x02000158 RID: 344
		// (Invoke) Token: 0x06000686 RID: 1670
		private delegate JointLimitState2D get_limitStateDelegate(IntPtr @this);

		// Token: 0x02000159 RID: 345
		// (Invoke) Token: 0x06000688 RID: 1672
		private delegate float get_referenceAngleDelegate(IntPtr @this);

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x0600068A RID: 1674
		private delegate float get_jointAngleDelegate(IntPtr @this);

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x0600068C RID: 1676
		private delegate float get_jointSpeedDelegate(IntPtr @this);

		// Token: 0x0200015C RID: 348
		// (Invoke) Token: 0x0600068E RID: 1678
		private delegate float GetMotorTorqueDelegate(IntPtr @this, float timeStep);
	}
}
