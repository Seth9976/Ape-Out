using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000021 RID: 33
	public class SpringJoint : Joint
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x000034B1 File Offset: 0x000016B1
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x000034C3 File Offset: 0x000016C3
		public float spring
		{
			get
			{
				return SpringJoint.get_springDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_springDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x000034D6 File Offset: 0x000016D6
		// (set) Token: 0x060002BA RID: 698 RVA: 0x000034E8 File Offset: 0x000016E8
		public float damper
		{
			get
			{
				return SpringJoint.get_damperDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_damperDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002BB RID: 699 RVA: 0x000034FB File Offset: 0x000016FB
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0000350D File Offset: 0x0000170D
		public float minDistance
		{
			get
			{
				return SpringJoint.get_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00003520 File Offset: 0x00001720
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00003532 File Offset: 0x00001732
		public float maxDistance
		{
			get
			{
				return SpringJoint.get_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00003545 File Offset: 0x00001745
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00003557 File Offset: 0x00001757
		public float tolerance
		{
			get
			{
				return SpringJoint.get_toleranceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_toleranceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001BA RID: 442
		private static readonly SpringJoint.get_springDelegate get_springDelegateField = IL2CPP.ResolveICall<SpringJoint.get_springDelegate>("UnityEngine.SpringJoint::get_spring");

		// Token: 0x040001BB RID: 443
		private static readonly SpringJoint.set_springDelegate set_springDelegateField = IL2CPP.ResolveICall<SpringJoint.set_springDelegate>("UnityEngine.SpringJoint::set_spring");

		// Token: 0x040001BC RID: 444
		private static readonly SpringJoint.get_damperDelegate get_damperDelegateField = IL2CPP.ResolveICall<SpringJoint.get_damperDelegate>("UnityEngine.SpringJoint::get_damper");

		// Token: 0x040001BD RID: 445
		private static readonly SpringJoint.set_damperDelegate set_damperDelegateField = IL2CPP.ResolveICall<SpringJoint.set_damperDelegate>("UnityEngine.SpringJoint::set_damper");

		// Token: 0x040001BE RID: 446
		private static readonly SpringJoint.get_minDistanceDelegate get_minDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.get_minDistanceDelegate>("UnityEngine.SpringJoint::get_minDistance");

		// Token: 0x040001BF RID: 447
		private static readonly SpringJoint.set_minDistanceDelegate set_minDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.set_minDistanceDelegate>("UnityEngine.SpringJoint::set_minDistance");

		// Token: 0x040001C0 RID: 448
		private static readonly SpringJoint.get_maxDistanceDelegate get_maxDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.get_maxDistanceDelegate>("UnityEngine.SpringJoint::get_maxDistance");

		// Token: 0x040001C1 RID: 449
		private static readonly SpringJoint.set_maxDistanceDelegate set_maxDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.set_maxDistanceDelegate>("UnityEngine.SpringJoint::set_maxDistance");

		// Token: 0x040001C2 RID: 450
		private static readonly SpringJoint.get_toleranceDelegate get_toleranceDelegateField = IL2CPP.ResolveICall<SpringJoint.get_toleranceDelegate>("UnityEngine.SpringJoint::get_tolerance");

		// Token: 0x040001C3 RID: 451
		private static readonly SpringJoint.set_toleranceDelegate set_toleranceDelegateField = IL2CPP.ResolveICall<SpringJoint.set_toleranceDelegate>("UnityEngine.SpringJoint::set_tolerance");

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x06000526 RID: 1318
		private delegate float get_springDelegate(IntPtr @this);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x06000528 RID: 1320
		private delegate void set_springDelegate(IntPtr @this, float value);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x0600052A RID: 1322
		private delegate float get_damperDelegate(IntPtr @this);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x0600052C RID: 1324
		private delegate void set_damperDelegate(IntPtr @this, float value);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x0600052E RID: 1326
		private delegate float get_minDistanceDelegate(IntPtr @this);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x06000530 RID: 1328
		private delegate void set_minDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x06000532 RID: 1330
		private delegate float get_maxDistanceDelegate(IntPtr @this);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x06000534 RID: 1332
		private delegate void set_maxDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x06000536 RID: 1334
		private delegate float get_toleranceDelegate(IntPtr @this);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x06000538 RID: 1336
		private delegate void set_toleranceDelegate(IntPtr @this, float value);
	}
}
