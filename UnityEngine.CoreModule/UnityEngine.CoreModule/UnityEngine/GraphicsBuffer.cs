using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x02000211 RID: 529
	public sealed class GraphicsBuffer
	{
		// Token: 0x060020E8 RID: 8424 RVA: 0x00075548 File Offset: 0x00073748
		public ~GraphicsBuffer()
		{
			this.Dispose(false);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x0001138D File Offset: 0x0000F58D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0001139F File Offset: 0x0000F59F
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0007557C File Offset: 0x0007377C
		public static bool RequiresCompute(GraphicsBuffer.Target target)
		{
			int num = 3;
			return (target & (GraphicsBuffer.Target)num) != target;
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x000113AC File Offset: 0x0000F5AC
		public static IntPtr InitBuffer(GraphicsBuffer.Target target, int count, int stride)
		{
			return GraphicsBuffer.InitBufferDelegateField(target, count, stride);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x000113BB File Offset: 0x0000F5BB
		public static void DestroyBuffer(GraphicsBuffer buf)
		{
			GraphicsBuffer.DestroyBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buf));
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000113CD File Offset: 0x0000F5CD
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000113D7 File Offset: 0x0000F5D7
		public bool IsValid()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x000113E4 File Offset: 0x0000F5E4
		public int count
		{
			get
			{
				return GraphicsBuffer.get_countDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x000113F6 File Offset: 0x0000F5F6
		public int stride
		{
			get
			{
				return GraphicsBuffer.get_strideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0007559C File Offset: 0x0007379C
		public void SetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalSetData(data, 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00075604 File Offset: 0x00073804
		public void SetData<T>(List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00011408 File Offset: 0x0000F608
		public void SetData<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00075678 File Offset: 0x00073878
		public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetData(data, managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x0007571C File Offset: 0x0007391C
		public void SetData<T>(List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000757CC File Offset: 0x000739CC
		public void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = nativeBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || nativeBufferStartIndex + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (nativeBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", nativeBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), nativeBufferStartIndex, graphicsBufferStartIndex, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x0001142B File Offset: 0x0000F62B
		public void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalSetNativeDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, nativeBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00011444 File Offset: 0x0000F644
		public void InternalSetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalSetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x0007583C File Offset: 0x00073A3C
		public void GetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000758A4 File Offset: 0x00073AA4
		public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00011462 File Offset: 0x0000F662
		public void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalGetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00011480 File Offset: 0x0000F680
		public IntPtr GetNativeBufferPtr()
		{
			return GraphicsBuffer.GetNativeBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00011492 File Offset: 0x0000F692
		public void SetName(string name)
		{
			GraphicsBuffer.SetNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000114AA File Offset: 0x0000F6AA
		public void SetCounterValue(uint counterValue)
		{
			GraphicsBuffer.SetCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), counterValue);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000114BD File Offset: 0x0000F6BD
		public static void CopyCountCC(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCCDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000114D6 File Offset: 0x0000F6D6
		public static void CopyCountGC(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGCDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000114EF File Offset: 0x0000F6EF
		public static void CopyCountCG(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00011508 File Offset: 0x0000F708
		public static void CopyCountGG(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00011521 File Offset: 0x0000F721
		public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x0001152D File Offset: 0x0000F72D
		public static void CopyCount(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00011539 File Offset: 0x0000F739
		public static void CopyCount(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCG(src, dst, dstOffsetBytes);
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00011545 File Offset: 0x0000F745
		public static void CopyCount(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGG(src, dst, dstOffsetBytes);
		}

		// Token: 0x04001AC5 RID: 6853
		private static readonly GraphicsBuffer.InitBufferDelegate InitBufferDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InitBufferDelegate>("UnityEngine.GraphicsBuffer::InitBuffer");

		// Token: 0x04001AC6 RID: 6854
		private static readonly GraphicsBuffer.DestroyBufferDelegate DestroyBufferDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.DestroyBufferDelegate>("UnityEngine.GraphicsBuffer::DestroyBuffer");

		// Token: 0x04001AC7 RID: 6855
		private static readonly GraphicsBuffer.get_countDelegate get_countDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_countDelegate>("UnityEngine.GraphicsBuffer::get_count");

		// Token: 0x04001AC8 RID: 6856
		private static readonly GraphicsBuffer.get_strideDelegate get_strideDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_strideDelegate>("UnityEngine.GraphicsBuffer::get_stride");

		// Token: 0x04001AC9 RID: 6857
		private static readonly GraphicsBuffer.InternalSetNativeDataDelegate InternalSetNativeDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalSetNativeDataDelegate>("UnityEngine.GraphicsBuffer::InternalSetNativeData");

		// Token: 0x04001ACA RID: 6858
		private static readonly GraphicsBuffer.InternalSetDataDelegate InternalSetDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalSetDataDelegate>("UnityEngine.GraphicsBuffer::InternalSetData");

		// Token: 0x04001ACB RID: 6859
		private static readonly GraphicsBuffer.InternalGetDataDelegate InternalGetDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalGetDataDelegate>("UnityEngine.GraphicsBuffer::InternalGetData");

		// Token: 0x04001ACC RID: 6860
		private static readonly GraphicsBuffer.GetNativeBufferPtrDelegate GetNativeBufferPtrDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.GetNativeBufferPtrDelegate>("UnityEngine.GraphicsBuffer::GetNativeBufferPtr");

		// Token: 0x04001ACD RID: 6861
		private static readonly GraphicsBuffer.SetNameDelegate SetNameDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.SetNameDelegate>("UnityEngine.GraphicsBuffer::SetName");

		// Token: 0x04001ACE RID: 6862
		private static readonly GraphicsBuffer.SetCounterValueDelegate SetCounterValueDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.SetCounterValueDelegate>("UnityEngine.GraphicsBuffer::SetCounterValue");

		// Token: 0x04001ACF RID: 6863
		private static readonly GraphicsBuffer.CopyCountCCDelegate CopyCountCCDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCCDelegate>("UnityEngine.GraphicsBuffer::CopyCountCC");

		// Token: 0x04001AD0 RID: 6864
		private static readonly GraphicsBuffer.CopyCountGCDelegate CopyCountGCDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGCDelegate>("UnityEngine.GraphicsBuffer::CopyCountGC");

		// Token: 0x04001AD1 RID: 6865
		private static readonly GraphicsBuffer.CopyCountCGDelegate CopyCountCGDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCGDelegate>("UnityEngine.GraphicsBuffer::CopyCountCG");

		// Token: 0x04001AD2 RID: 6866
		private static readonly GraphicsBuffer.CopyCountGGDelegate CopyCountGGDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGGDelegate>("UnityEngine.GraphicsBuffer::CopyCountGG");

		// Token: 0x02000B14 RID: 2836
		public enum Target
		{
			// Token: 0x0400204E RID: 8270
			Vertex = 1,
			// Token: 0x0400204F RID: 8271
			Index,
			// Token: 0x04002050 RID: 8272
			Structured = 16,
			// Token: 0x04002051 RID: 8273
			Raw = 32,
			// Token: 0x04002052 RID: 8274
			Append = 64,
			// Token: 0x04002053 RID: 8275
			Counter = 128,
			// Token: 0x04002054 RID: 8276
			IndirectArguments = 256,
			// Token: 0x04002055 RID: 8277
			Constant = 512
		}

		// Token: 0x02000B15 RID: 2837
		// (Invoke) Token: 0x0600348A RID: 13450
		private delegate IntPtr InitBufferDelegate(GraphicsBuffer.Target target, int count, int stride);

		// Token: 0x02000B16 RID: 2838
		// (Invoke) Token: 0x0600348C RID: 13452
		private delegate void DestroyBufferDelegate(IntPtr buf);

		// Token: 0x02000B17 RID: 2839
		// (Invoke) Token: 0x0600348E RID: 13454
		private delegate int get_countDelegate(IntPtr @this);

		// Token: 0x02000B18 RID: 2840
		// (Invoke) Token: 0x06003490 RID: 13456
		private delegate int get_strideDelegate(IntPtr @this);

		// Token: 0x02000B19 RID: 2841
		// (Invoke) Token: 0x06003492 RID: 13458
		private delegate void InternalSetNativeDataDelegate(IntPtr @this, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x02000B1A RID: 2842
		// (Invoke) Token: 0x06003494 RID: 13460
		private delegate void InternalSetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x02000B1B RID: 2843
		// (Invoke) Token: 0x06003496 RID: 13462
		private delegate void InternalGetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x02000B1C RID: 2844
		// (Invoke) Token: 0x06003498 RID: 13464
		private delegate IntPtr GetNativeBufferPtrDelegate(IntPtr @this);

		// Token: 0x02000B1D RID: 2845
		// (Invoke) Token: 0x0600349A RID: 13466
		private delegate void SetNameDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000B1E RID: 2846
		// (Invoke) Token: 0x0600349C RID: 13468
		private delegate void SetCounterValueDelegate(IntPtr @this, uint counterValue);

		// Token: 0x02000B1F RID: 2847
		// (Invoke) Token: 0x0600349E RID: 13470
		private delegate void CopyCountCCDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000B20 RID: 2848
		// (Invoke) Token: 0x060034A0 RID: 13472
		private delegate void CopyCountGCDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000B21 RID: 2849
		// (Invoke) Token: 0x060034A2 RID: 13474
		private delegate void CopyCountCGDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000B22 RID: 2850
		// (Invoke) Token: 0x060034A4 RID: 13476
		private delegate void CopyCountGGDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);
	}
}
