using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005B RID: 91
	public sealed class RotationConstraint : Behaviour
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x00005299 File Offset: 0x00003499
		public static void Internal_Create(RotationConstraint self)
		{
			RotationConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x000052AB File Offset: 0x000034AB
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x000052BD File Offset: 0x000034BD
		public float weight
		{
			get
			{
				return RotationConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x000052D0 File Offset: 0x000034D0
		public Vector3 rotationAtRest
		{
			get
			{
				Vector3 vector;
				this.get_rotationAtRest_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rotationAtRest_Injected(ref value);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0000EDF8 File Offset: 0x0000CFF8
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x000052DA File Offset: 0x000034DA
		public Vector3 rotationOffset
		{
			get
			{
				Vector3 vector;
				this.get_rotationOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rotationOffset_Injected(ref value);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x000052E4 File Offset: 0x000034E4
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x000052F6 File Offset: 0x000034F6
		public Axis rotationAxis
		{
			get
			{
				return RotationConstraint.get_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00005309 File Offset: 0x00003509
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x0000531B File Offset: 0x0000351B
		public bool constraintActive
		{
			get
			{
				return RotationConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0000532E File Offset: 0x0000352E
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00005340 File Offset: 0x00003540
		public bool locked
		{
			get
			{
				return RotationConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0000EE10 File Offset: 0x0000D010
		public int sourceCount
		{
			get
			{
				return RotationConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00005353 File Offset: 0x00003553
		public static int GetSourceCountInternal(RotationConstraint self)
		{
			return RotationConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00005365 File Offset: 0x00003565
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00005378 File Offset: 0x00003578
		public void RemoveSourceInternal(int index)
		{
			RotationConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000EE28 File Offset: 0x0000D028
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The RotationConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000538B File Offset: 0x0000358B
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			RotationConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000539E File Offset: 0x0000359E
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			RotationConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000053B1 File Offset: 0x000035B1
		public void get_rotationOffset_Injected(out Vector3 ret)
		{
			RotationConstraint.get_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000053C4 File Offset: 0x000035C4
		public void set_rotationOffset_Injected(ref Vector3 value)
		{
			RotationConstraint.set_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040003E5 RID: 997
		private static readonly RotationConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<RotationConstraint.Internal_CreateDelegate>("UnityEngine.Animations.RotationConstraint::Internal_Create");

		// Token: 0x040003E6 RID: 998
		private static readonly RotationConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_weightDelegate>("UnityEngine.Animations.RotationConstraint::get_weight");

		// Token: 0x040003E7 RID: 999
		private static readonly RotationConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_weightDelegate>("UnityEngine.Animations.RotationConstraint::set_weight");

		// Token: 0x040003E8 RID: 1000
		private static readonly RotationConstraint.get_rotationAxisDelegate get_rotationAxisDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_rotationAxisDelegate>("UnityEngine.Animations.RotationConstraint::get_rotationAxis");

		// Token: 0x040003E9 RID: 1001
		private static readonly RotationConstraint.set_rotationAxisDelegate set_rotationAxisDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_rotationAxisDelegate>("UnityEngine.Animations.RotationConstraint::set_rotationAxis");

		// Token: 0x040003EA RID: 1002
		private static readonly RotationConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.RotationConstraint::get_constraintActive");

		// Token: 0x040003EB RID: 1003
		private static readonly RotationConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.RotationConstraint::set_constraintActive");

		// Token: 0x040003EC RID: 1004
		private static readonly RotationConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_lockedDelegate>("UnityEngine.Animations.RotationConstraint::get_locked");

		// Token: 0x040003ED RID: 1005
		private static readonly RotationConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_lockedDelegate>("UnityEngine.Animations.RotationConstraint::set_locked");

		// Token: 0x040003EE RID: 1006
		private static readonly RotationConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<RotationConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.RotationConstraint::GetSourceCountInternal");

		// Token: 0x040003EF RID: 1007
		private static readonly RotationConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<RotationConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.RotationConstraint::RemoveSourceInternal");

		// Token: 0x040003F0 RID: 1008
		private static readonly RotationConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::get_rotationAtRest_Injected");

		// Token: 0x040003F1 RID: 1009
		private static readonly RotationConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::set_rotationAtRest_Injected");

		// Token: 0x040003F2 RID: 1010
		private static readonly RotationConstraint.get_rotationOffset_InjectedDelegate get_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_rotationOffset_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::get_rotationOffset_Injected");

		// Token: 0x040003F3 RID: 1011
		private static readonly RotationConstraint.set_rotationOffset_InjectedDelegate set_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_rotationOffset_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::set_rotationOffset_Injected");

		// Token: 0x02000226 RID: 550
		// (Invoke) Token: 0x06000940 RID: 2368
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000227 RID: 551
		// (Invoke) Token: 0x06000942 RID: 2370
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000228 RID: 552
		// (Invoke) Token: 0x06000944 RID: 2372
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000229 RID: 553
		// (Invoke) Token: 0x06000946 RID: 2374
		private delegate Axis get_rotationAxisDelegate(IntPtr @this);

		// Token: 0x0200022A RID: 554
		// (Invoke) Token: 0x06000948 RID: 2376
		private delegate void set_rotationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x0200022B RID: 555
		// (Invoke) Token: 0x0600094A RID: 2378
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200022C RID: 556
		// (Invoke) Token: 0x0600094C RID: 2380
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200022D RID: 557
		// (Invoke) Token: 0x0600094E RID: 2382
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200022E RID: 558
		// (Invoke) Token: 0x06000950 RID: 2384
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200022F RID: 559
		// (Invoke) Token: 0x06000952 RID: 2386
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x02000230 RID: 560
		// (Invoke) Token: 0x06000954 RID: 2388
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000231 RID: 561
		// (Invoke) Token: 0x06000956 RID: 2390
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000232 RID: 562
		// (Invoke) Token: 0x06000958 RID: 2392
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000233 RID: 563
		// (Invoke) Token: 0x0600095A RID: 2394
		private delegate void get_rotationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000234 RID: 564
		// (Invoke) Token: 0x0600095C RID: 2396
		private delegate void set_rotationOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
