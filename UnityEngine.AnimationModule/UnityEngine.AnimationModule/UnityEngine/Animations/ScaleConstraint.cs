using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005C RID: 92
	public sealed class ScaleConstraint : Behaviour
	{
		// Token: 0x0600054B RID: 1355 RVA: 0x000053D7 File Offset: 0x000035D7
		public static void Internal_Create(ScaleConstraint self)
		{
			ScaleConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x000053E9 File Offset: 0x000035E9
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x000053FB File Offset: 0x000035FB
		public float weight
		{
			get
			{
				return ScaleConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0000EF80 File Offset: 0x0000D180
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x0000540E File Offset: 0x0000360E
		public Vector3 scaleAtRest
		{
			get
			{
				Vector3 vector;
				this.get_scaleAtRest_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_scaleAtRest_Injected(ref value);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0000EF98 File Offset: 0x0000D198
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00005418 File Offset: 0x00003618
		public Vector3 scaleOffset
		{
			get
			{
				Vector3 vector;
				this.get_scaleOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_scaleOffset_Injected(ref value);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00005422 File Offset: 0x00003622
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00005434 File Offset: 0x00003634
		public Axis scalingAxis
		{
			get
			{
				return ScaleConstraint.get_scalingAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_scalingAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00005447 File Offset: 0x00003647
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00005459 File Offset: 0x00003659
		public bool constraintActive
		{
			get
			{
				return ScaleConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0000546C File Offset: 0x0000366C
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x0000547E File Offset: 0x0000367E
		public bool locked
		{
			get
			{
				return ScaleConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0000EFB0 File Offset: 0x0000D1B0
		public int sourceCount
		{
			get
			{
				return ScaleConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00005491 File Offset: 0x00003691
		public static int GetSourceCountInternal(ScaleConstraint self)
		{
			return ScaleConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000054A3 File Offset: 0x000036A3
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000054B6 File Offset: 0x000036B6
		public void RemoveSourceInternal(int index)
		{
			ScaleConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The ScaleConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000054C9 File Offset: 0x000036C9
		public void get_scaleAtRest_Injected(out Vector3 ret)
		{
			ScaleConstraint.get_scaleAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000054DC File Offset: 0x000036DC
		public void set_scaleAtRest_Injected(ref Vector3 value)
		{
			ScaleConstraint.set_scaleAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000054EF File Offset: 0x000036EF
		public void get_scaleOffset_Injected(out Vector3 ret)
		{
			ScaleConstraint.get_scaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00005502 File Offset: 0x00003702
		public void set_scaleOffset_Injected(ref Vector3 value)
		{
			ScaleConstraint.set_scaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040003F4 RID: 1012
		private static readonly ScaleConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ScaleConstraint.Internal_CreateDelegate>("UnityEngine.Animations.ScaleConstraint::Internal_Create");

		// Token: 0x040003F5 RID: 1013
		private static readonly ScaleConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_weightDelegate>("UnityEngine.Animations.ScaleConstraint::get_weight");

		// Token: 0x040003F6 RID: 1014
		private static readonly ScaleConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_weightDelegate>("UnityEngine.Animations.ScaleConstraint::set_weight");

		// Token: 0x040003F7 RID: 1015
		private static readonly ScaleConstraint.get_scalingAxisDelegate get_scalingAxisDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_scalingAxisDelegate>("UnityEngine.Animations.ScaleConstraint::get_scalingAxis");

		// Token: 0x040003F8 RID: 1016
		private static readonly ScaleConstraint.set_scalingAxisDelegate set_scalingAxisDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_scalingAxisDelegate>("UnityEngine.Animations.ScaleConstraint::set_scalingAxis");

		// Token: 0x040003F9 RID: 1017
		private static readonly ScaleConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.ScaleConstraint::get_constraintActive");

		// Token: 0x040003FA RID: 1018
		private static readonly ScaleConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.ScaleConstraint::set_constraintActive");

		// Token: 0x040003FB RID: 1019
		private static readonly ScaleConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_lockedDelegate>("UnityEngine.Animations.ScaleConstraint::get_locked");

		// Token: 0x040003FC RID: 1020
		private static readonly ScaleConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_lockedDelegate>("UnityEngine.Animations.ScaleConstraint::set_locked");

		// Token: 0x040003FD RID: 1021
		private static readonly ScaleConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<ScaleConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.ScaleConstraint::GetSourceCountInternal");

		// Token: 0x040003FE RID: 1022
		private static readonly ScaleConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<ScaleConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.ScaleConstraint::RemoveSourceInternal");

		// Token: 0x040003FF RID: 1023
		private static readonly ScaleConstraint.get_scaleAtRest_InjectedDelegate get_scaleAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_scaleAtRest_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::get_scaleAtRest_Injected");

		// Token: 0x04000400 RID: 1024
		private static readonly ScaleConstraint.set_scaleAtRest_InjectedDelegate set_scaleAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_scaleAtRest_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::set_scaleAtRest_Injected");

		// Token: 0x04000401 RID: 1025
		private static readonly ScaleConstraint.get_scaleOffset_InjectedDelegate get_scaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_scaleOffset_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::get_scaleOffset_Injected");

		// Token: 0x04000402 RID: 1026
		private static readonly ScaleConstraint.set_scaleOffset_InjectedDelegate set_scaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_scaleOffset_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::set_scaleOffset_Injected");

		// Token: 0x02000235 RID: 565
		// (Invoke) Token: 0x0600095E RID: 2398
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000236 RID: 566
		// (Invoke) Token: 0x06000960 RID: 2400
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000237 RID: 567
		// (Invoke) Token: 0x06000962 RID: 2402
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000238 RID: 568
		// (Invoke) Token: 0x06000964 RID: 2404
		private delegate Axis get_scalingAxisDelegate(IntPtr @this);

		// Token: 0x02000239 RID: 569
		// (Invoke) Token: 0x06000966 RID: 2406
		private delegate void set_scalingAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x0200023A RID: 570
		// (Invoke) Token: 0x06000968 RID: 2408
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200023B RID: 571
		// (Invoke) Token: 0x0600096A RID: 2410
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200023C RID: 572
		// (Invoke) Token: 0x0600096C RID: 2412
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200023D RID: 573
		// (Invoke) Token: 0x0600096E RID: 2414
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200023E RID: 574
		// (Invoke) Token: 0x06000970 RID: 2416
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x0200023F RID: 575
		// (Invoke) Token: 0x06000972 RID: 2418
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000240 RID: 576
		// (Invoke) Token: 0x06000974 RID: 2420
		private delegate void get_scaleAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000241 RID: 577
		// (Invoke) Token: 0x06000976 RID: 2422
		private delegate void set_scaleAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000242 RID: 578
		// (Invoke) Token: 0x06000978 RID: 2424
		private delegate void get_scaleOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000243 RID: 579
		// (Invoke) Token: 0x0600097A RID: 2426
		private delegate void set_scaleOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
