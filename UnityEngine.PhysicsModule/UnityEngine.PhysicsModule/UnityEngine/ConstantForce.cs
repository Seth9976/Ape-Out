using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001E RID: 30
	public class ConstantForce : Behaviour
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00009F6C File Offset: 0x0000816C
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00003187 File Offset: 0x00001387
		public Vector3 force
		{
			get
			{
				Vector3 vector;
				this.get_force_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_force_Injected(ref value);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00009F84 File Offset: 0x00008184
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00003191 File Offset: 0x00001391
		public Vector3 relativeForce
		{
			get
			{
				Vector3 vector;
				this.get_relativeForce_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_relativeForce_Injected(ref value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00009F9C File Offset: 0x0000819C
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0000319B File Offset: 0x0000139B
		public Vector3 torque
		{
			get
			{
				Vector3 vector;
				this.get_torque_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_torque_Injected(ref value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00009FB4 File Offset: 0x000081B4
		// (set) Token: 0x06000282 RID: 642 RVA: 0x000031A5 File Offset: 0x000013A5
		public Vector3 relativeTorque
		{
			get
			{
				Vector3 vector;
				this.get_relativeTorque_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_relativeTorque_Injected(ref value);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000031AF File Offset: 0x000013AF
		public void get_force_Injected(out Vector3 ret)
		{
			ConstantForce.get_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000031C2 File Offset: 0x000013C2
		public void set_force_Injected(ref Vector3 value)
		{
			ConstantForce.set_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000031D5 File Offset: 0x000013D5
		public void get_relativeForce_Injected(out Vector3 ret)
		{
			ConstantForce.get_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000031E8 File Offset: 0x000013E8
		public void set_relativeForce_Injected(ref Vector3 value)
		{
			ConstantForce.set_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000031FB File Offset: 0x000013FB
		public void get_torque_Injected(out Vector3 ret)
		{
			ConstantForce.get_torque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000320E File Offset: 0x0000140E
		public void set_torque_Injected(ref Vector3 value)
		{
			ConstantForce.set_torque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003221 File Offset: 0x00001421
		public void get_relativeTorque_Injected(out Vector3 ret)
		{
			ConstantForce.get_relativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003234 File Offset: 0x00001434
		public void set_relativeTorque_Injected(ref Vector3 value)
		{
			ConstantForce.set_relativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000191 RID: 401
		private static readonly ConstantForce.get_force_InjectedDelegate get_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_force_InjectedDelegate>("UnityEngine.ConstantForce::get_force_Injected");

		// Token: 0x04000192 RID: 402
		private static readonly ConstantForce.set_force_InjectedDelegate set_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_force_InjectedDelegate>("UnityEngine.ConstantForce::set_force_Injected");

		// Token: 0x04000193 RID: 403
		private static readonly ConstantForce.get_relativeForce_InjectedDelegate get_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce::get_relativeForce_Injected");

		// Token: 0x04000194 RID: 404
		private static readonly ConstantForce.set_relativeForce_InjectedDelegate set_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce::set_relativeForce_Injected");

		// Token: 0x04000195 RID: 405
		private static readonly ConstantForce.get_torque_InjectedDelegate get_torque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_torque_InjectedDelegate>("UnityEngine.ConstantForce::get_torque_Injected");

		// Token: 0x04000196 RID: 406
		private static readonly ConstantForce.set_torque_InjectedDelegate set_torque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_torque_InjectedDelegate>("UnityEngine.ConstantForce::set_torque_Injected");

		// Token: 0x04000197 RID: 407
		private static readonly ConstantForce.get_relativeTorque_InjectedDelegate get_relativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_relativeTorque_InjectedDelegate>("UnityEngine.ConstantForce::get_relativeTorque_Injected");

		// Token: 0x04000198 RID: 408
		private static readonly ConstantForce.set_relativeTorque_InjectedDelegate set_relativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_relativeTorque_InjectedDelegate>("UnityEngine.ConstantForce::set_relativeTorque_Injected");

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x060004D4 RID: 1236
		private delegate void get_force_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x060004D6 RID: 1238
		private delegate void set_force_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x060004D8 RID: 1240
		private delegate void get_relativeForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x060004DA RID: 1242
		private delegate void set_relativeForce_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x060004DC RID: 1244
		private delegate void get_torque_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x060004DE RID: 1246
		private delegate void set_torque_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x060004E0 RID: 1248
		private delegate void get_relativeTorque_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x060004E2 RID: 1250
		private delegate void set_relativeTorque_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
