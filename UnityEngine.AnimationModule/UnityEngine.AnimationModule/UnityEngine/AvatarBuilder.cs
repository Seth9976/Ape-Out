using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000047 RID: 71
	public class AvatarBuilder
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
		public static Avatar BuildHumanAvatar(GameObject go, HumanDescription humanDescription)
		{
			bool flag = go == null;
			if (flag)
			{
				throw new NullReferenceException();
			}
			return AvatarBuilder.BuildHumanAvatarInternal(go, humanDescription);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00004B8D File Offset: 0x00002D8D
		public static Avatar BuildHumanAvatarInternal(GameObject go, HumanDescription humanDescription)
		{
			return AvatarBuilder.BuildHumanAvatarInternal_Injected(go, ref humanDescription);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000E2F0 File Offset: 0x0000C4F0
		public static Avatar BuildGenericAvatar(GameObject go, string rootMotionTransformName)
		{
			IntPtr intPtr = AvatarBuilder.BuildGenericAvatarDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), IL2CPP.ManagedStringToIl2Cpp(rootMotionTransformName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000E324 File Offset: 0x0000C524
		public unsafe static Avatar BuildHumanAvatarInternal_Injected(GameObject go, ref HumanDescription humanDescription)
		{
			AvatarBuilder.BuildHumanAvatarInternal_InjectedDelegate buildHumanAvatarInternal_InjectedDelegateField = AvatarBuilder.BuildHumanAvatarInternal_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(humanDescription);
			IntPtr intPtr3 = buildHumanAvatarInternal_InjectedDelegateField(intPtr, &intPtr2);
			IntPtr intPtr4 = intPtr3;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr4) : null;
		}

		// Token: 0x04000378 RID: 888
		private static readonly AvatarBuilder.BuildGenericAvatarDelegate BuildGenericAvatarDelegateField = IL2CPP.ResolveICall<AvatarBuilder.BuildGenericAvatarDelegate>("UnityEngine.AvatarBuilder::BuildGenericAvatar");

		// Token: 0x04000379 RID: 889
		private static readonly AvatarBuilder.BuildHumanAvatarInternal_InjectedDelegate BuildHumanAvatarInternal_InjectedDelegateField = IL2CPP.ResolveICall<AvatarBuilder.BuildHumanAvatarInternal_InjectedDelegate>("UnityEngine.AvatarBuilder::BuildHumanAvatarInternal_Injected");

		// Token: 0x020001D4 RID: 468
		// (Invoke) Token: 0x0600089E RID: 2206
		private delegate IntPtr BuildGenericAvatarDelegate(IntPtr go, IntPtr rootMotionTransformName);

		// Token: 0x020001D5 RID: 469
		// (Invoke) Token: 0x060008A0 RID: 2208
		private delegate IntPtr BuildHumanAvatarInternal_InjectedDelegate(IntPtr go, IntPtr humanDescription);
	}
}
