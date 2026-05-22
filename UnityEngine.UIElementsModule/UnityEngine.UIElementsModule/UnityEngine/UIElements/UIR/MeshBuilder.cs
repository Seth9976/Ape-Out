using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000157 RID: 343
	public static class MeshBuilder
	{
		// Token: 0x060007E7 RID: 2023 RVA: 0x0000DA24 File Offset: 0x0000BC24
		public static Vertex ConvertTextVertexToUIRVertex(TextVertex textVertex, Vector2 offset)
		{
			return new Vertex
			{
				position = new Vector3(textVertex.position.x + offset.x, textVertex.position.y + offset.y, 0f),
				uv = textVertex.uv0,
				tint = textVertex.color,
				idsFlags = new Color32(0, 0, 0, 1)
			};
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		public static int LimitTextVertices(int vertexCount, [Optional] bool logTruncation)
		{
			bool flag = vertexCount <= 49152;
			int num;
			if (flag)
			{
				num = vertexCount;
			}
			else
			{
				if (logTruncation)
				{
					Debug.LogError(String.Format("Generated text will be truncated because it exceeds {0} vertices.", 49152));
				}
				num = 49152;
			}
			return num;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0000DAEC File Offset: 0x0000BCEC
		public static void UpdateText(NativeArray<TextVertex> uiVertices, Vector2 offset, Matrix4x4 transform, Color32 xformClipPages, Color32 idsFlags, Color32 opacityPageSVGSettingIndex, NativeSlice<Vertex> vertices)
		{
			int num = MeshBuilder.LimitTextVertices(uiVertices.Length, false);
			Debug.Assert(num == vertices.Length);
			idsFlags.a = 1;
			for (int i = 0; i < num; i++)
			{
				TextVertex textVertex = uiVertices[i];
				vertices[i] = new Vertex
				{
					position = transform.MultiplyPoint3x4(new Vector3(textVertex.position.x + offset.x, textVertex.position.y + offset.y, 0f)),
					uv = textVertex.uv0,
					tint = textVertex.color,
					xformClipPages = xformClipPages,
					idsFlags = idsFlags,
					opacityPageSVGSettingIndex = opacityPageSVGSettingIndex
				};
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00007657 File Offset: 0x00005857
		public unsafe static void RectClipTriangle(Vertex* vt, ushort* it, Vector4 clipRectMinMax, MeshWriteData mwd, ref ushort nextNewVertex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		public unsafe static Vector3 GetVertexBaryCentricCoordinates(Vertex* vt, float x, float y)
		{
			float num = vt[1].position.x - vt->position.x;
			float num2 = vt[1].position.y - vt->position.y;
			float num3 = vt[2].position.x - vt->position.x;
			float num4 = vt[2].position.y - vt->position.y;
			float num5 = x - vt->position.x;
			float num6 = y - vt->position.y;
			float num7 = num * num + num2 * num2;
			float num8 = num * num3 + num2 * num4;
			float num9 = num3 * num3 + num4 * num4;
			float num10 = num5 * num + num6 * num2;
			float num11 = num5 * num3 + num6 * num4;
			float num12 = num7 * num9 - num8 * num8;
			Vector3 vector;
			vector.y = (num9 * num10 - num8 * num11) / num12;
			vector.z = (num7 * num11 - num8 * num10) / num12;
			vector.x = 1f - vector.y - vector.z;
			return vector;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0000DD04 File Offset: 0x0000BF04
		public unsafe static Vertex InterpolateVertexInTriangle(Vertex* vt, float x, float y, Vector3 uvw)
		{
			Vertex vertex = *vt;
			vertex.position.x = x;
			vertex.position.y = y;
			vertex.tint = vt->tint * uvw.x + vt[1].tint * uvw.y + vt[2].tint * uvw.z;
			vertex.uv = vt->uv * uvw.x + vt[1].uv * uvw.y + vt[2].uv * uvw.z;
			return vertex;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0000DDF8 File Offset: 0x0000BFF8
		public unsafe static Vertex InterpolateVertexInTriangleEdge(Vertex* vt, int e0, int e1, float t)
		{
			Vertex vertex = *vt;
			vertex.position.x = vt[e0].position.x + t * (vt[e1].position.x - vt[e0].position.x);
			vertex.position.y = vt[e0].position.y + t * (vt[e1].position.y - vt[e0].position.y);
			vertex.tint = Color.LerpUnclamped(vt[e0].tint, vt[e1].tint, t);
			vertex.uv = Vector2.LerpUnclamped(vt[e0].uv, vt[e1].uv, t);
			return vertex;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0000DF1C File Offset: 0x0000C11C
		public static float IntersectSegments(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy)
		{
			float num = (ax - dx) * (by - dy) - (ay - dy) * (bx - dx);
			float num2 = (ax - cx) * (by - cy) - (ay - cy) * (bx - cx);
			bool flag = num * num2 >= 0f;
			float num3;
			if (flag)
			{
				num3 = float.MaxValue;
			}
			else
			{
				float num4 = (cx - ax) * (dy - ay) - (cy - ay) * (dx - ax);
				float num5 = num4 + num2 - num;
				bool flag2 = num4 * num5 >= 0f;
				if (flag2)
				{
					num3 = float.MaxValue;
				}
				else
				{
					num3 = num4 / (num4 - num5);
				}
			}
			return num3;
		}
	}
}
