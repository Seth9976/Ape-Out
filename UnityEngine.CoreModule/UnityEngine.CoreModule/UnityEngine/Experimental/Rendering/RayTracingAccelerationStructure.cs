using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002D8 RID: 728
	public sealed class RayTracingAccelerationStructure
	{
		// Token: 0x06002311 RID: 8977 RVA: 0x00078B30 File Offset: 0x00076D30
		public ~RayTracingAccelerationStructure()
		{
			this.Dispose(false);
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x00012C6B File Offset: 0x00010E6B
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00012C7D File Offset: 0x00010E7D
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00012C8A File Offset: 0x00010E8A
		public static void Destroy(RayTracingAccelerationStructure accelStruct)
		{
			RayTracingAccelerationStructure.DestroyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(accelStruct));
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00012C9C File Offset: 0x00010E9C
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00012CA6 File Offset: 0x00010EA6
		public void Build()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00012CB5 File Offset: 0x00010EB5
		public void Update()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00012CC4 File Offset: 0x00010EC4
		public void Build(Vector3 relativeOrigin)
		{
			this.Build_Injected(ref relativeOrigin);
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00012CCE File Offset: 0x00010ECE
		public void Update(Vector3 relativeOrigin)
		{
			this.Update_Injected(ref relativeOrigin);
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00012CD8 File Offset: 0x00010ED8
		public void AddInstance(Renderer targetRenderer, [Optional] Il2CppStructArray<bool> subMeshMask, [Optional] Il2CppStructArray<bool> subMeshTransparencyFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask)
		{
			RayTracingAccelerationStructure.AddInstanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(subMeshMask), IL2CPP.Il2CppObjectBaseToPtr(subMeshTransparencyFlags), enableTriangleCulling, frontTriangleCounterClockwise, mask);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00078B64 File Offset: 0x00076D64
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds)
		{
			this.AddInstance_Procedural(aabbBuffer, numElements, material, Matrix4x4.identity, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00078B8C File Offset: 0x00076D8C
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds)
		{
			this.AddInstance_Procedural(aabbBuffer, numElements, material, instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00078BB0 File Offset: 0x00076DB0
		public void AddInstance_Procedural(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds)
		{
			this.AddInstance_Procedural_Injected(aabbBuffer, numElements, material, ref instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00012D02 File Offset: 0x00010F02
		public void UpdateInstanceTransform(Renderer renderer)
		{
			RayTracingAccelerationStructure.UpdateInstanceTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00012D1A File Offset: 0x00010F1A
		public ulong GetSize()
		{
			return RayTracingAccelerationStructure.GetSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00012D2C File Offset: 0x00010F2C
		public void Build_Injected(ref Vector3 relativeOrigin)
		{
			RayTracingAccelerationStructure.Build_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeOrigin);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00012D3F File Offset: 0x00010F3F
		public void Update_Injected(ref Vector3 relativeOrigin)
		{
			RayTracingAccelerationStructure.Update_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeOrigin);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00078BD4 File Offset: 0x00076DD4
		public void AddInstance_Procedural_Injected(GraphicsBuffer aabbBuffer, uint numElements, Material material, ref Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds)
		{
			RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(aabbBuffer), numElements, IL2CPP.Il2CppObjectBaseToPtr(material), ref instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds);
		}

		// Token: 0x04001E29 RID: 7721
		private static readonly RayTracingAccelerationStructure.DestroyDelegate DestroyDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.DestroyDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Destroy");

		// Token: 0x04001E2A RID: 7722
		private static readonly RayTracingAccelerationStructure.AddInstanceDelegate AddInstanceDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstanceDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance");

		// Token: 0x04001E2B RID: 7723
		private static readonly RayTracingAccelerationStructure.UpdateInstanceTransformDelegate UpdateInstanceTransformDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceTransformDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform");

		// Token: 0x04001E2C RID: 7724
		private static readonly RayTracingAccelerationStructure.GetSizeDelegate GetSizeDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.GetSizeDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::GetSize");

		// Token: 0x04001E2D RID: 7725
		private static readonly RayTracingAccelerationStructure.Build_InjectedDelegate Build_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.Build_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Build_Injected");

		// Token: 0x04001E2E RID: 7726
		private static readonly RayTracingAccelerationStructure.Update_InjectedDelegate Update_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.Update_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Update_Injected");

		// Token: 0x04001E2F RID: 7727
		private static readonly RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegate AddInstance_Procedural_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance_Procedural_Injected");

		// Token: 0x02000C14 RID: 3092
		public enum RayTracingModeMask
		{
			// Token: 0x0400205E RID: 8286
			Nothing,
			// Token: 0x0400205F RID: 8287
			Static = 2,
			// Token: 0x04002060 RID: 8288
			DynamicTransform = 4,
			// Token: 0x04002061 RID: 8289
			DynamicGeometry = 8,
			// Token: 0x04002062 RID: 8290
			Everything = 14
		}

		// Token: 0x02000C15 RID: 3093
		public enum ManagementMode
		{
			// Token: 0x04002064 RID: 8292
			Manual,
			// Token: 0x04002065 RID: 8293
			Automatic
		}

		// Token: 0x02000C16 RID: 3094
		// (Invoke) Token: 0x0600367E RID: 13950
		private delegate void DestroyDelegate(IntPtr accelStruct);

		// Token: 0x02000C17 RID: 3095
		// (Invoke) Token: 0x06003680 RID: 13952
		private delegate void AddInstanceDelegate(IntPtr @this, IntPtr targetRenderer, IntPtr subMeshMask, IntPtr subMeshTransparencyFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask);

		// Token: 0x02000C18 RID: 3096
		// (Invoke) Token: 0x06003682 RID: 13954
		private delegate void UpdateInstanceTransformDelegate(IntPtr @this, IntPtr renderer);

		// Token: 0x02000C19 RID: 3097
		// (Invoke) Token: 0x06003684 RID: 13956
		private delegate ulong GetSizeDelegate(IntPtr @this);

		// Token: 0x02000C1A RID: 3098
		// (Invoke) Token: 0x06003686 RID: 13958
		private delegate void Build_InjectedDelegate(IntPtr @this, IntPtr relativeOrigin);

		// Token: 0x02000C1B RID: 3099
		// (Invoke) Token: 0x06003688 RID: 13960
		private delegate void Update_InjectedDelegate(IntPtr @this, IntPtr relativeOrigin);

		// Token: 0x02000C1C RID: 3100
		// (Invoke) Token: 0x0600368A RID: 13962
		private delegate void AddInstance_Procedural_InjectedDelegate(IntPtr @this, IntPtr aabbBuffer, uint numElements, IntPtr material, IntPtr instanceTransform, bool isCutOff, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, bool reuseBounds);
	}
}
