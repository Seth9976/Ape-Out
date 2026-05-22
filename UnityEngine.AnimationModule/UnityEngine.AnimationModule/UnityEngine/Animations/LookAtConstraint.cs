using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005D RID: 93
	public sealed class LookAtConstraint : Behaviour
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x00005515 File Offset: 0x00003715
		public static void Internal_Create(LookAtConstraint self)
		{
			LookAtConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00005527 File Offset: 0x00003727
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00005539 File Offset: 0x00003739
		public float weight
		{
			get
			{
				return LookAtConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0000554C File Offset: 0x0000374C
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x0000555E File Offset: 0x0000375E
		public float roll
		{
			get
			{
				return LookAtConstraint.get_rollDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_rollDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00005571 File Offset: 0x00003771
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00005583 File Offset: 0x00003783
		public bool constraintActive
		{
			get
			{
				return LookAtConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00005596 File Offset: 0x00003796
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x000055A8 File Offset: 0x000037A8
		public bool locked
		{
			get
			{
				return LookAtConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0000F15C File Offset: 0x0000D35C
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x000055BB File Offset: 0x000037BB
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0000F174 File Offset: 0x0000D374
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x000055C5 File Offset: 0x000037C5
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0000F18C File Offset: 0x0000D38C
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x000055CF File Offset: 0x000037CF
		public Transform worldUpObject
		{
			get
			{
				IntPtr intPtr = LookAtConstraint.get_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				LookAtConstraint.set_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000055E7 File Offset: 0x000037E7
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x000055F9 File Offset: 0x000037F9
		public bool useUpObject
		{
			get
			{
				return LookAtConstraint.get_useUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_useUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0000F1B8 File Offset: 0x0000D3B8
		public int sourceCount
		{
			get
			{
				return LookAtConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000560C File Offset: 0x0000380C
		public static int GetSourceCountInternal(LookAtConstraint self)
		{
			return LookAtConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0000561E File Offset: 0x0000381E
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00005631 File Offset: 0x00003831
		public void RemoveSourceInternal(int index)
		{
			LookAtConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The LookAtConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00005644 File Offset: 0x00003844
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			LookAtConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00005657 File Offset: 0x00003857
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			LookAtConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000566A File Offset: 0x0000386A
		public void get_rotationOffset_Injected(out Vector3 ret)
		{
			LookAtConstraint.get_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0000567D File Offset: 0x0000387D
		public void set_rotationOffset_Injected(ref Vector3 value)
		{
			LookAtConstraint.set_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000403 RID: 1027
		private static readonly LookAtConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<LookAtConstraint.Internal_CreateDelegate>("UnityEngine.Animations.LookAtConstraint::Internal_Create");

		// Token: 0x04000404 RID: 1028
		private static readonly LookAtConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_weightDelegate>("UnityEngine.Animations.LookAtConstraint::get_weight");

		// Token: 0x04000405 RID: 1029
		private static readonly LookAtConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_weightDelegate>("UnityEngine.Animations.LookAtConstraint::set_weight");

		// Token: 0x04000406 RID: 1030
		private static readonly LookAtConstraint.get_rollDelegate get_rollDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_rollDelegate>("UnityEngine.Animations.LookAtConstraint::get_roll");

		// Token: 0x04000407 RID: 1031
		private static readonly LookAtConstraint.set_rollDelegate set_rollDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_rollDelegate>("UnityEngine.Animations.LookAtConstraint::set_roll");

		// Token: 0x04000408 RID: 1032
		private static readonly LookAtConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.LookAtConstraint::get_constraintActive");

		// Token: 0x04000409 RID: 1033
		private static readonly LookAtConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.LookAtConstraint::set_constraintActive");

		// Token: 0x0400040A RID: 1034
		private static readonly LookAtConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_lockedDelegate>("UnityEngine.Animations.LookAtConstraint::get_locked");

		// Token: 0x0400040B RID: 1035
		private static readonly LookAtConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_lockedDelegate>("UnityEngine.Animations.LookAtConstraint::set_locked");

		// Token: 0x0400040C RID: 1036
		private static readonly LookAtConstraint.get_worldUpObjectDelegate get_worldUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_worldUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::get_worldUpObject");

		// Token: 0x0400040D RID: 1037
		private static readonly LookAtConstraint.set_worldUpObjectDelegate set_worldUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_worldUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::set_worldUpObject");

		// Token: 0x0400040E RID: 1038
		private static readonly LookAtConstraint.get_useUpObjectDelegate get_useUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_useUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::get_useUpObject");

		// Token: 0x0400040F RID: 1039
		private static readonly LookAtConstraint.set_useUpObjectDelegate set_useUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_useUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::set_useUpObject");

		// Token: 0x04000410 RID: 1040
		private static readonly LookAtConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<LookAtConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.LookAtConstraint::GetSourceCountInternal");

		// Token: 0x04000411 RID: 1041
		private static readonly LookAtConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<LookAtConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.LookAtConstraint::RemoveSourceInternal");

		// Token: 0x04000412 RID: 1042
		private static readonly LookAtConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::get_rotationAtRest_Injected");

		// Token: 0x04000413 RID: 1043
		private static readonly LookAtConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::set_rotationAtRest_Injected");

		// Token: 0x04000414 RID: 1044
		private static readonly LookAtConstraint.get_rotationOffset_InjectedDelegate get_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_rotationOffset_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::get_rotationOffset_Injected");

		// Token: 0x04000415 RID: 1045
		private static readonly LookAtConstraint.set_rotationOffset_InjectedDelegate set_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_rotationOffset_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::set_rotationOffset_Injected");

		// Token: 0x02000244 RID: 580
		// (Invoke) Token: 0x0600097C RID: 2428
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000245 RID: 581
		// (Invoke) Token: 0x0600097E RID: 2430
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000246 RID: 582
		// (Invoke) Token: 0x06000980 RID: 2432
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000247 RID: 583
		// (Invoke) Token: 0x06000982 RID: 2434
		private delegate float get_rollDelegate(IntPtr @this);

		// Token: 0x02000248 RID: 584
		// (Invoke) Token: 0x06000984 RID: 2436
		private delegate void set_rollDelegate(IntPtr @this, float value);

		// Token: 0x02000249 RID: 585
		// (Invoke) Token: 0x06000986 RID: 2438
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200024A RID: 586
		// (Invoke) Token: 0x06000988 RID: 2440
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200024B RID: 587
		// (Invoke) Token: 0x0600098A RID: 2442
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200024C RID: 588
		// (Invoke) Token: 0x0600098C RID: 2444
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200024D RID: 589
		// (Invoke) Token: 0x0600098E RID: 2446
		private delegate IntPtr get_worldUpObjectDelegate(IntPtr @this);

		// Token: 0x0200024E RID: 590
		// (Invoke) Token: 0x06000990 RID: 2448
		private delegate void set_worldUpObjectDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200024F RID: 591
		// (Invoke) Token: 0x06000992 RID: 2450
		private delegate bool get_useUpObjectDelegate(IntPtr @this);

		// Token: 0x02000250 RID: 592
		// (Invoke) Token: 0x06000994 RID: 2452
		private delegate void set_useUpObjectDelegate(IntPtr @this, bool value);

		// Token: 0x02000251 RID: 593
		// (Invoke) Token: 0x06000996 RID: 2454
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x02000252 RID: 594
		// (Invoke) Token: 0x06000998 RID: 2456
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000253 RID: 595
		// (Invoke) Token: 0x0600099A RID: 2458
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000254 RID: 596
		// (Invoke) Token: 0x0600099C RID: 2460
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000255 RID: 597
		// (Invoke) Token: 0x0600099E RID: 2462
		private delegate void get_rotationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000256 RID: 598
		// (Invoke) Token: 0x060009A0 RID: 2464
		private delegate void set_rotationOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
