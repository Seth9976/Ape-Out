using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering;

namespace UnityEngine.U2D
{
	// Token: 0x02000271 RID: 625
	public static class SpriteDataAccessExtensions
	{
		// Token: 0x06002214 RID: 8724 RVA: 0x00012134 File Offset: 0x00010334
		public static void CheckAttributeTypeMatchesAndThrow<T>(UnityEngine.Rendering.VertexAttribute channel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x00012141 File Offset: 0x00010341
		public static Unity.Collections.NativeSlice<T> GetVertexAttribute<T>(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0001214E File Offset: 0x0001034E
		public static void SetVertexAttribute<T>(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, Unity.Collections.NativeArray<T> src) where T : struct
		{
			SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<T>(channel);
			SpriteDataAccessExtensions.SetChannelData(sprite, channel, src.GetUnsafeReadOnlyPtr<T>());
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00012166 File Offset: 0x00010366
		public static Unity.Collections.NativeArray<Matrix4x4> GetBindPoses(Sprite sprite)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x00012173 File Offset: 0x00010373
		public static void SetBindPoses(Sprite sprite, Unity.Collections.NativeArray<Matrix4x4> src)
		{
			SpriteDataAccessExtensions.SetBindPoseData(sprite, src.GetUnsafeReadOnlyPtr<Matrix4x4>(), src.Length);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0001218A File Offset: 0x0001038A
		public static Unity.Collections.NativeArray<ushort> GetIndices(Sprite sprite)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00012197 File Offset: 0x00010397
		public static void SetIndices(Sprite sprite, Unity.Collections.NativeArray<ushort> src)
		{
			SpriteDataAccessExtensions.SetIndicesData(sprite, src.GetUnsafeReadOnlyPtr<ushort>(), src.Length);
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00077964 File Offset: 0x00075B64
		public static Il2CppReferenceArray<SpriteBone> GetBones(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetBoneInfo(sprite);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x000121AE File Offset: 0x000103AE
		public static void SetBones(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
		{
			SpriteDataAccessExtensions.SetBoneData(sprite, src);
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x000121B9 File Offset: 0x000103B9
		public static bool HasVertexAttribute(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel)
		{
			return SpriteDataAccessExtensions.HasVertexAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), channel);
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x000121CC File Offset: 0x000103CC
		public static void SetVertexCount(Sprite sprite, int count)
		{
			SpriteDataAccessExtensions.SetVertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), count);
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x000121DF File Offset: 0x000103DF
		public static int GetVertexCount(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetVertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x000121F1 File Offset: 0x000103F1
		public unsafe static void SetBindPoseData(Sprite sprite, void* src, int count)
		{
			SpriteDataAccessExtensions.SetBindPoseDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), src, count);
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00012205 File Offset: 0x00010405
		public unsafe static void SetIndicesData(Sprite sprite, void* src, int count)
		{
			SpriteDataAccessExtensions.SetIndicesDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), src, count);
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00012219 File Offset: 0x00010419
		public unsafe static void SetChannelData(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, void* src)
		{
			SpriteDataAccessExtensions.SetChannelDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), channel, src);
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0007797C File Offset: 0x00075B7C
		public static Il2CppReferenceArray<SpriteBone> GetBoneInfo(Sprite sprite)
		{
			IntPtr intPtr = SpriteDataAccessExtensions.GetBoneInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteBone>>(intPtr2) : null;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0001222D File Offset: 0x0001042D
		public static void SetBoneData(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
		{
			SpriteDataAccessExtensions.SetBoneDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), IL2CPP.Il2CppObjectBaseToPtr(src));
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x00012245 File Offset: 0x00010445
		public static int GetPrimaryVertexStreamSize(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
		}

		// Token: 0x04001C2D RID: 7213
		private static readonly SpriteDataAccessExtensions.HasVertexAttributeDelegate HasVertexAttributeDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.HasVertexAttributeDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::HasVertexAttribute");

		// Token: 0x04001C2E RID: 7214
		private static readonly SpriteDataAccessExtensions.SetVertexCountDelegate SetVertexCountDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetVertexCountDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetVertexCount");

		// Token: 0x04001C2F RID: 7215
		private static readonly SpriteDataAccessExtensions.GetVertexCountDelegate GetVertexCountDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetVertexCountDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetVertexCount");

		// Token: 0x04001C30 RID: 7216
		private static readonly SpriteDataAccessExtensions.SetBindPoseDataDelegate SetBindPoseDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBindPoseDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBindPoseData");

		// Token: 0x04001C31 RID: 7217
		private static readonly SpriteDataAccessExtensions.SetIndicesDataDelegate SetIndicesDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetIndicesDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetIndicesData");

		// Token: 0x04001C32 RID: 7218
		private static readonly SpriteDataAccessExtensions.SetChannelDataDelegate SetChannelDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetChannelDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetChannelData");

		// Token: 0x04001C33 RID: 7219
		private static readonly SpriteDataAccessExtensions.GetBoneInfoDelegate GetBoneInfoDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetBoneInfoDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetBoneInfo");

		// Token: 0x04001C34 RID: 7220
		private static readonly SpriteDataAccessExtensions.SetBoneDataDelegate SetBoneDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBoneDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBoneData");

		// Token: 0x04001C35 RID: 7221
		private static readonly SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegate GetPrimaryVertexStreamSizeDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetPrimaryVertexStreamSize");

		// Token: 0x02000BA1 RID: 2977
		// (Invoke) Token: 0x0600359C RID: 13724
		private delegate bool HasVertexAttributeDelegate(IntPtr sprite, UnityEngine.Rendering.VertexAttribute channel);

		// Token: 0x02000BA2 RID: 2978
		// (Invoke) Token: 0x0600359E RID: 13726
		private delegate void SetVertexCountDelegate(IntPtr sprite, int count);

		// Token: 0x02000BA3 RID: 2979
		// (Invoke) Token: 0x060035A0 RID: 13728
		private delegate int GetVertexCountDelegate(IntPtr sprite);

		// Token: 0x02000BA4 RID: 2980
		// (Invoke) Token: 0x060035A2 RID: 13730
		private delegate void SetBindPoseDataDelegate(IntPtr sprite, IntPtr src, int count);

		// Token: 0x02000BA5 RID: 2981
		// (Invoke) Token: 0x060035A4 RID: 13732
		private delegate void SetIndicesDataDelegate(IntPtr sprite, IntPtr src, int count);

		// Token: 0x02000BA6 RID: 2982
		// (Invoke) Token: 0x060035A6 RID: 13734
		private delegate void SetChannelDataDelegate(IntPtr sprite, UnityEngine.Rendering.VertexAttribute channel, IntPtr src);

		// Token: 0x02000BA7 RID: 2983
		// (Invoke) Token: 0x060035A8 RID: 13736
		private delegate IntPtr GetBoneInfoDelegate(IntPtr sprite);

		// Token: 0x02000BA8 RID: 2984
		// (Invoke) Token: 0x060035AA RID: 13738
		private delegate void SetBoneDataDelegate(IntPtr sprite, IntPtr src);

		// Token: 0x02000BA9 RID: 2985
		// (Invoke) Token: 0x060035AC RID: 13740
		private delegate int GetPrimaryVertexStreamSizeDelegate(IntPtr sprite);
	}
}
