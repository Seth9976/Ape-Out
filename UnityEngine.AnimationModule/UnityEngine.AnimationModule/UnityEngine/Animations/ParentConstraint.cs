using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005E RID: 94
	public sealed class ParentConstraint : Behaviour
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x00005690 File Offset: 0x00003890
		public static void Internal_Create(ParentConstraint self)
		{
			ParentConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x000056A2 File Offset: 0x000038A2
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x000056B4 File Offset: 0x000038B4
		public float weight
		{
			get
			{
				return ParentConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x000056C7 File Offset: 0x000038C7
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x000056D9 File Offset: 0x000038D9
		public bool constraintActive
		{
			get
			{
				return ParentConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x000056EC File Offset: 0x000038EC
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x000056FE File Offset: 0x000038FE
		public bool locked
		{
			get
			{
				return ParentConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0000F3BC File Offset: 0x0000D5BC
		public int sourceCount
		{
			get
			{
				return ParentConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00005711 File Offset: 0x00003911
		public static int GetSourceCountInternal(ParentConstraint self)
		{
			return ParentConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0000F3D4 File Offset: 0x0000D5D4
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00005723 File Offset: 0x00003923
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0000572D File Offset: 0x0000392D
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0000F404 File Offset: 0x0000D604
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x00005737 File Offset: 0x00003937
		public Il2CppStructArray<Vector3> translationOffsets
		{
			get
			{
				IntPtr intPtr = ParentConstraint.get_translationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				ParentConstraint.set_translationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0000F430 File Offset: 0x0000D630
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0000574F File Offset: 0x0000394F
		public Il2CppStructArray<Vector3> rotationOffsets
		{
			get
			{
				IntPtr intPtr = ParentConstraint.get_rotationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				ParentConstraint.set_rotationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00005767 File Offset: 0x00003967
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00005779 File Offset: 0x00003979
		public Axis translationAxis
		{
			get
			{
				return ParentConstraint.get_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0000578C File Offset: 0x0000398C
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0000579E File Offset: 0x0000399E
		public Axis rotationAxis
		{
			get
			{
				return ParentConstraint.get_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000F45C File Offset: 0x0000D65C
		public Vector3 GetTranslationOffset(int index)
		{
			this.ValidateSourceIndex(index);
			return this.GetTranslationOffsetInternal(index);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000057B1 File Offset: 0x000039B1
		public void SetTranslationOffset(int index, Vector3 value)
		{
			this.ValidateSourceIndex(index);
			this.SetTranslationOffsetInternal(index, value);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0000F480 File Offset: 0x0000D680
		public Vector3 GetTranslationOffsetInternal(int index)
		{
			Vector3 vector;
			this.GetTranslationOffsetInternal_Injected(index, out vector);
			return vector;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000057C5 File Offset: 0x000039C5
		public void SetTranslationOffsetInternal(int index, Vector3 value)
		{
			this.SetTranslationOffsetInternal_Injected(index, ref value);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000F498 File Offset: 0x0000D698
		public Vector3 GetRotationOffset(int index)
		{
			this.ValidateSourceIndex(index);
			return this.GetRotationOffsetInternal(index);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000057D0 File Offset: 0x000039D0
		public void SetRotationOffset(int index, Vector3 value)
		{
			this.ValidateSourceIndex(index);
			this.SetRotationOffsetInternal(index, value);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000F4BC File Offset: 0x0000D6BC
		public Vector3 GetRotationOffsetInternal(int index)
		{
			Vector3 vector;
			this.GetRotationOffsetInternal_Injected(index, out vector);
			return vector;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000057E4 File Offset: 0x000039E4
		public void SetRotationOffsetInternal(int index, Vector3 value)
		{
			this.SetRotationOffsetInternal_Injected(index, ref value);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The ParentConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000057EF File Offset: 0x000039EF
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00005802 File Offset: 0x00003A02
		public void RemoveSourceInternal(int index)
		{
			ParentConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00005815 File Offset: 0x00003A15
		public void get_translationAtRest_Injected(out Vector3 ret)
		{
			ParentConstraint.get_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00005828 File Offset: 0x00003A28
		public void set_translationAtRest_Injected(ref Vector3 value)
		{
			ParentConstraint.set_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000583B File Offset: 0x00003A3B
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			ParentConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000584E File Offset: 0x00003A4E
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			ParentConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00005861 File Offset: 0x00003A61
		public void GetTranslationOffsetInternal_Injected(int index, out Vector3 ret)
		{
			ParentConstraint.GetTranslationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00005875 File Offset: 0x00003A75
		public void SetTranslationOffsetInternal_Injected(int index, ref Vector3 value)
		{
			ParentConstraint.SetTranslationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref value);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00005889 File Offset: 0x00003A89
		public void GetRotationOffsetInternal_Injected(int index, out Vector3 ret)
		{
			ParentConstraint.GetRotationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000589D File Offset: 0x00003A9D
		public void SetRotationOffsetInternal_Injected(int index, ref Vector3 value)
		{
			ParentConstraint.SetRotationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref value);
		}

		// Token: 0x04000416 RID: 1046
		private static readonly ParentConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ParentConstraint.Internal_CreateDelegate>("UnityEngine.Animations.ParentConstraint::Internal_Create");

		// Token: 0x04000417 RID: 1047
		private static readonly ParentConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_weightDelegate>("UnityEngine.Animations.ParentConstraint::get_weight");

		// Token: 0x04000418 RID: 1048
		private static readonly ParentConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_weightDelegate>("UnityEngine.Animations.ParentConstraint::set_weight");

		// Token: 0x04000419 RID: 1049
		private static readonly ParentConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.ParentConstraint::get_constraintActive");

		// Token: 0x0400041A RID: 1050
		private static readonly ParentConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.ParentConstraint::set_constraintActive");

		// Token: 0x0400041B RID: 1051
		private static readonly ParentConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_lockedDelegate>("UnityEngine.Animations.ParentConstraint::get_locked");

		// Token: 0x0400041C RID: 1052
		private static readonly ParentConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_lockedDelegate>("UnityEngine.Animations.ParentConstraint::set_locked");

		// Token: 0x0400041D RID: 1053
		private static readonly ParentConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<ParentConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.ParentConstraint::GetSourceCountInternal");

		// Token: 0x0400041E RID: 1054
		private static readonly ParentConstraint.get_translationOffsetsDelegate get_translationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_translationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::get_translationOffsets");

		// Token: 0x0400041F RID: 1055
		private static readonly ParentConstraint.set_translationOffsetsDelegate set_translationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_translationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::set_translationOffsets");

		// Token: 0x04000420 RID: 1056
		private static readonly ParentConstraint.get_rotationOffsetsDelegate get_rotationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_rotationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::get_rotationOffsets");

		// Token: 0x04000421 RID: 1057
		private static readonly ParentConstraint.set_rotationOffsetsDelegate set_rotationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_rotationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::set_rotationOffsets");

		// Token: 0x04000422 RID: 1058
		private static readonly ParentConstraint.get_translationAxisDelegate get_translationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_translationAxisDelegate>("UnityEngine.Animations.ParentConstraint::get_translationAxis");

		// Token: 0x04000423 RID: 1059
		private static readonly ParentConstraint.set_translationAxisDelegate set_translationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_translationAxisDelegate>("UnityEngine.Animations.ParentConstraint::set_translationAxis");

		// Token: 0x04000424 RID: 1060
		private static readonly ParentConstraint.get_rotationAxisDelegate get_rotationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_rotationAxisDelegate>("UnityEngine.Animations.ParentConstraint::get_rotationAxis");

		// Token: 0x04000425 RID: 1061
		private static readonly ParentConstraint.set_rotationAxisDelegate set_rotationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_rotationAxisDelegate>("UnityEngine.Animations.ParentConstraint::set_rotationAxis");

		// Token: 0x04000426 RID: 1062
		private static readonly ParentConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<ParentConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.ParentConstraint::RemoveSourceInternal");

		// Token: 0x04000427 RID: 1063
		private static readonly ParentConstraint.get_translationAtRest_InjectedDelegate get_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_translationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::get_translationAtRest_Injected");

		// Token: 0x04000428 RID: 1064
		private static readonly ParentConstraint.set_translationAtRest_InjectedDelegate set_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_translationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::set_translationAtRest_Injected");

		// Token: 0x04000429 RID: 1065
		private static readonly ParentConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::get_rotationAtRest_Injected");

		// Token: 0x0400042A RID: 1066
		private static readonly ParentConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::set_rotationAtRest_Injected");

		// Token: 0x0400042B RID: 1067
		private static readonly ParentConstraint.GetTranslationOffsetInternal_InjectedDelegate GetTranslationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.GetTranslationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::GetTranslationOffsetInternal_Injected");

		// Token: 0x0400042C RID: 1068
		private static readonly ParentConstraint.SetTranslationOffsetInternal_InjectedDelegate SetTranslationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.SetTranslationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::SetTranslationOffsetInternal_Injected");

		// Token: 0x0400042D RID: 1069
		private static readonly ParentConstraint.GetRotationOffsetInternal_InjectedDelegate GetRotationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.GetRotationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::GetRotationOffsetInternal_Injected");

		// Token: 0x0400042E RID: 1070
		private static readonly ParentConstraint.SetRotationOffsetInternal_InjectedDelegate SetRotationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.SetRotationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::SetRotationOffsetInternal_Injected");

		// Token: 0x02000257 RID: 599
		// (Invoke) Token: 0x060009A2 RID: 2466
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000258 RID: 600
		// (Invoke) Token: 0x060009A4 RID: 2468
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000259 RID: 601
		// (Invoke) Token: 0x060009A6 RID: 2470
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x0200025A RID: 602
		// (Invoke) Token: 0x060009A8 RID: 2472
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200025B RID: 603
		// (Invoke) Token: 0x060009AA RID: 2474
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200025C RID: 604
		// (Invoke) Token: 0x060009AC RID: 2476
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200025D RID: 605
		// (Invoke) Token: 0x060009AE RID: 2478
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200025E RID: 606
		// (Invoke) Token: 0x060009B0 RID: 2480
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x0200025F RID: 607
		// (Invoke) Token: 0x060009B2 RID: 2482
		private delegate IntPtr get_translationOffsetsDelegate(IntPtr @this);

		// Token: 0x02000260 RID: 608
		// (Invoke) Token: 0x060009B4 RID: 2484
		private delegate void set_translationOffsetsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000261 RID: 609
		// (Invoke) Token: 0x060009B6 RID: 2486
		private delegate IntPtr get_rotationOffsetsDelegate(IntPtr @this);

		// Token: 0x02000262 RID: 610
		// (Invoke) Token: 0x060009B8 RID: 2488
		private delegate void set_rotationOffsetsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000263 RID: 611
		// (Invoke) Token: 0x060009BA RID: 2490
		private delegate Axis get_translationAxisDelegate(IntPtr @this);

		// Token: 0x02000264 RID: 612
		// (Invoke) Token: 0x060009BC RID: 2492
		private delegate void set_translationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x02000265 RID: 613
		// (Invoke) Token: 0x060009BE RID: 2494
		private delegate Axis get_rotationAxisDelegate(IntPtr @this);

		// Token: 0x02000266 RID: 614
		// (Invoke) Token: 0x060009C0 RID: 2496
		private delegate void set_rotationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x02000267 RID: 615
		// (Invoke) Token: 0x060009C2 RID: 2498
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000268 RID: 616
		// (Invoke) Token: 0x060009C4 RID: 2500
		private delegate void get_translationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000269 RID: 617
		// (Invoke) Token: 0x060009C6 RID: 2502
		private delegate void set_translationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200026A RID: 618
		// (Invoke) Token: 0x060009C8 RID: 2504
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200026B RID: 619
		// (Invoke) Token: 0x060009CA RID: 2506
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200026C RID: 620
		// (Invoke) Token: 0x060009CC RID: 2508
		private delegate void GetTranslationOffsetInternal_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x0200026D RID: 621
		// (Invoke) Token: 0x060009CE RID: 2510
		private delegate void SetTranslationOffsetInternal_InjectedDelegate(IntPtr @this, int index, IntPtr value);

		// Token: 0x0200026E RID: 622
		// (Invoke) Token: 0x060009D0 RID: 2512
		private delegate void GetRotationOffsetInternal_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x0200026F RID: 623
		// (Invoke) Token: 0x060009D2 RID: 2514
		private delegate void SetRotationOffsetInternal_InjectedDelegate(IntPtr @this, int index, IntPtr value);
	}
}
