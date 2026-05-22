using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x02000050 RID: 80
	public sealed class AimConstraint : Behaviour
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x00004DE1 File Offset: 0x00002FE1
		public static void Internal_Create(AimConstraint self)
		{
			AimConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00004DF3 File Offset: 0x00002FF3
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00004E05 File Offset: 0x00003005
		public float weight
		{
			get
			{
				return AimConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00004E18 File Offset: 0x00003018
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00004E2A File Offset: 0x0000302A
		public bool constraintActive
		{
			get
			{
				return AimConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00004E3D File Offset: 0x0000303D
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00004E4F File Offset: 0x0000304F
		public bool locked
		{
			get
			{
				return AimConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0000E934 File Offset: 0x0000CB34
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00004E62 File Offset: 0x00003062
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0000E94C File Offset: 0x0000CB4C
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00004E6C File Offset: 0x0000306C
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00004E76 File Offset: 0x00003076
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00004E88 File Offset: 0x00003088
		public Axis rotationAxis
		{
			get
			{
				return AimConstraint.get_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0000E964 File Offset: 0x0000CB64
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00004E9B File Offset: 0x0000309B
		public Vector3 aimVector
		{
			get
			{
				Vector3 vector;
				this.get_aimVector_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_aimVector_Injected(ref value);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0000E97C File Offset: 0x0000CB7C
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00004EA5 File Offset: 0x000030A5
		public Vector3 upVector
		{
			get
			{
				Vector3 vector;
				this.get_upVector_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_upVector_Injected(ref value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0000E994 File Offset: 0x0000CB94
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00004EAF File Offset: 0x000030AF
		public Vector3 worldUpVector
		{
			get
			{
				Vector3 vector;
				this.get_worldUpVector_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_worldUpVector_Injected(ref value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00004EB9 File Offset: 0x000030B9
		public Transform worldUpObject
		{
			get
			{
				IntPtr intPtr = AimConstraint.get_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				AimConstraint.set_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00004ED1 File Offset: 0x000030D1
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00004EE3 File Offset: 0x000030E3
		public AimConstraint.WorldUpType worldUpType
		{
			get
			{
				return AimConstraint.get_worldUpTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_worldUpTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
		public int sourceCount
		{
			get
			{
				return AimConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00004EF6 File Offset: 0x000030F6
		public static int GetSourceCountInternal(AimConstraint self)
		{
			return AimConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00004F08 File Offset: 0x00003108
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004F1B File Offset: 0x0000311B
		public void RemoveSourceInternal(int index)
		{
			AimConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The AimConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00004F2E File Offset: 0x0000312E
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			AimConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00004F41 File Offset: 0x00003141
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			AimConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00004F54 File Offset: 0x00003154
		public void get_rotationOffset_Injected(out Vector3 ret)
		{
			AimConstraint.get_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00004F67 File Offset: 0x00003167
		public void set_rotationOffset_Injected(ref Vector3 value)
		{
			AimConstraint.set_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00004F7A File Offset: 0x0000317A
		public void get_aimVector_Injected(out Vector3 ret)
		{
			AimConstraint.get_aimVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00004F8D File Offset: 0x0000318D
		public void set_aimVector_Injected(ref Vector3 value)
		{
			AimConstraint.set_aimVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00004FA0 File Offset: 0x000031A0
		public void get_upVector_Injected(out Vector3 ret)
		{
			AimConstraint.get_upVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00004FB3 File Offset: 0x000031B3
		public void set_upVector_Injected(ref Vector3 value)
		{
			AimConstraint.set_upVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00004FC6 File Offset: 0x000031C6
		public void get_worldUpVector_Injected(out Vector3 ret)
		{
			AimConstraint.get_worldUpVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00004FD9 File Offset: 0x000031D9
		public void set_worldUpVector_Injected(ref Vector3 value)
		{
			AimConstraint.set_worldUpVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400039C RID: 924
		private static readonly AimConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<AimConstraint.Internal_CreateDelegate>("UnityEngine.Animations.AimConstraint::Internal_Create");

		// Token: 0x0400039D RID: 925
		private static readonly AimConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<AimConstraint.get_weightDelegate>("UnityEngine.Animations.AimConstraint::get_weight");

		// Token: 0x0400039E RID: 926
		private static readonly AimConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<AimConstraint.set_weightDelegate>("UnityEngine.Animations.AimConstraint::set_weight");

		// Token: 0x0400039F RID: 927
		private static readonly AimConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<AimConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.AimConstraint::get_constraintActive");

		// Token: 0x040003A0 RID: 928
		private static readonly AimConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<AimConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.AimConstraint::set_constraintActive");

		// Token: 0x040003A1 RID: 929
		private static readonly AimConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_lockedDelegate>("UnityEngine.Animations.AimConstraint::get_locked");

		// Token: 0x040003A2 RID: 930
		private static readonly AimConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_lockedDelegate>("UnityEngine.Animations.AimConstraint::set_locked");

		// Token: 0x040003A3 RID: 931
		private static readonly AimConstraint.get_rotationAxisDelegate get_rotationAxisDelegateField = IL2CPP.ResolveICall<AimConstraint.get_rotationAxisDelegate>("UnityEngine.Animations.AimConstraint::get_rotationAxis");

		// Token: 0x040003A4 RID: 932
		private static readonly AimConstraint.set_rotationAxisDelegate set_rotationAxisDelegateField = IL2CPP.ResolveICall<AimConstraint.set_rotationAxisDelegate>("UnityEngine.Animations.AimConstraint::set_rotationAxis");

		// Token: 0x040003A5 RID: 933
		private static readonly AimConstraint.get_worldUpObjectDelegate get_worldUpObjectDelegateField = IL2CPP.ResolveICall<AimConstraint.get_worldUpObjectDelegate>("UnityEngine.Animations.AimConstraint::get_worldUpObject");

		// Token: 0x040003A6 RID: 934
		private static readonly AimConstraint.set_worldUpObjectDelegate set_worldUpObjectDelegateField = IL2CPP.ResolveICall<AimConstraint.set_worldUpObjectDelegate>("UnityEngine.Animations.AimConstraint::set_worldUpObject");

		// Token: 0x040003A7 RID: 935
		private static readonly AimConstraint.get_worldUpTypeDelegate get_worldUpTypeDelegateField = IL2CPP.ResolveICall<AimConstraint.get_worldUpTypeDelegate>("UnityEngine.Animations.AimConstraint::get_worldUpType");

		// Token: 0x040003A8 RID: 936
		private static readonly AimConstraint.set_worldUpTypeDelegate set_worldUpTypeDelegateField = IL2CPP.ResolveICall<AimConstraint.set_worldUpTypeDelegate>("UnityEngine.Animations.AimConstraint::set_worldUpType");

		// Token: 0x040003A9 RID: 937
		private static readonly AimConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<AimConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.AimConstraint::GetSourceCountInternal");

		// Token: 0x040003AA RID: 938
		private static readonly AimConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<AimConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.AimConstraint::RemoveSourceInternal");

		// Token: 0x040003AB RID: 939
		private static readonly AimConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_rotationAtRest_Injected");

		// Token: 0x040003AC RID: 940
		private static readonly AimConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_rotationAtRest_Injected");

		// Token: 0x040003AD RID: 941
		private static readonly AimConstraint.get_rotationOffset_InjectedDelegate get_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_rotationOffset_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_rotationOffset_Injected");

		// Token: 0x040003AE RID: 942
		private static readonly AimConstraint.set_rotationOffset_InjectedDelegate set_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_rotationOffset_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_rotationOffset_Injected");

		// Token: 0x040003AF RID: 943
		private static readonly AimConstraint.get_aimVector_InjectedDelegate get_aimVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_aimVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_aimVector_Injected");

		// Token: 0x040003B0 RID: 944
		private static readonly AimConstraint.set_aimVector_InjectedDelegate set_aimVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_aimVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_aimVector_Injected");

		// Token: 0x040003B1 RID: 945
		private static readonly AimConstraint.get_upVector_InjectedDelegate get_upVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_upVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_upVector_Injected");

		// Token: 0x040003B2 RID: 946
		private static readonly AimConstraint.set_upVector_InjectedDelegate set_upVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_upVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_upVector_Injected");

		// Token: 0x040003B3 RID: 947
		private static readonly AimConstraint.get_worldUpVector_InjectedDelegate get_worldUpVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_worldUpVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_worldUpVector_Injected");

		// Token: 0x040003B4 RID: 948
		private static readonly AimConstraint.set_worldUpVector_InjectedDelegate set_worldUpVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_worldUpVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_worldUpVector_Injected");

		// Token: 0x020001F1 RID: 497
		public enum WorldUpType
		{
			// Token: 0x0400043B RID: 1083
			SceneUp,
			// Token: 0x0400043C RID: 1084
			ObjectUp,
			// Token: 0x0400043D RID: 1085
			ObjectRotationUp,
			// Token: 0x0400043E RID: 1086
			Vector,
			// Token: 0x0400043F RID: 1087
			None
		}

		// Token: 0x020001F2 RID: 498
		// (Invoke) Token: 0x060008D8 RID: 2264
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x020001F3 RID: 499
		// (Invoke) Token: 0x060008DA RID: 2266
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x020001F4 RID: 500
		// (Invoke) Token: 0x060008DC RID: 2268
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x020001F5 RID: 501
		// (Invoke) Token: 0x060008DE RID: 2270
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x020001F6 RID: 502
		// (Invoke) Token: 0x060008E0 RID: 2272
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x020001F7 RID: 503
		// (Invoke) Token: 0x060008E2 RID: 2274
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x020001F8 RID: 504
		// (Invoke) Token: 0x060008E4 RID: 2276
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x020001F9 RID: 505
		// (Invoke) Token: 0x060008E6 RID: 2278
		private delegate Axis get_rotationAxisDelegate(IntPtr @this);

		// Token: 0x020001FA RID: 506
		// (Invoke) Token: 0x060008E8 RID: 2280
		private delegate void set_rotationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x020001FB RID: 507
		// (Invoke) Token: 0x060008EA RID: 2282
		private delegate IntPtr get_worldUpObjectDelegate(IntPtr @this);

		// Token: 0x020001FC RID: 508
		// (Invoke) Token: 0x060008EC RID: 2284
		private delegate void set_worldUpObjectDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001FD RID: 509
		// (Invoke) Token: 0x060008EE RID: 2286
		private delegate AimConstraint.WorldUpType get_worldUpTypeDelegate(IntPtr @this);

		// Token: 0x020001FE RID: 510
		// (Invoke) Token: 0x060008F0 RID: 2288
		private delegate void set_worldUpTypeDelegate(IntPtr @this, AimConstraint.WorldUpType value);

		// Token: 0x020001FF RID: 511
		// (Invoke) Token: 0x060008F2 RID: 2290
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x02000200 RID: 512
		// (Invoke) Token: 0x060008F4 RID: 2292
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000201 RID: 513
		// (Invoke) Token: 0x060008F6 RID: 2294
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000202 RID: 514
		// (Invoke) Token: 0x060008F8 RID: 2296
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000203 RID: 515
		// (Invoke) Token: 0x060008FA RID: 2298
		private delegate void get_rotationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000204 RID: 516
		// (Invoke) Token: 0x060008FC RID: 2300
		private delegate void set_rotationOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000205 RID: 517
		// (Invoke) Token: 0x060008FE RID: 2302
		private delegate void get_aimVector_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000206 RID: 518
		// (Invoke) Token: 0x06000900 RID: 2304
		private delegate void set_aimVector_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000207 RID: 519
		// (Invoke) Token: 0x06000902 RID: 2306
		private delegate void get_upVector_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000208 RID: 520
		// (Invoke) Token: 0x06000904 RID: 2308
		private delegate void set_upVector_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000209 RID: 521
		// (Invoke) Token: 0x06000906 RID: 2310
		private delegate void get_worldUpVector_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200020A RID: 522
		// (Invoke) Token: 0x06000908 RID: 2312
		private delegate void set_worldUpVector_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
