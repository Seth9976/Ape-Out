using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	public class HingeJoint : Joint
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000341E File Offset: 0x0000161E
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00003430 File Offset: 0x00001630
		public bool useMotor
		{
			get
			{
				return HingeJoint.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00003443 File Offset: 0x00001643
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00003455 File Offset: 0x00001655
		public bool useLimits
		{
			get
			{
				return HingeJoint.get_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00003468 File Offset: 0x00001668
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000347A File Offset: 0x0000167A
		public bool useSpring
		{
			get
			{
				return HingeJoint.get_useSpringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useSpringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000348D File Offset: 0x0000168D
		public float velocity
		{
			get
			{
				return HingeJoint.get_velocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000349F File Offset: 0x0000169F
		public float angle
		{
			get
			{
				return HingeJoint.get_angleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x040001B2 RID: 434
		private static readonly HingeJoint.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useMotorDelegate>("UnityEngine.HingeJoint::get_useMotor");

		// Token: 0x040001B3 RID: 435
		private static readonly HingeJoint.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useMotorDelegate>("UnityEngine.HingeJoint::set_useMotor");

		// Token: 0x040001B4 RID: 436
		private static readonly HingeJoint.get_useLimitsDelegate get_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useLimitsDelegate>("UnityEngine.HingeJoint::get_useLimits");

		// Token: 0x040001B5 RID: 437
		private static readonly HingeJoint.set_useLimitsDelegate set_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useLimitsDelegate>("UnityEngine.HingeJoint::set_useLimits");

		// Token: 0x040001B6 RID: 438
		private static readonly HingeJoint.get_useSpringDelegate get_useSpringDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useSpringDelegate>("UnityEngine.HingeJoint::get_useSpring");

		// Token: 0x040001B7 RID: 439
		private static readonly HingeJoint.set_useSpringDelegate set_useSpringDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useSpringDelegate>("UnityEngine.HingeJoint::set_useSpring");

		// Token: 0x040001B8 RID: 440
		private static readonly HingeJoint.get_velocityDelegate get_velocityDelegateField = IL2CPP.ResolveICall<HingeJoint.get_velocityDelegate>("UnityEngine.HingeJoint::get_velocity");

		// Token: 0x040001B9 RID: 441
		private static readonly HingeJoint.get_angleDelegate get_angleDelegateField = IL2CPP.ResolveICall<HingeJoint.get_angleDelegate>("UnityEngine.HingeJoint::get_angle");

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x06000516 RID: 1302
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x06000518 RID: 1304
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x0600051A RID: 1306
		private delegate bool get_useLimitsDelegate(IntPtr @this);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x0600051C RID: 1308
		private delegate void set_useLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x0600051E RID: 1310
		private delegate bool get_useSpringDelegate(IntPtr @this);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x06000520 RID: 1312
		private delegate void set_useSpringDelegate(IntPtr @this, bool value);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x06000522 RID: 1314
		private delegate float get_velocityDelegate(IntPtr @this);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x06000524 RID: 1316
		private delegate float get_angleDelegate(IntPtr @this);
	}
}
