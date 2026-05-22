using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000237 RID: 567
	public sealed class LineUtility
	{
		// Token: 0x06002164 RID: 8548 RVA: 0x00075EC0 File Offset: 0x000740C0
		public static void Simplify(List<Vector3> points, float tolerance, List<int> pointsToKeep)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = pointsToKeep == null;
			if (flag2)
			{
				throw new ArgumentNullException("pointsToKeep");
			}
			LineUtility.GeneratePointsToKeep3D(points, tolerance, pointsToKeep);
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00075F00 File Offset: 0x00074100
		public static void Simplify(List<Vector3> points, float tolerance, List<Vector3> simplifiedPoints)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = simplifiedPoints == null;
			if (flag2)
			{
				throw new ArgumentNullException("simplifiedPoints");
			}
			LineUtility.GenerateSimplifiedPoints3D(points, tolerance, simplifiedPoints);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00075F40 File Offset: 0x00074140
		public static void Simplify(List<Vector2> points, float tolerance, List<int> pointsToKeep)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = pointsToKeep == null;
			if (flag2)
			{
				throw new ArgumentNullException("pointsToKeep");
			}
			LineUtility.GeneratePointsToKeep2D(points, tolerance, pointsToKeep);
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00075F80 File Offset: 0x00074180
		public static void Simplify(List<Vector2> points, float tolerance, List<Vector2> simplifiedPoints)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = simplifiedPoints == null;
			if (flag2)
			{
				throw new ArgumentNullException("simplifiedPoints");
			}
			LineUtility.GenerateSimplifiedPoints2D(points, tolerance, simplifiedPoints);
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00011B04 File Offset: 0x0000FD04
		public static void GeneratePointsToKeep3D(Object pointsList, float tolerance, Object pointsToKeepList)
		{
			LineUtility.GeneratePointsToKeep3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(pointsToKeepList));
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00011B1D File Offset: 0x0000FD1D
		public static void GeneratePointsToKeep2D(Object pointsList, float tolerance, Object pointsToKeepList)
		{
			LineUtility.GeneratePointsToKeep2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(pointsToKeepList));
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00011B36 File Offset: 0x0000FD36
		public static void GenerateSimplifiedPoints3D(Object pointsList, float tolerance, Object simplifiedPoints)
		{
			LineUtility.GenerateSimplifiedPoints3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(simplifiedPoints));
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00011B4F File Offset: 0x0000FD4F
		public static void GenerateSimplifiedPoints2D(Object pointsList, float tolerance, Object simplifiedPoints)
		{
			LineUtility.GenerateSimplifiedPoints2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(simplifiedPoints));
		}

		// Token: 0x04001B8F RID: 7055
		private static readonly LineUtility.GeneratePointsToKeep3DDelegate GeneratePointsToKeep3DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep3DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep3D");

		// Token: 0x04001B90 RID: 7056
		private static readonly LineUtility.GeneratePointsToKeep2DDelegate GeneratePointsToKeep2DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep2DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep2D");

		// Token: 0x04001B91 RID: 7057
		private static readonly LineUtility.GenerateSimplifiedPoints3DDelegate GenerateSimplifiedPoints3DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints3DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints3D");

		// Token: 0x04001B92 RID: 7058
		private static readonly LineUtility.GenerateSimplifiedPoints2DDelegate GenerateSimplifiedPoints2DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints2DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints2D");

		// Token: 0x02000B67 RID: 2919
		// (Invoke) Token: 0x0600352E RID: 13614
		private delegate void GeneratePointsToKeep3DDelegate(IntPtr pointsList, float tolerance, IntPtr pointsToKeepList);

		// Token: 0x02000B68 RID: 2920
		// (Invoke) Token: 0x06003530 RID: 13616
		private delegate void GeneratePointsToKeep2DDelegate(IntPtr pointsList, float tolerance, IntPtr pointsToKeepList);

		// Token: 0x02000B69 RID: 2921
		// (Invoke) Token: 0x06003532 RID: 13618
		private delegate void GenerateSimplifiedPoints3DDelegate(IntPtr pointsList, float tolerance, IntPtr simplifiedPoints);

		// Token: 0x02000B6A RID: 2922
		// (Invoke) Token: 0x06003534 RID: 13620
		private delegate void GenerateSimplifiedPoints2DDelegate(IntPtr pointsList, float tolerance, IntPtr simplifiedPoints);
	}
}
