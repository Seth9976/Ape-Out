using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	public class Joint2D : Behaviour
	{
		// Token: 0x0600033C RID: 828 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		// Note: this type is marked as 'beforefieldinit'.
		static Joint2D()
		{
			Il2CppClassPointerStore<Joint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Joint2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Joint2D>.NativeClassPtr);
			Joint2D.get_attachedRigidbodyDelegateField = IL2CPP.ResolveICall<Joint2D.get_attachedRigidbodyDelegate>("UnityEngine.Joint2D::get_attachedRigidbody");
			Joint2D.get_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint2D.get_connectedBodyDelegate>("UnityEngine.Joint2D::get_connectedBody");
			Joint2D.set_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint2D.set_connectedBodyDelegate>("UnityEngine.Joint2D::set_connectedBody");
			Joint2D.get_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint2D.get_enableCollisionDelegate>("UnityEngine.Joint2D::get_enableCollision");
			Joint2D.set_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint2D.set_enableCollisionDelegate>("UnityEngine.Joint2D::set_enableCollision");
			Joint2D.get_breakForceDelegateField = IL2CPP.ResolveICall<Joint2D.get_breakForceDelegate>("UnityEngine.Joint2D::get_breakForce");
			Joint2D.set_breakForceDelegateField = IL2CPP.ResolveICall<Joint2D.set_breakForceDelegate>("UnityEngine.Joint2D::set_breakForce");
			Joint2D.get_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.get_breakTorqueDelegate>("UnityEngine.Joint2D::get_breakTorque");
			Joint2D.set_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.set_breakTorqueDelegate>("UnityEngine.Joint2D::set_breakTorque");
			Joint2D.get_reactionTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.get_reactionTorqueDelegate>("UnityEngine.Joint2D::get_reactionTorque");
			Joint2D.GetReactionTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.GetReactionTorqueDelegate>("UnityEngine.Joint2D::GetReactionTorque");
			Joint2D.get_reactionForce_InjectedDelegateField = IL2CPP.ResolveICall<Joint2D.get_reactionForce_InjectedDelegate>("UnityEngine.Joint2D::get_reactionForce_Injected");
			Joint2D.GetReactionForce_InjectedDelegateField = IL2CPP.ResolveICall<Joint2D.GetReactionForce_InjectedDelegate>("UnityEngine.Joint2D::GetReactionForce_Injected");
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000353B File Offset: 0x0000173B
		public Joint2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		public Rigidbody2D attachedRigidbody
		{
			get
			{
				IntPtr intPtr = Joint2D.get_attachedRigidbodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000D21C File Offset: 0x0000B41C
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00003544 File Offset: 0x00001744
		public Rigidbody2D connectedBody
		{
			get
			{
				IntPtr intPtr = Joint2D.get_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				Joint2D.set_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000355C File Offset: 0x0000175C
		// (set) Token: 0x06000342 RID: 834 RVA: 0x0000356E File Offset: 0x0000176E
		public bool enableCollision
		{
			get
			{
				return Joint2D.get_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00003581 File Offset: 0x00001781
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00003593 File Offset: 0x00001793
		public float breakForce
		{
			get
			{
				return Joint2D.get_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000035A6 File Offset: 0x000017A6
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000035B8 File Offset: 0x000017B8
		public float breakTorque
		{
			get
			{
				return Joint2D.get_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000D248 File Offset: 0x0000B448
		public Vector2 reactionForce
		{
			get
			{
				Vector2 vector;
				this.get_reactionForce_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000035CB File Offset: 0x000017CB
		public float reactionTorque
		{
			get
			{
				return Joint2D.get_reactionTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000D260 File Offset: 0x0000B460
		public Vector2 GetReactionForce(float timeStep)
		{
			Vector2 vector;
			this.GetReactionForce_Injected(timeStep, out vector);
			return vector;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000035DD File Offset: 0x000017DD
		public float GetReactionTorque(float timeStep)
		{
			return Joint2D.GetReactionTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000035F0 File Offset: 0x000017F0
		public void get_reactionForce_Injected(out Vector2 ret)
		{
			Joint2D.get_reactionForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003603 File Offset: 0x00001803
		public void GetReactionForce_Injected(float timeStep, out Vector2 ret)
		{
			Joint2D.GetReactionForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep, out ret);
		}

		// Token: 0x040001DA RID: 474
		private static readonly Joint2D.get_attachedRigidbodyDelegate get_attachedRigidbodyDelegateField;

		// Token: 0x040001DB RID: 475
		private static readonly Joint2D.get_connectedBodyDelegate get_connectedBodyDelegateField;

		// Token: 0x040001DC RID: 476
		private static readonly Joint2D.set_connectedBodyDelegate set_connectedBodyDelegateField;

		// Token: 0x040001DD RID: 477
		private static readonly Joint2D.get_enableCollisionDelegate get_enableCollisionDelegateField;

		// Token: 0x040001DE RID: 478
		private static readonly Joint2D.set_enableCollisionDelegate set_enableCollisionDelegateField;

		// Token: 0x040001DF RID: 479
		private static readonly Joint2D.get_breakForceDelegate get_breakForceDelegateField;

		// Token: 0x040001E0 RID: 480
		private static readonly Joint2D.set_breakForceDelegate set_breakForceDelegateField;

		// Token: 0x040001E1 RID: 481
		private static readonly Joint2D.get_breakTorqueDelegate get_breakTorqueDelegateField;

		// Token: 0x040001E2 RID: 482
		private static readonly Joint2D.set_breakTorqueDelegate set_breakTorqueDelegateField;

		// Token: 0x040001E3 RID: 483
		private static readonly Joint2D.get_reactionTorqueDelegate get_reactionTorqueDelegateField;

		// Token: 0x040001E4 RID: 484
		private static readonly Joint2D.GetReactionTorqueDelegate GetReactionTorqueDelegateField;

		// Token: 0x040001E5 RID: 485
		private static readonly Joint2D.get_reactionForce_InjectedDelegate get_reactionForce_InjectedDelegateField;

		// Token: 0x040001E6 RID: 486
		private static readonly Joint2D.GetReactionForce_InjectedDelegate GetReactionForce_InjectedDelegateField;

		// Token: 0x02000114 RID: 276
		// (Invoke) Token: 0x06000602 RID: 1538
		private delegate IntPtr get_attachedRigidbodyDelegate(IntPtr @this);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x06000604 RID: 1540
		private delegate IntPtr get_connectedBodyDelegate(IntPtr @this);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x06000606 RID: 1542
		private delegate void set_connectedBodyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x06000608 RID: 1544
		private delegate bool get_enableCollisionDelegate(IntPtr @this);

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x0600060A RID: 1546
		private delegate void set_enableCollisionDelegate(IntPtr @this, bool value);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x0600060C RID: 1548
		private delegate float get_breakForceDelegate(IntPtr @this);

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x0600060E RID: 1550
		private delegate void set_breakForceDelegate(IntPtr @this, float value);

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x06000610 RID: 1552
		private delegate float get_breakTorqueDelegate(IntPtr @this);

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x06000612 RID: 1554
		private delegate void set_breakTorqueDelegate(IntPtr @this, float value);

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x06000614 RID: 1556
		private delegate float get_reactionTorqueDelegate(IntPtr @this);

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x06000616 RID: 1558
		private delegate float GetReactionTorqueDelegate(IntPtr @this, float timeStep);

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x06000618 RID: 1560
		private delegate void get_reactionForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x0600061A RID: 1562
		private delegate void GetReactionForce_InjectedDelegate(IntPtr @this, float timeStep, [Out] IntPtr ret);
	}
}
