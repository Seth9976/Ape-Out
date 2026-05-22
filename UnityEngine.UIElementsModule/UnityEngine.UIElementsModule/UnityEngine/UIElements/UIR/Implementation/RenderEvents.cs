using System;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x02000172 RID: 370
	public static class RenderEvents
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00007ABF File Offset: 0x00005CBF
		public static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00007ACC File Offset: 0x00005CCC
		public static Vector4 GetClipRectIDClipInfo(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00007AD9 File Offset: 0x00005CD9
		public static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00007AE6 File Offset: 0x00005CE6
		public static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00007AF3 File Offset: 0x00005CF3
		public static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00007B00 File Offset: 0x00005D00
		public static bool IsElementHierarchyHidden(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0000E770 File Offset: 0x0000C970
		public static bool IsElementSelfHidden(VisualElement ve)
		{
			return ve.resolvedStyle.visibility == Visibility.Hidden;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00007B0D File Offset: 0x00005D0D
		public static VisualElement GetLastDeepestChild(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00007B1A File Offset: 0x00005D1A
		public static VisualElement GetNextDepthFirst(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00007B27 File Offset: 0x00005D27
		public static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00007B34 File Offset: 0x00005D34
		public static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0000E790 File Offset: 0x0000C990
		public static bool NeedsTransformID(VisualElement ve)
		{
			return (ve.renderHints & RenderHints.GroupTransform) == RenderHints.None && (ve.renderHints & RenderHints.BoneTransform) == RenderHints.BoneTransform;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		public static void CopyTransformVertsPos(NativeSlice<Vertex> source, NativeSlice<Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 idsAddFlags, Color32 opacityPage)
		{
			int length = source.Length;
			for (int i = 0; i < length; i++)
			{
				Vertex vertex = source[i];
				vertex.position = mat.MultiplyPoint3x4(vertex.position);
				vertex.xformClipPages = xformClipPages;
				vertex.idsFlags.r = idsAddFlags.r;
				vertex.idsFlags.g = idsAddFlags.g;
				vertex.idsFlags.b = idsAddFlags.b;
				vertex.idsFlags.a = vertex.idsFlags.a + idsAddFlags.a;
				vertex.opacityPageSVGSettingIndex.r = opacityPage.r;
				vertex.opacityPageSVGSettingIndex.g = opacityPage.g;
				target[i] = vertex;
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0000E890 File Offset: 0x0000CA90
		public static void CopyTransformVertsPosAndVec(NativeSlice<Vertex> source, NativeSlice<Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 idsAddFlags, Color32 opacityPage)
		{
			int length = source.Length;
			Vector3 vector = new Vector3(0f, 0f, 0f);
			for (int i = 0; i < length; i++)
			{
				Vertex vertex = source[i];
				vertex.position = mat.MultiplyPoint3x4(vertex.position);
				vector.x = vertex.uv.x;
				vector.y = vertex.uv.y;
				vertex.uv = mat.MultiplyVector(vector);
				vertex.xformClipPages = xformClipPages;
				vertex.idsFlags.r = idsAddFlags.r;
				vertex.idsFlags.g = idsAddFlags.g;
				vertex.idsFlags.b = idsAddFlags.b;
				vertex.idsFlags.a = vertex.idsFlags.a + idsAddFlags.a;
				vertex.opacityPageSVGSettingIndex.r = opacityPage.r;
				vertex.opacityPageSVGSettingIndex.g = opacityPage.g;
				target[i] = vertex;
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0000E9B4 File Offset: 0x0000CBB4
		public static void CopyTriangleIndicesFlipWindingOrder(NativeSlice<ushort> source, NativeSlice<ushort> target)
		{
			Debug.Assert(source != target);
			int length = source.Length;
			for (int i = 0; i < length; i += 3)
			{
				ushort num = source[i];
				target[i] = source[i + 1];
				target[i + 1] = num;
				target[i + 2] = source[i + 2];
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0000EA28 File Offset: 0x0000CC28
		public static void CopyTriangleIndicesFlipWindingOrder(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset)
		{
			Debug.Assert(source != target);
			int length = source.Length;
			for (int i = 0; i < length; i += 3)
			{
				ushort num = (ushort)((int)source[i] + indexOffset);
				target[i] = (ushort)((int)source[i + 1] + indexOffset);
				target[i + 1] = num;
				target[i + 2] = (ushort)((int)source[i + 2] + indexOffset);
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0000EAA4 File Offset: 0x0000CCA4
		public static void CopyTriangleIndices(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset)
		{
			int length = source.Length;
			for (int i = 0; i < length; i++)
			{
				target[i] = (ushort)((int)source[i] + indexOffset);
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00007B41 File Offset: 0x00005D41
		public static bool NudgeVerticesToNewSpace(VisualElement ve, UIRenderDevice device)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00007B4E File Offset: 0x00005D4E
		public static void DoNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, ref Matrix4x4 nudgeTransform, bool isClosingMesh)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00007B5B File Offset: 0x00005D5B
		public static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, Texture custom, Texture font)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00007B68 File Offset: 0x00005D68
		public static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, Texture custom, Texture font)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00007B75 File Offset: 0x00005D75
		public static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00007B82 File Offset: 0x00005D82
		public static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00007B8F File Offset: 0x00005D8F
		public static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00007B9C File Offset: 0x00005D9C
		public static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00007BA9 File Offset: 0x00005DA9
		public static void ResetCommands(RenderChain renderChain, VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
