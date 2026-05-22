using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	public sealed class CompositeCollider2D : Collider2D
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000381D File Offset: 0x00001A1D
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000382F File Offset: 0x00001A2F
		public CompositeCollider2D.GeometryType geometryType
		{
			get
			{
				return CompositeCollider2D.get_geometryTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_geometryTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00003842 File Offset: 0x00001A42
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00003854 File Offset: 0x00001A54
		public CompositeCollider2D.GenerationType generationType
		{
			get
			{
				return CompositeCollider2D.get_generationTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_generationTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00003867 File Offset: 0x00001A67
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00003879 File Offset: 0x00001A79
		public float vertexDistance
		{
			get
			{
				return CompositeCollider2D.get_vertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_vertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000388C File Offset: 0x00001A8C
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0000389E File Offset: 0x00001A9E
		public float edgeRadius
		{
			get
			{
				return CompositeCollider2D.get_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600037C RID: 892 RVA: 0x000038B1 File Offset: 0x00001AB1
		// (set) Token: 0x0600037D RID: 893 RVA: 0x000038C3 File Offset: 0x00001AC3
		public float offsetDistance
		{
			get
			{
				return CompositeCollider2D.get_offsetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CompositeCollider2D.set_offsetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000038D6 File Offset: 0x00001AD6
		public void GenerateGeometry()
		{
			CompositeCollider2D.GenerateGeometryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000D654 File Offset: 0x0000B854
		public int GetPathPointCount(int index)
		{
			int num = this.pathCount - 1;
			bool flag = index < 0 || index > num;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Path index {0} must be in the range of 0 to {1}.", index, num));
			}
			return this.GetPathPointCount_Internal(index);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000038E8 File Offset: 0x00001AE8
		public int GetPathPointCount_Internal(int index)
		{
			return CompositeCollider2D.GetPathPointCount_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000038FB File Offset: 0x00001AFB
		public int pathCount
		{
			get
			{
				return CompositeCollider2D.get_pathCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000390D File Offset: 0x00001B0D
		public int pointCount
		{
			get
			{
				return CompositeCollider2D.get_pointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		public int GetPath(int index, Il2CppStructArray<Vector2> points)
		{
			bool flag = index < 0 || index >= this.pathCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Path index {0} must be in the range of 0 to {1}.", index, this.pathCount - 1));
			}
			bool flag2 = points == null;
			if (flag2)
			{
				throw new ArgumentNullException("points");
			}
			return this.GetPathArray_Internal(index, points);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000391F File Offset: 0x00001B1F
		public int GetPathArray_Internal(int index, Il2CppStructArray<Vector2> points)
		{
			return CompositeCollider2D.GetPathArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000D714 File Offset: 0x0000B914
		public int GetPath(int index, List<Vector2> points)
		{
			bool flag = index < 0 || index >= this.pathCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Path index {0} must be in the range of 0 to {1}.", index, this.pathCount - 1));
			}
			bool flag2 = points == null;
			if (flag2)
			{
				throw new ArgumentNullException("points");
			}
			return this.GetPathList_Internal(index, points);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00003938 File Offset: 0x00001B38
		public int GetPathList_Internal(int index, List<Vector2> points)
		{
			return CompositeCollider2D.GetPathList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x04000218 RID: 536
		private static readonly CompositeCollider2D.get_geometryTypeDelegate get_geometryTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_geometryTypeDelegate>("UnityEngine.CompositeCollider2D::get_geometryType");

		// Token: 0x04000219 RID: 537
		private static readonly CompositeCollider2D.set_geometryTypeDelegate set_geometryTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_geometryTypeDelegate>("UnityEngine.CompositeCollider2D::set_geometryType");

		// Token: 0x0400021A RID: 538
		private static readonly CompositeCollider2D.get_generationTypeDelegate get_generationTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_generationTypeDelegate>("UnityEngine.CompositeCollider2D::get_generationType");

		// Token: 0x0400021B RID: 539
		private static readonly CompositeCollider2D.set_generationTypeDelegate set_generationTypeDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_generationTypeDelegate>("UnityEngine.CompositeCollider2D::set_generationType");

		// Token: 0x0400021C RID: 540
		private static readonly CompositeCollider2D.get_vertexDistanceDelegate get_vertexDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_vertexDistanceDelegate>("UnityEngine.CompositeCollider2D::get_vertexDistance");

		// Token: 0x0400021D RID: 541
		private static readonly CompositeCollider2D.set_vertexDistanceDelegate set_vertexDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_vertexDistanceDelegate>("UnityEngine.CompositeCollider2D::set_vertexDistance");

		// Token: 0x0400021E RID: 542
		private static readonly CompositeCollider2D.get_edgeRadiusDelegate get_edgeRadiusDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_edgeRadiusDelegate>("UnityEngine.CompositeCollider2D::get_edgeRadius");

		// Token: 0x0400021F RID: 543
		private static readonly CompositeCollider2D.set_edgeRadiusDelegate set_edgeRadiusDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_edgeRadiusDelegate>("UnityEngine.CompositeCollider2D::set_edgeRadius");

		// Token: 0x04000220 RID: 544
		private static readonly CompositeCollider2D.get_offsetDistanceDelegate get_offsetDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_offsetDistanceDelegate>("UnityEngine.CompositeCollider2D::get_offsetDistance");

		// Token: 0x04000221 RID: 545
		private static readonly CompositeCollider2D.set_offsetDistanceDelegate set_offsetDistanceDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.set_offsetDistanceDelegate>("UnityEngine.CompositeCollider2D::set_offsetDistance");

		// Token: 0x04000222 RID: 546
		private static readonly CompositeCollider2D.GenerateGeometryDelegate GenerateGeometryDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GenerateGeometryDelegate>("UnityEngine.CompositeCollider2D::GenerateGeometry");

		// Token: 0x04000223 RID: 547
		private static readonly CompositeCollider2D.GetPathPointCount_InternalDelegate GetPathPointCount_InternalDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GetPathPointCount_InternalDelegate>("UnityEngine.CompositeCollider2D::GetPathPointCount_Internal");

		// Token: 0x04000224 RID: 548
		private static readonly CompositeCollider2D.get_pathCountDelegate get_pathCountDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_pathCountDelegate>("UnityEngine.CompositeCollider2D::get_pathCount");

		// Token: 0x04000225 RID: 549
		private static readonly CompositeCollider2D.get_pointCountDelegate get_pointCountDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.get_pointCountDelegate>("UnityEngine.CompositeCollider2D::get_pointCount");

		// Token: 0x04000226 RID: 550
		private static readonly CompositeCollider2D.GetPathArray_InternalDelegate GetPathArray_InternalDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GetPathArray_InternalDelegate>("UnityEngine.CompositeCollider2D::GetPathArray_Internal");

		// Token: 0x04000227 RID: 551
		private static readonly CompositeCollider2D.GetPathList_InternalDelegate GetPathList_InternalDelegateField = IL2CPP.ResolveICall<CompositeCollider2D.GetPathList_InternalDelegate>("UnityEngine.CompositeCollider2D::GetPathList_Internal");

		// Token: 0x02000136 RID: 310
		public enum GeometryType
		{
			// Token: 0x040002C3 RID: 707
			Outlines,
			// Token: 0x040002C4 RID: 708
			Polygons
		}

		// Token: 0x02000137 RID: 311
		public enum GenerationType
		{
			// Token: 0x040002C6 RID: 710
			Synchronous,
			// Token: 0x040002C7 RID: 711
			Manual
		}

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x06000646 RID: 1606
		private delegate CompositeCollider2D.GeometryType get_geometryTypeDelegate(IntPtr @this);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x06000648 RID: 1608
		private delegate void set_geometryTypeDelegate(IntPtr @this, CompositeCollider2D.GeometryType value);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x0600064A RID: 1610
		private delegate CompositeCollider2D.GenerationType get_generationTypeDelegate(IntPtr @this);

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x0600064C RID: 1612
		private delegate void set_generationTypeDelegate(IntPtr @this, CompositeCollider2D.GenerationType value);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x0600064E RID: 1614
		private delegate float get_vertexDistanceDelegate(IntPtr @this);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x06000650 RID: 1616
		private delegate void set_vertexDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x06000652 RID: 1618
		private delegate float get_edgeRadiusDelegate(IntPtr @this);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x06000654 RID: 1620
		private delegate void set_edgeRadiusDelegate(IntPtr @this, float value);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x06000656 RID: 1622
		private delegate float get_offsetDistanceDelegate(IntPtr @this);

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x06000658 RID: 1624
		private delegate void set_offsetDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x0600065A RID: 1626
		private delegate void GenerateGeometryDelegate(IntPtr @this);

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x0600065C RID: 1628
		private delegate int GetPathPointCount_InternalDelegate(IntPtr @this, int index);

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x0600065E RID: 1630
		private delegate int get_pathCountDelegate(IntPtr @this);

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x06000660 RID: 1632
		private delegate int get_pointCountDelegate(IntPtr @this);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x06000662 RID: 1634
		private delegate int GetPathArray_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x02000147 RID: 327
		// (Invoke) Token: 0x06000664 RID: 1636
		private delegate int GetPathList_InternalDelegate(IntPtr @this, int index, IntPtr points);
	}
}
