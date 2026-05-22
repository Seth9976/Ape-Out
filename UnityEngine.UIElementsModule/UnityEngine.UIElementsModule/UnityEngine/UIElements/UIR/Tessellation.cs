using System;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200015C RID: 348
	public static class Tessellation
	{
		// Token: 0x060007F3 RID: 2035 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		public static void TessellateRoundedCorner(Rect rect, Color32 color, float posZ, Vector2 radius, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			Vector2 vector = rect.position + radius;
			Rect zero = Rect.zero;
			bool flag = radius == Vector2.zero;
			if (flag)
			{
				Tessellation.TessellateQuad(rect, 0f, 0f, 0f, Tessellation.TessellationType.Content, color, posZ, mesh, ref vertexCount, ref indexCount, countOnly);
			}
			else
			{
				Tessellation.TessellateFilledFan(Tessellation.TessellationType.Content, vector, radius, 0f, 0f, color, posZ, mesh, ref vertexCount, ref indexCount, countOnly);
				bool flag2 = radius.x < rect.width;
				if (flag2)
				{
					zero = new Rect(rect.x + radius.x, rect.y, rect.width - radius.x, rect.height);
					Tessellation.TessellateQuad(zero, 0f, 0f, 0f, Tessellation.TessellationType.Content, color, posZ, mesh, ref vertexCount, ref indexCount, countOnly);
				}
				bool flag3 = radius.y < rect.height;
				if (flag3)
				{
					zero = new Rect(rect.x, rect.y + radius.y, (radius.x < rect.width) ? radius.x : rect.width, rect.height - radius.y);
					Tessellation.TessellateQuad(zero, 0f, 0f, 0f, Tessellation.TessellationType.Content, color, posZ, mesh, ref vertexCount, ref indexCount, countOnly);
				}
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00007690 File Offset: 0x00005890
		public static void TessellateRoundedBorder(Rect rect, Color32 leftColor, Color32 topColor, float posZ, Vector2 radius, float leftWidth, float topWidth, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0000E138 File Offset: 0x0000C338
		public static Vector2 IntersectEllipseWithLine(float a, float b, Vector2 dir)
		{
			Debug.Assert(dir.x > 0f || dir.y > 0f);
			bool flag = a < Mathf.Epsilon || b < Mathf.Epsilon;
			Vector2 vector;
			if (flag)
			{
				vector = new Vector2(0f, 0f);
			}
			else
			{
				bool flag2 = (double)dir.y < 0.001 * (double)dir.x;
				if (flag2)
				{
					vector = new Vector2(a, 0f);
				}
				else
				{
					bool flag3 = (double)dir.x < 0.001 * (double)dir.y;
					if (flag3)
					{
						vector = new Vector2(0f, b);
					}
					else
					{
						float num = dir.y / dir.x;
						float num2 = b / a;
						float num3 = b * (num2 + num - Mathf.Sqrt(2f * num * num2)) / (num * num + num2 * num2);
						float num4 = num * num3;
						vector = new Vector2(num3, num4);
					}
				}
			}
			return vector;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0000E238 File Offset: 0x0000C438
		public static float GetCenteredEllipseLineIntersectionTheta(float a, float b, Vector2 dir)
		{
			return Mathf.Atan2(dir.y * a, dir.x * b);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0000E260 File Offset: 0x0000C460
		public static Vector2 IntersectLines(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			Vector2 vector = p3 - p2;
			Vector2 vector2 = p2 - p0;
			Vector2 vector3 = p1 - p0;
			float num = vector.x * vector3.y - vector3.x * vector.y;
			bool flag = Mathf.Approximately(num, 0f);
			Vector2 vector4;
			if (flag)
			{
				vector4 = new Vector2(float.NaN, float.NaN);
			}
			else
			{
				float num2 = vector.x * vector2.y - vector2.x * vector.y;
				float num3 = num2 / num;
				Vector2 vector5 = p0 + vector3 * num3;
				vector4 = vector5;
			}
			return vector4;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0000769D File Offset: 0x0000589D
		public static int LooseCompare(float a, float b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000076AA File Offset: 0x000058AA
		public static void TessellateComplexBorderCorner(Rect rect, Vector2 radius, float leftWidth, float topWidth, Color32 color, float posZ, MeshWriteData mesh, ref ushort refVertexCount, ref ushort refIndexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000076B7 File Offset: 0x000058B7
		public static void TessellateComplexBorderCorner(Rect rect, Vector2 radius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000076C4 File Offset: 0x000058C4
		public static void TessellateQuad(Rect rect, float miterOffset, float leftWidth, float topWidth, Tessellation.TessellationType tessellationType, Color32 color, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000076D1 File Offset: 0x000058D1
		public static void TessellateFilledFan(Vector2 center, Vector2 radius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000076DE File Offset: 0x000058DE
		public static void TessellateFilledFan(Tessellation.TessellationType tessellationType, Vector2 center, Vector2 radius, float leftWidth, float topWidth, Color32 color, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000076EB File Offset: 0x000058EB
		public static void TessellateBorderedFan(Vector2 center, Vector2 outerRadius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000076F8 File Offset: 0x000058F8
		public static void TessellateBorderedFan(Vector2 center, Vector2 radius, float leftWidth, float topWidth, Color32 color, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0000E304 File Offset: 0x0000C504
		public static void MirrorVertices(Rect rect, NativeSlice<Vertex> vertices, int vertexStart, int vertexCount, bool flipHorizontal)
		{
			if (flipHorizontal)
			{
				for (int i = 0; i < vertexCount; i++)
				{
					Vertex vertex = vertices[vertexStart + i];
					vertex.position.x = rect.xMax - (vertex.position.x - rect.xMax);
					vertex.uv.x = -vertex.uv.x;
					vertices[vertexStart + i] = vertex;
				}
			}
			else
			{
				for (int j = 0; j < vertexCount; j++)
				{
					Vertex vertex2 = vertices[vertexStart + j];
					vertex2.position.y = rect.yMax - (vertex2.position.y - rect.yMax);
					vertex2.uv.y = -vertex2.uv.y;
					vertices[vertexStart + j] = vertex2;
				}
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0000E3FC File Offset: 0x0000C5FC
		public static void FlipWinding(NativeSlice<ushort> indices, int indexStart, int indexCount)
		{
			for (int i = 0; i < indexCount; i += 3)
			{
				ushort num = indices[indexStart + i];
				indices[indexStart + i] = indices[indexStart + i + 1];
				indices[indexStart + i + 1] = num;
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0000E44C File Offset: 0x0000C64C
		public static void ComputeUVs(Rect tessellatedRect, Rect textureRect, Rect uvRegion, NativeSlice<Vertex> vertices)
		{
			Vector2 position = tessellatedRect.position;
			Vector2 vector = new Vector2(1f / tessellatedRect.width, 1f / tessellatedRect.height);
			for (int i = 0; i < vertices.Length; i++)
			{
				Vertex vertex = vertices[i];
				Vector2 vector2 = vertex.position;
				vector2 -= position;
				vector2 *= vector;
				vertex.uv.x = (vector2.x * textureRect.width + textureRect.xMin) * uvRegion.width + uvRegion.xMin;
				vertex.uv.y = ((1f - vector2.y) * textureRect.height + textureRect.yMin) * uvRegion.height + uvRegion.yMin;
				vertices[i] = vertex;
			}
		}

		// Token: 0x02000213 RID: 531
		public enum TessellationType
		{
			// Token: 0x0400026E RID: 622
			EdgeHorizontal,
			// Token: 0x0400026F RID: 623
			EdgeVertical,
			// Token: 0x04000270 RID: 624
			EdgeCorner,
			// Token: 0x04000271 RID: 625
			Content
		}
	}
}
