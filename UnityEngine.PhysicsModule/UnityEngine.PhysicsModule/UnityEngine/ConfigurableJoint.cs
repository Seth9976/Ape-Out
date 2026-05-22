using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	public class ConfigurableJoint : Joint
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000A620 File Offset: 0x00008820
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00003609 File Offset: 0x00001809
		public Vector3 secondaryAxis
		{
			get
			{
				Vector3 vector;
				this.get_secondaryAxis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_secondaryAxis_Injected(ref value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00003613 File Offset: 0x00001813
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003625 File Offset: 0x00001825
		public ConfigurableJointMotion xMotion
		{
			get
			{
				return ConfigurableJoint.get_xMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_xMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00003638 File Offset: 0x00001838
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000364A File Offset: 0x0000184A
		public ConfigurableJointMotion yMotion
		{
			get
			{
				return ConfigurableJoint.get_yMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_yMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000365D File Offset: 0x0000185D
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000366F File Offset: 0x0000186F
		public ConfigurableJointMotion zMotion
		{
			get
			{
				return ConfigurableJoint.get_zMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_zMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00003682 File Offset: 0x00001882
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00003694 File Offset: 0x00001894
		public ConfigurableJointMotion angularXMotion
		{
			get
			{
				return ConfigurableJoint.get_angularXMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_angularXMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x000036A7 File Offset: 0x000018A7
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x000036B9 File Offset: 0x000018B9
		public ConfigurableJointMotion angularYMotion
		{
			get
			{
				return ConfigurableJoint.get_angularYMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_angularYMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x000036CC File Offset: 0x000018CC
		// (set) Token: 0x060002DA RID: 730 RVA: 0x000036DE File Offset: 0x000018DE
		public ConfigurableJointMotion angularZMotion
		{
			get
			{
				return ConfigurableJoint.get_angularZMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_angularZMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000A638 File Offset: 0x00008838
		// (set) Token: 0x060002DC RID: 732 RVA: 0x000036F1 File Offset: 0x000018F1
		public Vector3 targetPosition
		{
			get
			{
				Vector3 vector;
				this.get_targetPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_targetPosition_Injected(ref value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000A650 File Offset: 0x00008850
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000036FB File Offset: 0x000018FB
		public Vector3 targetVelocity
		{
			get
			{
				Vector3 vector;
				this.get_targetVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_targetVelocity_Injected(ref value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000A668 File Offset: 0x00008868
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003705 File Offset: 0x00001905
		public Quaternion targetRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_targetRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_targetRotation_Injected(ref value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000A680 File Offset: 0x00008880
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000370F File Offset: 0x0000190F
		public Vector3 targetAngularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_targetAngularVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_targetAngularVelocity_Injected(ref value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00003719 File Offset: 0x00001919
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0000372B File Offset: 0x0000192B
		public RotationDriveMode rotationDriveMode
		{
			get
			{
				return ConfigurableJoint.get_rotationDriveModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_rotationDriveModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000373E File Offset: 0x0000193E
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00003750 File Offset: 0x00001950
		public JointProjectionMode projectionMode
		{
			get
			{
				return ConfigurableJoint.get_projectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_projectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00003763 File Offset: 0x00001963
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00003775 File Offset: 0x00001975
		public float projectionDistance
		{
			get
			{
				return ConfigurableJoint.get_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00003788 File Offset: 0x00001988
		// (set) Token: 0x060002EA RID: 746 RVA: 0x0000379A File Offset: 0x0000199A
		public float projectionAngle
		{
			get
			{
				return ConfigurableJoint.get_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002EB RID: 747 RVA: 0x000037AD File Offset: 0x000019AD
		// (set) Token: 0x060002EC RID: 748 RVA: 0x000037BF File Offset: 0x000019BF
		public bool configuredInWorldSpace
		{
			get
			{
				return ConfigurableJoint.get_configuredInWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_configuredInWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002ED RID: 749 RVA: 0x000037D2 File Offset: 0x000019D2
		// (set) Token: 0x060002EE RID: 750 RVA: 0x000037E4 File Offset: 0x000019E4
		public bool swapBodies
		{
			get
			{
				return ConfigurableJoint.get_swapBodiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_swapBodiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000037F7 File Offset: 0x000019F7
		public void get_secondaryAxis_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_secondaryAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000380A File Offset: 0x00001A0A
		public void set_secondaryAxis_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_secondaryAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000381D File Offset: 0x00001A1D
		public void get_targetPosition_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_targetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00003830 File Offset: 0x00001A30
		public void set_targetPosition_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_targetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00003843 File Offset: 0x00001A43
		public void get_targetVelocity_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_targetVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003856 File Offset: 0x00001A56
		public void set_targetVelocity_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_targetVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003869 File Offset: 0x00001A69
		public void get_targetRotation_Injected(out Quaternion ret)
		{
			ConfigurableJoint.get_targetRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000387C File Offset: 0x00001A7C
		public void set_targetRotation_Injected(ref Quaternion value)
		{
			ConfigurableJoint.set_targetRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000388F File Offset: 0x00001A8F
		public void get_targetAngularVelocity_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_targetAngularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000038A2 File Offset: 0x00001AA2
		public void set_targetAngularVelocity_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_targetAngularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001CC RID: 460
		private static readonly ConfigurableJoint.get_xMotionDelegate get_xMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_xMotionDelegate>("UnityEngine.ConfigurableJoint::get_xMotion");

		// Token: 0x040001CD RID: 461
		private static readonly ConfigurableJoint.set_xMotionDelegate set_xMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_xMotionDelegate>("UnityEngine.ConfigurableJoint::set_xMotion");

		// Token: 0x040001CE RID: 462
		private static readonly ConfigurableJoint.get_yMotionDelegate get_yMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_yMotionDelegate>("UnityEngine.ConfigurableJoint::get_yMotion");

		// Token: 0x040001CF RID: 463
		private static readonly ConfigurableJoint.set_yMotionDelegate set_yMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_yMotionDelegate>("UnityEngine.ConfigurableJoint::set_yMotion");

		// Token: 0x040001D0 RID: 464
		private static readonly ConfigurableJoint.get_zMotionDelegate get_zMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_zMotionDelegate>("UnityEngine.ConfigurableJoint::get_zMotion");

		// Token: 0x040001D1 RID: 465
		private static readonly ConfigurableJoint.set_zMotionDelegate set_zMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_zMotionDelegate>("UnityEngine.ConfigurableJoint::set_zMotion");

		// Token: 0x040001D2 RID: 466
		private static readonly ConfigurableJoint.get_angularXMotionDelegate get_angularXMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_angularXMotionDelegate>("UnityEngine.ConfigurableJoint::get_angularXMotion");

		// Token: 0x040001D3 RID: 467
		private static readonly ConfigurableJoint.set_angularXMotionDelegate set_angularXMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_angularXMotionDelegate>("UnityEngine.ConfigurableJoint::set_angularXMotion");

		// Token: 0x040001D4 RID: 468
		private static readonly ConfigurableJoint.get_angularYMotionDelegate get_angularYMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_angularYMotionDelegate>("UnityEngine.ConfigurableJoint::get_angularYMotion");

		// Token: 0x040001D5 RID: 469
		private static readonly ConfigurableJoint.set_angularYMotionDelegate set_angularYMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_angularYMotionDelegate>("UnityEngine.ConfigurableJoint::set_angularYMotion");

		// Token: 0x040001D6 RID: 470
		private static readonly ConfigurableJoint.get_angularZMotionDelegate get_angularZMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_angularZMotionDelegate>("UnityEngine.ConfigurableJoint::get_angularZMotion");

		// Token: 0x040001D7 RID: 471
		private static readonly ConfigurableJoint.set_angularZMotionDelegate set_angularZMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_angularZMotionDelegate>("UnityEngine.ConfigurableJoint::set_angularZMotion");

		// Token: 0x040001D8 RID: 472
		private static readonly ConfigurableJoint.get_rotationDriveModeDelegate get_rotationDriveModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_rotationDriveModeDelegate>("UnityEngine.ConfigurableJoint::get_rotationDriveMode");

		// Token: 0x040001D9 RID: 473
		private static readonly ConfigurableJoint.set_rotationDriveModeDelegate set_rotationDriveModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_rotationDriveModeDelegate>("UnityEngine.ConfigurableJoint::set_rotationDriveMode");

		// Token: 0x040001DA RID: 474
		private static readonly ConfigurableJoint.get_projectionModeDelegate get_projectionModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_projectionModeDelegate>("UnityEngine.ConfigurableJoint::get_projectionMode");

		// Token: 0x040001DB RID: 475
		private static readonly ConfigurableJoint.set_projectionModeDelegate set_projectionModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_projectionModeDelegate>("UnityEngine.ConfigurableJoint::set_projectionMode");

		// Token: 0x040001DC RID: 476
		private static readonly ConfigurableJoint.get_projectionDistanceDelegate get_projectionDistanceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_projectionDistanceDelegate>("UnityEngine.ConfigurableJoint::get_projectionDistance");

		// Token: 0x040001DD RID: 477
		private static readonly ConfigurableJoint.set_projectionDistanceDelegate set_projectionDistanceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_projectionDistanceDelegate>("UnityEngine.ConfigurableJoint::set_projectionDistance");

		// Token: 0x040001DE RID: 478
		private static readonly ConfigurableJoint.get_projectionAngleDelegate get_projectionAngleDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_projectionAngleDelegate>("UnityEngine.ConfigurableJoint::get_projectionAngle");

		// Token: 0x040001DF RID: 479
		private static readonly ConfigurableJoint.set_projectionAngleDelegate set_projectionAngleDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_projectionAngleDelegate>("UnityEngine.ConfigurableJoint::set_projectionAngle");

		// Token: 0x040001E0 RID: 480
		private static readonly ConfigurableJoint.get_configuredInWorldSpaceDelegate get_configuredInWorldSpaceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_configuredInWorldSpaceDelegate>("UnityEngine.ConfigurableJoint::get_configuredInWorldSpace");

		// Token: 0x040001E1 RID: 481
		private static readonly ConfigurableJoint.set_configuredInWorldSpaceDelegate set_configuredInWorldSpaceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_configuredInWorldSpaceDelegate>("UnityEngine.ConfigurableJoint::set_configuredInWorldSpace");

		// Token: 0x040001E2 RID: 482
		private static readonly ConfigurableJoint.get_swapBodiesDelegate get_swapBodiesDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_swapBodiesDelegate>("UnityEngine.ConfigurableJoint::get_swapBodies");

		// Token: 0x040001E3 RID: 483
		private static readonly ConfigurableJoint.set_swapBodiesDelegate set_swapBodiesDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_swapBodiesDelegate>("UnityEngine.ConfigurableJoint::set_swapBodies");

		// Token: 0x040001E4 RID: 484
		private static readonly ConfigurableJoint.get_secondaryAxis_InjectedDelegate get_secondaryAxis_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_secondaryAxis_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_secondaryAxis_Injected");

		// Token: 0x040001E5 RID: 485
		private static readonly ConfigurableJoint.set_secondaryAxis_InjectedDelegate set_secondaryAxis_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_secondaryAxis_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_secondaryAxis_Injected");

		// Token: 0x040001E6 RID: 486
		private static readonly ConfigurableJoint.get_targetPosition_InjectedDelegate get_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetPosition_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetPosition_Injected");

		// Token: 0x040001E7 RID: 487
		private static readonly ConfigurableJoint.set_targetPosition_InjectedDelegate set_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetPosition_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetPosition_Injected");

		// Token: 0x040001E8 RID: 488
		private static readonly ConfigurableJoint.get_targetVelocity_InjectedDelegate get_targetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetVelocity_Injected");

		// Token: 0x040001E9 RID: 489
		private static readonly ConfigurableJoint.set_targetVelocity_InjectedDelegate set_targetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetVelocity_Injected");

		// Token: 0x040001EA RID: 490
		private static readonly ConfigurableJoint.get_targetRotation_InjectedDelegate get_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetRotation_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetRotation_Injected");

		// Token: 0x040001EB RID: 491
		private static readonly ConfigurableJoint.set_targetRotation_InjectedDelegate set_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetRotation_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetRotation_Injected");

		// Token: 0x040001EC RID: 492
		private static readonly ConfigurableJoint.get_targetAngularVelocity_InjectedDelegate get_targetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetAngularVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetAngularVelocity_Injected");

		// Token: 0x040001ED RID: 493
		private static readonly ConfigurableJoint.set_targetAngularVelocity_InjectedDelegate set_targetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetAngularVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetAngularVelocity_Injected");

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x0600054A RID: 1354
		private delegate ConfigurableJointMotion get_xMotionDelegate(IntPtr @this);

		// Token: 0x02000114 RID: 276
		// (Invoke) Token: 0x0600054C RID: 1356
		private delegate void set_xMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x0600054E RID: 1358
		private delegate ConfigurableJointMotion get_yMotionDelegate(IntPtr @this);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x06000550 RID: 1360
		private delegate void set_yMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x06000552 RID: 1362
		private delegate ConfigurableJointMotion get_zMotionDelegate(IntPtr @this);

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x06000554 RID: 1364
		private delegate void set_zMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x06000556 RID: 1366
		private delegate ConfigurableJointMotion get_angularXMotionDelegate(IntPtr @this);

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x06000558 RID: 1368
		private delegate void set_angularXMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x0600055A RID: 1370
		private delegate ConfigurableJointMotion get_angularYMotionDelegate(IntPtr @this);

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x0600055C RID: 1372
		private delegate void set_angularYMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x0600055E RID: 1374
		private delegate ConfigurableJointMotion get_angularZMotionDelegate(IntPtr @this);

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x06000560 RID: 1376
		private delegate void set_angularZMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x06000562 RID: 1378
		private delegate RotationDriveMode get_rotationDriveModeDelegate(IntPtr @this);

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x06000564 RID: 1380
		private delegate void set_rotationDriveModeDelegate(IntPtr @this, RotationDriveMode value);

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x06000566 RID: 1382
		private delegate JointProjectionMode get_projectionModeDelegate(IntPtr @this);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x06000568 RID: 1384
		private delegate void set_projectionModeDelegate(IntPtr @this, JointProjectionMode value);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x0600056A RID: 1386
		private delegate float get_projectionDistanceDelegate(IntPtr @this);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x0600056C RID: 1388
		private delegate void set_projectionDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x0600056E RID: 1390
		private delegate float get_projectionAngleDelegate(IntPtr @this);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x06000570 RID: 1392
		private delegate void set_projectionAngleDelegate(IntPtr @this, float value);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x06000572 RID: 1394
		private delegate bool get_configuredInWorldSpaceDelegate(IntPtr @this);

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x06000574 RID: 1396
		private delegate void set_configuredInWorldSpaceDelegate(IntPtr @this, bool value);

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x06000576 RID: 1398
		private delegate bool get_swapBodiesDelegate(IntPtr @this);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x06000578 RID: 1400
		private delegate void set_swapBodiesDelegate(IntPtr @this, bool value);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x0600057A RID: 1402
		private delegate void get_secondaryAxis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x0600057C RID: 1404
		private delegate void set_secondaryAxis_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x0600057E RID: 1406
		private delegate void get_targetPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012E RID: 302
		// (Invoke) Token: 0x06000580 RID: 1408
		private delegate void set_targetPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x06000582 RID: 1410
		private delegate void get_targetVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x06000584 RID: 1412
		private delegate void set_targetVelocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x06000586 RID: 1414
		private delegate void get_targetRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x06000588 RID: 1416
		private delegate void set_targetRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x0600058A RID: 1418
		private delegate void get_targetAngularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x0600058C RID: 1420
		private delegate void set_targetAngularVelocity_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
