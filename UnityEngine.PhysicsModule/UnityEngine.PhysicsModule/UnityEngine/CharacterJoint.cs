using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	public class CharacterJoint : Joint
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000A3FC File Offset: 0x000085FC
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000356A File Offset: 0x0000176A
		public Vector3 swingAxis
		{
			get
			{
				Vector3 vector;
				this.get_swingAxis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_swingAxis_Injected(ref value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00003574 File Offset: 0x00001774
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00003586 File Offset: 0x00001786
		public bool enableProjection
		{
			get
			{
				return CharacterJoint.get_enableProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterJoint.set_enableProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00003599 File Offset: 0x00001799
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x000035AB File Offset: 0x000017AB
		public float projectionDistance
		{
			get
			{
				return CharacterJoint.get_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterJoint.set_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000035BE File Offset: 0x000017BE
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x000035D0 File Offset: 0x000017D0
		public float projectionAngle
		{
			get
			{
				return CharacterJoint.get_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterJoint.set_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000035E3 File Offset: 0x000017E3
		public void get_swingAxis_Injected(out Vector3 ret)
		{
			CharacterJoint.get_swingAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000035F6 File Offset: 0x000017F6
		public void set_swingAxis_Injected(ref Vector3 value)
		{
			CharacterJoint.set_swingAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001C4 RID: 452
		private static readonly CharacterJoint.get_enableProjectionDelegate get_enableProjectionDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_enableProjectionDelegate>("UnityEngine.CharacterJoint::get_enableProjection");

		// Token: 0x040001C5 RID: 453
		private static readonly CharacterJoint.set_enableProjectionDelegate set_enableProjectionDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_enableProjectionDelegate>("UnityEngine.CharacterJoint::set_enableProjection");

		// Token: 0x040001C6 RID: 454
		private static readonly CharacterJoint.get_projectionDistanceDelegate get_projectionDistanceDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_projectionDistanceDelegate>("UnityEngine.CharacterJoint::get_projectionDistance");

		// Token: 0x040001C7 RID: 455
		private static readonly CharacterJoint.set_projectionDistanceDelegate set_projectionDistanceDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_projectionDistanceDelegate>("UnityEngine.CharacterJoint::set_projectionDistance");

		// Token: 0x040001C8 RID: 456
		private static readonly CharacterJoint.get_projectionAngleDelegate get_projectionAngleDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_projectionAngleDelegate>("UnityEngine.CharacterJoint::get_projectionAngle");

		// Token: 0x040001C9 RID: 457
		private static readonly CharacterJoint.set_projectionAngleDelegate set_projectionAngleDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_projectionAngleDelegate>("UnityEngine.CharacterJoint::set_projectionAngle");

		// Token: 0x040001CA RID: 458
		private static readonly CharacterJoint.get_swingAxis_InjectedDelegate get_swingAxis_InjectedDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_swingAxis_InjectedDelegate>("UnityEngine.CharacterJoint::get_swingAxis_Injected");

		// Token: 0x040001CB RID: 459
		private static readonly CharacterJoint.set_swingAxis_InjectedDelegate set_swingAxis_InjectedDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_swingAxis_InjectedDelegate>("UnityEngine.CharacterJoint::set_swingAxis_Injected");

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x0600053A RID: 1338
		private delegate bool get_enableProjectionDelegate(IntPtr @this);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x0600053C RID: 1340
		private delegate void set_enableProjectionDelegate(IntPtr @this, bool value);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x0600053E RID: 1342
		private delegate float get_projectionDistanceDelegate(IntPtr @this);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x06000540 RID: 1344
		private delegate void set_projectionDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x06000542 RID: 1346
		private delegate float get_projectionAngleDelegate(IntPtr @this);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x06000544 RID: 1348
		private delegate void set_projectionAngleDelegate(IntPtr @this, float value);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x06000546 RID: 1350
		private delegate void get_swingAxis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x06000548 RID: 1352
		private delegate void set_swingAxis_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
