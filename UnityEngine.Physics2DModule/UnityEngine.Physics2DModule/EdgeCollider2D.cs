using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	public sealed class EdgeCollider2D : Collider2D
	{
		// Token: 0x06000305 RID: 773 RVA: 0x0000CABC File Offset: 0x0000ACBC
		// Note: this type is marked as 'beforefieldinit'.
		static EdgeCollider2D()
		{
			Il2CppClassPointerStore<EdgeCollider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "EdgeCollider2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EdgeCollider2D>.NativeClassPtr);
			EdgeCollider2D.ResetDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.ResetDelegate>("UnityEngine.EdgeCollider2D::Reset");
			EdgeCollider2D.get_edgeRadiusDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_edgeRadiusDelegate>("UnityEngine.EdgeCollider2D::get_edgeRadius");
			EdgeCollider2D.set_edgeRadiusDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_edgeRadiusDelegate>("UnityEngine.EdgeCollider2D::set_edgeRadius");
			EdgeCollider2D.get_edgeCountDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_edgeCountDelegate>("UnityEngine.EdgeCollider2D::get_edgeCount");
			EdgeCollider2D.get_pointCountDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_pointCountDelegate>("UnityEngine.EdgeCollider2D::get_pointCount");
			EdgeCollider2D.get_pointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_pointsDelegate>("UnityEngine.EdgeCollider2D::get_points");
			EdgeCollider2D.set_pointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_pointsDelegate>("UnityEngine.EdgeCollider2D::set_points");
			EdgeCollider2D.GetPointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.GetPointsDelegate>("UnityEngine.EdgeCollider2D::GetPoints");
			EdgeCollider2D.SetPointsDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.SetPointsDelegate>("UnityEngine.EdgeCollider2D::SetPoints");
			EdgeCollider2D.get_useAdjacentStartPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_useAdjacentStartPointDelegate>("UnityEngine.EdgeCollider2D::get_useAdjacentStartPoint");
			EdgeCollider2D.set_useAdjacentStartPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_useAdjacentStartPointDelegate>("UnityEngine.EdgeCollider2D::set_useAdjacentStartPoint");
			EdgeCollider2D.get_useAdjacentEndPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_useAdjacentEndPointDelegate>("UnityEngine.EdgeCollider2D::get_useAdjacentEndPoint");
			EdgeCollider2D.set_useAdjacentEndPointDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_useAdjacentEndPointDelegate>("UnityEngine.EdgeCollider2D::set_useAdjacentEndPoint");
			EdgeCollider2D.get_adjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_adjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_adjacentStartPoint_Injected");
			EdgeCollider2D.set_adjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_adjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_adjacentStartPoint_Injected");
			EdgeCollider2D.get_adjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.get_adjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_adjacentEndPoint_Injected");
			EdgeCollider2D.set_adjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<EdgeCollider2D.set_adjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_adjacentEndPoint_Injected");
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000327E File Offset: 0x0000147E
		public EdgeCollider2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003287 File Offset: 0x00001487
		public void Reset()
		{
			EdgeCollider2D.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00003299 File Offset: 0x00001499
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000032AB File Offset: 0x000014AB
		public float edgeRadius
		{
			get
			{
				return EdgeCollider2D.get_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				EdgeCollider2D.set_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000032BE File Offset: 0x000014BE
		public int edgeCount
		{
			get
			{
				return EdgeCollider2D.get_edgeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600030B RID: 779 RVA: 0x000032D0 File Offset: 0x000014D0
		public int pointCount
		{
			get
			{
				return EdgeCollider2D.get_pointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000032E2 File Offset: 0x000014E2
		public Il2CppStructArray<Vector2> points
		{
			get
			{
				IntPtr intPtr = EdgeCollider2D.get_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				EdgeCollider2D.set_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000032FA File Offset: 0x000014FA
		public int GetPoints(List<Vector2> points)
		{
			return EdgeCollider2D.GetPointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003312 File Offset: 0x00001512
		public bool SetPoints(List<Vector2> points)
		{
			return EdgeCollider2D.SetPointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000332A File Offset: 0x0000152A
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0000333C File Offset: 0x0000153C
		public bool useAdjacentStartPoint
		{
			get
			{
				return EdgeCollider2D.get_useAdjacentStartPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				EdgeCollider2D.set_useAdjacentStartPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000334F File Offset: 0x0000154F
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00003361 File Offset: 0x00001561
		public bool useAdjacentEndPoint
		{
			get
			{
				return EdgeCollider2D.get_useAdjacentEndPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				EdgeCollider2D.set_useAdjacentEndPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000CC18 File Offset: 0x0000AE18
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00003374 File Offset: 0x00001574
		public Vector2 adjacentStartPoint
		{
			get
			{
				Vector2 vector;
				this.get_adjacentStartPoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_adjacentStartPoint_Injected(ref value);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000CC30 File Offset: 0x0000AE30
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0000337E File Offset: 0x0000157E
		public Vector2 adjacentEndPoint
		{
			get
			{
				Vector2 vector;
				this.get_adjacentEndPoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_adjacentEndPoint_Injected(ref value);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00003388 File Offset: 0x00001588
		public void get_adjacentStartPoint_Injected(out Vector2 ret)
		{
			EdgeCollider2D.get_adjacentStartPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000339B File Offset: 0x0000159B
		public void set_adjacentStartPoint_Injected(ref Vector2 value)
		{
			EdgeCollider2D.set_adjacentStartPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000033AE File Offset: 0x000015AE
		public void get_adjacentEndPoint_Injected(out Vector2 ret)
		{
			EdgeCollider2D.get_adjacentEndPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000033C1 File Offset: 0x000015C1
		public void set_adjacentEndPoint_Injected(ref Vector2 value)
		{
			EdgeCollider2D.set_adjacentEndPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001B5 RID: 437
		private static readonly EdgeCollider2D.ResetDelegate ResetDelegateField;

		// Token: 0x040001B6 RID: 438
		private static readonly EdgeCollider2D.get_edgeRadiusDelegate get_edgeRadiusDelegateField;

		// Token: 0x040001B7 RID: 439
		private static readonly EdgeCollider2D.set_edgeRadiusDelegate set_edgeRadiusDelegateField;

		// Token: 0x040001B8 RID: 440
		private static readonly EdgeCollider2D.get_edgeCountDelegate get_edgeCountDelegateField;

		// Token: 0x040001B9 RID: 441
		private static readonly EdgeCollider2D.get_pointCountDelegate get_pointCountDelegateField;

		// Token: 0x040001BA RID: 442
		private static readonly EdgeCollider2D.get_pointsDelegate get_pointsDelegateField;

		// Token: 0x040001BB RID: 443
		private static readonly EdgeCollider2D.set_pointsDelegate set_pointsDelegateField;

		// Token: 0x040001BC RID: 444
		private static readonly EdgeCollider2D.GetPointsDelegate GetPointsDelegateField;

		// Token: 0x040001BD RID: 445
		private static readonly EdgeCollider2D.SetPointsDelegate SetPointsDelegateField;

		// Token: 0x040001BE RID: 446
		private static readonly EdgeCollider2D.get_useAdjacentStartPointDelegate get_useAdjacentStartPointDelegateField;

		// Token: 0x040001BF RID: 447
		private static readonly EdgeCollider2D.set_useAdjacentStartPointDelegate set_useAdjacentStartPointDelegateField;

		// Token: 0x040001C0 RID: 448
		private static readonly EdgeCollider2D.get_useAdjacentEndPointDelegate get_useAdjacentEndPointDelegateField;

		// Token: 0x040001C1 RID: 449
		private static readonly EdgeCollider2D.set_useAdjacentEndPointDelegate set_useAdjacentEndPointDelegateField;

		// Token: 0x040001C2 RID: 450
		private static readonly EdgeCollider2D.get_adjacentStartPoint_InjectedDelegate get_adjacentStartPoint_InjectedDelegateField;

		// Token: 0x040001C3 RID: 451
		private static readonly EdgeCollider2D.set_adjacentStartPoint_InjectedDelegate set_adjacentStartPoint_InjectedDelegateField;

		// Token: 0x040001C4 RID: 452
		private static readonly EdgeCollider2D.get_adjacentEndPoint_InjectedDelegate get_adjacentEndPoint_InjectedDelegateField;

		// Token: 0x040001C5 RID: 453
		private static readonly EdgeCollider2D.set_adjacentEndPoint_InjectedDelegate set_adjacentEndPoint_InjectedDelegateField;

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x060005C2 RID: 1474
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x060005C4 RID: 1476
		private delegate float get_edgeRadiusDelegate(IntPtr @this);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x060005C6 RID: 1478
		private delegate void set_edgeRadiusDelegate(IntPtr @this, float value);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x060005C8 RID: 1480
		private delegate int get_edgeCountDelegate(IntPtr @this);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x060005CA RID: 1482
		private delegate int get_pointCountDelegate(IntPtr @this);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x060005CC RID: 1484
		private delegate IntPtr get_pointsDelegate(IntPtr @this);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x060005CE RID: 1486
		private delegate void set_pointsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x060005D0 RID: 1488
		private delegate int GetPointsDelegate(IntPtr @this, IntPtr points);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x060005D2 RID: 1490
		private delegate bool SetPointsDelegate(IntPtr @this, IntPtr points);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x060005D4 RID: 1492
		private delegate bool get_useAdjacentStartPointDelegate(IntPtr @this);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x060005D6 RID: 1494
		private delegate void set_useAdjacentStartPointDelegate(IntPtr @this, bool value);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x060005D8 RID: 1496
		private delegate bool get_useAdjacentEndPointDelegate(IntPtr @this);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x060005DA RID: 1498
		private delegate void set_useAdjacentEndPointDelegate(IntPtr @this, bool value);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x060005DC RID: 1500
		private delegate void get_adjacentStartPoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x060005DE RID: 1502
		private delegate void set_adjacentStartPoint_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x060005E0 RID: 1504
		private delegate void get_adjacentEndPoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060005E2 RID: 1506
		private delegate void set_adjacentEndPoint_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
