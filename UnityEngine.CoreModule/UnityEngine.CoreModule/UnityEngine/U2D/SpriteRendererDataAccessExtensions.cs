using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D
{
	// Token: 0x02000272 RID: 626
	public static class SpriteRendererDataAccessExtensions
	{
		// Token: 0x06002227 RID: 8743 RVA: 0x00077A00 File Offset: 0x00075C00
		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<byte> src)
		{
			bool flag = spriteRenderer.sprite == null;
			if (flag)
			{
				throw new ArgumentException(String.Format("spriteRenderer does not have a valid sprite set.", new Il2CppReferenceArray<Object>(0L)));
			}
			bool flag2 = src.Length != SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite);
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("custom sprite vertex data size must match sprite asset's vertex data size {0} {1}", src.Length, SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite)));
			}
			SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<byte>(), src.Length);
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00077A90 File Offset: 0x00075C90
		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<Vector3> src)
		{
			bool flag = spriteRenderer.sprite == null;
			if (flag)
			{
				throw new InvalidOperationException("spriteRenderer does not have a valid sprite set.");
			}
			bool flag2 = src.Length != SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite);
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("The src length {0} must match the vertex count of source Sprite {1}.", src.Length, SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite)));
			}
			SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<Vector3>(), src.Length);
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00077B14 File Offset: 0x00075D14
		public static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, Unity.Collections.NativeArray<IntPtr> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<Bounds> bounds)
		{
			int num = spriteRenderers.Length;
			bool flag = num != buffers.Length || num != bufferSizes.Length || num != bounds.Length;
			if (flag)
			{
				throw new ArgumentException("Input array sizes are not the same.");
			}
			SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArray(spriteRenderers, buffers.GetUnsafeReadOnlyPtr<IntPtr>(), bufferSizes.GetUnsafeReadOnlyPtr<int>(), bounds.GetUnsafeReadOnlyPtr<Bounds>(), num);
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00077B78 File Offset: 0x00075D78
		public unsafe static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, IntPtr buffer)
		{
			return SpriteRendererDataAccessExtensions.IsUsingDeformableBuffer(spriteRenderer, (void*)buffer);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00012257 File Offset: 0x00010457
		public static void DeactivateDeformableBuffer(SpriteRenderer renderer)
		{
			SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x00012269 File Offset: 0x00010469
		public static void SetLocalAABB(SpriteRenderer renderer, Bounds aabb)
		{
			SpriteRendererDataAccessExtensions.SetLocalAABB_Injected(renderer, ref aabb);
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x00012273 File Offset: 0x00010473
		public unsafe static void SetDeformableBuffer(SpriteRenderer spriteRenderer, void* src, int count)
		{
			SpriteRendererDataAccessExtensions.SetDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer), src, count);
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00012287 File Offset: 0x00010487
		public unsafe static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, void* buffers, void* bufferSizes, void* bounds, int count)
		{
			SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderers), buffers, bufferSizes, bounds, count);
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0001229E File Offset: 0x0001049E
		public unsafe static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, void* buffer)
		{
			return SpriteRendererDataAccessExtensions.IsUsingDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer), buffer);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x000122B1 File Offset: 0x000104B1
		public static void SetLocalAABB_Injected(SpriteRenderer renderer, ref Bounds aabb)
		{
			SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer), ref aabb);
		}

		// Token: 0x04001C36 RID: 7222
		private static readonly SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegate DeactivateDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::DeactivateDeformableBuffer");

		// Token: 0x04001C37 RID: 7223
		private static readonly SpriteRendererDataAccessExtensions.SetDeformableBufferDelegate SetDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetDeformableBuffer");

		// Token: 0x04001C38 RID: 7224
		private static readonly SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate SetBatchDeformableBufferAndLocalAABBArrayDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetBatchDeformableBufferAndLocalAABBArray");

		// Token: 0x04001C39 RID: 7225
		private static readonly SpriteRendererDataAccessExtensions.IsUsingDeformableBufferDelegate IsUsingDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.IsUsingDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::IsUsingDeformableBuffer");

		// Token: 0x04001C3A RID: 7226
		private static readonly SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate SetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetLocalAABB_Injected");

		// Token: 0x02000BAA RID: 2986
		// (Invoke) Token: 0x060035AE RID: 13742
		private delegate void DeactivateDeformableBufferDelegate(IntPtr renderer);

		// Token: 0x02000BAB RID: 2987
		// (Invoke) Token: 0x060035B0 RID: 13744
		private delegate void SetDeformableBufferDelegate(IntPtr spriteRenderer, IntPtr src, int count);

		// Token: 0x02000BAC RID: 2988
		// (Invoke) Token: 0x060035B2 RID: 13746
		private delegate void SetBatchDeformableBufferAndLocalAABBArrayDelegate(IntPtr spriteRenderers, IntPtr buffers, IntPtr bufferSizes, IntPtr bounds, int count);

		// Token: 0x02000BAD RID: 2989
		// (Invoke) Token: 0x060035B4 RID: 13748
		private delegate bool IsUsingDeformableBufferDelegate(IntPtr spriteRenderer, IntPtr buffer);

		// Token: 0x02000BAE RID: 2990
		// (Invoke) Token: 0x060035B6 RID: 13750
		private delegate void SetLocalAABB_InjectedDelegate(IntPtr renderer, IntPtr aabb);
	}
}
