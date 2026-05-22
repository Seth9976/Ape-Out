using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000028 RID: 40
	public sealed class WheelJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00003E4D File Offset: 0x0000204D
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003E5F File Offset: 0x0000205F
		public bool useMotor
		{
			get
			{
				return WheelJoint2D.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelJoint2D.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00003E72 File Offset: 0x00002072
		public float jointTranslation
		{
			get
			{
				return WheelJoint2D.get_jointTranslationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00003E84 File Offset: 0x00002084
		public float jointLinearSpeed
		{
			get
			{
				return WheelJoint2D.get_jointLinearSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00003E96 File Offset: 0x00002096
		public float jointSpeed
		{
			get
			{
				return WheelJoint2D.get_jointSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00003EA8 File Offset: 0x000020A8
		public float jointAngle
		{
			get
			{
				return WheelJoint2D.get_jointAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003EBA File Offset: 0x000020BA
		public float GetMotorTorque(float timeStep)
		{
			return WheelJoint2D.GetMotorTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x04000268 RID: 616
		private static readonly WheelJoint2D.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_useMotorDelegate>("UnityEngine.WheelJoint2D::get_useMotor");

		// Token: 0x04000269 RID: 617
		private static readonly WheelJoint2D.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<WheelJoint2D.set_useMotorDelegate>("UnityEngine.WheelJoint2D::set_useMotor");

		// Token: 0x0400026A RID: 618
		private static readonly WheelJoint2D.get_jointTranslationDelegate get_jointTranslationDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointTranslationDelegate>("UnityEngine.WheelJoint2D::get_jointTranslation");

		// Token: 0x0400026B RID: 619
		private static readonly WheelJoint2D.get_jointLinearSpeedDelegate get_jointLinearSpeedDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointLinearSpeedDelegate>("UnityEngine.WheelJoint2D::get_jointLinearSpeed");

		// Token: 0x0400026C RID: 620
		private static readonly WheelJoint2D.get_jointSpeedDelegate get_jointSpeedDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointSpeedDelegate>("UnityEngine.WheelJoint2D::get_jointSpeed");

		// Token: 0x0400026D RID: 621
		private static readonly WheelJoint2D.get_jointAngleDelegate get_jointAngleDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointAngleDelegate>("UnityEngine.WheelJoint2D::get_jointAngle");

		// Token: 0x0400026E RID: 622
		private static readonly WheelJoint2D.GetMotorTorqueDelegate GetMotorTorqueDelegateField = IL2CPP.ResolveICall<WheelJoint2D.GetMotorTorqueDelegate>("UnityEngine.WheelJoint2D::GetMotorTorque");

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x060006E6 RID: 1766
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x060006E8 RID: 1768
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x060006EA RID: 1770
		private delegate float get_jointTranslationDelegate(IntPtr @this);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x060006EC RID: 1772
		private delegate float get_jointLinearSpeedDelegate(IntPtr @this);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x060006EE RID: 1774
		private delegate float get_jointSpeedDelegate(IntPtr @this);

		// Token: 0x0200018D RID: 397
		// (Invoke) Token: 0x060006F0 RID: 1776
		private delegate float get_jointAngleDelegate(IntPtr @this);

		// Token: 0x0200018E RID: 398
		// (Invoke) Token: 0x060006F2 RID: 1778
		private delegate float GetMotorTorqueDelegate(IntPtr @this, float timeStep);
	}
}
