using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000030 RID: 48
	public sealed class ConstantForce2D : PhysicsUpdateBehaviour2D
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000E174 File Offset: 0x0000C374
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x0000445C File Offset: 0x0000265C
		public Vector2 force
		{
			get
			{
				Vector2 vector;
				this.get_force_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_force_Injected(ref value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000E18C File Offset: 0x0000C38C
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00004466 File Offset: 0x00002666
		public Vector2 relativeForce
		{
			get
			{
				Vector2 vector;
				this.get_relativeForce_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_relativeForce_Injected(ref value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00004470 File Offset: 0x00002670
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00004482 File Offset: 0x00002682
		public float torque
		{
			get
			{
				return ConstantForce2D.get_torqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConstantForce2D.set_torqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00004495 File Offset: 0x00002695
		public void get_force_Injected(out Vector2 ret)
		{
			ConstantForce2D.get_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000044A8 File Offset: 0x000026A8
		public void set_force_Injected(ref Vector2 value)
		{
			ConstantForce2D.set_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000044BB File Offset: 0x000026BB
		public void get_relativeForce_Injected(out Vector2 ret)
		{
			ConstantForce2D.get_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000044CE File Offset: 0x000026CE
		public void set_relativeForce_Injected(ref Vector2 value)
		{
			ConstantForce2D.set_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040002BC RID: 700
		private static readonly ConstantForce2D.get_torqueDelegate get_torqueDelegateField = IL2CPP.ResolveICall<ConstantForce2D.get_torqueDelegate>("UnityEngine.ConstantForce2D::get_torque");

		// Token: 0x040002BD RID: 701
		private static readonly ConstantForce2D.set_torqueDelegate set_torqueDelegateField = IL2CPP.ResolveICall<ConstantForce2D.set_torqueDelegate>("UnityEngine.ConstantForce2D::set_torque");

		// Token: 0x040002BE RID: 702
		private static readonly ConstantForce2D.get_force_InjectedDelegate get_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.get_force_InjectedDelegate>("UnityEngine.ConstantForce2D::get_force_Injected");

		// Token: 0x040002BF RID: 703
		private static readonly ConstantForce2D.set_force_InjectedDelegate set_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.set_force_InjectedDelegate>("UnityEngine.ConstantForce2D::set_force_Injected");

		// Token: 0x040002C0 RID: 704
		private static readonly ConstantForce2D.get_relativeForce_InjectedDelegate get_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.get_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce2D::get_relativeForce_Injected");

		// Token: 0x040002C1 RID: 705
		private static readonly ConstantForce2D.set_relativeForce_InjectedDelegate set_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.set_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce2D::set_relativeForce_Injected");

		// Token: 0x020001DC RID: 476
		// (Invoke) Token: 0x0600078E RID: 1934
		private delegate float get_torqueDelegate(IntPtr @this);

		// Token: 0x020001DD RID: 477
		// (Invoke) Token: 0x06000790 RID: 1936
		private delegate void set_torqueDelegate(IntPtr @this, float value);

		// Token: 0x020001DE RID: 478
		// (Invoke) Token: 0x06000792 RID: 1938
		private delegate void get_force_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001DF RID: 479
		// (Invoke) Token: 0x06000794 RID: 1940
		private delegate void set_force_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001E0 RID: 480
		// (Invoke) Token: 0x06000796 RID: 1942
		private delegate void get_relativeForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001E1 RID: 481
		// (Invoke) Token: 0x06000798 RID: 1944
		private delegate void set_relativeForce_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
