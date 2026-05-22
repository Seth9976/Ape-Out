using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000202 RID: 514
	public sealed class GeometryUtility
	{
		// Token: 0x06002088 RID: 8328 RVA: 0x00010EC2 File Offset: 0x0000F0C2
		public static Il2CppStructArray<Plane> CalculateFrustumPlanes(Camera camera)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00010ECF File Offset: 0x0000F0CF
		public static Il2CppStructArray<Plane> CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00010EDC File Offset: 0x0000F0DC
		public static void CalculateFrustumPlanes(Camera camera, Il2CppStructArray<Plane> planes)
		{
			GeometryUtility.CalculateFrustumPlanes(camera.projectionMatrix * camera.worldToCameraMatrix, planes);
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00074CD8 File Offset: 0x00072ED8
		public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Il2CppStructArray<Plane> planes)
		{
			bool flag = planes == null;
			if (flag)
			{
				throw new ArgumentNullException("planes");
			}
			bool flag2 = planes.Length != 6;
			if (flag2)
			{
				throw new ArgumentException("Planes array must be of length 6.", "planes");
			}
			GeometryUtility.Internal_ExtractPlanes(planes, worldToProjectionMatrix);
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00074D24 File Offset: 0x00072F24
		public static Bounds CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
		{
			bool flag = positions == null;
			if (flag)
			{
				throw new ArgumentNullException("positions");
			}
			bool flag2 = positions.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.", "positions");
			}
			return GeometryUtility.Internal_CalculateBounds(positions, transform);
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00074D70 File Offset: 0x00072F70
		public static bool TryCreatePlaneFromPolygon(Il2CppStructArray<Vector3> vertices, out Plane plane)
		{
			bool flag = vertices == null || vertices.Length < 3;
			bool flag2;
			if (flag)
			{
				plane = new Plane(Vector3.up, 0f);
				flag2 = false;
			}
			else
			{
				bool flag3 = vertices.Length == 3;
				if (flag3)
				{
					Vector3 vector = vertices[0];
					Vector3 vector2 = vertices[1];
					Vector3 vector3 = vertices[2];
					plane = new Plane(vector, vector2, vector3);
					flag2 = plane.normal.sqrMagnitude > 0f;
				}
				else
				{
					Vector3 zero = Vector3.zero;
					int num = vertices.Length - 1;
					Vector3 vector4 = vertices[num];
					for (int i = 0; i < vertices.Length; i++)
					{
						Vector3 vector5 = vertices[i];
						zero.x += (vector4.y - vector5.y) * (vector4.z + vector5.z);
						zero.y += (vector4.z - vector5.z) * (vector4.x + vector5.x);
						zero.z += (vector4.x - vector5.x) * (vector4.y + vector5.y);
						vector4 = vector5;
					}
					zero.Normalize();
					float num2 = 0f;
					for (int j = 0; j < vertices.Length; j++)
					{
						Vector3 vector6 = vertices[j];
						num2 -= Vector3.Dot(zero, vector6);
					}
					num2 /= (float)vertices.Length;
					plane = new Plane(zero, num2);
					flag2 = plane.normal.sqrMagnitude > 0f;
				}
			}
			return flag2;
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00010EF7 File Offset: 0x0000F0F7
		public static bool TestPlanesAABB(Il2CppStructArray<Plane> planes, Bounds bounds)
		{
			return GeometryUtility.TestPlanesAABB_Injected(planes, ref bounds);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00010F01 File Offset: 0x0000F101
		public static void Internal_ExtractPlanes([Out] Il2CppStructArray<Plane> planes, Matrix4x4 worldToProjectionMatrix)
		{
			GeometryUtility.Internal_ExtractPlanes_Injected(planes, ref worldToProjectionMatrix);
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00074F4C File Offset: 0x0007314C
		public static Bounds Internal_CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
		{
			Bounds bounds;
			GeometryUtility.Internal_CalculateBounds_Injected(positions, ref transform, out bounds);
			return bounds;
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00010F0B File Offset: 0x0000F10B
		public static bool TestPlanesAABB_Injected(Il2CppStructArray<Plane> planes, ref Bounds bounds)
		{
			return GeometryUtility.TestPlanesAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(planes), ref bounds);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00010F1E File Offset: 0x0000F11E
		public static void Internal_ExtractPlanes_Injected([Out] Il2CppStructArray<Plane> planes, ref Matrix4x4 worldToProjectionMatrix)
		{
			GeometryUtility.Internal_ExtractPlanes_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(planes), ref worldToProjectionMatrix);
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00010F31 File Offset: 0x0000F131
		public static void Internal_CalculateBounds_Injected(Il2CppStructArray<Vector3> positions, ref Matrix4x4 transform, out Bounds ret)
		{
			GeometryUtility.Internal_CalculateBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(positions), ref transform, out ret);
		}

		// Token: 0x04001A85 RID: 6789
		private static readonly GeometryUtility.TestPlanesAABB_InjectedDelegate TestPlanesAABB_InjectedDelegateField = IL2CPP.ResolveICall<GeometryUtility.TestPlanesAABB_InjectedDelegate>("UnityEngine.GeometryUtility::TestPlanesAABB_Injected");

		// Token: 0x04001A86 RID: 6790
		private static readonly GeometryUtility.Internal_ExtractPlanes_InjectedDelegate Internal_ExtractPlanes_InjectedDelegateField = IL2CPP.ResolveICall<GeometryUtility.Internal_ExtractPlanes_InjectedDelegate>("UnityEngine.GeometryUtility::Internal_ExtractPlanes_Injected");

		// Token: 0x04001A87 RID: 6791
		private static readonly GeometryUtility.Internal_CalculateBounds_InjectedDelegate Internal_CalculateBounds_InjectedDelegateField = IL2CPP.ResolveICall<GeometryUtility.Internal_CalculateBounds_InjectedDelegate>("UnityEngine.GeometryUtility::Internal_CalculateBounds_Injected");

		// Token: 0x02000AE4 RID: 2788
		// (Invoke) Token: 0x0600342A RID: 13354
		private delegate bool TestPlanesAABB_InjectedDelegate(IntPtr planes, IntPtr bounds);

		// Token: 0x02000AE5 RID: 2789
		// (Invoke) Token: 0x0600342C RID: 13356
		private delegate void Internal_ExtractPlanes_InjectedDelegate([Out] IntPtr planes, IntPtr worldToProjectionMatrix);

		// Token: 0x02000AE6 RID: 2790
		// (Invoke) Token: 0x0600342E RID: 13358
		private delegate void Internal_CalculateBounds_InjectedDelegate(IntPtr positions, IntPtr transform, [Out] IntPtr ret);
	}
}
