using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005A RID: 90
	public sealed class PositionConstraint : Behaviour
	{
		// Token: 0x0600051D RID: 1309 RVA: 0x0000515B File Offset: 0x0000335B
		public static void Internal_Create(PositionConstraint self)
		{
			PositionConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0000516D File Offset: 0x0000336D
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x0000517F File Offset: 0x0000337F
		public float weight
		{
			get
			{
				return PositionConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000EC40 File Offset: 0x0000CE40
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00005192 File Offset: 0x00003392
		public Vector3 translationAtRest
		{
			get
			{
				Vector3 vector;
				this.get_translationAtRest_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_translationAtRest_Injected(ref value);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000EC58 File Offset: 0x0000CE58
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x0000519C File Offset: 0x0000339C
		public Vector3 translationOffset
		{
			get
			{
				Vector3 vector;
				this.get_translationOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_translationOffset_Injected(ref value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x000051A6 File Offset: 0x000033A6
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x000051B8 File Offset: 0x000033B8
		public Axis translationAxis
		{
			get
			{
				return PositionConstraint.get_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x000051CB File Offset: 0x000033CB
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x000051DD File Offset: 0x000033DD
		public bool constraintActive
		{
			get
			{
				return PositionConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x000051F0 File Offset: 0x000033F0
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00005202 File Offset: 0x00003402
		public bool locked
		{
			get
			{
				return PositionConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0000EC70 File Offset: 0x0000CE70
		public int sourceCount
		{
			get
			{
				return PositionConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00005215 File Offset: 0x00003415
		public static int GetSourceCountInternal(PositionConstraint self)
		{
			return PositionConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00005227 File Offset: 0x00003427
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000523A File Offset: 0x0000343A
		public void RemoveSourceInternal(int index)
		{
			PositionConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000EC88 File Offset: 0x0000CE88
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The PositionConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000524D File Offset: 0x0000344D
		public void get_translationAtRest_Injected(out Vector3 ret)
		{
			PositionConstraint.get_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00005260 File Offset: 0x00003460
		public void set_translationAtRest_Injected(ref Vector3 value)
		{
			PositionConstraint.set_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00005273 File Offset: 0x00003473
		public void get_translationOffset_Injected(out Vector3 ret)
		{
			PositionConstraint.get_translationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00005286 File Offset: 0x00003486
		public void set_translationOffset_Injected(ref Vector3 value)
		{
			PositionConstraint.set_translationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040003D6 RID: 982
		private static readonly PositionConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<PositionConstraint.Internal_CreateDelegate>("UnityEngine.Animations.PositionConstraint::Internal_Create");

		// Token: 0x040003D7 RID: 983
		private static readonly PositionConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_weightDelegate>("UnityEngine.Animations.PositionConstraint::get_weight");

		// Token: 0x040003D8 RID: 984
		private static readonly PositionConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_weightDelegate>("UnityEngine.Animations.PositionConstraint::set_weight");

		// Token: 0x040003D9 RID: 985
		private static readonly PositionConstraint.get_translationAxisDelegate get_translationAxisDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_translationAxisDelegate>("UnityEngine.Animations.PositionConstraint::get_translationAxis");

		// Token: 0x040003DA RID: 986
		private static readonly PositionConstraint.set_translationAxisDelegate set_translationAxisDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_translationAxisDelegate>("UnityEngine.Animations.PositionConstraint::set_translationAxis");

		// Token: 0x040003DB RID: 987
		private static readonly PositionConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.PositionConstraint::get_constraintActive");

		// Token: 0x040003DC RID: 988
		private static readonly PositionConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.PositionConstraint::set_constraintActive");

		// Token: 0x040003DD RID: 989
		private static readonly PositionConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_lockedDelegate>("UnityEngine.Animations.PositionConstraint::get_locked");

		// Token: 0x040003DE RID: 990
		private static readonly PositionConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_lockedDelegate>("UnityEngine.Animations.PositionConstraint::set_locked");

		// Token: 0x040003DF RID: 991
		private static readonly PositionConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<PositionConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.PositionConstraint::GetSourceCountInternal");

		// Token: 0x040003E0 RID: 992
		private static readonly PositionConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<PositionConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.PositionConstraint::RemoveSourceInternal");

		// Token: 0x040003E1 RID: 993
		private static readonly PositionConstraint.get_translationAtRest_InjectedDelegate get_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_translationAtRest_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::get_translationAtRest_Injected");

		// Token: 0x040003E2 RID: 994
		private static readonly PositionConstraint.set_translationAtRest_InjectedDelegate set_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_translationAtRest_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::set_translationAtRest_Injected");

		// Token: 0x040003E3 RID: 995
		private static readonly PositionConstraint.get_translationOffset_InjectedDelegate get_translationOffset_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_translationOffset_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::get_translationOffset_Injected");

		// Token: 0x040003E4 RID: 996
		private static readonly PositionConstraint.set_translationOffset_InjectedDelegate set_translationOffset_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_translationOffset_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::set_translationOffset_Injected");

		// Token: 0x02000217 RID: 535
		// (Invoke) Token: 0x06000922 RID: 2338
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000218 RID: 536
		// (Invoke) Token: 0x06000924 RID: 2340
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000219 RID: 537
		// (Invoke) Token: 0x06000926 RID: 2342
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x0200021A RID: 538
		// (Invoke) Token: 0x06000928 RID: 2344
		private delegate Axis get_translationAxisDelegate(IntPtr @this);

		// Token: 0x0200021B RID: 539
		// (Invoke) Token: 0x0600092A RID: 2346
		private delegate void set_translationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x0200021C RID: 540
		// (Invoke) Token: 0x0600092C RID: 2348
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200021D RID: 541
		// (Invoke) Token: 0x0600092E RID: 2350
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200021E RID: 542
		// (Invoke) Token: 0x06000930 RID: 2352
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200021F RID: 543
		// (Invoke) Token: 0x06000932 RID: 2354
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x02000220 RID: 544
		// (Invoke) Token: 0x06000934 RID: 2356
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x02000221 RID: 545
		// (Invoke) Token: 0x06000936 RID: 2358
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000222 RID: 546
		// (Invoke) Token: 0x06000938 RID: 2360
		private delegate void get_translationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000223 RID: 547
		// (Invoke) Token: 0x0600093A RID: 2362
		private delegate void set_translationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000224 RID: 548
		// (Invoke) Token: 0x0600093C RID: 2364
		private delegate void get_translationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000225 RID: 549
		// (Invoke) Token: 0x0600093E RID: 2366
		private delegate void set_translationOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
