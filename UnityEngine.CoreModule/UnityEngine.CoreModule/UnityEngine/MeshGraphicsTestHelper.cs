using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000239 RID: 569
	public struct MeshGraphicsTestHelper
	{
		// Token: 0x0600216F RID: 8559 RVA: 0x00011B8B File Offset: 0x0000FD8B
		public static void InternalEnableComputeBufferBindings(Mesh mesh)
		{
			MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh));
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00011B9D File Offset: 0x0000FD9D
		public static void InternalEnableComputeBufferBindingsSkinned(SkinnedMeshRenderer mesh)
		{
			MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsSkinnedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh));
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00011BAF File Offset: 0x0000FDAF
		public static bool InternalAssignComputeBuffer(Mesh mesh, ComputeShader shader, int kernelIndex, int iboTargetID, int vboTargetID)
		{
			return MeshGraphicsTestHelper.InternalAssignComputeBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(shader), kernelIndex, iboTargetID, vboTargetID);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00011BCB File Offset: 0x0000FDCB
		public static bool InternalAssignComputeBufferSkinned(SkinnedMeshRenderer mesh, ComputeShader shader, int kernelIndex, int vboTargetID)
		{
			return MeshGraphicsTestHelper.InternalAssignComputeBufferSkinnedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(shader), kernelIndex, vboTargetID);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00076018 File Offset: 0x00074218
		public static bool InternalSetChannelInfo(Mesh mesh, ComputeShader shader, int kernelIndex, int vertexStrideID, int positionOffsetID, int normalOffsetID, int uvOffsetID, int colorOffsetID)
		{
			return MeshGraphicsTestHelper.InternalSetChannelInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(shader), kernelIndex, vertexStrideID, positionOffsetID, normalOffsetID, uvOffsetID, colorOffsetID);
		}

		// Token: 0x04001B94 RID: 7060
		private static readonly MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsDelegate InternalEnableComputeBufferBindingsDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalEnableComputeBufferBindings");

		// Token: 0x04001B95 RID: 7061
		private static readonly MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsSkinnedDelegate InternalEnableComputeBufferBindingsSkinnedDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsSkinnedDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalEnableComputeBufferBindingsSkinned");

		// Token: 0x04001B96 RID: 7062
		private static readonly MeshGraphicsTestHelper.InternalAssignComputeBufferDelegate InternalAssignComputeBufferDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalAssignComputeBufferDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalAssignComputeBuffer");

		// Token: 0x04001B97 RID: 7063
		private static readonly MeshGraphicsTestHelper.InternalAssignComputeBufferSkinnedDelegate InternalAssignComputeBufferSkinnedDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalAssignComputeBufferSkinnedDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalAssignComputeBufferSkinned");

		// Token: 0x04001B98 RID: 7064
		private static readonly MeshGraphicsTestHelper.InternalSetChannelInfoDelegate InternalSetChannelInfoDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalSetChannelInfoDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalSetChannelInfo");

		// Token: 0x02000B6C RID: 2924
		// (Invoke) Token: 0x06003538 RID: 13624
		private delegate void InternalEnableComputeBufferBindingsDelegate(IntPtr mesh);

		// Token: 0x02000B6D RID: 2925
		// (Invoke) Token: 0x0600353A RID: 13626
		private delegate void InternalEnableComputeBufferBindingsSkinnedDelegate(IntPtr mesh);

		// Token: 0x02000B6E RID: 2926
		// (Invoke) Token: 0x0600353C RID: 13628
		private delegate bool InternalAssignComputeBufferDelegate(IntPtr mesh, IntPtr shader, int kernelIndex, int iboTargetID, int vboTargetID);

		// Token: 0x02000B6F RID: 2927
		// (Invoke) Token: 0x0600353E RID: 13630
		private delegate bool InternalAssignComputeBufferSkinnedDelegate(IntPtr mesh, IntPtr shader, int kernelIndex, int vboTargetID);

		// Token: 0x02000B70 RID: 2928
		// (Invoke) Token: 0x06003540 RID: 13632
		private delegate bool InternalSetChannelInfoDelegate(IntPtr mesh, IntPtr shader, int kernelIndex, int vertexStrideID, int positionOffsetID, int normalOffsetID, int uvOffsetID, int colorOffsetID);
	}
}
