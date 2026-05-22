using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000028 RID: 40
	public class ArticulationBody : Behaviour
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000038D4 File Offset: 0x00001AD4
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000038E6 File Offset: 0x00001AE6
		public ArticulationJointType jointType
		{
			get
			{
				return ArticulationBody.get_jointTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_jointTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000AC64 File Offset: 0x00008E64
		// (set) Token: 0x06000301 RID: 769 RVA: 0x000038F9 File Offset: 0x00001AF9
		public Vector3 anchorPosition
		{
			get
			{
				Vector3 vector;
				this.get_anchorPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchorPosition_Injected(ref value);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000AC7C File Offset: 0x00008E7C
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00003903 File Offset: 0x00001B03
		public Vector3 parentAnchorPosition
		{
			get
			{
				Vector3 vector;
				this.get_parentAnchorPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_parentAnchorPosition_Injected(ref value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000AC94 File Offset: 0x00008E94
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0000390D File Offset: 0x00001B0D
		public Quaternion anchorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_anchorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_anchorRotation_Injected(ref value);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000ACAC File Offset: 0x00008EAC
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00003917 File Offset: 0x00001B17
		public Quaternion parentAnchorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_parentAnchorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_parentAnchorRotation_Injected(ref value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00003921 File Offset: 0x00001B21
		public bool isRoot
		{
			get
			{
				return ArticulationBody.get_isRootDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00003933 File Offset: 0x00001B33
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00003945 File Offset: 0x00001B45
		public ArticulationDofLock linearLockX
		{
			get
			{
				return ArticulationBody.get_linearLockXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearLockXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00003958 File Offset: 0x00001B58
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000396A File Offset: 0x00001B6A
		public ArticulationDofLock linearLockY
		{
			get
			{
				return ArticulationBody.get_linearLockYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearLockYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000397D File Offset: 0x00001B7D
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000398F File Offset: 0x00001B8F
		public ArticulationDofLock linearLockZ
		{
			get
			{
				return ArticulationBody.get_linearLockZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearLockZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600030F RID: 783 RVA: 0x000039A2 File Offset: 0x00001BA2
		// (set) Token: 0x06000310 RID: 784 RVA: 0x000039B4 File Offset: 0x00001BB4
		public ArticulationDofLock swingYLock
		{
			get
			{
				return ArticulationBody.get_swingYLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_swingYLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000039C7 File Offset: 0x00001BC7
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000039D9 File Offset: 0x00001BD9
		public ArticulationDofLock swingZLock
		{
			get
			{
				return ArticulationBody.get_swingZLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_swingZLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000313 RID: 787 RVA: 0x000039EC File Offset: 0x00001BEC
		// (set) Token: 0x06000314 RID: 788 RVA: 0x000039FE File Offset: 0x00001BFE
		public ArticulationDofLock twistLock
		{
			get
			{
				return ArticulationBody.get_twistLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_twistLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00003A11 File Offset: 0x00001C11
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003A23 File Offset: 0x00001C23
		public bool immovable
		{
			get
			{
				return ArticulationBody.get_immovableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_immovableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00003A36 File Offset: 0x00001C36
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00003A48 File Offset: 0x00001C48
		public bool useGravity
		{
			get
			{
				return ArticulationBody.get_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00003A5B File Offset: 0x00001C5B
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003A6D File Offset: 0x00001C6D
		public float linearDamping
		{
			get
			{
				return ArticulationBody.get_linearDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00003A80 File Offset: 0x00001C80
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00003A92 File Offset: 0x00001C92
		public float angularDamping
		{
			get
			{
				return ArticulationBody.get_angularDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_angularDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00003AA5 File Offset: 0x00001CA5
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003AB7 File Offset: 0x00001CB7
		public float jointFriction
		{
			get
			{
				return ArticulationBody.get_jointFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_jointFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003ACA File Offset: 0x00001CCA
		public void AddForce(Vector3 force)
		{
			this.AddForce_Injected(ref force);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public void AddRelativeForce(Vector3 force)
		{
			this.AddRelativeForce_Injected(ref force);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00003ADE File Offset: 0x00001CDE
		public void AddTorque(Vector3 torque)
		{
			this.AddTorque_Injected(ref torque);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00003AE8 File Offset: 0x00001CE8
		public void AddRelativeTorque(Vector3 torque)
		{
			this.AddRelativeTorque_Injected(ref torque);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003AF2 File Offset: 0x00001CF2
		public void AddForceAtPosition(Vector3 force, Vector3 position)
		{
			this.AddForceAtPosition_Injected(ref force, ref position);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00003AFE File Offset: 0x00001CFE
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_velocity_Injected(ref value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000ACDC File Offset: 0x00008EDC
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003B08 File Offset: 0x00001D08
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_angularVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_angularVelocity_Injected(ref value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00003B12 File Offset: 0x00001D12
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00003B24 File Offset: 0x00001D24
		public float mass
		{
			get
			{
				return ArticulationBody.get_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00003B37 File Offset: 0x00001D37
		public Vector3 centerOfMass
		{
			get
			{
				Vector3 vector;
				this.get_centerOfMass_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_centerOfMass_Injected(ref value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000AD0C File Offset: 0x00008F0C
		public Vector3 worldCenterOfMass
		{
			get
			{
				Vector3 vector;
				this.get_worldCenterOfMass_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000AD24 File Offset: 0x00008F24
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00003B41 File Offset: 0x00001D41
		public Vector3 inertiaTensor
		{
			get
			{
				Vector3 vector;
				this.get_inertiaTensor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_inertiaTensor_Injected(ref value);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000AD3C File Offset: 0x00008F3C
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00003B4B File Offset: 0x00001D4B
		public Quaternion inertiaTensorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_inertiaTensorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_inertiaTensorRotation_Injected(ref value);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003B55 File Offset: 0x00001D55
		public void ResetCenterOfMass()
		{
			ArticulationBody.ResetCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00003B67 File Offset: 0x00001D67
		public void ResetInertiaTensor()
		{
			ArticulationBody.ResetInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00003B79 File Offset: 0x00001D79
		public void Sleep()
		{
			ArticulationBody.SleepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00003B8B File Offset: 0x00001D8B
		public bool IsSleeping()
		{
			return ArticulationBody.IsSleepingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00003B9D File Offset: 0x00001D9D
		public void WakeUp()
		{
			ArticulationBody.WakeUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00003BAF File Offset: 0x00001DAF
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00003BC1 File Offset: 0x00001DC1
		public float sleepThreshold
		{
			get
			{
				return ArticulationBody.get_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00003BD4 File Offset: 0x00001DD4
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00003BE6 File Offset: 0x00001DE6
		public int solverIterations
		{
			get
			{
				return ArticulationBody.get_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00003BF9 File Offset: 0x00001DF9
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00003C0B File Offset: 0x00001E0B
		public int solverVelocityIterations
		{
			get
			{
				return ArticulationBody.get_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00003C1E File Offset: 0x00001E1E
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003C30 File Offset: 0x00001E30
		public float maxAngularVelocity
		{
			get
			{
				return ArticulationBody.get_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00003C43 File Offset: 0x00001E43
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00003C55 File Offset: 0x00001E55
		public float maxLinearVelocity
		{
			get
			{
				return ArticulationBody.get_maxLinearVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxLinearVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00003C68 File Offset: 0x00001E68
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00003C7A File Offset: 0x00001E7A
		public float maxJointVelocity
		{
			get
			{
				return ArticulationBody.get_maxJointVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxJointVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00003C8D File Offset: 0x00001E8D
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00003C9F File Offset: 0x00001E9F
		public float maxDepenetrationVelocity
		{
			get
			{
				return ArticulationBody.get_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00003CB2 File Offset: 0x00001EB2
		public int dofCount
		{
			get
			{
				return ArticulationBody.get_dofCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00003CC4 File Offset: 0x00001EC4
		public int index
		{
			get
			{
				return ArticulationBody.get_indexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00003CD6 File Offset: 0x00001ED6
		public void TeleportRoot(Vector3 position, Quaternion rotation)
		{
			this.TeleportRoot_Injected(ref position, ref rotation);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000AD54 File Offset: 0x00008F54
		public Vector3 GetClosestPoint(Vector3 point)
		{
			Vector3 vector;
			this.GetClosestPoint_Injected(ref point, out vector);
			return vector;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000AD6C File Offset: 0x00008F6C
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
		{
			Vector3 vector;
			this.GetRelativePointVelocity_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000AD84 File Offset: 0x00008F84
		public Vector3 GetPointVelocity(Vector3 worldPoint)
		{
			Vector3 vector;
			this.GetPointVelocity_Injected(ref worldPoint, out vector);
			return vector;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00003CE2 File Offset: 0x00001EE2
		public int GetJointPositions(List<float> positions)
		{
			return ArticulationBody.GetJointPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00003CFA File Offset: 0x00001EFA
		public void SetJointPositions(List<float> positions)
		{
			ArticulationBody.SetJointPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003D12 File Offset: 0x00001F12
		public int GetJointVelocities(List<float> velocities)
		{
			return ArticulationBody.GetJointVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(velocities));
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003D2A File Offset: 0x00001F2A
		public void SetJointVelocities(List<float> velocities)
		{
			ArticulationBody.SetJointVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(velocities));
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00003D42 File Offset: 0x00001F42
		public int GetJointAccelerations(List<float> accelerations)
		{
			return ArticulationBody.GetJointAccelerationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(accelerations));
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003D5A File Offset: 0x00001F5A
		public void SetJointAccelerations(List<float> accelerations)
		{
			ArticulationBody.SetJointAccelerationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(accelerations));
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003D72 File Offset: 0x00001F72
		public int GetJointForces(List<float> forces)
		{
			return ArticulationBody.GetJointForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003D8A File Offset: 0x00001F8A
		public void SetJointForces(List<float> forces)
		{
			ArticulationBody.SetJointForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces));
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003DA2 File Offset: 0x00001FA2
		public int GetDriveTargets(List<float> targets)
		{
			return ArticulationBody.GetDriveTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targets));
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00003DBA File Offset: 0x00001FBA
		public void SetDriveTargets(List<float> targets)
		{
			ArticulationBody.SetDriveTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targets));
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003DD2 File Offset: 0x00001FD2
		public int GetDriveTargetVelocities(List<float> targetVelocities)
		{
			return ArticulationBody.GetDriveTargetVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetVelocities));
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003DEA File Offset: 0x00001FEA
		public void SetDriveTargetVelocities(List<float> targetVelocities)
		{
			ArticulationBody.SetDriveTargetVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetVelocities));
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003E02 File Offset: 0x00002002
		public int GetDofStartIndices(List<int> dofStartIndices)
		{
			return ArticulationBody.GetDofStartIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dofStartIndices));
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00003E1A File Offset: 0x0000201A
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00003E2C File Offset: 0x0000202C
		public CollisionDetectionMode collisionDetectionMode
		{
			get
			{
				return ArticulationBody.get_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003E3F File Offset: 0x0000203F
		public void get_anchorPosition_Injected(out Vector3 ret)
		{
			ArticulationBody.get_anchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003E52 File Offset: 0x00002052
		public void set_anchorPosition_Injected(ref Vector3 value)
		{
			ArticulationBody.set_anchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00003E65 File Offset: 0x00002065
		public void get_parentAnchorPosition_Injected(out Vector3 ret)
		{
			ArticulationBody.get_parentAnchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003E78 File Offset: 0x00002078
		public void set_parentAnchorPosition_Injected(ref Vector3 value)
		{
			ArticulationBody.set_parentAnchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00003E8B File Offset: 0x0000208B
		public void get_anchorRotation_Injected(out Quaternion ret)
		{
			ArticulationBody.get_anchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003E9E File Offset: 0x0000209E
		public void set_anchorRotation_Injected(ref Quaternion value)
		{
			ArticulationBody.set_anchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00003EB1 File Offset: 0x000020B1
		public void get_parentAnchorRotation_Injected(out Quaternion ret)
		{
			ArticulationBody.get_parentAnchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003EC4 File Offset: 0x000020C4
		public void set_parentAnchorRotation_Injected(ref Quaternion value)
		{
			ArticulationBody.set_parentAnchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003ED7 File Offset: 0x000020D7
		public void AddForce_Injected(ref Vector3 force)
		{
			ArticulationBody.AddForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003EEA File Offset: 0x000020EA
		public void AddRelativeForce_Injected(ref Vector3 force)
		{
			ArticulationBody.AddRelativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003EFD File Offset: 0x000020FD
		public void AddTorque_Injected(ref Vector3 torque)
		{
			ArticulationBody.AddTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003F10 File Offset: 0x00002110
		public void AddRelativeTorque_Injected(ref Vector3 torque)
		{
			ArticulationBody.AddRelativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003F23 File Offset: 0x00002123
		public void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position)
		{
			ArticulationBody.AddForceAtPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, ref position);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00003F37 File Offset: 0x00002137
		public void get_velocity_Injected(out Vector3 ret)
		{
			ArticulationBody.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003F4A File Offset: 0x0000214A
		public void set_velocity_Injected(ref Vector3 value)
		{
			ArticulationBody.set_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00003F5D File Offset: 0x0000215D
		public void get_angularVelocity_Injected(out Vector3 ret)
		{
			ArticulationBody.get_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003F70 File Offset: 0x00002170
		public void set_angularVelocity_Injected(ref Vector3 value)
		{
			ArticulationBody.set_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003F83 File Offset: 0x00002183
		public void get_centerOfMass_Injected(out Vector3 ret)
		{
			ArticulationBody.get_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003F96 File Offset: 0x00002196
		public void set_centerOfMass_Injected(ref Vector3 value)
		{
			ArticulationBody.set_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00003FA9 File Offset: 0x000021A9
		public void get_worldCenterOfMass_Injected(out Vector3 ret)
		{
			ArticulationBody.get_worldCenterOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00003FBC File Offset: 0x000021BC
		public void get_inertiaTensor_Injected(out Vector3 ret)
		{
			ArticulationBody.get_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00003FCF File Offset: 0x000021CF
		public void set_inertiaTensor_Injected(ref Vector3 value)
		{
			ArticulationBody.set_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00003FE2 File Offset: 0x000021E2
		public void get_inertiaTensorRotation_Injected(out Quaternion ret)
		{
			ArticulationBody.get_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00003FF5 File Offset: 0x000021F5
		public void set_inertiaTensorRotation_Injected(ref Quaternion value)
		{
			ArticulationBody.set_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00004008 File Offset: 0x00002208
		public void TeleportRoot_Injected(ref Vector3 position, ref Quaternion rotation)
		{
			ArticulationBody.TeleportRoot_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref rotation);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000401C File Offset: 0x0000221C
		public void GetClosestPoint_Injected(ref Vector3 point, out Vector3 ret)
		{
			ArticulationBody.GetClosestPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, out ret);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00004030 File Offset: 0x00002230
		public void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret)
		{
			ArticulationBody.GetRelativePointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00004044 File Offset: 0x00002244
		public void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret)
		{
			ArticulationBody.GetPointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref worldPoint, out ret);
		}

		// Token: 0x040001F8 RID: 504
		private static readonly ArticulationBody.get_jointTypeDelegate get_jointTypeDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_jointTypeDelegate>("UnityEngine.ArticulationBody::get_jointType");

		// Token: 0x040001F9 RID: 505
		private static readonly ArticulationBody.set_jointTypeDelegate set_jointTypeDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_jointTypeDelegate>("UnityEngine.ArticulationBody::set_jointType");

		// Token: 0x040001FA RID: 506
		private static readonly ArticulationBody.get_isRootDelegate get_isRootDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_isRootDelegate>("UnityEngine.ArticulationBody::get_isRoot");

		// Token: 0x040001FB RID: 507
		private static readonly ArticulationBody.get_linearLockXDelegate get_linearLockXDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearLockXDelegate>("UnityEngine.ArticulationBody::get_linearLockX");

		// Token: 0x040001FC RID: 508
		private static readonly ArticulationBody.set_linearLockXDelegate set_linearLockXDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearLockXDelegate>("UnityEngine.ArticulationBody::set_linearLockX");

		// Token: 0x040001FD RID: 509
		private static readonly ArticulationBody.get_linearLockYDelegate get_linearLockYDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearLockYDelegate>("UnityEngine.ArticulationBody::get_linearLockY");

		// Token: 0x040001FE RID: 510
		private static readonly ArticulationBody.set_linearLockYDelegate set_linearLockYDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearLockYDelegate>("UnityEngine.ArticulationBody::set_linearLockY");

		// Token: 0x040001FF RID: 511
		private static readonly ArticulationBody.get_linearLockZDelegate get_linearLockZDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearLockZDelegate>("UnityEngine.ArticulationBody::get_linearLockZ");

		// Token: 0x04000200 RID: 512
		private static readonly ArticulationBody.set_linearLockZDelegate set_linearLockZDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearLockZDelegate>("UnityEngine.ArticulationBody::set_linearLockZ");

		// Token: 0x04000201 RID: 513
		private static readonly ArticulationBody.get_swingYLockDelegate get_swingYLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_swingYLockDelegate>("UnityEngine.ArticulationBody::get_swingYLock");

		// Token: 0x04000202 RID: 514
		private static readonly ArticulationBody.set_swingYLockDelegate set_swingYLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_swingYLockDelegate>("UnityEngine.ArticulationBody::set_swingYLock");

		// Token: 0x04000203 RID: 515
		private static readonly ArticulationBody.get_swingZLockDelegate get_swingZLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_swingZLockDelegate>("UnityEngine.ArticulationBody::get_swingZLock");

		// Token: 0x04000204 RID: 516
		private static readonly ArticulationBody.set_swingZLockDelegate set_swingZLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_swingZLockDelegate>("UnityEngine.ArticulationBody::set_swingZLock");

		// Token: 0x04000205 RID: 517
		private static readonly ArticulationBody.get_twistLockDelegate get_twistLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_twistLockDelegate>("UnityEngine.ArticulationBody::get_twistLock");

		// Token: 0x04000206 RID: 518
		private static readonly ArticulationBody.set_twistLockDelegate set_twistLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_twistLockDelegate>("UnityEngine.ArticulationBody::set_twistLock");

		// Token: 0x04000207 RID: 519
		private static readonly ArticulationBody.get_immovableDelegate get_immovableDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_immovableDelegate>("UnityEngine.ArticulationBody::get_immovable");

		// Token: 0x04000208 RID: 520
		private static readonly ArticulationBody.set_immovableDelegate set_immovableDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_immovableDelegate>("UnityEngine.ArticulationBody::set_immovable");

		// Token: 0x04000209 RID: 521
		private static readonly ArticulationBody.get_useGravityDelegate get_useGravityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_useGravityDelegate>("UnityEngine.ArticulationBody::get_useGravity");

		// Token: 0x0400020A RID: 522
		private static readonly ArticulationBody.set_useGravityDelegate set_useGravityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_useGravityDelegate>("UnityEngine.ArticulationBody::set_useGravity");

		// Token: 0x0400020B RID: 523
		private static readonly ArticulationBody.get_linearDampingDelegate get_linearDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearDampingDelegate>("UnityEngine.ArticulationBody::get_linearDamping");

		// Token: 0x0400020C RID: 524
		private static readonly ArticulationBody.set_linearDampingDelegate set_linearDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearDampingDelegate>("UnityEngine.ArticulationBody::set_linearDamping");

		// Token: 0x0400020D RID: 525
		private static readonly ArticulationBody.get_angularDampingDelegate get_angularDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_angularDampingDelegate>("UnityEngine.ArticulationBody::get_angularDamping");

		// Token: 0x0400020E RID: 526
		private static readonly ArticulationBody.set_angularDampingDelegate set_angularDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_angularDampingDelegate>("UnityEngine.ArticulationBody::set_angularDamping");

		// Token: 0x0400020F RID: 527
		private static readonly ArticulationBody.get_jointFrictionDelegate get_jointFrictionDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_jointFrictionDelegate>("UnityEngine.ArticulationBody::get_jointFriction");

		// Token: 0x04000210 RID: 528
		private static readonly ArticulationBody.set_jointFrictionDelegate set_jointFrictionDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_jointFrictionDelegate>("UnityEngine.ArticulationBody::set_jointFriction");

		// Token: 0x04000211 RID: 529
		private static readonly ArticulationBody.get_massDelegate get_massDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_massDelegate>("UnityEngine.ArticulationBody::get_mass");

		// Token: 0x04000212 RID: 530
		private static readonly ArticulationBody.set_massDelegate set_massDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_massDelegate>("UnityEngine.ArticulationBody::set_mass");

		// Token: 0x04000213 RID: 531
		private static readonly ArticulationBody.ResetCenterOfMassDelegate ResetCenterOfMassDelegateField = IL2CPP.ResolveICall<ArticulationBody.ResetCenterOfMassDelegate>("UnityEngine.ArticulationBody::ResetCenterOfMass");

		// Token: 0x04000214 RID: 532
		private static readonly ArticulationBody.ResetInertiaTensorDelegate ResetInertiaTensorDelegateField = IL2CPP.ResolveICall<ArticulationBody.ResetInertiaTensorDelegate>("UnityEngine.ArticulationBody::ResetInertiaTensor");

		// Token: 0x04000215 RID: 533
		private static readonly ArticulationBody.SleepDelegate SleepDelegateField = IL2CPP.ResolveICall<ArticulationBody.SleepDelegate>("UnityEngine.ArticulationBody::Sleep");

		// Token: 0x04000216 RID: 534
		private static readonly ArticulationBody.IsSleepingDelegate IsSleepingDelegateField = IL2CPP.ResolveICall<ArticulationBody.IsSleepingDelegate>("UnityEngine.ArticulationBody::IsSleeping");

		// Token: 0x04000217 RID: 535
		private static readonly ArticulationBody.WakeUpDelegate WakeUpDelegateField = IL2CPP.ResolveICall<ArticulationBody.WakeUpDelegate>("UnityEngine.ArticulationBody::WakeUp");

		// Token: 0x04000218 RID: 536
		private static readonly ArticulationBody.get_sleepThresholdDelegate get_sleepThresholdDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_sleepThresholdDelegate>("UnityEngine.ArticulationBody::get_sleepThreshold");

		// Token: 0x04000219 RID: 537
		private static readonly ArticulationBody.set_sleepThresholdDelegate set_sleepThresholdDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_sleepThresholdDelegate>("UnityEngine.ArticulationBody::set_sleepThreshold");

		// Token: 0x0400021A RID: 538
		private static readonly ArticulationBody.get_solverIterationsDelegate get_solverIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_solverIterationsDelegate>("UnityEngine.ArticulationBody::get_solverIterations");

		// Token: 0x0400021B RID: 539
		private static readonly ArticulationBody.set_solverIterationsDelegate set_solverIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_solverIterationsDelegate>("UnityEngine.ArticulationBody::set_solverIterations");

		// Token: 0x0400021C RID: 540
		private static readonly ArticulationBody.get_solverVelocityIterationsDelegate get_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_solverVelocityIterationsDelegate>("UnityEngine.ArticulationBody::get_solverVelocityIterations");

		// Token: 0x0400021D RID: 541
		private static readonly ArticulationBody.set_solverVelocityIterationsDelegate set_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_solverVelocityIterationsDelegate>("UnityEngine.ArticulationBody::set_solverVelocityIterations");

		// Token: 0x0400021E RID: 542
		private static readonly ArticulationBody.get_maxAngularVelocityDelegate get_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxAngularVelocityDelegate>("UnityEngine.ArticulationBody::get_maxAngularVelocity");

		// Token: 0x0400021F RID: 543
		private static readonly ArticulationBody.set_maxAngularVelocityDelegate set_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxAngularVelocityDelegate>("UnityEngine.ArticulationBody::set_maxAngularVelocity");

		// Token: 0x04000220 RID: 544
		private static readonly ArticulationBody.get_maxLinearVelocityDelegate get_maxLinearVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxLinearVelocityDelegate>("UnityEngine.ArticulationBody::get_maxLinearVelocity");

		// Token: 0x04000221 RID: 545
		private static readonly ArticulationBody.set_maxLinearVelocityDelegate set_maxLinearVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxLinearVelocityDelegate>("UnityEngine.ArticulationBody::set_maxLinearVelocity");

		// Token: 0x04000222 RID: 546
		private static readonly ArticulationBody.get_maxJointVelocityDelegate get_maxJointVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxJointVelocityDelegate>("UnityEngine.ArticulationBody::get_maxJointVelocity");

		// Token: 0x04000223 RID: 547
		private static readonly ArticulationBody.set_maxJointVelocityDelegate set_maxJointVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxJointVelocityDelegate>("UnityEngine.ArticulationBody::set_maxJointVelocity");

		// Token: 0x04000224 RID: 548
		private static readonly ArticulationBody.get_maxDepenetrationVelocityDelegate get_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxDepenetrationVelocityDelegate>("UnityEngine.ArticulationBody::get_maxDepenetrationVelocity");

		// Token: 0x04000225 RID: 549
		private static readonly ArticulationBody.set_maxDepenetrationVelocityDelegate set_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxDepenetrationVelocityDelegate>("UnityEngine.ArticulationBody::set_maxDepenetrationVelocity");

		// Token: 0x04000226 RID: 550
		private static readonly ArticulationBody.get_dofCountDelegate get_dofCountDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_dofCountDelegate>("UnityEngine.ArticulationBody::get_dofCount");

		// Token: 0x04000227 RID: 551
		private static readonly ArticulationBody.get_indexDelegate get_indexDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_indexDelegate>("UnityEngine.ArticulationBody::get_index");

		// Token: 0x04000228 RID: 552
		private static readonly ArticulationBody.GetJointPositionsDelegate GetJointPositionsDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointPositionsDelegate>("UnityEngine.ArticulationBody::GetJointPositions");

		// Token: 0x04000229 RID: 553
		private static readonly ArticulationBody.SetJointPositionsDelegate SetJointPositionsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointPositionsDelegate>("UnityEngine.ArticulationBody::SetJointPositions");

		// Token: 0x0400022A RID: 554
		private static readonly ArticulationBody.GetJointVelocitiesDelegate GetJointVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointVelocitiesDelegate>("UnityEngine.ArticulationBody::GetJointVelocities");

		// Token: 0x0400022B RID: 555
		private static readonly ArticulationBody.SetJointVelocitiesDelegate SetJointVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointVelocitiesDelegate>("UnityEngine.ArticulationBody::SetJointVelocities");

		// Token: 0x0400022C RID: 556
		private static readonly ArticulationBody.GetJointAccelerationsDelegate GetJointAccelerationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointAccelerationsDelegate>("UnityEngine.ArticulationBody::GetJointAccelerations");

		// Token: 0x0400022D RID: 557
		private static readonly ArticulationBody.SetJointAccelerationsDelegate SetJointAccelerationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointAccelerationsDelegate>("UnityEngine.ArticulationBody::SetJointAccelerations");

		// Token: 0x0400022E RID: 558
		private static readonly ArticulationBody.GetJointForcesDelegate GetJointForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointForcesDelegate>("UnityEngine.ArticulationBody::GetJointForces");

		// Token: 0x0400022F RID: 559
		private static readonly ArticulationBody.SetJointForcesDelegate SetJointForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointForcesDelegate>("UnityEngine.ArticulationBody::SetJointForces");

		// Token: 0x04000230 RID: 560
		private static readonly ArticulationBody.GetDriveTargetsDelegate GetDriveTargetsDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDriveTargetsDelegate>("UnityEngine.ArticulationBody::GetDriveTargets");

		// Token: 0x04000231 RID: 561
		private static readonly ArticulationBody.SetDriveTargetsDelegate SetDriveTargetsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveTargetsDelegate>("UnityEngine.ArticulationBody::SetDriveTargets");

		// Token: 0x04000232 RID: 562
		private static readonly ArticulationBody.GetDriveTargetVelocitiesDelegate GetDriveTargetVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDriveTargetVelocitiesDelegate>("UnityEngine.ArticulationBody::GetDriveTargetVelocities");

		// Token: 0x04000233 RID: 563
		private static readonly ArticulationBody.SetDriveTargetVelocitiesDelegate SetDriveTargetVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveTargetVelocitiesDelegate>("UnityEngine.ArticulationBody::SetDriveTargetVelocities");

		// Token: 0x04000234 RID: 564
		private static readonly ArticulationBody.GetDofStartIndicesDelegate GetDofStartIndicesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDofStartIndicesDelegate>("UnityEngine.ArticulationBody::GetDofStartIndices");

		// Token: 0x04000235 RID: 565
		private static readonly ArticulationBody.get_collisionDetectionModeDelegate get_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_collisionDetectionModeDelegate>("UnityEngine.ArticulationBody::get_collisionDetectionMode");

		// Token: 0x04000236 RID: 566
		private static readonly ArticulationBody.set_collisionDetectionModeDelegate set_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_collisionDetectionModeDelegate>("UnityEngine.ArticulationBody::set_collisionDetectionMode");

		// Token: 0x04000237 RID: 567
		private static readonly ArticulationBody.get_anchorPosition_InjectedDelegate get_anchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_anchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::get_anchorPosition_Injected");

		// Token: 0x04000238 RID: 568
		private static readonly ArticulationBody.set_anchorPosition_InjectedDelegate set_anchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_anchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::set_anchorPosition_Injected");

		// Token: 0x04000239 RID: 569
		private static readonly ArticulationBody.get_parentAnchorPosition_InjectedDelegate get_parentAnchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_parentAnchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::get_parentAnchorPosition_Injected");

		// Token: 0x0400023A RID: 570
		private static readonly ArticulationBody.set_parentAnchorPosition_InjectedDelegate set_parentAnchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_parentAnchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::set_parentAnchorPosition_Injected");

		// Token: 0x0400023B RID: 571
		private static readonly ArticulationBody.get_anchorRotation_InjectedDelegate get_anchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_anchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_anchorRotation_Injected");

		// Token: 0x0400023C RID: 572
		private static readonly ArticulationBody.set_anchorRotation_InjectedDelegate set_anchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_anchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_anchorRotation_Injected");

		// Token: 0x0400023D RID: 573
		private static readonly ArticulationBody.get_parentAnchorRotation_InjectedDelegate get_parentAnchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_parentAnchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_parentAnchorRotation_Injected");

		// Token: 0x0400023E RID: 574
		private static readonly ArticulationBody.set_parentAnchorRotation_InjectedDelegate set_parentAnchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_parentAnchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_parentAnchorRotation_Injected");

		// Token: 0x0400023F RID: 575
		private static readonly ArticulationBody.AddForce_InjectedDelegate AddForce_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddForce_InjectedDelegate>("UnityEngine.ArticulationBody::AddForce_Injected");

		// Token: 0x04000240 RID: 576
		private static readonly ArticulationBody.AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddRelativeForce_InjectedDelegate>("UnityEngine.ArticulationBody::AddRelativeForce_Injected");

		// Token: 0x04000241 RID: 577
		private static readonly ArticulationBody.AddTorque_InjectedDelegate AddTorque_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddTorque_InjectedDelegate>("UnityEngine.ArticulationBody::AddTorque_Injected");

		// Token: 0x04000242 RID: 578
		private static readonly ArticulationBody.AddRelativeTorque_InjectedDelegate AddRelativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddRelativeTorque_InjectedDelegate>("UnityEngine.ArticulationBody::AddRelativeTorque_Injected");

		// Token: 0x04000243 RID: 579
		private static readonly ArticulationBody.AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddForceAtPosition_InjectedDelegate>("UnityEngine.ArticulationBody::AddForceAtPosition_Injected");

		// Token: 0x04000244 RID: 580
		private static readonly ArticulationBody.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_velocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_velocity_Injected");

		// Token: 0x04000245 RID: 581
		private static readonly ArticulationBody.set_velocity_InjectedDelegate set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_velocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_velocity_Injected");

		// Token: 0x04000246 RID: 582
		private static readonly ArticulationBody.get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_angularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_angularVelocity_Injected");

		// Token: 0x04000247 RID: 583
		private static readonly ArticulationBody.set_angularVelocity_InjectedDelegate set_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_angularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_angularVelocity_Injected");

		// Token: 0x04000248 RID: 584
		private static readonly ArticulationBody.get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_centerOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::get_centerOfMass_Injected");

		// Token: 0x04000249 RID: 585
		private static readonly ArticulationBody.set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_centerOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::set_centerOfMass_Injected");

		// Token: 0x0400024A RID: 586
		private static readonly ArticulationBody.get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_worldCenterOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::get_worldCenterOfMass_Injected");

		// Token: 0x0400024B RID: 587
		private static readonly ArticulationBody.get_inertiaTensor_InjectedDelegate get_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_inertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::get_inertiaTensor_Injected");

		// Token: 0x0400024C RID: 588
		private static readonly ArticulationBody.set_inertiaTensor_InjectedDelegate set_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_inertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::set_inertiaTensor_Injected");

		// Token: 0x0400024D RID: 589
		private static readonly ArticulationBody.get_inertiaTensorRotation_InjectedDelegate get_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_inertiaTensorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_inertiaTensorRotation_Injected");

		// Token: 0x0400024E RID: 590
		private static readonly ArticulationBody.set_inertiaTensorRotation_InjectedDelegate set_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_inertiaTensorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_inertiaTensorRotation_Injected");

		// Token: 0x0400024F RID: 591
		private static readonly ArticulationBody.TeleportRoot_InjectedDelegate TeleportRoot_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.TeleportRoot_InjectedDelegate>("UnityEngine.ArticulationBody::TeleportRoot_Injected");

		// Token: 0x04000250 RID: 592
		private static readonly ArticulationBody.GetClosestPoint_InjectedDelegate GetClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetClosestPoint_InjectedDelegate>("UnityEngine.ArticulationBody::GetClosestPoint_Injected");

		// Token: 0x04000251 RID: 593
		private static readonly ArticulationBody.GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetRelativePointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::GetRelativePointVelocity_Injected");

		// Token: 0x04000252 RID: 594
		private static readonly ArticulationBody.GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetPointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::GetPointVelocity_Injected");

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x06000590 RID: 1424
		private delegate ArticulationJointType get_jointTypeDelegate(IntPtr @this);

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x06000592 RID: 1426
		private delegate void set_jointTypeDelegate(IntPtr @this, ArticulationJointType value);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x06000594 RID: 1428
		private delegate bool get_isRootDelegate(IntPtr @this);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x06000596 RID: 1430
		private delegate ArticulationDofLock get_linearLockXDelegate(IntPtr @this);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x06000598 RID: 1432
		private delegate void set_linearLockXDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x0600059A RID: 1434
		private delegate ArticulationDofLock get_linearLockYDelegate(IntPtr @this);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x0600059C RID: 1436
		private delegate void set_linearLockYDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x0600059E RID: 1438
		private delegate ArticulationDofLock get_linearLockZDelegate(IntPtr @this);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x060005A0 RID: 1440
		private delegate void set_linearLockZDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x060005A2 RID: 1442
		private delegate ArticulationDofLock get_swingYLockDelegate(IntPtr @this);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x060005A4 RID: 1444
		private delegate void set_swingYLockDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x060005A6 RID: 1446
		private delegate ArticulationDofLock get_swingZLockDelegate(IntPtr @this);

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x060005A8 RID: 1448
		private delegate void set_swingZLockDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x060005AA RID: 1450
		private delegate ArticulationDofLock get_twistLockDelegate(IntPtr @this);

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x060005AC RID: 1452
		private delegate void set_twistLockDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x060005AE RID: 1454
		private delegate bool get_immovableDelegate(IntPtr @this);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x060005B0 RID: 1456
		private delegate void set_immovableDelegate(IntPtr @this, bool value);

		// Token: 0x02000147 RID: 327
		// (Invoke) Token: 0x060005B2 RID: 1458
		private delegate bool get_useGravityDelegate(IntPtr @this);

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x060005B4 RID: 1460
		private delegate void set_useGravityDelegate(IntPtr @this, bool value);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x060005B6 RID: 1462
		private delegate float get_linearDampingDelegate(IntPtr @this);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x060005B8 RID: 1464
		private delegate void set_linearDampingDelegate(IntPtr @this, float value);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x060005BA RID: 1466
		private delegate float get_angularDampingDelegate(IntPtr @this);

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x060005BC RID: 1468
		private delegate void set_angularDampingDelegate(IntPtr @this, float value);

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x060005BE RID: 1470
		private delegate float get_jointFrictionDelegate(IntPtr @this);

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x060005C0 RID: 1472
		private delegate void set_jointFrictionDelegate(IntPtr @this, float value);

		// Token: 0x0200014F RID: 335
		// (Invoke) Token: 0x060005C2 RID: 1474
		private delegate float get_massDelegate(IntPtr @this);

		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x060005C4 RID: 1476
		private delegate void set_massDelegate(IntPtr @this, float value);

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x060005C6 RID: 1478
		private delegate void ResetCenterOfMassDelegate(IntPtr @this);

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x060005C8 RID: 1480
		private delegate void ResetInertiaTensorDelegate(IntPtr @this);

		// Token: 0x02000153 RID: 339
		// (Invoke) Token: 0x060005CA RID: 1482
		private delegate void SleepDelegate(IntPtr @this);

		// Token: 0x02000154 RID: 340
		// (Invoke) Token: 0x060005CC RID: 1484
		private delegate bool IsSleepingDelegate(IntPtr @this);

		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x060005CE RID: 1486
		private delegate void WakeUpDelegate(IntPtr @this);

		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x060005D0 RID: 1488
		private delegate float get_sleepThresholdDelegate(IntPtr @this);

		// Token: 0x02000157 RID: 343
		// (Invoke) Token: 0x060005D2 RID: 1490
		private delegate void set_sleepThresholdDelegate(IntPtr @this, float value);

		// Token: 0x02000158 RID: 344
		// (Invoke) Token: 0x060005D4 RID: 1492
		private delegate int get_solverIterationsDelegate(IntPtr @this);

		// Token: 0x02000159 RID: 345
		// (Invoke) Token: 0x060005D6 RID: 1494
		private delegate void set_solverIterationsDelegate(IntPtr @this, int value);

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x060005D8 RID: 1496
		private delegate int get_solverVelocityIterationsDelegate(IntPtr @this);

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x060005DA RID: 1498
		private delegate void set_solverVelocityIterationsDelegate(IntPtr @this, int value);

		// Token: 0x0200015C RID: 348
		// (Invoke) Token: 0x060005DC RID: 1500
		private delegate float get_maxAngularVelocityDelegate(IntPtr @this);

		// Token: 0x0200015D RID: 349
		// (Invoke) Token: 0x060005DE RID: 1502
		private delegate void set_maxAngularVelocityDelegate(IntPtr @this, float value);

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x060005E0 RID: 1504
		private delegate float get_maxLinearVelocityDelegate(IntPtr @this);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x060005E2 RID: 1506
		private delegate void set_maxLinearVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x060005E4 RID: 1508
		private delegate float get_maxJointVelocityDelegate(IntPtr @this);

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x060005E6 RID: 1510
		private delegate void set_maxJointVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x060005E8 RID: 1512
		private delegate float get_maxDepenetrationVelocityDelegate(IntPtr @this);

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x060005EA RID: 1514
		private delegate void set_maxDepenetrationVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x060005EC RID: 1516
		private delegate int get_dofCountDelegate(IntPtr @this);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x060005EE RID: 1518
		private delegate int get_indexDelegate(IntPtr @this);

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x060005F0 RID: 1520
		private delegate int GetJointPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x060005F2 RID: 1522
		private delegate void SetJointPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x060005F4 RID: 1524
		private delegate int GetJointVelocitiesDelegate(IntPtr @this, IntPtr velocities);

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x060005F6 RID: 1526
		private delegate void SetJointVelocitiesDelegate(IntPtr @this, IntPtr velocities);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x060005F8 RID: 1528
		private delegate int GetJointAccelerationsDelegate(IntPtr @this, IntPtr accelerations);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x060005FA RID: 1530
		private delegate void SetJointAccelerationsDelegate(IntPtr @this, IntPtr accelerations);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x060005FC RID: 1532
		private delegate int GetJointForcesDelegate(IntPtr @this, IntPtr forces);

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x060005FE RID: 1534
		private delegate void SetJointForcesDelegate(IntPtr @this, IntPtr forces);

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x06000600 RID: 1536
		private delegate int GetDriveTargetsDelegate(IntPtr @this, IntPtr targets);

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x06000602 RID: 1538
		private delegate void SetDriveTargetsDelegate(IntPtr @this, IntPtr targets);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x06000604 RID: 1540
		private delegate int GetDriveTargetVelocitiesDelegate(IntPtr @this, IntPtr targetVelocities);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x06000606 RID: 1542
		private delegate void SetDriveTargetVelocitiesDelegate(IntPtr @this, IntPtr targetVelocities);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x06000608 RID: 1544
		private delegate int GetDofStartIndicesDelegate(IntPtr @this, IntPtr dofStartIndices);

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x0600060A RID: 1546
		private delegate CollisionDetectionMode get_collisionDetectionModeDelegate(IntPtr @this);

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x0600060C RID: 1548
		private delegate void set_collisionDetectionModeDelegate(IntPtr @this, CollisionDetectionMode value);

		// Token: 0x02000175 RID: 373
		// (Invoke) Token: 0x0600060E RID: 1550
		private delegate void get_anchorPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x06000610 RID: 1552
		private delegate void set_anchorPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000177 RID: 375
		// (Invoke) Token: 0x06000612 RID: 1554
		private delegate void get_parentAnchorPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x06000614 RID: 1556
		private delegate void set_parentAnchorPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x06000616 RID: 1558
		private delegate void get_anchorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x06000618 RID: 1560
		private delegate void set_anchorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x0600061A RID: 1562
		private delegate void get_parentAnchorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x0600061C RID: 1564
		private delegate void set_parentAnchorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x0600061E RID: 1566
		private delegate void AddForce_InjectedDelegate(IntPtr @this, IntPtr force);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x06000620 RID: 1568
		private delegate void AddRelativeForce_InjectedDelegate(IntPtr @this, IntPtr force);

		// Token: 0x0200017F RID: 383
		// (Invoke) Token: 0x06000622 RID: 1570
		private delegate void AddTorque_InjectedDelegate(IntPtr @this, IntPtr torque);

		// Token: 0x02000180 RID: 384
		// (Invoke) Token: 0x06000624 RID: 1572
		private delegate void AddRelativeTorque_InjectedDelegate(IntPtr @this, IntPtr torque);

		// Token: 0x02000181 RID: 385
		// (Invoke) Token: 0x06000626 RID: 1574
		private delegate void AddForceAtPosition_InjectedDelegate(IntPtr @this, IntPtr force, IntPtr position);

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x06000628 RID: 1576
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x0600062A RID: 1578
		private delegate void set_velocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x0600062C RID: 1580
		private delegate void get_angularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x0600062E RID: 1582
		private delegate void set_angularVelocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x06000630 RID: 1584
		private delegate void get_centerOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x06000632 RID: 1586
		private delegate void set_centerOfMass_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x06000634 RID: 1588
		private delegate void get_worldCenterOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x06000636 RID: 1590
		private delegate void get_inertiaTensor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x06000638 RID: 1592
		private delegate void set_inertiaTensor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x0600063A RID: 1594
		private delegate void get_inertiaTensorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x0600063C RID: 1596
		private delegate void set_inertiaTensorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200018D RID: 397
		// (Invoke) Token: 0x0600063E RID: 1598
		private delegate void TeleportRoot_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr rotation);

		// Token: 0x0200018E RID: 398
		// (Invoke) Token: 0x06000640 RID: 1600
		private delegate void GetClosestPoint_InjectedDelegate(IntPtr @this, IntPtr point, [Out] IntPtr ret);

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x06000642 RID: 1602
		private delegate void GetRelativePointVelocity_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x06000644 RID: 1604
		private delegate void GetPointVelocity_InjectedDelegate(IntPtr @this, IntPtr worldPoint, [Out] IntPtr ret);
	}
}
