using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000048 RID: 72
	public class HumanPoseHandler
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x00004B97 File Offset: 0x00002D97
		public static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root)
		{
			return HumanPoseHandler.Internal_CreateFromRootDelegateField(IL2CPP.Il2CppObjectBaseToPtr(avatar), IL2CPP.Il2CppObjectBaseToPtr(root));
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00004BAF File Offset: 0x00002DAF
		public static IntPtr Internal_CreateFromJointPaths(Avatar avatar, Il2CppStringArray jointPaths)
		{
			return HumanPoseHandler.Internal_CreateFromJointPathsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(avatar), IL2CPP.Il2CppObjectBaseToPtr(jointPaths));
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00004BC7 File Offset: 0x00002DC7
		public static void Internal_Destroy(IntPtr ptr)
		{
			HumanPoseHandler.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.GetHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out bodyPosition, out bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00004BEE File Offset: 0x00002DEE
		public void SetHumanPose(ref Vector3 bodyPosition, ref Quaternion bodyRotation, Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.SetHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref bodyPosition, ref bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00004C08 File Offset: 0x00002E08
		public void GetInternalHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.GetInternalHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out bodyPosition, out bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00004C22 File Offset: 0x00002E22
		public void SetInternalHumanPose(ref Vector3 bodyPosition, ref Quaternion bodyRotation, Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.SetInternalHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref bodyPosition, ref bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00004C3C File Offset: 0x00002E3C
		public unsafe void GetInternalAvatarPose(void* avatarPose, int avatarPoseLength)
		{
			HumanPoseHandler.GetInternalAvatarPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), avatarPose, avatarPoseLength);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00004C50 File Offset: 0x00002E50
		public unsafe void SetInternalAvatarPose(void* avatarPose, int avatarPoseLength)
		{
			HumanPoseHandler.SetInternalAvatarPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), avatarPose, avatarPoseLength);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00004C64 File Offset: 0x00002E64
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00004C71 File Offset: 0x00002E71
		public void GetInternalAvatarPose(NativeArray<float> avatarPose)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00004C7E File Offset: 0x00002E7E
		public void SetInternalAvatarPose(NativeArray<float> avatarPose)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400037A RID: 890
		private static readonly HumanPoseHandler.Internal_CreateFromRootDelegate Internal_CreateFromRootDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.Internal_CreateFromRootDelegate>("UnityEngine.HumanPoseHandler::Internal_CreateFromRoot");

		// Token: 0x0400037B RID: 891
		private static readonly HumanPoseHandler.Internal_CreateFromJointPathsDelegate Internal_CreateFromJointPathsDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.Internal_CreateFromJointPathsDelegate>("UnityEngine.HumanPoseHandler::Internal_CreateFromJointPaths");

		// Token: 0x0400037C RID: 892
		private static readonly HumanPoseHandler.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.Internal_DestroyDelegate>("UnityEngine.HumanPoseHandler::Internal_Destroy");

		// Token: 0x0400037D RID: 893
		private static readonly HumanPoseHandler.GetHumanPoseDelegate GetHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.GetHumanPoseDelegate>("UnityEngine.HumanPoseHandler::GetHumanPose");

		// Token: 0x0400037E RID: 894
		private static readonly HumanPoseHandler.SetHumanPoseDelegate SetHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.SetHumanPoseDelegate>("UnityEngine.HumanPoseHandler::SetHumanPose");

		// Token: 0x0400037F RID: 895
		private static readonly HumanPoseHandler.GetInternalHumanPoseDelegate GetInternalHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.GetInternalHumanPoseDelegate>("UnityEngine.HumanPoseHandler::GetInternalHumanPose");

		// Token: 0x04000380 RID: 896
		private static readonly HumanPoseHandler.SetInternalHumanPoseDelegate SetInternalHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.SetInternalHumanPoseDelegate>("UnityEngine.HumanPoseHandler::SetInternalHumanPose");

		// Token: 0x04000381 RID: 897
		private static readonly HumanPoseHandler.GetInternalAvatarPoseDelegate GetInternalAvatarPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.GetInternalAvatarPoseDelegate>("UnityEngine.HumanPoseHandler::GetInternalAvatarPose");

		// Token: 0x04000382 RID: 898
		private static readonly HumanPoseHandler.SetInternalAvatarPoseDelegate SetInternalAvatarPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.SetInternalAvatarPoseDelegate>("UnityEngine.HumanPoseHandler::SetInternalAvatarPose");

		// Token: 0x020001D6 RID: 470
		// (Invoke) Token: 0x060008A2 RID: 2210
		private delegate IntPtr Internal_CreateFromRootDelegate(IntPtr avatar, IntPtr root);

		// Token: 0x020001D7 RID: 471
		// (Invoke) Token: 0x060008A4 RID: 2212
		private delegate IntPtr Internal_CreateFromJointPathsDelegate(IntPtr avatar, IntPtr jointPaths);

		// Token: 0x020001D8 RID: 472
		// (Invoke) Token: 0x060008A6 RID: 2214
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x020001D9 RID: 473
		// (Invoke) Token: 0x060008A8 RID: 2216
		private delegate void GetHumanPoseDelegate(IntPtr @this, [Out] IntPtr bodyPosition, [Out] IntPtr bodyRotation, [Out] IntPtr muscles);

		// Token: 0x020001DA RID: 474
		// (Invoke) Token: 0x060008AA RID: 2218
		private delegate void SetHumanPoseDelegate(IntPtr @this, IntPtr bodyPosition, IntPtr bodyRotation, IntPtr muscles);

		// Token: 0x020001DB RID: 475
		// (Invoke) Token: 0x060008AC RID: 2220
		private delegate void GetInternalHumanPoseDelegate(IntPtr @this, [Out] IntPtr bodyPosition, [Out] IntPtr bodyRotation, [Out] IntPtr muscles);

		// Token: 0x020001DC RID: 476
		// (Invoke) Token: 0x060008AE RID: 2222
		private delegate void SetInternalHumanPoseDelegate(IntPtr @this, IntPtr bodyPosition, IntPtr bodyRotation, IntPtr muscles);

		// Token: 0x020001DD RID: 477
		// (Invoke) Token: 0x060008B0 RID: 2224
		private delegate void GetInternalAvatarPoseDelegate(IntPtr @this, IntPtr avatarPose, int avatarPoseLength);

		// Token: 0x020001DE RID: 478
		// (Invoke) Token: 0x060008B2 RID: 2226
		private delegate void SetInternalAvatarPoseDelegate(IntPtr @this, IntPtr avatarPose, int avatarPoseLength);
	}
}
