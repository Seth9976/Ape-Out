using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public class Joint : Component
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000A150 File Offset: 0x00008350
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00003247 File Offset: 0x00001447
		public Rigidbody connectedBody
		{
			get
			{
				IntPtr intPtr = Joint.get_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				Joint.set_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000A17C File Offset: 0x0000837C
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000325F File Offset: 0x0000145F
		public ArticulationBody connectedArticulationBody
		{
			get
			{
				IntPtr intPtr = Joint.get_connectedArticulationBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArticulationBody>(intPtr2) : null;
			}
			set
			{
				Joint.set_connectedArticulationBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000A1A8 File Offset: 0x000083A8
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00003277 File Offset: 0x00001477
		public Vector3 axis
		{
			get
			{
				Vector3 vector;
				this.get_axis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_axis_Injected(ref value);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000A1C0 File Offset: 0x000083C0
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00003281 File Offset: 0x00001481
		public Vector3 anchor
		{
			get
			{
				Vector3 vector;
				this.get_anchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchor_Injected(ref value);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000A1D8 File Offset: 0x000083D8
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000328B File Offset: 0x0000148B
		public Vector3 connectedAnchor
		{
			get
			{
				Vector3 vector;
				this.get_connectedAnchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_connectedAnchor_Injected(ref value);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00003295 File Offset: 0x00001495
		// (set) Token: 0x06000297 RID: 663 RVA: 0x000032A7 File Offset: 0x000014A7
		public bool autoConfigureConnectedAnchor
		{
			get
			{
				return Joint.get_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000032BA File Offset: 0x000014BA
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000032CC File Offset: 0x000014CC
		public float breakForce
		{
			get
			{
				return Joint.get_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000032DF File Offset: 0x000014DF
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000032F1 File Offset: 0x000014F1
		public float breakTorque
		{
			get
			{
				return Joint.get_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00003316 File Offset: 0x00001516
		public bool enableCollision
		{
			get
			{
				return Joint.get_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00003329 File Offset: 0x00001529
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000333B File Offset: 0x0000153B
		public bool enablePreprocessing
		{
			get
			{
				return Joint.get_enablePreprocessingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_enablePreprocessingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000334E File Offset: 0x0000154E
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00003360 File Offset: 0x00001560
		public float massScale
		{
			get
			{
				return Joint.get_massScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_massScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00003373 File Offset: 0x00001573
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00003385 File Offset: 0x00001585
		public float connectedMassScale
		{
			get
			{
				return Joint.get_connectedMassScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_connectedMassScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003398 File Offset: 0x00001598
		public void GetCurrentForces(ref Vector3 linearForce, ref Vector3 angularForce)
		{
			Joint.GetCurrentForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref linearForce, ref angularForce);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000A1F0 File Offset: 0x000083F0
		public Vector3 currentForce
		{
			get
			{
				Vector3 zero = Vector3.zero;
				Vector3 zero2 = Vector3.zero;
				this.GetCurrentForces(ref zero, ref zero2);
				return zero;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000A21C File Offset: 0x0000841C
		public Vector3 currentTorque
		{
			get
			{
				Vector3 zero = Vector3.zero;
				Vector3 zero2 = Vector3.zero;
				this.GetCurrentForces(ref zero, ref zero2);
				return zero2;
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000033AC File Offset: 0x000015AC
		public void get_axis_Injected(out Vector3 ret)
		{
			Joint.get_axis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000033BF File Offset: 0x000015BF
		public void set_axis_Injected(ref Vector3 value)
		{
			Joint.set_axis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000033D2 File Offset: 0x000015D2
		public void get_anchor_Injected(out Vector3 ret)
		{
			Joint.get_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000033E5 File Offset: 0x000015E5
		public void set_anchor_Injected(ref Vector3 value)
		{
			Joint.set_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000033F8 File Offset: 0x000015F8
		public void get_connectedAnchor_Injected(out Vector3 ret)
		{
			Joint.get_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000340B File Offset: 0x0000160B
		public void set_connectedAnchor_Injected(ref Vector3 value)
		{
			Joint.set_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000199 RID: 409
		private static readonly Joint.get_connectedBodyDelegate get_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint.get_connectedBodyDelegate>("UnityEngine.Joint::get_connectedBody");

		// Token: 0x0400019A RID: 410
		private static readonly Joint.set_connectedBodyDelegate set_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint.set_connectedBodyDelegate>("UnityEngine.Joint::set_connectedBody");

		// Token: 0x0400019B RID: 411
		private static readonly Joint.get_connectedArticulationBodyDelegate get_connectedArticulationBodyDelegateField = IL2CPP.ResolveICall<Joint.get_connectedArticulationBodyDelegate>("UnityEngine.Joint::get_connectedArticulationBody");

		// Token: 0x0400019C RID: 412
		private static readonly Joint.set_connectedArticulationBodyDelegate set_connectedArticulationBodyDelegateField = IL2CPP.ResolveICall<Joint.set_connectedArticulationBodyDelegate>("UnityEngine.Joint::set_connectedArticulationBody");

		// Token: 0x0400019D RID: 413
		private static readonly Joint.get_autoConfigureConnectedAnchorDelegate get_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<Joint.get_autoConfigureConnectedAnchorDelegate>("UnityEngine.Joint::get_autoConfigureConnectedAnchor");

		// Token: 0x0400019E RID: 414
		private static readonly Joint.set_autoConfigureConnectedAnchorDelegate set_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<Joint.set_autoConfigureConnectedAnchorDelegate>("UnityEngine.Joint::set_autoConfigureConnectedAnchor");

		// Token: 0x0400019F RID: 415
		private static readonly Joint.get_breakForceDelegate get_breakForceDelegateField = IL2CPP.ResolveICall<Joint.get_breakForceDelegate>("UnityEngine.Joint::get_breakForce");

		// Token: 0x040001A0 RID: 416
		private static readonly Joint.set_breakForceDelegate set_breakForceDelegateField = IL2CPP.ResolveICall<Joint.set_breakForceDelegate>("UnityEngine.Joint::set_breakForce");

		// Token: 0x040001A1 RID: 417
		private static readonly Joint.get_breakTorqueDelegate get_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint.get_breakTorqueDelegate>("UnityEngine.Joint::get_breakTorque");

		// Token: 0x040001A2 RID: 418
		private static readonly Joint.set_breakTorqueDelegate set_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint.set_breakTorqueDelegate>("UnityEngine.Joint::set_breakTorque");

		// Token: 0x040001A3 RID: 419
		private static readonly Joint.get_enableCollisionDelegate get_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint.get_enableCollisionDelegate>("UnityEngine.Joint::get_enableCollision");

		// Token: 0x040001A4 RID: 420
		private static readonly Joint.set_enableCollisionDelegate set_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint.set_enableCollisionDelegate>("UnityEngine.Joint::set_enableCollision");

		// Token: 0x040001A5 RID: 421
		private static readonly Joint.get_enablePreprocessingDelegate get_enablePreprocessingDelegateField = IL2CPP.ResolveICall<Joint.get_enablePreprocessingDelegate>("UnityEngine.Joint::get_enablePreprocessing");

		// Token: 0x040001A6 RID: 422
		private static readonly Joint.set_enablePreprocessingDelegate set_enablePreprocessingDelegateField = IL2CPP.ResolveICall<Joint.set_enablePreprocessingDelegate>("UnityEngine.Joint::set_enablePreprocessing");

		// Token: 0x040001A7 RID: 423
		private static readonly Joint.get_massScaleDelegate get_massScaleDelegateField = IL2CPP.ResolveICall<Joint.get_massScaleDelegate>("UnityEngine.Joint::get_massScale");

		// Token: 0x040001A8 RID: 424
		private static readonly Joint.set_massScaleDelegate set_massScaleDelegateField = IL2CPP.ResolveICall<Joint.set_massScaleDelegate>("UnityEngine.Joint::set_massScale");

		// Token: 0x040001A9 RID: 425
		private static readonly Joint.get_connectedMassScaleDelegate get_connectedMassScaleDelegateField = IL2CPP.ResolveICall<Joint.get_connectedMassScaleDelegate>("UnityEngine.Joint::get_connectedMassScale");

		// Token: 0x040001AA RID: 426
		private static readonly Joint.set_connectedMassScaleDelegate set_connectedMassScaleDelegateField = IL2CPP.ResolveICall<Joint.set_connectedMassScaleDelegate>("UnityEngine.Joint::set_connectedMassScale");

		// Token: 0x040001AB RID: 427
		private static readonly Joint.GetCurrentForcesDelegate GetCurrentForcesDelegateField = IL2CPP.ResolveICall<Joint.GetCurrentForcesDelegate>("UnityEngine.Joint::GetCurrentForces");

		// Token: 0x040001AC RID: 428
		private static readonly Joint.get_axis_InjectedDelegate get_axis_InjectedDelegateField = IL2CPP.ResolveICall<Joint.get_axis_InjectedDelegate>("UnityEngine.Joint::get_axis_Injected");

		// Token: 0x040001AD RID: 429
		private static readonly Joint.set_axis_InjectedDelegate set_axis_InjectedDelegateField = IL2CPP.ResolveICall<Joint.set_axis_InjectedDelegate>("UnityEngine.Joint::set_axis_Injected");

		// Token: 0x040001AE RID: 430
		private static readonly Joint.get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.get_anchor_InjectedDelegate>("UnityEngine.Joint::get_anchor_Injected");

		// Token: 0x040001AF RID: 431
		private static readonly Joint.set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.set_anchor_InjectedDelegate>("UnityEngine.Joint::set_anchor_Injected");

		// Token: 0x040001B0 RID: 432
		private static readonly Joint.get_connectedAnchor_InjectedDelegate get_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.get_connectedAnchor_InjectedDelegate>("UnityEngine.Joint::get_connectedAnchor_Injected");

		// Token: 0x040001B1 RID: 433
		private static readonly Joint.set_connectedAnchor_InjectedDelegate set_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.set_connectedAnchor_InjectedDelegate>("UnityEngine.Joint::set_connectedAnchor_Injected");

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x060004E4 RID: 1252
		private delegate IntPtr get_connectedBodyDelegate(IntPtr @this);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x060004E6 RID: 1254
		private delegate void set_connectedBodyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x060004E8 RID: 1256
		private delegate IntPtr get_connectedArticulationBodyDelegate(IntPtr @this);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x060004EA RID: 1258
		private delegate void set_connectedArticulationBodyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x060004EC RID: 1260
		private delegate bool get_autoConfigureConnectedAnchorDelegate(IntPtr @this);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x060004EE RID: 1262
		private delegate void set_autoConfigureConnectedAnchorDelegate(IntPtr @this, bool value);

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x060004F0 RID: 1264
		private delegate float get_breakForceDelegate(IntPtr @this);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x060004F2 RID: 1266
		private delegate void set_breakForceDelegate(IntPtr @this, float value);

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060004F4 RID: 1268
		private delegate float get_breakTorqueDelegate(IntPtr @this);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x060004F6 RID: 1270
		private delegate void set_breakTorqueDelegate(IntPtr @this, float value);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x060004F8 RID: 1272
		private delegate bool get_enableCollisionDelegate(IntPtr @this);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060004FA RID: 1274
		private delegate void set_enableCollisionDelegate(IntPtr @this, bool value);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x060004FC RID: 1276
		private delegate bool get_enablePreprocessingDelegate(IntPtr @this);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060004FE RID: 1278
		private delegate void set_enablePreprocessingDelegate(IntPtr @this, bool value);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x06000500 RID: 1280
		private delegate float get_massScaleDelegate(IntPtr @this);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x06000502 RID: 1282
		private delegate void set_massScaleDelegate(IntPtr @this, float value);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x06000504 RID: 1284
		private delegate float get_connectedMassScaleDelegate(IntPtr @this);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x06000506 RID: 1286
		private delegate void set_connectedMassScaleDelegate(IntPtr @this, float value);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x06000508 RID: 1288
		private delegate void GetCurrentForcesDelegate(IntPtr @this, IntPtr linearForce, IntPtr angularForce);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x0600050A RID: 1290
		private delegate void get_axis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x0600050C RID: 1292
		private delegate void set_axis_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x0600050E RID: 1294
		private delegate void get_anchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x06000510 RID: 1296
		private delegate void set_anchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x06000512 RID: 1298
		private delegate void get_connectedAnchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x06000514 RID: 1300
		private delegate void set_connectedAnchor_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
