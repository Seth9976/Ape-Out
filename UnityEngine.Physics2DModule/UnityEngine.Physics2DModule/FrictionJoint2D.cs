using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	public sealed class FrictionJoint2D : AnchoredJoint2D
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00003A23 File Offset: 0x00001C23
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00003A35 File Offset: 0x00001C35
		public float maxForce
		{
			get
			{
				return FrictionJoint2D.get_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FrictionJoint2D.set_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00003A48 File Offset: 0x00001C48
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00003A5A File Offset: 0x00001C5A
		public float maxTorque
		{
			get
			{
				return FrictionJoint2D.get_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FrictionJoint2D.set_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000230 RID: 560
		private static readonly FrictionJoint2D.get_maxForceDelegate get_maxForceDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.get_maxForceDelegate>("UnityEngine.FrictionJoint2D::get_maxForce");

		// Token: 0x04000231 RID: 561
		private static readonly FrictionJoint2D.set_maxForceDelegate set_maxForceDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.set_maxForceDelegate>("UnityEngine.FrictionJoint2D::set_maxForce");

		// Token: 0x04000232 RID: 562
		private static readonly FrictionJoint2D.get_maxTorqueDelegate get_maxTorqueDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.get_maxTorqueDelegate>("UnityEngine.FrictionJoint2D::get_maxTorque");

		// Token: 0x04000233 RID: 563
		private static readonly FrictionJoint2D.set_maxTorqueDelegate set_maxTorqueDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.set_maxTorqueDelegate>("UnityEngine.FrictionJoint2D::set_maxTorque");

		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x06000676 RID: 1654
		private delegate float get_maxForceDelegate(IntPtr @this);

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x06000678 RID: 1656
		private delegate void set_maxForceDelegate(IntPtr @this, float value);

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x0600067A RID: 1658
		private delegate float get_maxTorqueDelegate(IntPtr @this);

		// Token: 0x02000153 RID: 339
		// (Invoke) Token: 0x0600067C RID: 1660
		private delegate void set_maxTorqueDelegate(IntPtr @this, float value);
	}
}
