using System;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000166 RID: 358
	public class UIRenderDevice
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0000786E File Offset: 0x00005A6E
		public uint maxVerticesPerPage
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0000787B File Offset: 0x00005A7B
		public static Texture2D defaultShaderInfoTexFloat
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00007888 File Offset: 0x00005A88
		public static Texture2D defaultShaderInfoTexARGB8
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00007895 File Offset: 0x00005A95
		public static bool vertexTexturingIsAvailable
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x000078A2 File Offset: 0x00005AA2
		public void InitVertexDeclaration()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000078AF File Offset: 0x00005AAF
		public void CompleteCreation()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x000078BC File Offset: 0x00005ABC
		public bool fullyCreated
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x000078C9 File Offset: 0x00005AC9
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x000078D6 File Offset: 0x00005AD6
		public bool disposed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000078E3 File Offset: 0x00005AE3
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000078F5 File Offset: 0x00005AF5
		public void DisposeImmediate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00007902 File Offset: 0x00005B02
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0000790F File Offset: 0x00005B0F
		public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0000791C File Offset: 0x00005B1C
		public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex> vertexData)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00007929 File Offset: 0x00005B29
		public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00007936 File Offset: 0x00005B36
		public void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00007943 File Offset: 0x00005B43
		public void Free(MeshHandle mesh)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00007950 File Offset: 0x00005B50
		public static void Set1PixelSizeParameter(DrawParams drawParams, MaterialPropertyBlock props)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0000795D File Offset: 0x00005B5D
		public void OnFrameRenderingBegin()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0000E544 File Offset: 0x0000C744
		public unsafe static NativeSlice<T> PtrToSlice<T>(void* p, int count) where T : struct
		{
			return NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<T>(p, UnsafeUtility.SizeOf<T>(), count);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0000796A File Offset: 0x00005B6A
		public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture atlas, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00007977 File Offset: 0x00005B77
		public void UpdateFenceValue()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00007984 File Offset: 0x00005B84
		public void WaitOnAllCpuFences()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0000E564 File Offset: 0x0000C764
		public void WaitOnCpuFence(uint fence)
		{
			bool flag = fence != 0U && !Utility.CPUFencePassed(fence);
			if (flag)
			{
				Utility.WaitForCPUFencePassed(fence);
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00007991 File Offset: 0x00005B91
		public void AdvanceFrame()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0000799E File Offset: 0x00005B9E
		public void PruneUnusedPages()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000079AB File Offset: 0x00005BAB
		public static void PrepareForGfxDeviceRecreate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000079B8 File Offset: 0x00005BB8
		public static void WrapUpGfxDeviceRecreate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000079C5 File Offset: 0x00005BC5
		public static void FlushAllPendingDeviceDisposes()
		{
			Utility.SyncRenderThread();
			UIRenderDevice.ProcessDeviceFreeQueue();
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000079D4 File Offset: 0x00005BD4
		public static void ProcessDeviceFreeQueue()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000079E1 File Offset: 0x00005BE1
		public static void OnEngineUpdateGlobal()
		{
			UIRenderDevice.ProcessDeviceFreeQueue();
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000079EA File Offset: 0x00005BEA
		public static void OnFlushPendingResources()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000169 RID: 361
		public const uint k_MaxQueuedFrameCount = 4U;

		// Token: 0x0400016A RID: 362
		public const int k_PruneEmptyPageFrameCount = 60;

		// Token: 0x0400016B RID: 363
		public const string k_VertexTexturingIsAvailableTag = "UIE_VertexTexturingIsAvailable";

		// Token: 0x0400016C RID: 364
		public const string k_VertexTexturingIsAvailableTrue = "1";
	}
}
